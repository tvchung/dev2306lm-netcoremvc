using System;
using System.Collections.Generic;

namespace Lesson07.Assignment.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public double? SalePrice { get; set; }

    public byte? Status { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }
}
