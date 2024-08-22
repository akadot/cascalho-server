using System;
using Cascalho.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cascalho.Infra.Context;

public class EntitiesConfigurator
{
    public static void Configure(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasMany(x => x.UserAccounts)
        .WithOne(y => y.User)
        .HasForeignKey(z => z.UserId);

        modelBuilder.Entity<Account>()
        .HasMany(x => x.UserAccounts)
        .WithOne(y => y.Account)
        .HasForeignKey(z => z.AccountId);

        modelBuilder.Entity<Account>()
        .HasOne(a => a.Owner)
        .WithMany()
        .HasForeignKey(a => a.OwnerId)
        .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<UserAccount>()
        .HasKey(x => new { x.UserId, x.AccountId });

        modelBuilder.Entity<Transaction>()
        .HasOne(t => t.SenderAccount)
        .WithMany()
        .HasForeignKey(t => new { t.SenderUserId, t.SenderAccountId })
        .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Transaction>()
        .HasOne(t => t.ReceiverAccount)
        .WithMany()
        .HasForeignKey(t => new { t.ReceiverUserId, t.ReceiverAccountId })
        .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Reminder>()
        .HasOne(r => r.User)
        .WithMany(u => u.Reminders)
        .HasForeignKey(r => r.UserId);

        modelBuilder.Entity<Reminder>()
        .HasOne(r => r.Transaction)
        .WithMany()
        .HasForeignKey(r => r.TransactionId)
        .OnDelete(DeleteBehavior.SetNull);
    }
}
