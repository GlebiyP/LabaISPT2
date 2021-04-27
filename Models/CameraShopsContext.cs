using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LabaISPT2.Models
{
    public class CameraShopsContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }

        public CameraShopsContext(DbContextOptions<CameraShopsContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
