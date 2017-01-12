using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCSupport.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}