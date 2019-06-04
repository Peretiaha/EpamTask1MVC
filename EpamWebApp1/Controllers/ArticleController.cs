using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpamWebApp1.Models;

namespace EpamWebApp1.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Article(Article article)
        {
            ViewBag.id = article.ArticleId;
            return View();
        }

        public ActionResult Details(int id)
        {

            ViewBag.Article = ArticleList.SpesialArticle(id);
            return View();
        }
    } 
}