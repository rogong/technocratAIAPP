using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class Search
    {
        public long SearchId { get; set; }
        public long? SourceRowId { get; set; }
        public string SearchTerm { get; set; }
        public string RawSearch { get; set; }
        public float Sentiment { get; set; }
        public string KeyTerms { get; set; }
        public float Volume { get; set; }
        public float Growth { get; set; }
        public int? TopicLevel1Id { get; set; }
        public int? TopicLevel2Id { get; set; }
        public int? TopicLevel3Id { get; set; }
        public int? DataSourceId { get; set; }
        public int? ProductId { get; set; }
        public int? LanguageId { get; set; }
        public int? RegionId { get; set; }
        public int? MarketId { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
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
