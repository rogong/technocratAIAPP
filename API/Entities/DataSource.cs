using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class DataSource
    {
        public DataSource()
        {
            Mentions = new HashSet<Mention>();
            Searches = new HashSet<Search>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string SourceName { get; set; }
        public string SourceDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastProcessed { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Search> Searches { get; set; }
    }
}
