using API.Entities;
using API.Specifications;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class SpecificationEvaluator<TEntiry> where TEntiry : BaseEntity
    {
        public static IQueryable<TEntiry> GetQuery(IQueryable<TEntiry> inputQuery,
        ISpecification<TEntiry> spec)
        {
            var query = inputQuery;

            if(spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}