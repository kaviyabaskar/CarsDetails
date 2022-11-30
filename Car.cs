using System;
using System.Collections.Generic;

namespace CarsApi.Models;

public partial class Car
{
    public int Id { get; set; }

    public string Carname { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Modelnum { get; set; }

    public string? ImageUrl { get; set; }
}
