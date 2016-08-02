using Microsoft.EntityFrameworkCore;
using NetCore.Zhu.Dao.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Zhu.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TestDbContext _context = null;
        private readonly DbSet<T> _dbSet;
        public Repository(TestDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAllList(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return _dbSet.AsEnumerable();
            }
            return _dbSet.Where(predicate).ToList();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public long Count()
        {
            return _dbSet.LongCount();
        }
    }
}
