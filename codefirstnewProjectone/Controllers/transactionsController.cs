using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using codefirstnewProjectone.Models;

namespace codefirstnewProjectone.Controllers
{
    public class transactionsController : Controller
    {
        private transContext db = new transContext();

        // GET: transactions
        public ActionResult Index()
        {
            var transactions = db.transactions.Include(t => t.Staff).Include(t => t.Tblitem);
            return View(transactions.ToList());
        }

        // GET: transactions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transaction transaction = db.transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // GET: transactions/Create
        public ActionResult Create()
        {
            ViewBag.Staff_Id = new SelectList(db.Staffs, "staff_id", "staff_name");
            ViewBag.item_id = new SelectList(db.Tblitems, "item_id", "item_desc");
            return View();
        }

        // POST: transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Trans_no,Staff_Id,item_id,Trans_amount")] transaction transaction)
        {
            if (ModelState.IsValid)
            {
                transaction.Trans_amount = transaction.calcFinal(); 
                db.transactions.Add(transaction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Staff_Id = new SelectList(db.Staffs, "staff_id", "staff_name", transaction.Staff_Id);
            ViewBag.item_id = new SelectList(db.Tblitems, "item_id", "item_desc", transaction.item_id);
            return View(transaction);
        }

        // GET: transactions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transaction transaction = db.transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            ViewBag.Staff_Id = new SelectList(db.Staffs, "staff_id", "staff_name", transaction.Staff_Id);
            ViewBag.item_id = new SelectList(db.Tblitems, "item_id", "item_desc", transaction.item_id);
            return View(transaction);
        }

        // POST: transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Trans_no,Staff_Id,item_id,Trans_amount")] transaction transaction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transaction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Staff_Id = new SelectList(db.Staffs, "staff_id", "staff_name", transaction.Staff_Id);
            ViewBag.item_id = new SelectList(db.Tblitems, "item_id", "item_desc", transaction.item_id);
            return View(transaction);
        }

        // GET: transactions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            transaction transaction = db.transactions.Find(id);
            if (transaction == null)
            {
                return HttpNotFound();
            }
            return View(transaction);
        }

        // POST: transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            transaction transaction = db.transactions.Find(id);
            db.transactions.Remove(transaction);
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
