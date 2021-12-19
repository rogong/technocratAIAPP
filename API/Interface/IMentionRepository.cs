using API.Entities;

namespace API.Interface
{
    public interface IMentionRepository
    {
        Task<Mention> GetMentionByIdAsync(long id);
        Task<IReadOnlyList<Mention>> GetMentionsAsync();
        Task<IReadOnlyList<Market>> GetMarketsAsync();
        Task<IReadOnlyList<Region>> GetRegionsAsync();
        Task<IReadOnlyList<AbpLanguage>> GetLanguagesAsync();
        Task<IReadOnlyList<DataSource>> GetDataSourcesAsync();
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}