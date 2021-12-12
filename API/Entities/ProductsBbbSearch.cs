using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsBbbSearch
    {
        public ProductsBbbSearch()
        {
            ProductsBbbReviews = new HashSet<ProductsBbbReview>();
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
        public string Name { get; set; }
        public string BusId { get; set; }
        public string Url { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string BusinessStart { get; set; }
        public string BbbFileOpened { get; set; }
        public string Incorporated { get; set; }
        public string Accredited { get; set; }
        public string Categories { get; set; }
        public bool? IsAccredited { get; set; }
        public string Description { get; set; }
        public int? YearsInBusiness { get; set; }
        public string TypeOfEntity { get; set; }
        public int? NumOfReviews { get; set; }
        public string BbbRating { get; set; }
        public string ComplaintTypes { get; set; }
        public string Reviews { get; set; }
        public string Search { get; set; }
        public int? ProductId1 { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }

        public virtual ICollection<ProductsBbbReview> ProductsBbbReviews { get; set; }
    }
}
