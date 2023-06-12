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
    public class returningsController : Controller
    {
        private movieContext db = new movieContext();

        // GET: returnings
        public ActionResult Index()
        {
            var returnings = db.returnings.Include(r => r.Rent);
            return View(returnings.ToList());
        }

        // GET: returnings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            returning returning = db.returnings.Find(id);
            if (returning == null)
            {
                return HttpNotFound();
            }
            return View(returning);
        }

        // GET: returnings/Create
        public ActionResult Create()
        {
            ViewBag.rent_id = new SelectList(db.rents, "rent_id", "rent_id");
            return View();
        }

        // POST: returnings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "returning_id,rent_id,late_fee,actual_fee")] returning returning)
        {
            if (ModelState.IsValid)
            { 
                db.returnings.Add(returning);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.rent_id = new SelectList(db.rents, "rent_id", "rent_id", returning.rent_id);
            return View(returning);
        }

        // GET: returnings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            returning returning = db.returnings.Find(id);
            if (returning == null)
            {
                return HttpNotFound();
            }
            ViewBag.rent_id = new SelectList(db.rents, "rent_id", "rent_id", returning.rent_id);
            return View(returning);
        }

        // POST: returnings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "returning_id,rent_id,late_fee")] returning returning)
        {
            if (ModelState.IsValid)
            {
                db.Entry(returning).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.rent_id = new SelectList(db.rents, "rent_id", "rent_id", returning.rent_id);
            return View(returning);
        }

        // GET: returnings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            returning returning = db.returnings.Find(id);
            if (returning == null)
            {
                return HttpNotFound();
            }
            return View(returning);
        }

        // POST: returnings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            returning returning = db.returnings.Find(id);
            db.returnings.Remove(returning);
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
