﻿using System;
using System.Collections.Generic;

namespace ASPCoreWebAPI.Model;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? City { get; set; }
}
