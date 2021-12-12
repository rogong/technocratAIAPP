using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class SentimentDecreaseLevel1
    {
        public int? TopicLevel1Id { get; set; }
        public string TopicLevelTerm { get; set; }
        public float? SentimentDecrease { get; set; }
        public int? TopicCategoryId { get; set; }
    }
}
