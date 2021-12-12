using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class TopicLevel1Mention
    {
        public int TopicLevel1Id { get; set; }
        public long MentionId { get; set; }
        public string TopicLevelTerm { get; set; }
        public string RawSource { get; set; }
        public float Sentiment { get; set; }
        public float Quantity { get; set; }
        public float Growth { get; set; }
        public int? ProductId { get; set; }
        public int DateKey { get; set; }
    }
}
