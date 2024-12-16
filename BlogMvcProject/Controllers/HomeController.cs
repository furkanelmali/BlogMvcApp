using BlogMvcApp.Models;
using BlogMvcProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogMvcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; 
        private readonly BlogContext _context;


        public HomeController(ILogger<HomeController> logger, BlogContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var blogs = _context.Blogs
                .Select(i => new BlogModel()
                {
                    CategoryId = i.CategoryId,
                    BlogId = i.BlogId,
                    Title = i.Title.Length > 100 ? i.Title.Substring(0 - 100) + "..." : i.Title,
                    Description = i.Description,
                    AddingDate = i.AddingDate,
                    Homepage = i.Homepage,
                    Verified =i.Verified,
                    Img = i.Img,
                })
                .Where(i=>i.Verified == true && i.Homepage == true);
            return View(blogs.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
