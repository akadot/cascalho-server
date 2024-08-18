using System;

namespace Cascalho.Domain.Entities;

public class UserAccount
{
    public long UserId {get; set;}
    public long AccountId {get; set;}

    public User User {get; set;} = null!;
    public Account Account {get; set;} = null!;
}
