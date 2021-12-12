using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsFoursquareReview
    {
        public int Id { get; set; }
        public int? TopicLevel1Id { get; set; }
        public int? TopicLevel2Id { get; set; }
        public int? TopicLevel3Id { get; set; }
        public int? Sentiment { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public double? DownVote { get; set; }
        public double? UpVote { get; set; }
        public string Date { get; set; }
        public string UserJustification { get; set; }
        public int FoursquareId { get; set; }

        public virtual ProductsFoursquareSearch Foursquare { get; set; }
    }
}
