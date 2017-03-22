using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KV.Models;

namespace KV.Controllers
{
    public class TaskStatusController : Controller
    {
        private KVContext db = new KVContext();

        // GET: TaskStatus
        public ActionResult Index()
        {
            return View(db.TaskStatus.ToList());
        }

        // GET: TaskStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskStatus taskStatus = db.TaskStatus.Find(id);
            if (taskStatus == null)
            {
                return HttpNotFound();
            }
            return View(taskStatus);
        }

        // GET: TaskStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskStatus/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] TaskStatus taskStatus)
        {
            if (ModelState.IsValid)
            {
                db.TaskStatus.Add(taskStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskStatus);
        }

        // GET: TaskStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskStatus taskStatus = db.TaskStatus.Find(id);
            if (taskStatus == null)
            {
                return HttpNotFound();
            }
            return View(taskStatus);
        }

        // POST: TaskStatus/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] TaskStatus taskStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskStatus);
        }

        // GET: TaskStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskStatus taskStatus = db.TaskStatus.Find(id);
            if (taskStatus == null)
            {
                return HttpNotFound();
            }
            return View(taskStatus);
        }

        // POST: TaskStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskStatus taskStatus = db.TaskStatus.Find(id);
            db.TaskStatus.Remove(taskStatus);
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
