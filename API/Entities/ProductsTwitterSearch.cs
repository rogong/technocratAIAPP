using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class ProductsTwitterSearch
    {
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
        public string TweetId { get; set; }
        public string ConversationId { get; set; }
        public double? CreatedAt { get; set; }
        public string Date { get; set; }
        public string Timezone { get; set; }
        public string Place { get; set; }
        public string Tweet { get; set; }
        public string Language { get; set; }
        public string Hashtags { get; set; }
        public string Cashtags { get; set; }
        public long? UserId { get; set; }
        public string UserIdStr { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public int? Day { get; set; }
        public string Hour { get; set; }
        public string Link { get; set; }
        public string Urls { get; set; }
        public string Photos { get; set; }
        public int? Video { get; set; }
        public string Thumbnail { get; set; }
        public bool? Retweet { get; set; }
        public int? Nlikes { get; set; }
        public int? Nreplies { get; set; }
        public int? Nretweets { get; set; }
        public string QuoteUrl { get; set; }
        public string Search { get; set; }
        public string Near { get; set; }
        public string Geo { get; set; }
        public string Source { get; set; }
        public string UserRtId { get; set; }
        public string UserRt { get; set; }
        public string RetweetId { get; set; }
        public string ReplyTo { get; set; }
        public string RetweetDate { get; set; }
        public string Translate { get; set; }
        public string TransSrc { get; set; }
        public string TransDest { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public int? ProductId1 { get; set; }
    }
}
