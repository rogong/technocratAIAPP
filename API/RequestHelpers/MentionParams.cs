namespace API.RequestHelpers
{
    public class MentionParams : PaginationParams
    {
        public string OrderBy {get;set;}
        public string SearchTerm { get; set; }
        public string DataSources { get; set; }
        public string Markets { get; set; }
        public string Regions { get; set; }
         public string Products { get; set; }
        public string Languages { get; set; }
    }
}