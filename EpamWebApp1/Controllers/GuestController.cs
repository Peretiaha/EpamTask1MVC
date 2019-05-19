using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpamWebApp1.Models;

namespace EpamWebApp1.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        public ActionResult Guest()
        {
            CommentsList cmlist = new CommentsList();
            ViewBag.CommentsCount = cmlist.Count();
            ViewBag.Comments= cmlist.Info();
                       
            return View();
        }
    }
}