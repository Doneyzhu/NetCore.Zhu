using NetCore.Zhu.Dao.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace NetCore.Zhu.Repository
{
    public class BlogRepository : IRepository<Blog>
    {
        public long Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Blog Get(Expression<Func<Blog, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Blog> GetAllList(Expression<Func<Blog, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
