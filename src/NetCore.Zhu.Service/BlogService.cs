
using System.Linq;
using System.Collections.Generic;
using NetCore.Zhu.Dao.DbContexts;
using NetCore.Zhu.Dao.DataModels;
using NetCore.Zhu.Models;
using AutoMapper;

namespace NetCore.Zhu.Service
{
    public class BlogService
    {
        private TestDbContext _context;
        public BlogService(TestDbContext context)
        {
            _context = context;
            
        }

        public IList<Models.Blog> GetAllBlogs()
        {
            List<Models.Blog> blogViewModels = new List<Models.Blog>();
            if (_context.Blogs.Any())
            {
                foreach (var blogDto in _context.Blogs)
                {
                    Models.Blog blogView = new Models.Blog();
                    Mapper.Map(blogDto, blogView);
                    blogViewModels.Add(blogView);
                }
            }
            return blogViewModels;
        }

    }
}
