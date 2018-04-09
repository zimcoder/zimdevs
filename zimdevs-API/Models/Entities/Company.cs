using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("Companies")]
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Contact Contact { get; set; }

        public ICollection<Job> Jobs { get; set; }
    }
}