using System;
using System.Collections.Generic;

namespace AdoptionMVC.Models;

public partial class Pet
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string Breed { get; set; } = null!;

    public string? Img { get; set; }

    public int? Age { get; set; }
}
