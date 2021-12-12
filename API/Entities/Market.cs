using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class Market
    {
        public Market()
        {
            Mentions = new HashSet<Mention>();
            Searches = new HashSet<Search>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Search> Searches { get; set; }
    }
}
