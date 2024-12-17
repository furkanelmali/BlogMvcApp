using BlogMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlogMvcApp.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly BlogContext _context;
        // Bu örnekte sabit kategori listesi kullanıyoruz
        // Gerçek projede veritabanından veya başka bir kaynaktan veri çekebilirsiniz

        public CategoryListViewComponent(BlogContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Veritabanından kategorileri alıyoruz
            var categories = await _context.Categories.ToListAsync();

            // Kategorileri view'a gönderiyoruz
            return View(categories);
        }
    }
}