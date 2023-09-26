using System;
using System.Collections.Generic;

namespace Lesson07.Assignment.Models;

public partial class Banner
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte? Status { get; set; }

    public int? Prioty { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }
}
