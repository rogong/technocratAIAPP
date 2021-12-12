using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class AverageSentimentByProduct
    {
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public double? AvgSentiment { get; set; }
    }
}
