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
    [Migration("20240404204003_DbCreateWithConfigurations")]
    partial class DbCreateWithConfigurations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KEBZ_Communications.WebAPI.Entities.Device", b =>
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DeviceId");

                    b.HasIndex("UserId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceId = new Guid("f9c81872-0545-4028-9e99-36df82aa0604"),
                            IMEI = "400322363175433",
                            Manufacturer = "Apple",
                            Model = "IPhone",
                            PhoneNumber = "1234567890",
                            UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2")
                        },
                        new
                        {
                            DeviceId = new Guid("fcb80377-3327-4458-b86b-7f880c1984d3"),
                            IMEI = "143567321209614",
                            Manufacturer = "Samsung",
                            Model = "Galaxy",
                            PhoneNumber = "1987654321",
                            UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1")
                        },
                        new
                        {
                            DeviceId = new Guid("2a8f20dd-ae3c-4620-a0b1-419d6f7d2ab1"),
                            IMEI = "613638575519862",
                            Manufacturer = "Apple",
                            Model = "IPhone",
                            PhoneNumber = "5647382910",
                            UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb")
                        },
                        new
                        {
                            DeviceId = new Guid("5ecd57a5-c061-4658-adaf-309cea8d78e3"),
                            IMEI = "536773236552500",
                            Manufacturer = "Google",
                            Model = "Pixel",
                            PhoneNumber = "1122334455",
                            UserId = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d")
                        },
                        new
                        {
                            DeviceId = new Guid("8312440a-6f1a-4411-916e-556d6c66795c"),
                            IMEI = "013750962836846",
                            Manufacturer = "Motorola",
                            Model = "Razr",
                            PhoneNumber = "5544332211",
                            UserId = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12")
                        },
                        new
                        {
                            DeviceId = new Guid("e1a39dcc-5f9b-4a19-8cb7-9e92d099ee0c"),
                            IMEI = "464532177499263",
                            Manufacturer = "Samsung",
                            Model = "Galaxy",
                            PhoneNumber = "9231478343",
                            UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2")
                        },
                        new
                        {
                            DeviceId = new Guid("fa733d84-b500-4661-8b00-e0150b42701c"),
                            IMEI = "605713007805519",
                            Manufacturer = "Apple",
                            Model = "IPhone",
                            PhoneNumber = "8792013456",
                            UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1")
                        });
                });

            modelBuilder.Entity("KEBZ_Communications.WebAPI.Entities.Plan", b =>
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
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1862),
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
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1864),
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
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1869),
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
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1871),
                            DataLimit = 10,
                            DeviceLimit = 2,
                            MinuteLimit = -1,
                            PlanDescription = "Stay connected with friends, family, and colleagues without counting minutes. Connect up to 2 devices",
                            PlanName = "Oops! All minutes!",
                            Price = 0m,
                            TextLimit = 1000
                        });
                });

            modelBuilder.Entity("KEBZ_Communications.WebAPI.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1739),
                            Email = "email1@email.com",
                            FirstName = "Bryan",
                            LastName = "Zbojna",
                            Password = "password1",
                            Username = "username1",
                            status = true
                        },
                        new
                        {
                            UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1752),
                            Email = "email2@email.com",
                            FirstName = "Karl",
                            LastName = "Enriquez",
                            Password = "password2",
                            Username = "username2",
                            status = true
                        },
                        new
                        {
                            UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1754),
                            Email = "email3@email.com",
                            FirstName = "Ethan",
                            LastName = "Wintill",
                            Password = "password3",
                            Username = "username3",
                            status = true
                        },
                        new
                        {
                            UserId = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1756),
                            Email = "email4@email.com",
                            FirstName = "MyName",
                            LastName = "IsTest",
                            Password = "password4",
                            Username = "username4",
                            status = true
                        },
                        new
                        {
                            UserId = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                            CreatedAt = new DateTime(2024, 4, 4, 15, 40, 3, 108, DateTimeKind.Local).AddTicks(1758),
                            Email = "email5@email.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "password5",
                            Username = "username5",
                            status = true
                        });
                });

            modelBuilder.Entity("KEBZ_Communications.WebAPI.Entities.UserPlan", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "PlanId");

                    b.HasIndex("PlanId");

                    b.ToTable("UserPlans");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                            PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                            PlanId = new Guid("550e5574-2e5f-4f3e-8c1a-29dea792e733"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                            PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                            PlanId = new Guid("ae91ff01-f882-43b6-ac18-74ed0611deaa"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            UserId = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                            PlanId = new Guid("bbe280e0-0172-46cd-916b-c348d2c3a8b6"),
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("KEBZ_Communications.WebAPI.Entities.Device", b =>
                {
                    b.HasOne("KEBZ_Communications.WebAPI.Entities.User", "User")
                        .WithMany("Devices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KEBZ_Communications.WebAPI.Entities.UserPlan", b =>
                {
                    b.HasOne("KEBZ_Communications.WebAPI.Entities.Plan", "Plan")
                        .WithMany("UserPlans")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KEBZ_Communications.WebAPI.Entities.User", "User")
                        .WithMany("UserPlans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KEBZ_Communications.WebAPI.Entities.Plan", b =>
                {
                    b.Navigation("UserPlans");
                });

            modelBuilder.Entity("KEBZ_Communications.WebAPI.Entities.User", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("UserPlans");
                });
#pragma warning restore 612, 618
        }
    }
}