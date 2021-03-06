﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SocialNetworking
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("CreateAccount", "Account/CreateAccount", new
            {
                controller = "Account",
                action = "CreateAccount"
            });

            routes.MapRoute("Account", "{username}", new
            {
                controller = "Account",
                action = "Username"
            });

            routes.MapRoute("Default", "", new
            {
                controller = "Account",
                action = "Index"
            });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
