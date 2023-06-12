using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using videotutmvc.Models;

namespace videotutmvc.Controllers
{
    public class STOCKITEMsController : Controller
    {
        private WAREHOUSEEntities db = new WAREHOUSEEntities();

        // GET: STOCKITEMs
        public ActionResult Index()
        {
            return View(db.STOCKITEMS.ToList());
        }

        // GET: STOCKITEMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STOCKITEM sTOCKITEM = db.STOCKITEMS.Find(id);
            if (sTOCKITEM == null)
            {
                return HttpNotFound();
            }
            return View(sTOCKITEM);
        }

        // GET: STOCKITEMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: STOCKITEMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "itemCode,itemDesc,itemSize,itemCost,vat,selling")] STOCKITEM sTOCKITEM)
        {
            if (ModelState.IsValid)
            {
                db.STOCKITEMS.Add(sTOCKITEM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sTOCKITEM);
        }

        // GET: STOCKITEMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STOCKITEM sTOCKITEM = db.STOCKITEMS.Find(id);
            if (sTOCKITEM == null)
            {
                return HttpNotFound();
            }
            return View(sTOCKITEM);
        }

        // POST: STOCKITEMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "itemCode,itemDesc,itemSize,itemCost,vat,selling")] STOCKITEM sTOCKITEM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sTOCKITEM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sTOCKITEM);
        }

        // GET: STOCKITEMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STOCKITEM sTOCKITEM = db.STOCKITEMS.Find(id);
            if (sTOCKITEM == null)
            {
                return HttpNotFound();
            }
            return View(sTOCKITEM);
        }

        // POST: STOCKITEMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            STOCKITEM sTOCKITEM = db.STOCKITEMS.Find(id);
            db.STOCKITEMS.Remove(sTOCKITEM);
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
