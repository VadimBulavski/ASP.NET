using NewsContext.Context;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebNews.Areas.News.Controllers
{
    public class NewsController : Controller
    {
        private IRepository _service = null;
        private NewsDataContext db = new NewsDataContext();

        public NewsController()
        {
            _service = new Repository.Repository();
        }
        // GET: News/News
        public ActionResult Index()
        {
            return View(_service.GetAllNews());
        }

        //public ActionResult Print(string print)
        //{
        //    return View("Index", print);
        //}
    }
}