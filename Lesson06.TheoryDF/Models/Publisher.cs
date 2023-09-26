using System;
using System.Collections.Generic;

namespace Lesson06.TheoryDF.Models;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string? PublisherName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
