using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.WebApi.Extensions
{
    public static class ContainerStartupExtension
    {
        public static void InstallContainer(this IServiceCollection services)
        {
            IoCManager.Install();
        }
    }
}
