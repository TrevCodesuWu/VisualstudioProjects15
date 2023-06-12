using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using APDP201_mvc.Models;

namespace APDP201_mvc.Controllers
{
    public class stockitemsController : Controller
    {
        private inventorymainEntities db = new inventorymainEntities();

        // GET: stockitems
        public ActionResult Index()
        {
            return View(db.stockitems.ToList());
        }

        // GET: stockitems/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            stockitem stockitem = db.stockitems.Find(id);
            if (stockitem == null)
            {
                return HttpNotFound();
            }
            return View(stockitem);
        }

        // GET: stockitems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: stockitems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Item_Code,Item_desc,Item_Size,Item_Cost,Vat,Selling")] stockitem stockitem)
        {
            if (ModelState.IsValid)
            {
                stockitem.Vat = Convert.ToDecimal(stockitem.calcVat());
                stockitem.Selling = Convert.ToDecimal(stockitem.calcSelling()); 

                db.stockitems.Add(stockitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stockitem);
        }

        // GET: stockitems/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            stockitem stockitem = db.stockitems.Find(id);
            if (stockitem == null)
            {
                return HttpNotFound();
            }
            return View(stockitem);
        }

        // POST: stockitems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Item_Code,Item_desc,Item_Size,Item_Cost,Vat,Selling")] stockitem stockitem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stockitem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stockitem);
        }

        // GET: stockitems/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            stockitem stockitem = db.stockitems.Find(id);
            if (stockitem == null)
            {
                return HttpNotFound();
            }
            return View(stockitem);
        }

        // POST: stockitems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            stockitem stockitem = db.stockitems.Find(id);
            db.stockitems.Remove(stockitem);
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
