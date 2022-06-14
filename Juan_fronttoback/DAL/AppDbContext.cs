using Juan_fronttoback.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan_fronttoback.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColors> ProductColors { get; set; }
    }
}
