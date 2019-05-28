using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpamWebApp1.Models;
using StorageControl;

namespace EpamWebApp1.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        [HttpGet]
        public ActionResult ProfileList()
        {
            
            Profile profile = new Profile();
            ViewBag.ProfList =  ProfileLogic.LoadProfile();
            ViewBag.Profile = profile;
            
                            
            return View();
            
        }

        [HttpPost]
        public ActionResult ProfileList(Profile prof)
        {
            try
            {
                if (ProfileLogic.Add(prof)) ViewBag.succes = "Thanks";
                else ViewBag.danger = "You have been alredy fill this list";
            }
            catch (Exception) { }
                return View();

        }


        public ActionResult ProfileResults(Profile profile)
        {           
            return View(profile);
        }
     }
}