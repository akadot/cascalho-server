using System;

namespace Cascalho.Domain.Entities;

public class Account : Base
{
    public string Label {get; set;} = default!;
    public bool IsPublic {get;set;} = false;
    public bool IsUserMain {get; set;} = true;
    public string Avatar {get;set;} = default!;

    public ICollection<UserAccount> UserAccounts {get;set;} = new List<UserAccount>();
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
