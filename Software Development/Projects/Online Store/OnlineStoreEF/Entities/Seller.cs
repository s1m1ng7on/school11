using System;
using System.Collections.Generic;

namespace OnlineStoreEFCoreProject.Entities;

public partial class Seller : IIdentifiable
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Website { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
