using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsMantaSearch
    {
        public ProductsMantaSearch()
        {
            ProductsMantaReviews = new HashSet<ProductsMantaReview>();
        }

        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string MovieId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public double? AverageRating { get; set; }
        public string NumOfRevies { get; set; }
        public string MovieDuration { get; set; }
        public string Summary { get; set; }
        public string MovieInfo { get; set; }
        public string NumberOfReviews { get; set; }
        public string NumberOfCritics { get; set; }
        public string Popularity { get; set; }
        public string Cast { get; set; }
        public string Storyline { get; set; }
        public string PlotKeywords { get; set; }
        public string Genres { get; set; }
        public string ReviewLink { get; set; }
        public string Reviews { get; set; }
        public string Search { get; set; }
        public int? ProductId { get; set; }
        public DateTime? CreatedOn1 { get; set; }
        public string DataSourceId { get; set; }
        public int? Growth { get; set; }
        public string KeyTerms { get; set; }
        public string LanguageId { get; set; }
        public string MarketId { get; set; }
        public string MentionDefaultLang { get; set; }
        public string MentionEnglish { get; set; }
        public string OrganizationId { get; set; }
        public string OrganizationId1 { get; set; }
        public int? ProductId1 { get; set; }
        public int? Quantity { get; set; }
        public string RawMention { get; set; }
        public string RawSource { get; set; }
        public string Recommendation { get; set; }
        public string RegionId { get; set; }
        public int? Sentiment { get; set; }
        public string SourceUserId { get; set; }
        public int? TopicLevel1Id { get; set; }
        public int? TopicLevel2Id { get; set; }
        public int? TopicLevel3Id { get; set; }
        public DateTime? UpdatedOn1 { get; set; }

        public virtual ICollection<ProductsMantaReview> ProductsMantaReviews { get; set; }
    }
}
