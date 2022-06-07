using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainerPosition> TrainerPositions { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<FeatureItems> FeatureItems { get; set; }
        public DbSet<PricingFeatureItems> PricingFeatureItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
