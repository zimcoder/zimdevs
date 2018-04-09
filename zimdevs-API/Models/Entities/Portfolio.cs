using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("Portfolos")]
    public class Portfolio : EntityBase
    {
        public int Id { get; set; }
        public Developer Developer { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}
