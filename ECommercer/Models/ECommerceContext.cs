using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommercer.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {

        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ECommercer.Models.City> Cities { get; set; }
    }
}