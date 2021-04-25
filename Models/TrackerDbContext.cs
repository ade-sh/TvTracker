using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TvTracker.Models
{
    public class TrackerDbContext: DbContext
    {
        public DbSet<Tracker> Tracker { get; set; }
        public TrackerDbContext(DbContextOptions<TrackerDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tracker>().ToTable("Tracker");
        }
    }
}
