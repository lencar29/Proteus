using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using AgencyAlchemy.Core.Data;
using AgencyAlchemy.Models;
using AgencyAlchemy.Properties;

namespace AgencyAlchemy.Controllers
{
    [Authorize]
    public class AgencyController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Agency/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Agency/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Agency/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Agency/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Agency/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Agency/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "AgencyAdmin, SuperAdmin")]
        [OutputCache(Location = OutputCacheLocation.Client, Duration = 300, VaryByParam = "page, pageSize")]
        public ActionResult Dashboard(int id, int page = 1, int pageSize = 10)
        {
            if (User.IsInRole("AgencyAdmin") && id != Convert.ToInt32(Session["AgencyID"]))
            {
                throw new HttpException(401, Resources.UnauthorizedAccessMessage);
            }

            int totalRecords;
            PagedItemsModel model = new PagedItemsModel();            

            //TODO: Create composite to handle both agencies and applicants 
            model.Items = EventStat.GetAgencyEventStats(id, out totalRecords, page, pageSize);
            model.TotalRows = totalRecords;
            model.PageSize = pageSize;

            if (Request.IsAjaxRequest()) ;
            //TODO: Create partial            

            return View(model);
        }

        [Authorize(Roles = "SuperAdmin")]
        [OutputCache(Location= OutputCacheLocation.Client, Duration=300, VaryByParam="page, pageSize")]        
        public ActionResult List(int page = 0, int pageSize = 10)
        {
            var model = new PagedItemsModel();

            int recordCount;
            model.Items = Agency.GetAgencyMasterList(out recordCount, page, pageSize);
            model.TotalRows = recordCount;
            model.PageSize = pageSize;

            if (Request.IsAjaxRequest())
                return PartialView(); //TODO:Create Partial

            return View(model);
        }

        [Authorize(Roles = "SuperAdmin")]
        [OutputCache(Location = OutputCacheLocation.Client, Duration = 300, VaryByParam = "page, pageSize")]
        public ActionResult Users(int page = 1, int pageSize = 30)
        {
            var model = new PagedItemsModel();

            int recordCount;
            model.Items = Agency.GetUsersFromAllAgencies(out recordCount, page, pageSize);
            model.TotalRows = recordCount;
            model.Page = page;
            model.PageSize = pageSize;

            if (Request.IsAjaxRequest())
                return PartialView(); //TODO:Create Partial

            return View(model);
        }
    }
}
