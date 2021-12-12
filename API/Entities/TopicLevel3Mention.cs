using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class TopicLevel3Mention
    {
        public int TopicLevel3Id { get; set; }
        public long MentionId { get; set; }
        public string TopicLevelTerm { get; set; }
        public string RawSource { get; set; }
        public float Sentiment { get; set; }
        public float Quantity { get; set; }
        public float Growth { get; set; }
        public int? ProductId { get; set; }
        public int? TopicLevel2Id { get; set; }
    }
}
