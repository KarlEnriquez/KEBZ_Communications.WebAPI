/*
 * Filename: DeviceConfiguration.cs
 * Description: This file contains the configuration to load the database with sample data for the Device table
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
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasData(
                    new Device
                    {
                        DeviceId = Guid.NewGuid(),
                        UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                        PhoneNumber = "1234567890",
                        IMEI = "400322363175433",
                        Manufacturer = "Apple",
                        Model = "IPhone",
                    },
                    new Device
                    {
                        DeviceId = Guid.NewGuid(),
                        UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                        PhoneNumber = "1987654321",
                        IMEI = "143567321209614",
                        Manufacturer = "Samsung",
                        Model = "Galaxy",
                    },
                    new Device
                    {
                        DeviceId = Guid.NewGuid(),
                        UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                        PhoneNumber = "5647382910",
                        IMEI = "613638575519862",
                        Manufacturer = "Apple",
                        Model = "IPhone",
                    },
                    new Device
                    {
                        DeviceId = Guid.NewGuid(),
                        UserId = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                        PhoneNumber = "1122334455",
                        IMEI = "536773236552500",
                        Manufacturer = "Google",
                        Model = "Pixel",
                    },
                    new Device
                    {
                        DeviceId = Guid.NewGuid(),
                        UserId = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                        PhoneNumber = "5544332211",
                        IMEI = "013750962836846",
                        Manufacturer = "Motorola",
                        Model = "Razr",
                    },
                    new Device
                    {
                        DeviceId = Guid.NewGuid(),
                        UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                        PhoneNumber = "9231478343",
                        IMEI = "464532177499263",
                        Manufacturer = "Samsung",
                        Model = "Galaxy",
                    },
                    new Device
                    {
                        DeviceId = Guid.NewGuid(),
                        UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                        PhoneNumber = "8792013456",
                        IMEI = "605713007805519",
                        Manufacturer = "Apple",
                        Model = "IPhone",
                    }
              );
            builder.HasIndex(u => u.PhoneNumber).IsUnique();
        }
    }
}
