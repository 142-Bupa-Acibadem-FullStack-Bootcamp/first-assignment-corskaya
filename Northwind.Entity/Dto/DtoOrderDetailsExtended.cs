﻿using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

namespace Northwind.Entity.Models
{
    public partial class DtoOrderDetailsExtended : DtoBase
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public decimal? ExtendedPrice { get; set; }
    }
}
