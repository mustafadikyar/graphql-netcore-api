using System;
using System.Collections.Generic;

namespace GraphQL.DataLayer.Repository
{
    public interface IRepository<T> : IScopedDependency where T : class, IDTO, new()
    {
        public T GetById(Guid id);
        public IList<T> GetAll();
        public T Insert(T model);
    }
}
