using System;
using System.Collections.Generic;
using zimdevsapi.Models.Entities;

namespace zimdevsapi.Models.DTOs
{
    public class JobDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Company Company { get; set; }

        public string JobDetails { get; set; }

        public ICollection<SkillDTO> RequiredSkills { get; set; }
        public DateTime DatePosted { get; set; }

        public JobType JobType { get; set; }

        public JobLevel JobLevel { get; set; }

        public bool IsExpired { get; set; }
    }
}
