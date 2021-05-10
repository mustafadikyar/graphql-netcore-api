using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.DataLayer.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class, IDTO, new()
    {
        public static List<T> DummyList { get; set; }
        public Repository() => DummyList = new();

        public IList<T> GetAll() => DummyList;
        public T GetById(Guid id) => DummyList.FirstOrDefault(dummy => dummy.Id.Equals(id));
        public T Insert(T model)
        {
            DummyList.Add(model);
            return model;
        }
    }
}
