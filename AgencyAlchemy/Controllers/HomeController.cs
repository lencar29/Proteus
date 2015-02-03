using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using AgencyAlchemy.Core.Data;
using AgencyAlchemy.Core.Utility;
using AgencyAlchemy.Models;

namespace AgencyAlchemy.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [Authorize(Roles="SuperAdmin")]
        [OutputCache(Location=OutputCacheLocation.Client, Duration=300, VaryByParam="page, pageSize")]
        public ActionResult Dashboard(int page= 1, int pageSize = 10)
        {
            int totalRecords;
            PagedItemsModel model = new PagedItemsModel();     
              
            //TODO: Create composite to handle both agencies and applicants 
            model.Items = EventStat.GetAgencyEventStats(Convert.ToInt32(Session["AgencyID"]), out totalRecords, page, pageSize);
            model.TotalRows = totalRecords;
            model.PageSize = pageSize;   

            if (Request.IsAjaxRequest()) ;
                //TODO: Create partial            

            return View(model);
        }
        
    }
}
