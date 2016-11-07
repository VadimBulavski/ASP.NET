using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainObject.Entitys;
using Repository;
using NewsContext.Context;
using System.Net;
using System.Data.Entity;


namespace WebNews.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        private IRepository _service = null;
        private NewsDataContext db = new NewsDataContext();
       
        public AdminController()
        {
            _service = new Repository.Repository();
        }

        public ActionResult Index()
        {
            return View(_service.GetAllNews());
        }

        public ActionResult Read(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            New nextNew = db.News.Find(id);

            if (nextNew == null)
            {
                return HttpNotFound();
            }
            return View(nextNew);
        }

        public ActionResult Create()
        {
            return View();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NewsID, Header, Body, Hot, Type")] New nextNew)
        {
            if (ModelState.IsValid)
            {
                nextNew.CreateDate = DateTime.Now;
                db.News.Add(nextNew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nextNew);
        }

        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            New nextNew = db.News.Find(id);
            if (nextNew == null)
            {
                return HttpNotFound();
            }
            return View(nextNew);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind(Include = "NewsID, Header, Body, Hot, Type")] New nextNew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nextNew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nextNew);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            New nextNew = db.News.Find(id);
            if (nextNew == null)
            {
                return HttpNotFound();
            }
            return View(nextNew);
            //return DeleteConfirmed((int)id);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            New nexNew = db.News.Find(id);
            db.News.Remove(nexNew);
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