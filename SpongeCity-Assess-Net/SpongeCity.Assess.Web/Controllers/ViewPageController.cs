using SpongeCity.Asses.BLL;
using SpongeCityAsses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpongeCity.Assess.Web.Controllers
{
    public class ViewPageController : Controller
    {
        // GET: ViewPage
        public ActionResult PageView(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewModel vm = new ViewModel();
            ViewBLL bll = new ViewBLL();
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            vm = bll.GetViewbyViewId(viewId,kpiId, categoryId);
            return PartialView(vm);
        }
    }
}