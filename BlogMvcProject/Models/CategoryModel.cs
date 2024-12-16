using System.ComponentModel.DataAnnotations;

namespace BlogMvcApp.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; }
        public int BlogCount { get; set; }
    }
}
