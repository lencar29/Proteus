using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgencyAlchemy.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Http401(String errorMessage)
        {
            return View(errorMessage);
        }

        public ActionResult Http404(String errorMessage)
        {
            return View(errorMessage);
        }

        public ActionResult Http500(String errorMessage)
        {
            return View(errorMessage);
        }
    }
}
