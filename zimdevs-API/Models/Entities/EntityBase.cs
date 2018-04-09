using System;
using System.ComponentModel.DataAnnotations;

namespace zimdevsapi.Models.Entities
{
    public class EntityBase
    {
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        [StringLength(255)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime DateLastModified { get; set; } = DateTime.Now;

        [Required]
        [StringLength(255)]
        public string LastModifiedBy { get; set; }
    }
}
