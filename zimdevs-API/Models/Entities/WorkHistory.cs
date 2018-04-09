using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("WorkHistory")]
    public class WorkHistory : EntityBase
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(255)]
        public string JobTitle { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; } = false;

        [Required]
        public string Duties { get; set; }

        [Required]
        public string ReasonForLeaving { get; set; }

        [Required]
        public Contact Contact { get; set; }
    }
}
