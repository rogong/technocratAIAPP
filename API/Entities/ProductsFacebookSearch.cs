using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsFacebookSearch
    {
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
        public string PostId { get; set; }
        public string Text { get; set; }
        public string PostText { get; set; }
        public string SharedText { get; set; }
        public DateTime? Time { get; set; }
        public string Image { get; set; }
        public string ImagesLowquality { get; set; }
        public string Images { get; set; }
        public string Video { get; set; }
        public string VideoThumbnail { get; set; }
        public string VideoId { get; set; }
        public int? Likes { get; set; }
        public int? Comments { get; set; }
        public int? Shares { get; set; }
        public string PostUrl { get; set; }
        public string Link { get; set; }
        public long? UserId { get; set; }
        public string Username { get; set; }
        public string UserUrl { get; set; }
        public bool? IsLive { get; set; }
        public string Factcheck { get; set; }
        public string SharedPostId { get; set; }
        public string SharedTime { get; set; }
        public string SharedUserId { get; set; }
        public string SharedUsername { get; set; }
        public string SharedPostUrl { get; set; }
        public bool? Available { get; set; }
        public string CommentsFull { get; set; }
        public string Reactors { get; set; }
        public string Reactions { get; set; }
        public string W3FbUrl { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string Search { get; set; }
        public int? ProductId1 { get; set; }
        public string Account { get; set; }
    }
}
