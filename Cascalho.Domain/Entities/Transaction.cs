using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cascalho.Domain.Enums;

namespace Cascalho.Domain.Entities;

public class Transaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id {get; set;}
    [Required]
    public decimal Amount {get;set;} = default!;
    [Required]
    public ETransactionType Type {get;set;}
    [Required]
    public DateTime RegisteredAt {get;set;} = DateTime.Now;
    
    public UserAccount SenderAccount {get;set;} = new UserAccount();
    public UserAccount ReceiverAccount {get;set;} = new UserAccount();
}
