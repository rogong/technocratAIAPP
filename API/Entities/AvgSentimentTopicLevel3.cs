using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AvgSentimentTopicLevel3
    {
        public int? TopicLevel3Id { get; set; }
        public string TopicLevelTerm { get; set; }
        public int? ProductId { get; set; }
        public double? AvgSentiment { get; set; }
        public int? TopicLevel2Id { get; set; }
    }
}
