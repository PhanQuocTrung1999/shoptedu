using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTedu.Model.Model
{
    [Table("SupportOnline")]
   public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id tu tang
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(50)]
        public string Department { set; get; }

        [MaxLength(50)]
        public string Skyper { set; get; }

        [MaxLength(50)]
        public string Mobile { set; get; }

        [MaxLength(50)]
        public string Email { set; get; }

        [MaxLength(50)]
        public string Zalo { set; get; }

        [MaxLength(50)]
        public string Facebook { set; get; }

        [MaxLength(50)]
        public int? DisplayOrder { set; get; }

    }
}
