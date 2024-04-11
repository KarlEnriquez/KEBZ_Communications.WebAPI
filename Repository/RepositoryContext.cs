using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace Repository
{
    public class RepositoryContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
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
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<UserPlan>()
            //    .HasKey(c => new { c.UserId, c.PlanId }); TOTO: Remove commented code, removing this because I created UserPlanId

            modelBuilder.Entity<UserPlan>()
                .HasKey(c => new { c.UserPlanId });

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PlanConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new UserPlanConfiguration());

        }
    }
}
