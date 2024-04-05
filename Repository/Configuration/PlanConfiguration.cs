/*
 * Filename: PlanConfiguration.cs
 * Description: This file contains the configuration to load the database with sample data for the Plan table
 * Implements IEntityTypeConfiguration<T>
 * Is used in the RepositoryContext.cs file 
 */

using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.HasData(
                    new Plan
                    {
                        PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                        PlanName = "Unlimited Personal Plan",
                        PlanDescription = "Stay connected without limits. Enjoy unlimited data, minutes, and texts for up to 2 devices",
                        DeviceLimit = 2,
                        DataLimit = -1,
                        MinuteLimit = -1,
                        TextLimit = -1,
                        CreatedAt = DateTime.Now,
                    },
                    new Plan
                    {
                        PlanId = new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                        PlanName = "Unlimited Family Plan",
                        PlanDescription = "Stay connected without limits. Enjoy unlimited data, minutes, and texts for up to 5 devices",
                        DeviceLimit = 5,
                        DataLimit = -1,
                        MinuteLimit = -1,
                        TextLimit = -1,
                        CreatedAt = DateTime.Now,
                    },
                    new Plan
                    {
                        PlanId = new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                        PlanName = "Oops! All data!",
                        PlanDescription = "Stay connected without worrying about data limits. Enjoy unlimited data for up to 2 devices",
                        DeviceLimit = 2,
                        DataLimit = -1,
                        MinuteLimit = 1000,
                        TextLimit = 1000,
                        CreatedAt = DateTime.Now,
                    },
                    new Plan
                    {
                        PlanId = new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                        PlanName = "Oops! All minutes!",
                        PlanDescription = "Stay connected with friends, family, and colleagues without counting minutes. Connect up to 2 devices",
                        DeviceLimit = 2,
                        DataLimit = 10,
                        MinuteLimit = -1,
                        TextLimit = 1000,
                        CreatedAt = DateTime.Now,
                    }
              );
        }
    }
}
