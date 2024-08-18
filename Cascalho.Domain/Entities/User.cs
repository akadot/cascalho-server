using System;
using System.ComponentModel.DataAnnotations;

namespace Cascalho.Domain.Entities;

public class User : Base
{
    [Required]
    [StringLength(150)]
    public string FirstName {get; set;} = default!;
    public string? LastName {get; set;} = "";
    [Required]
    [StringLength(150)]
    public string Email {get;set;} = default!;
    [Required]
    public string Password {get; set;} = default!;
    public string Avatar {get;set;} = default!;

    public ICollection<UserAccount> UserAccounts {get;set;} = new List<UserAccount>();
    public ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();
}
