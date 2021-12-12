using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class TopicLevel1
    {
        public TopicLevel1()
        {
            Mentions = new HashSet<Mention>();
            Searches = new HashSet<Search>();
            TopicLevel2s = new HashSet<TopicLevel2>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string TopicLevelTerm { get; set; }
        public string Description { get; set; }
        public string TopicLevelCode { get; set; }
        public int? TopicCategoryId { get; set; }

        public virtual TopicCategory TopicCategory { get; set; }
        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Search> Searches { get; set; }
        public virtual ICollection<TopicLevel2> TopicLevel2s { get; set; }
    }
}
