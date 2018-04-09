namespace zimdevsapi.Models.DTOs
{
    public class CommentDTO
    {
        public int Id { get; set; }

          public string CommentBody { get; set; }

        public bool Approved { get; set; } = false;

        public BlogPostDTO BlogPost { get; set; }

        public UserDTO User { get; set; }
    }
}