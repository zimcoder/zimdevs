using System.Collections.Generic;

namespace zimdevsapi.Models.DTOs
{
    public class BlogDTO
    {
        public int Id { get; set; }
               public string Name { get; set; }
        public string Description { get; set; }
       
        ICollection<BlogPostDTO> Posts;
    }
}
