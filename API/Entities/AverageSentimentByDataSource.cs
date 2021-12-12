using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AverageSentimentByDataSource
    {
        public int? DataSourceId { get; set; }
        public string SourceName { get; set; }
        public double? AvgSentiment { get; set; }
    }
}
