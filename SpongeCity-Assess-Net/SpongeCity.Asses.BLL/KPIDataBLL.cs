using SpongeCity.Assess.DAL;
using SpongeCityAsses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpongeCity.Asses.BLL
{
    public class KPIDataBLL
    {
        public ChartData GetChartData(int subCategoryId, int viewId, int kpiId, int categoryId, string paramS)
        {
            var paramStrs =paramS.Split(',');
            List<int> paramArray = new List<int>();
            foreach (var p in paramStrs)
            {
                paramArray.Add(int.Parse(p));
            }
            ChartData chartData = new ChartData();
            List<string> XaixData = new List<string>();
            List<List<double>> KpiData = new List<List<double>>();
            using (AssessDBContext db = new AssessDBContext())
            {
                if (subCategoryId == 0)
                {
                    if (viewId == 0)
                    {
                        if (kpiId == 0)
                        {
                            kpiId = db.KPIs.FirstOrDefault(s=>s.CategoryId==categoryId).ID;
                        }
                        viewId = db.Views.FirstOrDefault(s => s.KpiId == kpiId).ID;
                    }
                    subCategoryId = db.SubCategorys.FirstOrDefault(s => s.ViewId == viewId).ID;
                }

                foreach (var pItem in paramArray)
                {
                    var dataTemp = db.KPIDatas.Where(s => s.KpiId == kpiId && s.Pid == pItem
                    && s.SubCategoryId == subCategoryId);
                    KpiData.Add(dataTemp.Select(s => s.NumricValue).ToList());
                    if (XaixData.Count == 0)
                    {
                        var tlist = dataTemp.OrderBy(s => s.SamplingTime).Select(s => s.SamplingTime).ToList();
                        foreach (var t in tlist)
                        {
                            XaixData.Add(t.ToString("MM-dd HH:mm"));
                        }
                    }
                }
            }
            chartData.KpiData = KpiData;
            chartData.XaixData = XaixData;
            return chartData;
        }
    }

    //public string GetReportData(int subCategoryId, int viewId, int kpiId, int categoryId)
    //{
    //    string content;
    //    List<string> XaixData = new List<string>();
    //    List<List<double>> KpiData = new List<List<double>>();
    //    using (AssessDBContext db = new AssessDBContext())
    //    {
    //        var filepath = db.SubCategorys.FirstOrDefault(s => s.ID == subCategoryId);

    //    }
    //    return content;
    //}
}
