using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsImdbReview
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
        public string Date { get; set; }
        public int? Rating { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public int? Reactions { get; set; }
        public int? Helpful { get; set; }
        public int ImdbId { get; set; }

        public virtual ProductsImdbSearch Imdb { get; set; }
    }
}
