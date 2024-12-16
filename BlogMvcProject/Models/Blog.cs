using System.ComponentModel.DataAnnotations;

namespace BlogMvcApp.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string Content { get; set; }
        public DateTime AddingDate { get; set; }
        public bool Verified { get; set; }
        public bool Homepage { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
