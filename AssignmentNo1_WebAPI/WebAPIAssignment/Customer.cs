﻿using System;
using System.Collections.Generic;

namespace AssignmentNo1_WebAPI.WebAPIAssignment;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    //public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
