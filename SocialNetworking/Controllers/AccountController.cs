using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialNetworking.Controllers
{
    public class AccountController : Controller
    {
        // GET: /
        public ActionResult Index()
        {
            //Confirm user is not logged
            string username = User.Identity.Name;

            if(!string.IsNullOrEmpty(username))
            {
                return Redirect("~/"+username);
            }


            //return view
            return View();
        }
    }
}