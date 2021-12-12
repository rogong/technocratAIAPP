using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class TopicLevel2
    {
        public TopicLevel2()
        {
            Mentions = new HashSet<Mention>();
            Searches = new HashSet<Search>();
            TopicLevel3s = new HashSet<TopicLevel3>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string TopicLevelTerm { get; set; }
        public string Description { get; set; }
        public string TopicLevelCode { get; set; }
        public int? TopicLevel1Id { get; set; }
        public int? TopicCategoryId { get; set; }

        public virtual TopicCategory TopicCategory { get; set; }
        public virtual TopicLevel1 TopicLevel1 { get; set; }
        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Search> Searches { get; set; }
        public virtual ICollection<TopicLevel3> TopicLevel3s { get; set; }
    }
}
