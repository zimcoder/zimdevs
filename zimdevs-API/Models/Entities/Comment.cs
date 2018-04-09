using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("Comments")]
    public class Comment : EntityBase
    {
        public int Id { get; set; }

        [Required]
        public string CommentBody { get; set; }

        public bool Approved { get; set; } = false;

        public BlogPost BlogPost { get; set; }

        public User User { get; set; }

    }
}