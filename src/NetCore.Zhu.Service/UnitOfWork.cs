using NetCore.Zhu.Dao.DataModels;
using NetCore.Zhu.Dao.DbContexts;
using NetCore.Zhu.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Zhu.Service
{
    public class UnitOfWork : IDisposable
    {
        private readonly TestDbContext _context = null;
        private Repository<Blog> _blogRepository = null;

        public UnitOfWork(Repository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
            _context = new TestDbContext();
        }

        public Repository<Blog> BlogRepository
        {
            get { return _blogRepository ?? (_blogRepository = new Repository<Blog>(_context)); }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
