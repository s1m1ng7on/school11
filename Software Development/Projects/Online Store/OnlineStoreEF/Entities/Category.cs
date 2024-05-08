using System;
using System.Collections.Generic;

namespace OnlineStoreEFCoreProject.Entities;

public partial class Category : IIdentifiable
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
