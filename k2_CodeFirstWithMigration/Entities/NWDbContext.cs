﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_CodeFirstWithMigration.Entities
{
    public class NWDbContext : DbContext
    {
        public NWDbContext()
        {
            this.Database.Connection.ConnectionString = "Server=MSI\\SQLEXPRESS;Database=NWDb;Trusted_Connection=True;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
