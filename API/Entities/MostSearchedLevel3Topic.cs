using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class MostSearchedLevel3Topic
    {
        public string KeyTerms { get; set; }
        public int? Count { get; set; }
        public int? Topic3 { get; set; }
        public string TopicLevelTerm { get; set; }
        public int? TopicCategoryId { get; set; }
    }
}
