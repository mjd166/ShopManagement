using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _0_Framework.Domain
{
    public interface IRepository<Tkey,T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        bool Exists(Expression<Func<T, bool>> expression);

        List<T> Get();
        T Get(Tkey id);

        void Save();
    }
}
