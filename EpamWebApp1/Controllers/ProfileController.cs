using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpamWebApp1.Models;

namespace EpamWebApp1.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult ProfileList()
        {
            
            Profile profile = new Profile();
            
            if (Request.HttpMethod == "POST")
            {
                return View("../Profile/ProfileResults", profile);
            }
            else
            {
                ViewBag.Profile = profile;
                return View();
            }
        }


        public ActionResult ProfileResults(Profile profile)
        {           
            return View(profile);
        }
        }
}