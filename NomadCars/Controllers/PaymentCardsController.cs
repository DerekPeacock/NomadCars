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
    public class PaymentCardsController : Controller
    {
        private NomadDbContext db = new NomadDbContext();

        // GET: PaymentCards
        [Authorize(Roles ="Staff")]
        public ActionResult Index()
        {
            return View(db.PaymentCards.ToList());
        }

        // GET: PaymentCards/Details/5
        public ActionResult Details(int? id)
        {
            PaymentCard paymentCard;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if(User.IsInRole("Staff"))
            {
                paymentCard = db.PaymentCards.Find(id);
            }
            else
            {
                Person person = GetLoggedInUser();
                paymentCard = db.PaymentCards.Find(person.PersonID);
            }

            if (paymentCard == null)
            {
                return HttpNotFound();
            }

            return View(paymentCard);
        }

        // GET: PaymentCards/Create
        public ActionResult Create()
        {
            PaymentCard card = new PaymentCard();

            Person person = GetLoggedInUser();
            card.PaymentCardID = person.PersonID;

            return View(card);
        }

        // POST: PaymentCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaymentCardID,CardType,CardNumber,NameOnCard,SecurityNumber,ExpiryMonth,ExpiryYear")] PaymentCard paymentCard)
        {
            if (ModelState.IsValid)
            {
                db.PaymentCards.Add(paymentCard);
                db.SaveChanges();
                return RedirectToAction("Details","People",new { id = paymentCard.PaymentCardID});
            }

            return View(paymentCard);
        }

        // GET: PaymentCards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentCard paymentCard = db.PaymentCards.Find(id);
            if (paymentCard == null)
            {
                return HttpNotFound();
            }
            return View(paymentCard);
        }

        // POST: PaymentCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PaymentCardID,CardType,CardNumber,NameOnCard,SecurityNumber,ExpiryMonth,ExpiryYear")] PaymentCard paymentCard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentCard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentCard);
        }

        // GET: PaymentCards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentCard paymentCard = db.PaymentCards.Find(id);
            if (paymentCard == null)
            {
                return HttpNotFound();
            }
            return View(paymentCard);
        }

        // POST: PaymentCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentCard paymentCard = db.PaymentCards.Find(id);
            db.PaymentCards.Remove(paymentCard);
            db.SaveChanges();
            return RedirectToAction("Index");
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
