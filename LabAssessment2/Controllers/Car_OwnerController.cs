using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LabAssessment2.Models;

namespace LabAssessment2.Controllers
{
    public class Car_OwnerController : Controller
    {
        private EasyGomodel1 db = new EasyGomodel1();

        // GET: Car_Owner
        public ActionResult Index()
        {
            return View(db.Car_Owner.ToList());
        }

        // GET: Car_Owner/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Owner car_Owner = db.Car_Owner.Find(id);
            if (car_Owner == null)
            {
                return HttpNotFound();
            }
            return View(car_Owner);
        }

        // GET: Car_Owner/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car_Owner/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Owner_id,Name,phone_num,UserId")] Car_Owner car_Owner)
        {
            if (ModelState.IsValid)
            {
                db.Car_Owner.Add(car_Owner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car_Owner);
        }

        // GET: Car_Owner/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Owner car_Owner = db.Car_Owner.Find(id);
            if (car_Owner == null)
            {
                return HttpNotFound();
            }
            return View(car_Owner);
        }

        // POST: Car_Owner/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Owner_id,Name,phone_num,UserId")] Car_Owner car_Owner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car_Owner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car_Owner);
        }

        // GET: Car_Owner/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Owner car_Owner = db.Car_Owner.Find(id);
            if (car_Owner == null)
            {
                return HttpNotFound();
            }
            return View(car_Owner);
        }

        // POST: Car_Owner/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car_Owner car_Owner = db.Car_Owner.Find(id);
            db.Car_Owner.Remove(car_Owner);
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
