using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

namespace Northwind.Entity.Models
{
    public partial class DtoCategorySalesFor1997 : DtoBase
    {
        public string CategoryName { get; set; } = null!;
        public decimal? CategorySales { get; set; }
    }
}
