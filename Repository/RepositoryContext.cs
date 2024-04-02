using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KEBZ_Communications.WebAPI.Entities;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Plan>? Plans { get; set; }
        public DbSet<Device>? Devices { get; set; }
        public DbSet<UserPlan>? UserPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPlan>()
                .HasKey(c => new { c.UserId, c.PlanId });
        }
    }
}
