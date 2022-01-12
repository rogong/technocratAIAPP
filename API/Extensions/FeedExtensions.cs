using API.Entities;

namespace API.Extensions
{
    public static class FeedExtensions
    {
        public static IQueryable<Mention> Sort(this IQueryable<Mention> query, string orderBy)
        {
            if(string.IsNullOrWhiteSpace(orderBy)) return query.OrderBy(m => m.Language);

            query = orderBy switch
            {
                "region" => query.OrderBy(m => m.DateKey),
                "regionDesc" => query.OrderByDescending(m => m.DateKey),
                _ => query.OrderBy(m => m.DateKey)
            };

            return query;
        }

        public static IQueryable<Mention> Search(this IQueryable<Mention> query, string searchTerm)
        {
            if(string.IsNullOrEmpty(searchTerm)) return query;

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            return query.Where(m => m.MentionEnglish.ToLower().Contains(lowerCaseSearchTerm));
        }

         public static IQueryable<Mention> Filter(this IQueryable<Mention> query, string datasource, 
         string region, string market, string product, string language, string brand, string competition)
        {
            var dataSourceList = new List<string>();
            var regionList = new List<string>();
            var marketList = new List<string>();
            var productList = new List<string>();
            var languageList = new List<string>();
            var brandList = new List<string>();
            var competitionList = new List<string>();

            if (!string.IsNullOrEmpty(datasource))
                dataSourceList.AddRange(datasource.ToLower().Split(",").ToList());

            if (!string.IsNullOrEmpty(region))
                regionList.AddRange(region.ToLower().Split(",").ToList());
            
            if (!string.IsNullOrEmpty(market))
                marketList.AddRange(market.ToLower().Split(",").ToList());
            
            if (!string.IsNullOrEmpty(product))
                productList.AddRange(product.ToLower().Split(",").ToList());

            if (!string.IsNullOrEmpty(language))
                languageList.AddRange(language.ToLower().Split(",").ToList());

            if (!string.IsNullOrEmpty(brand))
                brandList.AddRange(brand.ToLower().Split(",").ToList());

            if (!string.IsNullOrEmpty(competition))
                competitionList.AddRange(competition.ToLower().Split(",").ToList());

            query = query.Where(m => dataSourceList.Count == 0 || dataSourceList.Contains(m.DataSource.SourceName.ToLower()));
            query = query.Where(m => marketList.Count == 0 || marketList.Contains(m.Market.Name.ToLower()));
            query = query.Where(m => regionList.Count == 0 || regionList.Contains(m.Region.Name.ToLower()));
            query = query.Where(m => productList.Count == 0 || productList.Contains(m.Product.ProductName.ToLower()));
            query = query.Where(m => languageList.Count == 0 || languageList.Contains(m.Language.DisplayName.ToLower()));
            query = query.Where(m => brandList.Count == 0 || brandList.Contains(m.Product.Brand.Name.ToLower()));
            query = query.Where(m => competitionList.Count == 0 || competitionList.Contains(m.Product.Competition.Name.ToLower()));

            return query;

        }
    }
}