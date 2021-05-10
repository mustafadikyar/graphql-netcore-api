using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.Infrastructure.Schemas;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.WebApi.Extensions
{
    public static class GraphStartupExtension
    {
        public static void AddGraphTypes(this IServiceCollection services)
        {
            ISingletonGraphType[] list = IoCManager.ResolveAll<ISingletonGraphType>();
            foreach (ISingletonGraphType item in list)
            {
                services.AddSingleton(item.GetType());
            }
        }
        public static void AddGraphSchema(this IServiceCollection services)
        {
            services.AddSingleton<ISchema, GraphQLSchema>();
            services.AddSingleton<GraphQLMutation>();
            services.AddSingleton<GraphQLQuery>();
        }
    }
}