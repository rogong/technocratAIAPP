using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsTripAdvisorSearch
    {
        public ProductsTripAdvisorSearch()
        {
            ProductsTripAdvisorReviews = new HashSet<ProductsTripAdvisorReview>();
        }

        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string BizId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Neighborhoods { get; set; }
        public string BusinessUrl { get; set; }
        public string Tags { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string PriceRange { get; set; }
        public string StreetAddress { get; set; }
        public string AddressLocality { get; set; }
        public string AddressCountry { get; set; }
        public string AddressRegion { get; set; }
        public string PostalCode { get; set; }
        public string Review { get; set; }
        public double? AggregateRatingValue { get; set; }
        public int? AggregateReviewCount { get; set; }
        public string Categories { get; set; }
        public string Faq { get; set; }
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

        public virtual ICollection<ProductsTripAdvisorReview> ProductsTripAdvisorReviews { get; set; }
    }
}
