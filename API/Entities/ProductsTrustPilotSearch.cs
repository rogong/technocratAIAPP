using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsTrustPilotSearch
    {
        public ProductsTrustPilotSearch()
        {
            ProductsTrustPilotReviews = new HashSet<ProductsTrustPilotReview>();
        }

        public int Id { get; set; }
        public string DataSourceId { get; set; }
        public string RawSource { get; set; }
        public int? ProductId { get; set; }
        public int? TopicLevel1Id { get; set; }
        public int? TopicLevel2Id { get; set; }
        public int? TopicLevel3Id { get; set; }
        public string SourceUserId { get; set; }
        public string MentionEnglish { get; set; }
        public string RawMention { get; set; }
        public string MentionDefaultLang { get; set; }
        public int? Sentiment { get; set; }
        public string LanguageId { get; set; }
        public string RegionId { get; set; }
        public string MarketId { get; set; }
        public string OrganizationId { get; set; }
        public string OrganizationId1 { get; set; }
        public string KeyTerms { get; set; }
        public string Recommendation { get; set; }
        public int? Quantity { get; set; }
        public int? Growth { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? CreatedOn1 { get; set; }
        public DateTime? UpdatedOn1 { get; set; }
        public bool? IsActive { get; set; }
        public string BusId { get; set; }
        public string Name { get; set; }
        public int? NumberOfRatings { get; set; }
        public int? NumberOfReviews { get; set; }
        public double? AverageRating { get; set; }
        public string Url { get; set; }
        public string ReviewSummary { get; set; }
        public string Reviews { get; set; }
        public string Image { get; set; }
        public int? WorstRating { get; set; }
        public int? BestRating { get; set; }
        public string AddressCountry { get; set; }
        public string Search { get; set; }
        public int? ProductId1 { get; set; }

        public virtual ICollection<ProductsTrustPilotReview> ProductsTrustPilotReviews { get; set; }
    }
}
