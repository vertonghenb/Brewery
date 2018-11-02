using Brewery.Data.Configurations;
using Brewery.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Brewery.Data
{
    public class BreweryDbContext : DbContext
    {
        #region DbSets
        public DbSet<Brewer> Brewers { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Beerhall;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrewerConfiguration());
            modelBuilder.ApplyConfiguration(new BeerConfiguration());
        }
    }
}
