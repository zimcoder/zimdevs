using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("BlogPosts")]
    public class BlogPost : EntityBase
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public string PostBody { get; set; }

        public Blog Blog { get; set; }

        ICollection<Comment> Comments;
    }
}
