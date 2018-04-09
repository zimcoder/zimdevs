using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("Developers")]
    public class Developer : EntityBase
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        public string ProfilePhotoUrl { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}