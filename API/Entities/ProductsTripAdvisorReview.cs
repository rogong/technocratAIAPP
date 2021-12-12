﻿using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsTripAdvisorReview
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
        public int? Reaction { get; set; }
        public double? CommentRating { get; set; }
        public int TripAdvisorId { get; set; }

        public virtual ProductsTripAdvisorSearch TripAdvisor { get; set; }
    }
}
