using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class Competition
    {
        public Competition()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
