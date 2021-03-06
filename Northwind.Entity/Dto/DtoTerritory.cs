using System;
using System.Collections.Generic;
using Northwind.Entity.Base;

namespace Northwind.Entity.Models
{
    public partial class DtoTerritory : DtoBase
    {
        public DtoTerritory()
        {
            Employees = new HashSet<Employee>();
        }

        public string TerritoryId { get; set; } = null!;
        public string TerritoryDescription { get; set; } = null!;
        public int RegionId { get; set; }

        public virtual Region Region { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
