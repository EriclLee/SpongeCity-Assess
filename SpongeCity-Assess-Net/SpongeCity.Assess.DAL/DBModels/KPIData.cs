using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpongeCity.Assess.DAL.DBModels
{
    public class KPIData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int SubCategoryId { get; set; }
        public DateTime SamplingTime { get; set; }
        public int KpiId { get; set; }
        public int Pid { get; set; }
        public double NumricValue { get; set; }
        public string TextValue { get; set; }
        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }
        [ForeignKey("KpiId")]
        public virtual KPI Kpi { get; set; }
        [ForeignKey("Pid")]
        public virtual KPIParam KPIParam { get; set; }

    }
}
