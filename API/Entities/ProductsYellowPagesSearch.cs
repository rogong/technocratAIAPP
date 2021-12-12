using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsYellowPagesSearch
    {
        public ProductsYellowPagesSearch()
        {
            ProductsYellowPagesReviews = new HashSet<ProductsYellowPagesReview>();
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
        public string PostId { get; set; }
        public string BusinessName { get; set; }
        public string Telephone { get; set; }
        public string BusinessPage { get; set; }
        public int? Rank { get; set; }
        public string Category { get; set; }
        public string Website { get; set; }
        public int? NumberOfReviews { get; set; }
        public int? NumberOfRatings { get; set; }
        public string Address { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string Zipcode { get; set; }
        public int? YearsInBusiness { get; set; }
        public string Description { get; set; }
        public string ListingUrl { get; set; }
        public string Reviews { get; set; }
        public string BusinessInfo { get; set; }
        public string Country { get; set; }
        public string Search { get; set; }
        public int? ProductId1 { get; set; }

        public virtual ICollection<ProductsYellowPagesReview> ProductsYellowPagesReviews { get; set; }
    }
}
