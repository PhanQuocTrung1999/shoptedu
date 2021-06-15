using ShopTedu.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTedu.Model.Model
{
    [Table("Pages")]
   public class Page:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id tu tang
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        
        [Column(TypeName ="varchar")]// chi ra chinh xac kieu du lieu
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }
        public string Content { set; get; }


    }
}
