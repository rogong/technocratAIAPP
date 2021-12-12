using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class MostSearchedTopicLevel1
    {
        public string KeyTerms { get; set; }
        public int? Count { get; set; }
        public int? Topic1 { get; set; }
        public string TopicLevelTerm { get; set; }
        public int? TopicCategoryId { get; set; }
    }
}
