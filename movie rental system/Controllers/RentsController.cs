using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using movie_rental_system.Models;

namespace movie_rental_system.Controllers
{
    public class RentsController : Controller
    {
        private movieContext db = new movieContext();
        // GET: Rents
      
        public ActionResult Index()
        {
            var rents = db.rents.Include(r => r.Customer).Include(r => r.Movie);
            return View(rents.ToList());
            
        }
        // GET: Rents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rent rent = db.rents.Find(id);
            if (rent == null)
            {
                return HttpNotFound();
            }
            return View(rent);
        }

        // GET: Rents/Create
        public ActionResult Create()
        {
            ViewBag.customer_id = new SelectList(db.customers, "customer_id", "customer_name");
            ViewBag.movie_id = new SelectList(db.movies, "movie_id", "movie_name");
            return View();
        }

        // POST: Rents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rent_id,movie_id,customer_id,rental_fee,total_with_vat,start_date,end_date")] Rent rent)
        {
            if (ModelState.IsValid)
            {
                rent.start_date = rent.datenow(); 
                rent.rental_fee = rent.pullPrice();
                rent.total_with_vat = rent.addedvatPrice(); 
                db.rents.Add(rent);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.customer_id = new SelectList(db.customers, "customer_id", "customer_id", rent.customer_id);
            ViewBag.movie_id = new SelectList(db.movies, "movie_name", "movie_name", rent.movie_id);
            return View(rent);
        }

        // GET: Rents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rent rent = db.rents.Find(id);
            if (rent == null)
            {
                return HttpNotFound();
            }
            ViewBag.customer_id = new SelectList(db.customers, "customer_id", "customer_name", rent.customer_id);
            ViewBag.movie_id = new SelectList(db.movies, "movie_id", "movie_name", rent.movie_id);
            return View(rent);
        }

        // POST: Rents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rent_id,movie_id,customer_id,rental_fee,start_date,end_date")] Rent rent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.customer_id = new SelectList(db.customers, "customer_id", "customer_name", rent.customer_id);
            ViewBag.movie_id = new SelectList(db.movies, "movie_id", "movie_name", rent.movie_id);
            return View(rent);
        }

        // GET: Rents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rent rent = db.rents.Find(id);
            if (rent == null)
            {
                return HttpNotFound();
            }
            return View(rent);
        }

        // POST: Rents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rent rent = db.rents.Find(id);
            db.rents.Remove(rent);
            db.SaveChanges();
            return RedirectToAction("Index");
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
