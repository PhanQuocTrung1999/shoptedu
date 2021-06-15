using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTedu.Model.Model
{
    [Table("VisitorStatistics")]
   public class VisitorStatistic
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public DateTime VisitedDate { set; get; }
        
        [MaxLength(50)]
        public string IpAddress { set; get; }
    }
}
