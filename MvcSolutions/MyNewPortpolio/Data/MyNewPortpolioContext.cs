using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyNewPortpolio.Models;

namespace MyNewPortpolio.Data
{
    public class MyNewPortpolioContext : DbContext
    {
        public MyNewPortpolioContext(DbContextOptions<MyNewPortpolioContext> options)
            : base(options)
        {
        }

        public DbSet<MyNewPortpolio.Models.Contact> Contact { get; set; }

        public DbSet<MyNewPortpolio.Models.Account> Account { get; set; }

        public DbSet<MyNewPortpolio.Models.Manage> Manages { get; set; }

      
    }
}
