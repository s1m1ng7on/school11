using System;
using System.Collections.Generic;

namespace OnlineStoreEFCoreProject.Models.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public int? SellerId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Seller? Seller { get; set; }
}
