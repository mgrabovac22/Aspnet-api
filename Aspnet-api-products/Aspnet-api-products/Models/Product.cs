using System;
using System.Collections.Generic;

namespace Aspnet_api_products.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public double? Price { get; set; }

    public string? Image { get; set; }
}
