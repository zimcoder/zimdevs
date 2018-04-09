using System.ComponentModel.DataAnnotations;

namespace zimdevsapi.Models.Entities
{
    public class User : EntityBase
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
    }
}