using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NomadCars.DAL;
using NomadCars.Models;

namespace NomadCars.Controllers
{
    [Authorize]
    public class PeopleController : Controller
    {
        private NomadDbContext db = new NomadDbContext();

        // GET: People
        [Authorize(Roles ="Staff")]
        public ActionResult Index()
        {
            var people = db.People.Include(p => p.Address).Include(p => p.Staff);
            return View(people.ToList());
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            Person person;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if(User.IsInRole("Staff"))
            {
                person = db.People
                    .Where(a => a.PersonID == id)
                    .Include(b => b.Address)
                    .Include(p => p.Staff)
                    .FirstOrDefault();
            }
            else
            {
                person = GetLoggedInUser();
            }

            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            //ViewBag.PersonID = new SelectList(db.Addresses, "AddressID", "House");
            //ViewBag.PersonID = new SelectList(db.Staff, "StaffID", "Department");

            string email = User.Identity.Name;

            Person customer = new Person();

            customer.Email = email;
            customer.DateOfBirth = new System.DateTime(1980, 1, 1);
            customer.IsCustomer = true;
            customer.IsStaff = false;
           
            return View(customer);
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,FirstName,LastName,HomePhoneNumber,MobilePhoneNumber,Email,DateOfBirth,MaritalStatus,IsCustomer,IsStaff")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Details", new {id = person.PersonID });
            }

            //ViewBag.PersonID = new SelectList(db.Addresses, "AddressID", "House", person.PersonID);
            //ViewBag.PersonID = new SelectList(db.Staff, "StaffID", "Department", person.PersonID);

            return View(person);
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            Person person;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (User.IsInRole("Staff"))
            {
                person = db.People.Find(id);
            }
            else
            {
                person = GetLoggedInUser();
            }

            if (person == null)
            {
                return HttpNotFound();
            }

            //ViewBag.PersonID = new SelectList(db.Addresses, "AddressID", "House", person.PersonID);
            //ViewBag.PersonID = new SelectList(db.Staff, "StaffID", "Department", person.PersonID);

            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,FirstName,LastName,HomePhoneNumber,MobilePhoneNumber,Email,DateOfBirth,MaritalStatus,IsCustomer,IsStaff")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = person.PersonID});
            }

            //ViewBag.PersonID = new SelectList(db.Addresses, "AddressID", "House", person.PersonID);
            //ViewBag.PersonID = new SelectList(db.Staff, "StaffID", "Department", person.PersonID);

            return View(person);
        }

        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.People.Find(id);
            db.People.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult ViewAccount()
        {
            string email = User.Identity.Name;

            Person customer = db.People.Where(p => p.Email == email).FirstOrDefault();

            if(customer == null)
            {
                customer = new Person();

                customer.IsCustomer = true;
                customer.IsStaff = false;
                customer.Email = email;

                return RedirectToAction("Create");
            }
            
            return View(customer);
        }

        public Person GetLoggedInUser()
        {
            string email = User.Identity.Name;

            Person person = db.People
                .Where(p => p.Email == email)
                .Include(b => b.Address)
                .Include(p => p.Staff)
                .FirstOrDefault();

            return person;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
