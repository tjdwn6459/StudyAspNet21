using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyPortpolio.Models;
using RestApiTestApp.Models;

namespace MyPortpollo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MyPortpolio.Models.Contact> Contact { get; set; }
        public DbSet<MyPortpolio.Models.Account> Account { get; set; }

        public DbSet<Board> Boards { get; set; }

        public DbSet<MyPortpolio.Models.Manage> Manages { get; set; }

    }
}
