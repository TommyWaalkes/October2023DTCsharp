using System;
using System.Collections.Generic;

namespace EntityIntro.Models;

public partial class Movie
{
    public int Id { get; set; }

    //In C# the ? next to a data means it will allow for nulls. 
    //You want to leave your model properties unless you have changed your table's columns
    public string? Name { get; set; }

    public int? RunTime { get; set; }

    public int? ReleaseYear { get; set; }

    public string? Genre { get; set; }
}
