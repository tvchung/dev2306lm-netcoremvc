using System;
using System.Collections.Generic;

namespace Lesson06.TheoryDF.Models;

public partial class Book
{
    public string BookId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Author { get; set; }

    public int? Release { get; set; }

    public double? Price { get; set; }

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public int? PublisherId { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual Publisher? Publisher { get; set; }
}
