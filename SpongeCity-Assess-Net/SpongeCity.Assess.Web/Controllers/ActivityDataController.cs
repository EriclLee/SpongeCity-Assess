using SpongeCity.Asses.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpongeCity.Assess.Web.Controllers
{
    public class ActivityDataController : Controller
    {
        // GET: ActivityData
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetChartData(int subCategoryId, int viewId, int kpiId, int categoryId, string paramS)
        {
            KPIDataBLL bll = new KPIDataBLL();
            var data =bll.GetChartData(subCategoryId,viewId,kpiId,categoryId, paramS);
            return Json(new { XD = data.XaixData, KD = data.KpiData }, JsonRequestBehavior.AllowGet);
        }
    }
}