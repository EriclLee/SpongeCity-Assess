using SpongeCity.Asses.BLL;
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

        public ActionResult AzureDeckerAdmin(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            KPIDataBLL bll = new KPIDataBLL();
            var report = bll.GetReportData(subCategoryId, viewId, kpiId, categoryId);
            return PartialView(report);
        }

        //地下水水位
        public ActionResult GroundWaterLevel(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //生态岸线：盖度、存活率
        public ActionResult EcologicalShorelineCoverAndSurvival(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //生态岸线：物种丰富度、岸线长度
        public ActionResult EcologicalShorelineRichAndLength(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //地表水环境质量：参数1
        public ActionResult RiverWaterEnvironmentParam1(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //地表水环境质量：参数2
        public ActionResult RiverWaterEnvironmentParam2(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //地表水环境质量：水质参数
        public ActionResult RiverWaterEnvironmentQuality(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //城市面源污染
        public ActionResult NPSP(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //污水再生利用率
        public ActionResult WaterwaterReuseRate(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //管网漏损
        public ActionResult PipeLeakageRate(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }

        //雨水资源利用率
        public ActionResult RainwaterUtilization(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ViewBag.SubCategoryId = subCategoryId;
            ViewBag.ViewId = viewId;
            ViewBag.KpiId = kpiId;
            ViewBag.CategoryId = categoryId;
            return PartialView();
        }
    }
}