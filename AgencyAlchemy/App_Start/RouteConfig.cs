using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AgencyAlchemy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Dashboard",
                url: "{Dashboard}",
                defaults: new
                {
                    controller = "Home",
                    action = "Dashboard",
                    page = UrlParameter.Optional,
                    pageSize = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "Login",
                url: "Account/Login",
                defaults: new { controller = "Account", action = "Login"}
            );

            routes.MapRoute(
                name: "Register",
                url: "Account/Register",
                defaults: new { controller = "Account", action = "Register" }
            );

            routes.MapRoute(
                name: "PasswordReset",
                url: "Account/ResetPassword",
                defaults: new { controller = "Account", action = "ResetPassword" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}