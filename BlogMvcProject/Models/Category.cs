using System.ComponentModel.DataAnnotations;

namespace BlogMvcApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
