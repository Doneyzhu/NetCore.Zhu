using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore.Zhu.Service;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCore.Zhu.Controllers
{
    public class BlogController : Controller
    {
        public IBlogService BlogService { get; set; }
        public BlogController(IBlogService blogService)
        {
            BlogService = blogService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }
    }
}
