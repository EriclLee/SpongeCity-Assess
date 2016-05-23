using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpongeCityAsses.Model
{
    public class ChartData
    {
        public List<string> XaixData { get; set; }
        public List<List<double>> KpiData { get; set; }

        public List<string> LegendData { get; set; }
    }
}
