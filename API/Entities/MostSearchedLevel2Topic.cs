using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class MostSearchedLevel2Topic
    {
        public string KeyTerms { get; set; }
        public int? Count { get; set; }
        public int? Topic2 { get; set; }
        public string TopicLevelTerm { get; set; }
        public int? TopicCategoryId { get; set; }
    }
}
