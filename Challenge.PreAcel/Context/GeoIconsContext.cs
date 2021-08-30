using Challenge.PreAcel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.PreAcel.Context
{
    public class GeoIconsContext : DbContext
    {
        public GeoIconsContext(DbContextOptions options) :base (options)
        {

        }
        protected override  void OnModelCreating ( ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Continent> Continents { get; set; } = null!;
        public DbSet<City> City { get; set; } = null!;
        public DbSet<GeographicIcon> GeographicIcon { get; set; } = null!;

    }
}
