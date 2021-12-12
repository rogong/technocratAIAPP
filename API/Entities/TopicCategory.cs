using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class TopicCategory
    {
        public TopicCategory()
        {
            Products = new HashSet<Product>();
            TopicLevel1s = new HashSet<TopicLevel1>();
            TopicLevel2s = new HashSet<TopicLevel2>();
            TopicLevel3s = new HashSet<TopicLevel3>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<TopicLevel1> TopicLevel1s { get; set; }
        public virtual ICollection<TopicLevel2> TopicLevel2s { get; set; }
        public virtual ICollection<TopicLevel3> TopicLevel3s { get; set; }
    }
}
