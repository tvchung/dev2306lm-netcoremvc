using System;
using System.Collections.Generic;

namespace Lesson06.TheoryDF.Models;

public partial class Account
{
    public string AccountId { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public string? FullName { get; set; }

    public string? Picture { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public bool? IsAdmin { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<OrderBook> OrderBooks { get; set; } = new List<OrderBook>();
}
