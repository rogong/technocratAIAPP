using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class GrowthLevel3
    {
        public int? TopicLevel3Id { get; set; }
        public float? Growth { get; set; }
        public string TopicLevelTerm { get; set; }
        public int? TopicCategoryId { get; set; }
    }
}
