﻿using SpongeCity.Assess.DAL;
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


        public ChartData GetChildrenChartData(int subCategoryId, int viewId, int kpiId, int categoryId, string paramS)
        {
            var paramStrs = paramS.Split(',');
            List<int> paramArray = new List<int>();
            foreach (var p in paramStrs)
            {
                paramArray.Add(int.Parse(p));
            }
            List<string> Legends = new List<string>();
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
                            kpiId = db.KPIs.FirstOrDefault(s => s.CategoryId == categoryId).ID;
                        }
                        viewId = db.Views.FirstOrDefault(s => s.KpiId == kpiId).ID;
                    }
                    subCategoryId = db.SubCategorys.FirstOrDefault(s => s.ViewId == viewId).ID;
                }
                var children = db.SubCategorys.Where(s => s.ParentId == subCategoryId);
                foreach (var child in children)
                {
                    Legends.Add(child.DisplayName);
                    foreach (var pItem in paramArray)
                    {
                        var dataTemp = db.KPIDatas.Where(s => s.KpiId == kpiId && s.Pid == pItem
                        && s.SubCategoryId == child.ID);
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
            }
            chartData.KpiData = KpiData;
            chartData.XaixData = XaixData;
            chartData.LegendData = Legends;
            return chartData;
        }

        public ChartData GetChildChartData(int subCategoryId, int viewId, int kpiId, int categoryId, string paramS, int sort)
        {
            var paramStrs = paramS.Split(',');
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
                            kpiId = db.KPIs.FirstOrDefault(s => s.CategoryId == categoryId).ID;
                        }
                        viewId = db.Views.FirstOrDefault(s => s.KpiId == kpiId).ID;
                    }
                    subCategoryId = db.SubCategorys.FirstOrDefault(s => s.ViewId == viewId).ID;
                }
                var child = db.SubCategorys.FirstOrDefault(s => s.ParentId == subCategoryId && s.SortIdx == sort);
                foreach (var pItem in paramArray)
                {
                    var dataTemp = db.KPIDatas.Where(s => s.KpiId == kpiId && s.Pid == pItem
                    && s.SubCategoryId == child.ID);
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

        public ReportModel GetReportData(int subCategoryId, int viewId, int kpiId, int categoryId)
        {
            ReportModel report = null;
            using (AssessDBContext db = new AssessDBContext())
            {
                if (subCategoryId == 0)
                {
                    if (viewId == 0)
                    {
                        if (kpiId == 0)
                        {
                            kpiId = db.KPIs.FirstOrDefault(s => s.CategoryId == categoryId).ID;
                        }
                        viewId = db.Views.FirstOrDefault(s => s.KpiId == kpiId).ID;
                    }
                    subCategoryId = db.SubCategorys.FirstOrDefault(s => s.ViewId == viewId).ID;
                }
                var reportQ = db.KPIReports.FirstOrDefault(s=>s.SubCategoryId == subCategoryId);
                if (reportQ != null)
                {
                    report = new ReportModel() {
                        ID=reportQ.ID,
                        DisplayName = reportQ.DisplayName,
                        Name = reportQ.Name,
                        CreatTime = reportQ.CreatTime,
                        KpiId = reportQ.KpiId,
                        ReportUrl = reportQ.ReportUrl,
                        ReportContent = reportQ.ReportContent,
                        SubCategoryId = reportQ.SubCategoryId
                    };
                }
            }
            return report;
        }
    }
}
