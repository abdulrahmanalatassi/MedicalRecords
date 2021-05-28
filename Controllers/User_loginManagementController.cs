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
    public class User_loginManagementController : Controller
    {
        private MedicalRecordsEntities db = new MedicalRecordsEntities();

        // GET: User_login
        public ActionResult Index()
        {
            var user_login = db.User_login.Include(u => u.Doctor);
            return View(user_login.ToList());
        }

        // GET: User_login/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_login user_login = db.User_login.Find(id);
            if (user_login == null)
            {
                return HttpNotFound();
            }
            return View(user_login);
        }

        // GET: User_login/Create
        public ActionResult Create()
        {
            ViewBag.id_d = new SelectList(db.Doctors, "id_d", "first_name");
            return View();
        }

        // POST: User_login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "username,password,flag,id_d")] User_login user_login)
        {
            if (ModelState.IsValid)
            {
                db.User_login.Add(user_login);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_d = new SelectList(db.Doctors, "id_d", "first_name", user_login.id_d);
            return View(user_login);
        }

        // GET: User_login/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_login user_login = db.User_login.Find(id);
            if (user_login == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_d = new SelectList(db.Doctors, "id_d", "first_name", user_login.id_d);
            return View(user_login);
        }

        // POST: User_login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "username,password,flag,id_d")] User_login user_login)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_login).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_d = new SelectList(db.Doctors, "id_d", "first_name", user_login.id_d);
            return View(user_login);
        }

        // GET: User_login/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_login user_login = db.User_login.Find(id);
            if (user_login == null)
            {
                return HttpNotFound();
            }
            return View(user_login);
        }

        // POST: User_login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            User_login user_login = db.User_login.Find(id);
            db.User_login.Remove(user_login);
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
