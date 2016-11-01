using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebNews.Entitys;

namespace WebNews.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Read()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            return View(id);
        }

        [HttpPost]
        public ActionResult Update(New _new)
        {
            return View(_new);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(New _new)
        {
            return View(_new);
        }
    }
}