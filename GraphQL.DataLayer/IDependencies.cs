using System;

namespace GraphQL.DataLayer
{
    public interface IDTO
    {
        public Guid Id { get; set; }
    }
    public interface IScopedDependency { }
    public interface ISingletonDependency { }

    public interface ISingletonGraphType : ISingletonDependency { }

    public interface IQueryResolver : ISingletonDependency { }
    public interface IMutationResolver : ISingletonDependency { }
}
