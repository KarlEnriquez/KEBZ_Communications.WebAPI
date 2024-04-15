﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace KEBZ_Communications.WebAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240414184856_userplaniddevice")]
    partial class userplaniddevice
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Device", b =>
                {
                    b.Property<Guid>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IMEI")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DeviceId");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceId = new Guid("8f8ce237-2976-48b3-b740-a100299579ae"),
                            IMEI = "400322363175433",
                            Manufacturer = "Apple",
                            Model = "IPhone",
                            PhoneNumber = "1234567890",
                            UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                            UserPlanId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            DeviceId = new Guid("8cb627dd-f70d-4606-b903-d21a9eee14f6"),
                            IMEI = "143567321209614",
                            Manufacturer = "Samsung",
                            Model = "Galaxy",
                            PhoneNumber = "1987654321",
                            UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                            UserPlanId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            DeviceId = new Guid("836f99d4-43ca-4bd1-82f1-38dce36be77c"),
                            IMEI = "613638575519862",
                            Manufacturer = "Apple",
                            Model = "IPhone",
                            PhoneNumber = "5647382910",
                            UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                            UserPlanId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            DeviceId = new Guid("46778fee-73cd-46d3-8432-063e42b419e4"),
                            IMEI = "536773236552500",
                            Manufacturer = "Google",
                            Model = "Pixel",
                            PhoneNumber = "1122334455",
                            UserId = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                            UserPlanId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            DeviceId = new Guid("cf096677-6e6f-4607-8d5e-e43da3afab05"),
                            IMEI = "013750962836846",
                            Manufacturer = "Motorola",
                            Model = "Razr",
                            PhoneNumber = "5544332211",
                            UserId = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                            UserPlanId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            DeviceId = new Guid("770c4356-3ddb-417f-bcdb-cfb694bf51b6"),
                            IMEI = "464532177499263",
                            Manufacturer = "Samsung",
                            Model = "Galaxy",
                            PhoneNumber = "9231478343",
                            UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                            UserPlanId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            DeviceId = new Guid("83f872ec-3173-4ed9-9290-a816848df6af"),
                            IMEI = "605713007805519",
                            Manufacturer = "Apple",
                            Model = "IPhone",
                            PhoneNumber = "8792013456",
                            UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                            UserPlanId = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("Entities.Plan", b =>
                {
                    b.Property<Guid>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataLimit")
                        .HasColumnType("int");

                    b.Property<int>("DeviceLimit")
                        .HasColumnType("int");

                    b.Property<int>("MinuteLimit")
                        .HasColumnType("int");

                    b.Property<string>("PlanDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<int>("TextLimit")
                        .HasColumnType("int");

                    b.HasKey("PlanId");

                    b.ToTable("Plans");

                    b.HasData(
                        new
                        {
                            PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1620),
                            DataLimit = -1,
                            DeviceLimit = 2,
                            MinuteLimit = -1,
                            PlanDescription = "Stay connected without limits. Enjoy unlimited data, minutes, and texts for up to 2 devices",
                            PlanName = "Unlimited Personal Plan",
                            Price = 0m,
                            TextLimit = -1
                        },
                        new
                        {
                            PlanId = new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1620),
                            DataLimit = -1,
                            DeviceLimit = 5,
                            MinuteLimit = -1,
                            PlanDescription = "Stay connected without limits. Enjoy unlimited data, minutes, and texts for up to 5 devices",
                            PlanName = "Unlimited Family Plan",
                            Price = 0m,
                            TextLimit = -1
                        },
                        new
                        {
                            PlanId = new Guid("c539a331-806d-470f-8960-3b8c2051fa7f"),
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1630),
                            DataLimit = -1,
                            DeviceLimit = 2,
                            MinuteLimit = 1000,
                            PlanDescription = "Stay connected without worrying about data limits. Enjoy unlimited data for up to 2 devices",
                            PlanName = "Oops! All data!",
                            Price = 0m,
                            TextLimit = 1000
                        },
                        new
                        {
                            PlanId = new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1630),
                            DataLimit = 10,
                            DeviceLimit = 2,
                            MinuteLimit = -1,
                            PlanDescription = "Stay connected with friends, family, and colleagues without counting minutes. Connect up to 2 devices",
                            PlanName = "Oops! All minutes!",
                            Price = 0m,
                            TextLimit = 1000
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a5234556-a54d-4306-a98f-fe47459b8d9f",
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1430),
                            Email = "email1@email.com",
                            EmailConfirmed = false,
                            FirstName = "Bryan",
                            LastName = "Zbojna",
                            LockoutEnabled = false,
                            Password = "password1",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "username1",
                            status = true
                        },
                        new
                        {
                            Id = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c1d33a44-e9cb-4351-bc34-ca65db880453",
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1490),
                            Email = "email2@email.com",
                            EmailConfirmed = false,
                            FirstName = "Karl",
                            LastName = "Enriquez",
                            LockoutEnabled = false,
                            Password = "password2",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "username2",
                            status = true
                        },
                        new
                        {
                            Id = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "210a3544-c963-4091-a39a-7fbde5894de5",
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1500),
                            Email = "email3@email.com",
                            EmailConfirmed = false,
                            FirstName = "Ethan",
                            LastName = "Wintill",
                            LockoutEnabled = false,
                            Password = "password3",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "username3",
                            status = true
                        },
                        new
                        {
                            Id = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "970d377f-ee83-41a9-a506-da74052d578b",
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1510),
                            Email = "email4@email.com",
                            EmailConfirmed = false,
                            FirstName = "MyName",
                            LastName = "IsTest",
                            LockoutEnabled = false,
                            Password = "password4",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "username4",
                            status = true
                        },
                        new
                        {
                            Id = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "36a295a6-72aa-41db-9b89-b2e5e28d4231",
                            CreatedAt = new DateTime(2024, 4, 14, 13, 48, 56, 538, DateTimeKind.Local).AddTicks(1520),
                            Email = "email5@email.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            Password = "password5",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "username5",
                            status = true
                        });
                });

            modelBuilder.Entity("Entities.UserPlan", b =>
                {
                    b.Property<Guid>("UserPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserPlanId");

                    b.HasIndex("PlanId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPlans");

                    b.HasData(
                        new
                        {
                            UserPlanId = new Guid("57fc1c97-b5a1-4e9a-9b55-90906a2f2b0c"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2")
                        },
                        new
                        {
                            UserPlanId = new Guid("a5b47a1f-e288-4c77-83b1-65334a9ba877"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlanId = new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1")
                        },
                        new
                        {
                            UserPlanId = new Guid("f6a780d0-06a7-4d74-ae4d-d6fc8ff73b9f"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb")
                        },
                        new
                        {
                            UserPlanId = new Guid("aaf6281f-9668-4b6d-b6bc-8de2307337f5"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d")
                        },
                        new
                        {
                            UserPlanId = new Guid("1024c3d1-45f8-4513-b63c-8d4df5b1f2b8"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlanId = new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.Device", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithMany("Devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.UserPlan", b =>
                {
                    b.HasOne("Entities.Plan", "Plan")
                        .WithMany("UserPlans")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.User", "User")
                        .WithMany("UserPlans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Plan", b =>
                {
                    b.Navigation("UserPlans");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("UserPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
