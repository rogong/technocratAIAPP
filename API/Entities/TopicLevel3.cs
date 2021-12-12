﻿using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class TopicLevel3
    {
        public TopicLevel3()
        {
            Mentions = new HashSet<Mention>();
            Searches = new HashSet<Search>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string TopicLevelTerm { get; set; }
        public string Description { get; set; }
        public string TopicLevelCode { get; set; }
        public int? TopicCategoryId { get; set; }
        public int? TopicLevel2Id { get; set; }

        public virtual TopicCategory TopicCategory { get; set; }
        public virtual TopicLevel2 TopicLevel2 { get; set; }
        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Search> Searches { get; set; }
    }
}
