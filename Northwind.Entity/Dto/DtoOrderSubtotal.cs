﻿using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

namespace Northwind.Entity.Models
{
    public partial class DtoOrderSubtotal : DtoBase
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
