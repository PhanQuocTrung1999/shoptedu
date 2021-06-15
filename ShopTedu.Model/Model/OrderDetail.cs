using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTedu.Model.Model
{
    [Table("OrderDetails")]
   public class OrderDetail
    {

        [Key]
        public int OrderID { set; get; }
        [Key]
        public int ProductID { set; get; }
        public int Quantity { set; get; }
        [ForeignKey("OrderID")]
        public virtual IEnumerable<Order> Orders { set; get; }

        [ForeignKey("ProductID")]
        public virtual IEnumerable<Product> Products { set; get; }


    }
}
