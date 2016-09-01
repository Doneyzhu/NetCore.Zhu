using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Zhu.Service
{
    public interface IBlogService
    {
        IList<Models.Blog> GetAllBlogs();
    }
}
