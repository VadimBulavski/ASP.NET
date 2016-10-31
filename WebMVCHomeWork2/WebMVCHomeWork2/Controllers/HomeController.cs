using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCHomeWork2.Models;

namespace WebMVCHomeWork2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Message()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Message(Message mes)
        {
            mes.MessageText = message;
            return View(mes);
        }
    }
}