using System;
using System.Collections.Generic;
using System.Data;
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
    public class AddressesController : Controller
    {
        private NomadDbContext db = new NomadDbContext();

        // GET: Addresses
        [Authorize(Roles ="Staff")]
        public ActionResult Index()
        {
            var addresses = db.Addresses.Include(a => a.Person);
            return View(addresses.ToList());
        }

        // GET: Addresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = db.Addresses.Find(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // GET: Addresses/Create
        public ActionResult Create(int id)
        {
            //ViewBag.AddressID = new SelectList(db.People, "PersonID", "FullName");

            Person person = db.People.Find(id);

            if (person == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Address address = new Address();
            address.AddressID = id;
            address.Person = person;

            return View(address);
        }

        // POST: Addresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AddressID,House,StreetName,TownName,Postcode,County")] Address address)
        {
            if (ModelState.IsValid)
            {
                db.Addresses.Add(address);
                db.SaveChanges();
                return RedirectToAction("Details", "People", new { id = address.AddressID});
            }

            ViewBag.AddressID = new SelectList(db.People, "PersonID", "FirstName", address.AddressID);
            return View(address);
        }

        // GET: Addresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = db.Addresses.Find(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressID = new SelectList(db.People, "PersonID", "FirstName", address.AddressID);
            return View(address);
        }

        // POST: Addresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AddressID,House,StreetName,TownName,Postcode,County")] Address address)
        {
            if (ModelState.IsValid)
            {
                db.Entry(address).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressID = new SelectList(db.People, "PersonID", "FirstName", address.AddressID);
            return View(address);
        }

        // GET: Addresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address address = db.Addresses.Find(id);
            if (address == null)
            {
                return HttpNotFound();
            }
            return View(address);
        }

        // POST: Addresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Address address = db.Addresses.Find(id);
            db.Addresses.Remove(address);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public Person GetLoggedInUser()
        {
            string email = User.Identity.Name;

            Person person = db.People.Where(p => p.Email == email).FirstOrDefault();

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
