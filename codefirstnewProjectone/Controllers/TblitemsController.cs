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
    public class TblitemsController : Controller
    {
        private transContext db = new transContext();

        // GET: Tblitems
        public ActionResult Index()
        {
            var tblitems = db.Tblitems.Include(t => t.Category);
            return View(tblitems.ToList());
        }

        // GET: Tblitems/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tblitem tblitem = db.Tblitems.Find(id);
            if (tblitem == null)
            {
                return HttpNotFound();
            }
            return View(tblitem);
        }

        // GET: Tblitems/Create
        public ActionResult Create()
        {
            ViewBag.Cat_id = new SelectList(db.Categories, "Cat_id", "Cat_Name");
            return View();
        }

        // POST: Tblitems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "item_id,item_desc,Cat_id,item_size,item_cost,vat,selling")] Tblitem tblitem)
        {
            if (ModelState.IsValid)
            {
                tblitem.vat = tblitem.calcVat();
                tblitem.selling = tblitem.calcSelling(); 

                db.Tblitems.Add(tblitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cat_id = new SelectList(db.Categories, "Cat_id", "Cat_Name", tblitem.Cat_id);
            return View(tblitem);
        }

        // GET: Tblitems/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tblitem tblitem = db.Tblitems.Find(id);
            if (tblitem == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cat_id = new SelectList(db.Categories, "Cat_id", "Cat_Name", tblitem.Cat_id);
            return View(tblitem);
        }

        // POST: Tblitems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "item_id,item_desc,Cat_id,item_size,item_cost,vat,selling")] Tblitem tblitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cat_id = new SelectList(db.Categories, "Cat_id", "Cat_Name", tblitem.Cat_id);
            return View(tblitem);
        }

        // GET: Tblitems/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tblitem tblitem = db.Tblitems.Find(id);
            if (tblitem == null)
            {
                return HttpNotFound();
            }
            return View(tblitem);
        }

        // POST: Tblitems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tblitem tblitem = db.Tblitems.Find(id);
            db.Tblitems.Remove(tblitem);
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
