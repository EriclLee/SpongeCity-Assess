using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpongeCity.Assess.DAL.DBModels
{
    public class KPIParam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int KpiId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Unit { get; set; }
        public int DataStatus { get; set; }
        public virtual ICollection<KPIData> KPIDatas { get; set; }
        [ForeignKey("KpiId")]
        public virtual KPI Kpi { get; set; }

    }
}
