using API.Entities;
using API.Specifications;

namespace API.Interface
{
    public interface IGenericRepository<T> 
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}