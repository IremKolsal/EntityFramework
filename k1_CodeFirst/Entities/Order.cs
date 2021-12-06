using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; } // ? nullable
        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        [ForeignKey("ShipVia")]
        public Shipper Shipper { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public override string ToString()
        {
            return $"OrderID:{OrderID} - Order Date: {OrderDate.Value.ToString("dd/MM/yyyy")}";
        }
    }
    /*
     ReferanceTypes : class, string -> default da nullable'dır
     ValueTypes : int , bool, DateTime, struct , float, decimal, short, byte -> nullable değillerdir.
     */
}
