using System;
using System.Collections.Generic;

namespace OnlineStoreEFCoreProject.Models.Entities;

public partial class Seller
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Website { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public override string ToString()
    {
        return $"{Id}. {Name} ({Email}) - {Website}";
    }
}
