using Microsoft.EntityFrameworkCore;
// using P1Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLayer;

namespace RepositoryLayer
{
    public class P1Db : DbContext 
    {
        public DbSet<User> Users { get; set; }
        // public DbSet<Store> Stores { get; set; }
        //public DbSet<Product> Products { get; set; }
        // public DbSet<Order> Orders { get; set; }
        //public DbSet<Location> Locations { get; set; }

        // constructor
        public P1Db() { }
        public P1Db(DbContextOptions<P1Db>options) : base(options) { }

        //public P1Db(DbContextOptions<P1Db> options): base(options) { }

        // override
        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {
            // YOU CAN PUT THIS HERE OR WITHIN THE STARTUP.CS IN MVC
            // if (!options.IsConfigured) // check if the options have already been configured in the testing suite
            // {
            //     options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=P1Db;Trusted_Connection=True;");
            // }
        }

    }
}
