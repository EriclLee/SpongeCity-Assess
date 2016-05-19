using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpongeCity.Assess.Web.Controllers
{
    public class ActivitiesController : Controller
    {
        // GET: Activities
        public ActionResult Streamflow_Control_Rate(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        public ActionResult RainvsStream(int subCategoryId, int viewId, int kpiId, int categoryId) {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        public ActionResult In_Out_Water(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }
    }
}