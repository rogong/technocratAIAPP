using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsFoursquareSearch
    {
        public ProductsFoursquareSearch()
        {
            ProductsFoursquareReviews = new HashSet<ProductsFoursquareReview>();
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
        public string Url { get; set; }
        public double? AverageRating { get; set; }
        public string Author { get; set; }
        public string Descrption { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public string CreationDate { get; set; }
        public int? NumOfReviews { get; set; }
        public string Justification { get; set; }
        public string Tippets { get; set; }
        public string Features { get; set; }
        public string Varieties { get; set; }
        public string Reviews { get; set; }
        public string Search { get; set; }
        public int? ProductId1 { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }

        public virtual ICollection<ProductsFoursquareReview> ProductsFoursquareReviews { get; set; }
    }
}
