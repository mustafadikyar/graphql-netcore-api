using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.Types;

namespace GraphQL.Infrastructure.Schemas
{
    public class GraphQLMutation : ObjectGraphType
    {
        public GraphQLMutation()
        {
            IMutationResolver[] mutations = IoCManager.ResolveAll<IMutationResolver>();

            foreach (IMutationResolver mutation in mutations)
            {
                ObjectGraphType<object> objectGraphType = mutation as ObjectGraphType<object>;

                foreach (FieldType field in objectGraphType.Fields)
                {
                    AddField(field);
                }
            }
        }
    }
}
