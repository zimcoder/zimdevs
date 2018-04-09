using System.Collections.Generic;

namespace zimdevsapi.Models.DTOs
{
    public class BlogPostDTO
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public string PostBody { get; set; }

        public BlogDTO Blog { get; set; }

        ICollection<CommentDTO> Comments;
    }
}