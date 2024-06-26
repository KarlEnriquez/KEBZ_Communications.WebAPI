﻿/*
 * Filename: UserPlanConfiguration.cs
 * Description: This file contains the configuration to load the database with sample data for the UserPlan table
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
    public class UserPlanConfiguration : IEntityTypeConfiguration<UserPlan>
    {
        public void Configure(EntityTypeBuilder<UserPlan> builder)
        {
            builder.HasData(
                    new UserPlan
                    {
                        UserPlanId = new Guid("57fc1c97-b5a1-4e9a-9b55-90906a2f2b0c"),
                        UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                        PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa")
                    },
                    new UserPlan
                    {
                        UserPlanId = new Guid("a5b47a1f-e288-4c77-83b1-65334a9ba877"),
                        UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                        PlanId = new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733")
                    },
                    new UserPlan
                    {
                        UserPlanId = new Guid("f6a780d0-06a7-4d74-ae4d-d6fc8ff73b9f"),
                        UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                        PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa")
                    },
                    new UserPlan
                    {
                        UserPlanId = new Guid("aaf6281f-9668-4b6d-b6bc-8de2307337f5"),
                        UserId = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                        PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa")
                    },
                    new UserPlan
                    {
                        UserPlanId = new Guid("1024c3d1-45f8-4513-b63c-8d4df5b1f2b8"),
                        UserId = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                        PlanId = new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6")
                    }
              ); 
        }
    }
}
