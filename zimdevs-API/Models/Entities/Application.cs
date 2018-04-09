using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("Applications")]
    public class Application : EntityBase
    {
        public int Id { get; set; }
        public Job Job { get; set; }

        public Developer Developer { get; set; }

        public DateTime ApplicationDate { get; set; }

        public ApplicationStatus Status { get; set; }

        public string CoverLetter { get; set; }


    }
}
