using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpamWebApp1.Models;
using StorageControl;

namespace EpamWebApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {       
           ViewBag.Article  = ArticleList.LoadArticle();
           return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}