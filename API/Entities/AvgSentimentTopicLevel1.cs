using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AvgSentimentTopicLevel1
    {
        public int? TopicLevel1Id { get; set; }
        public string TopicLevelTerm { get; set; }
        public int? ProductId { get; set; }
        public double? AvgSentiment { get; set; }
    }
}
