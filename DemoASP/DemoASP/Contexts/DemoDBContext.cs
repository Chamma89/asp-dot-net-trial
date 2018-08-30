using System;
using Microsoft.EntityFrameworkCore;
using DemoASP.Models;
namespace DemoASP.Contexts
{
    public class DemoASPDBContext : DbContext
    {
        public DemoASPDBContext(DbContextOptions<DemoASPDBContext> options) : base(options) { }

        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
