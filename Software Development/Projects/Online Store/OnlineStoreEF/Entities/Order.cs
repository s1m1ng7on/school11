﻿using System;
using System.Collections.Generic;

namespace OnlineStoreEFCoreProject.Entities;

public partial class Order : IIdentifiable
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? Date { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
