using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class SentimentDecreaseLevel2
    {
        public int? TopicLevel2Id { get; set; }
        public string TopicLevelTerm { get; set; }
        public float? SentimentDecrease { get; set; }
        public int? TopicCategoryId { get; set; }
    }
}
