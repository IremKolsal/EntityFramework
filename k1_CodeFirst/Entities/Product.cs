using k1_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public bool Discontinued { get; set; }


        //one to many > product - category
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }

    /*
     nvarchar,text : string
    tint : byte
    smallint : short
    int : int

    bit : bool

    money, decimal(s,m) : decimal

    datetime : Datetime

    uniqidentifier : Guid


     */
}
