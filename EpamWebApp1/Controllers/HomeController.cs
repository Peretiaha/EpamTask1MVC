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
        [HttpGet]
        public ActionResult Index()
        {       
           ViewBag.Article  = ArticleList.LoadArticle();
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(Voiting voiting)
        {
            using (BlogDb db = new BlogDb())
            {
                db.Voiting.Add(voiting);
                db.SaveChanges();

            }
                return View("../Home/About");
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