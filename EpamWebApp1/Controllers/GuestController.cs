using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpamWebApp1.Models;
using StorageControl;

namespace EpamWebApp1.Controllers
{
    public class GuestController : Controller
    {


        // GET: Guest
        [HttpGet]
        public ActionResult Guest()
        {

            ViewBag.Comments = CommentsList.LoadComments();
            

            return View();
        }

        [HttpPost]
        public ActionResult Guest(Comments comment)   //Add new comment
        {
            
            if (CommentsList.Add(comment)) ViewBag.CommentDublicate = "Comment was successfully add";
            else ViewBag.CommentDublicateF = "Similar comment have been already add";
            ViewBag.Comments = CommentsList.LoadComments();   //перенести все в библиотеку, и потом viewbag поставить перед ретурном
                   

            return View();
        }


        }
}