using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class TotalSearchVolumeTopicLevel3
    {
        public int? TopicLevel3Id { get; set; }
        public double? Volume { get; set; }
        public string TopicLevelTerm { get; set; }
        public int DateKey { get; set; }
        public int? TopicCategoryId { get; set; }
    }
}
