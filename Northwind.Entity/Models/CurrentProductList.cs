using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

namespace Northwind.Entity.Models
{
    public partial class CurrentProductList : EntityBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
