using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsTrustPilotReview
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
        public string Location { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public double? CommentRating { get; set; }
        public int TrustPilotId { get; set; }

        public virtual ProductsTrustPilotSearch TrustPilot { get; set; }
    }
}
