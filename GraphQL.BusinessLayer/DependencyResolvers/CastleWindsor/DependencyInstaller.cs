using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GraphQL.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor
{
    public class DependecyInstaller : IWindsorInstaller
    {
        public const string _mask = "GraphQL.*";
        public static string _assemblyDirectoryName { get; } = string.Empty;

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            AssemblyFilter assemblyFilter = new(_assemblyDirectoryName, mask: _mask);

            container.Register(Classes.FromAssemblyInDirectory(assemblyFilter)
                .BasedOn<IScopedDependency>()
                .WithServiceSelect(ServiceSelector).LifestyleScoped());

            container.Register(Classes.FromAssemblyInDirectory(assemblyFilter)
                .BasedOn<ISingletonDependency>()
                .WithServiceSelect(ServiceSelector).LifestyleSingleton());
        }

        private static IEnumerable<Type> ServiceSelector(Type type, Type[] baseTypes)
        {
            var result = type.GetInterfaces().ToList();

            result.Add(type);
            return result;
        }
    }
}
