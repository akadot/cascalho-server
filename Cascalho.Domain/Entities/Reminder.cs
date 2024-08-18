using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cascalho.Domain.Enums;

namespace Cascalho.Domain.Entities;

public class Reminder
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public DateTime ScheduledAt { get; set; } = DateTime.Now;
    public decimal Amount { get; set; } = default!;
    public bool IsCompleted { get; set; } = false;

    public long UserId { get; set; }
    public User User { get; set; } = null!;

    public long? TransactionId { get; set; }
    public Transaction? Transaction { get; set; }

    public bool IsRecurring { get; set; } = false;
    public ERecurrenceFrequency? RecurrenceFrequency { get; set; }
    public DateTime? RecurrenceEndDate { get; set; }  // Data opcional para terminar a recorrência
}
