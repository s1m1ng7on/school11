using System;
using System.Collections.Generic;

namespace OnlineStoreEFCoreProject.Models.Entities;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public override string ToString()
    {
        return $"{Id}: {FirstName} {LastName} ({Email})";
    }
}
