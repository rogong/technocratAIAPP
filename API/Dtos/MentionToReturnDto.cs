using API.Entities;

namespace API.Dtos
{
    public class MentionToReturnDto
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
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }          
        public string DataSource { get; set; }
        public string TimePeriod  { get; set; } 
        public string AbpLanguage  { get; set; }
      
        public string Market  { get; set; }
      
        public string Product  { get; set; }
        //New 
       

        public string Region  { get; set; }
      
        public string TopicLevel1  { get; set; }
      
        public string TopicLevel2  { get; set; }
      
        public string TopicLevel3  { get; set; }
    }
}