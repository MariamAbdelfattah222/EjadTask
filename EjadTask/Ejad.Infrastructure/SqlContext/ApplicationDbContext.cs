using EjadTask.Ejad.Domain.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EjadTask.Ejad.Infrastructure.SqlContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Battle> Battles { get; set; }
        public DbSet<samurai> Samurais { get; set; }
        public DbSet<Horse> Horses { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
