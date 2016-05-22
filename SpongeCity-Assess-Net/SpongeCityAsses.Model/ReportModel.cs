using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpongeCityAsses.Model
{
    public class ReportModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int SubCategoryId { get; set; }
        public DateTime CreatTime { get; set; }
        public int KpiId { get; set; }
        public string ReportUrl { get; set; }
        public string ReportContent { get; set; }
    }
}
