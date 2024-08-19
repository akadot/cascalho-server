using System;
using Cascalho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cascalho.Infra.Context;

public class CascalhoContext(DbContextOptions<CascalhoContext> options) : DbContext(options)
{
    public DbSet<User> Users {get;set;} = default!;
    public DbSet<Account> Accounts {get;set;} = default!;
    public DbSet<UserAccount> UserAccounts {get;set;} = default!;
    public DbSet<Transaction> Transactions {get; set;} = default!;
    public DbSet<Reminder> Reminders {get;set;} = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        EntitiesConfigurator.Configure(modelBuilder);
        DataSeeder.Seed(modelBuilder);
    }
}
