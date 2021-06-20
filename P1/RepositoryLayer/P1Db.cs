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
    class P1Db : DbContext 
    {
        public DbSet<User> Users { get; set; }

        // constructor
        public P1Db() { }
        public P1Db(DbContextOptions options) : base(options) { }

        // override
        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {
            if (!options.IsConfigured) // check if the options have already been configured in the testing suite
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=P1Db;Trusted_Connection=True;");
            }
        }

    }
}
