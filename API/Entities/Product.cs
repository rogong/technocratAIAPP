using System;
using System.Collections.Generic;

namespace API.Entities
{
    public partial class Product
    {
        public Product()
        {
            Mentions = new HashSet<Mention>();
            Searches = new HashSet<Search>();
        }

        public int Id { get; set; }
        public int? TenantId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool OwnedCompetition { get; set; }
        public int Amazon { get; set; }
        public int Angies { get; set; }
        public int Bbb { get; set; }
        public int Facebook { get; set; }
        public int FourSquare { get; set; }
        public int GoogleMyBusiness { get; set; }
        public int ImDb { get; set; }
        public int Manta { get; set; }
        public int TripAdvisor { get; set; }
        public int TrustPilot { get; set; }
        public int Twitter { get; set; }
        public int YelowPages { get; set; }
        public int Yelp { get; set; }
        public int? ProductTypeId { get; set; }
        public int? ProductClassificationId { get; set; }
        public int? CompetitionId { get; set; }
        public int? BrandId { get; set; }
        public int? TopicCategoryId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Competition Competition { get; set; }
        public virtual ProductClassification ProductClassification { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual TopicCategory TopicCategory { get; set; }
        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Search> Searches { get; set; }
    }
}
