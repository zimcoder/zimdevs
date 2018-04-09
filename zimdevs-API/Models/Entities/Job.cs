using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("Jobs")]
    public class Job : EntityBase
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public Company Company { get; set; }

        [Required]
        public string JobDetails { get; set; }

        public ICollection<Skill> RequiredSkills { get; set; }
        public DateTime DatePosted { get; set; }

        public JobType JobType { get; set; }

        public JobLevel JobLevel { get; set; }

        public bool IsExpired { get; set; } = false;

    }
}
