using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using applicationMigrations.Models;

namespace applicationMigrations.Controllers
{
    public class borrowsController : Controller
    {
        private bankingContextClass db = new bankingContextClass();

        // GET: borrows
        [HttpGet]
        public ActionResult Index()
        {
            var borrows = db.borrows.Include(b => b.customer);
            return View(borrows.ToList());
        }
        [HttpPost]
        public ActionResult Index()
        {
            var borrows = db.borrows.Include(b => b.customer);
            return View(borrows.ToList());
        }

        // GET: borrows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            borrow borrow = db.borrows.Find(id);
            if (borrow == null)
            {
                return HttpNotFound();
            }
            return View(borrow);
        }

        // GET: borrows/Create
        public ActionResult Create()
        {
           // ViewBag.borrower_name = new SelectList(db.customers, "cust_Id", "borrower_name");
            ViewBag.cust_Id = new SelectList(db.customers, "cust_Id", "cust_Id");
            return View();
        }

        // POST: borrows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "borrow_Id,borrower_name,borrower_age,borrower_hometown,cust_Id")] borrow borrow)
        {
            if (ModelState.IsValid)
            {
                db.borrows.Add(borrow);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cust_Id = new SelectList(db.customers, "cust_Id", "cust_name", borrow.cust_Id);
            return View(borrow);
        }

        // GET: borrows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            borrow borrow = db.borrows.Find(id);
            if (borrow == null)
            {
                return HttpNotFound();
            }
            ViewBag.cust_Id = new SelectList(db.customers, "cust_Id", "cust_name", borrow.cust_Id);
            return View(borrow);
        }

        // POST: borrows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "borrow_Id,borrower_name,borrower_age,borrower_hometown,cust_Id")] borrow borrow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(borrow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cust_Id = new SelectList(db.customers, "cust_Id", "cust_name", borrow.cust_Id);
            return View(borrow);
        }

        // GET: borrows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            borrow borrow = db.borrows.Find(id);
            if (borrow == null)
            {
                return HttpNotFound();
            }
            return View(borrow);
        }

        // POST: borrows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            borrow borrow = db.borrows.Find(id);
            db.borrows.Remove(borrow);
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
