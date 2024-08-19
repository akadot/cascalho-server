using System;
using Cascalho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cascalho.Infra.Context;

public class DataSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "Fausto",
                LastName = "Silva",
                Email = "faustao@oloco.com",
                Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", //SHA-256
                Avatar = "", //BLOB
                Active = true,
            }
        );

        modelBuilder.Entity<Account>().HasData(
            new Account {
                Id = 1,
                AccountName = "Casa",
                Avatar = "",
                IsPublic = false,
                IsUserMain = true,
                OwnerId = 1,
                Active = true,
            }
        );

        modelBuilder.Entity<UserAccount>().HasData(
            new UserAccount {
                UserId = 1,
                AccountId = 1
            }
        );
    }
}
