namespace API.Entities
{
    public partial class Mention
    {
        public long Id { get; set; }
        public long? SourceRowId { get; set; }
        public string RawSource { get; set; }
        public string SourceUserId { get; set; }
        public string MentionEnglish { get; set; }
        public string RawMention { get; set; }
        public string MentionDefaultLang { get; set; }
        public float Sentiment { get; set; }
        public string KeyTerms { get; set; }
        public string Recommendation { get; set; }
        public float Quantity { get; set; }
        public float Growth { get; set; }
        public int? TopicLevel1Id { get; set; }
        public int? TopicLevel2Id { get; set; }
        public int? TopicLevel3Id { get; set; }
        public int? DataSourceId { get; set; }
        public int? ProductId { get; set; }
        public int? LanguageId { get; set; }
        public int? RegionId { get; set; }
        public int? MarketId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int DateKey { get; set; }

        
        public virtual DataSource DataSource { get; set; }
      
        public virtual TimePeriod DateKeyNavigation { get; set; }
      
        public virtual AbpLanguage Language { get; set; }
      
        public virtual Market Market { get; set; }
      
        public virtual Product Product { get; set; }
      
        public virtual Region Region { get; set; }
      
        public virtual TopicLevel1 TopicLevel1 { get; set; }
      
        public virtual TopicLevel2 TopicLevel2 { get; set; }
      
        public virtual TopicLevel3 TopicLevel3 { get; set; }
       
    }
}
