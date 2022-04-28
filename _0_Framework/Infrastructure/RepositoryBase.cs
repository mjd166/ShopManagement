using _0_Framework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _0_Framework.Infrastructure
{
    public class RepositoryBase<Tkey, T> : IRepository<Tkey, T> where T : class
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add<T>(entity);
            Save();
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(Tkey id)
        {
           return _context.Find<T>(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            Save();
        }
    }
}
