using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsAmazonSearch
    {
        public ProductsAmazonSearch()
        {
            ProductsAmazonReviews = new HashSet<ProductsAmazonReview>();
        }

        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsActive { get; set; }
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
        public DateTime? CreatedOn1 { get; set; }
        public DateTime? UpdatedOn1 { get; set; }
        public string ItemId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Images { get; set; }
        public double? Price { get; set; }
        public double? AverageRating { get; set; }
        public int? NumberOfReviews { get; set; }
        public string ProductVariants { get; set; }
        public string ProductDescription { get; set; }
        public string LinkToAllReviews { get; set; }
        public string ProductInformation { get; set; }
        public string ReviewsByRating { get; set; }
        public string ReviewsByComments { get; set; }
        public string Search { get; set; }
        public int? ProductId1 { get; set; }
        public int? NumberOfRating { get; set; }

        public virtual ICollection<ProductsAmazonReview> ProductsAmazonReviews { get; set; }
    }
}
