using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    public class NorthwindDbContext : DbContext //1.using system.Data.Entity;
    {
        //2.connection string
        public NorthwindDbContext()
        {
            this.Database.Connection.ConnectionString = "Server=MSI\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
        }
        //3.DbSet

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
    /*
     Standard Security: SQL Server Authentication (login ve password)
    //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;

    Trusted Connection: Windows Authentication
    //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
     */
}
