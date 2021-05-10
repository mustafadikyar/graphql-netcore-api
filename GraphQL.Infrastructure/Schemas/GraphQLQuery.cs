using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.Types;

namespace GraphQL.Infrastructure.Schemas
{
    public class GraphQLQuery : ObjectGraphType
    {
        public GraphQLQuery()
        {
            IQueryResolver[] queries = IoCManager.ResolveAll<IQueryResolver>();
            foreach (IQueryResolver query in queries)
            {
                ObjectGraphType<object> objectGraphType = query as ObjectGraphType<object>;
                foreach (var field in objectGraphType.Fields)
                {
                    AddField(field);
                }
            }
        }
    }
}
