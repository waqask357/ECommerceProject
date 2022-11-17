using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Database
{
    public class AppDatabaseContext : DbContext
    {
        public AppDatabaseContext() : base("StudentsProject")
        {

        }
        //DbSet database me table bnanay k liye use krte hain
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
