using System.Linq.Expressions;
using API.Entities;

namespace API.Specifications
{
    public class MentionWithRelationshipandSpecification : BaseSpecification<Mention>
    {
        public MentionWithRelationshipandSpecification()
        {
            AddInclude(x => x.DataSource);
            AddInclude(x => x.Language);
            AddInclude(x => x.Market);
            AddInclude(x => x.Region);
            AddInclude(x => x.Product);
            AddInclude(x => x.Language);
        }

        public MentionWithRelationshipandSpecification(long id) : base(x => x.Id == id)
        {
            AddInclude(x => x.DataSource);
            AddInclude(x => x.Language);
            AddInclude(x => x.Market);
            AddInclude(x => x.Region);
            AddInclude(x => x.Product);
            AddInclude(x => x.Language);
        }
    }
}