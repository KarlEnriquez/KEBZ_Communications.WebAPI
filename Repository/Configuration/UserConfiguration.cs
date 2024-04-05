/*
 * Filename: UserConfiguration.cs
 * Description: This file contains the configuration to load the database with sample data for the User table
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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                    new User
                    {
                        UserId = new Guid("06917677-cdd6-4523-91b8-88d6d0a912d2"),
                        Username = "username1",
                        Password = "password1",
                        Email = "email1@email.com",
                        FirstName = "Bryan",
                        LastName = "Zbojna",
                        CreatedAt = DateTime.Now,
                        status = true
                    },
                    new User
                    {
                        UserId = new Guid("798acf1b-7339-44bd-8367-7132a978d7b1"),
                        Username = "username2",
                        Password = "password2",
                        Email = "email2@email.com",
                        FirstName = "Karl",
                        LastName = "Enriquez",
                        CreatedAt = DateTime.Now,
                        status = true
                    },
                    new User
                    {
                        UserId = new Guid("2a36409f-6732-459b-b7d1-a561c521a3cb"),
                        Username = "username3",
                        Password = "password3",
                        Email = "email3@email.com",
                        FirstName = "Ethan",
                        LastName = "Wintill",
                        CreatedAt = DateTime.Now,
                        status = true
                    },
                    new User
                    {
                        UserId = new Guid("7d84360e-4967-4c7b-8e4c-0f085de7ca4d"),
                        Username = "username4",
                        Password = "password4",
                        Email = "email4@email.com",
                        FirstName = "MyName",
                        LastName = "IsTest",
                        CreatedAt = DateTime.Now,
                        status = true
                    },
                    new User
                    {
                        UserId = new Guid("7a1be69a-38ac-4cde-a105-615de38c2d12"),
                        Username = "username5",
                        Password = "password5",
                        Email = "email5@email.com",
                        FirstName = "John",
                        LastName = "Doe",
                        CreatedAt = DateTime.Now,
                        status = true
                    }
              );
        }
    }
}
