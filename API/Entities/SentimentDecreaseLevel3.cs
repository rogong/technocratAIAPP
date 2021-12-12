using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class SentimentDecreaseLevel3
    {
        public int? TopicLevel3Id { get; set; }
        public string TopicLevelTerm { get; set; }
        public int? SentimentDecrease { get; set; }
        public int? TopicCategoryId { get; set; }
    }
}
