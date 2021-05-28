using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MedicalRecords.Models;

namespace MedicalRecords.Controllers
{
    public class DiagnosesManagementController : Controller
    {
        private MedicalRecordsEntities db = new MedicalRecordsEntities();

        // GET: Diagnoses
        public ActionResult Index()
        {
            var diagnoses = db.Diagnoses.Include(d => d.Doctor).Include(d => d.Patient);
            return View(diagnoses.ToList());
        }

        // GET: Diagnoses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnose diagnose = db.Diagnoses.Find(id);
            if (diagnose == null)
            {
                return HttpNotFound();
            }
            return View(diagnose);
        }

        // GET: Diagnoses/Create
        public ActionResult Create()
        {
            ViewBag.id_d = new SelectList(db.Doctors, "id_d", "first_name");
            ViewBag.id_p = new SelectList(db.Patients, "id_p", "firstname");
            return View();
        }

        // POST: Diagnoses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_dig,id_p,id_d,disease_name,date,dangerous,cured")] Diagnose diagnose)
        {
            if (ModelState.IsValid)
            {
                db.Diagnoses.Add(diagnose);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_d = new SelectList(db.Doctors, "id_d", "first_name", diagnose.id_d);
            ViewBag.id_p = new SelectList(db.Patients, "id_p", "firstname", diagnose.id_p);
            return View(diagnose);
        }

        // GET: Diagnoses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnose diagnose = db.Diagnoses.Find(id);
            if (diagnose == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_d = new SelectList(db.Doctors, "id_d", "first_name", diagnose.id_d);
            ViewBag.id_p = new SelectList(db.Patients, "id_p", "firstname", diagnose.id_p);
            return View(diagnose);
        }

        // POST: Diagnoses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_dig,id_p,id_d,disease_name,date,dangerous,cured")] Diagnose diagnose)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diagnose).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_d = new SelectList(db.Doctors, "id_d", "first_name", diagnose.id_d);
            ViewBag.id_p = new SelectList(db.Patients, "id_p", "firstname", diagnose.id_p);
            return View(diagnose);
        }

        // GET: Diagnoses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diagnose diagnose = db.Diagnoses.Find(id);
            if (diagnose == null)
            {
                return HttpNotFound();
            }
            return View(diagnose);
        }

        // POST: Diagnoses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diagnose diagnose = db.Diagnoses.Find(id);
            db.Diagnoses.Remove(diagnose);
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
