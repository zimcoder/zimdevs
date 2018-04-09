using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{
    [Table("ShortLists")]
    public class ShortList
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Job Job { get; set; }
        public ICollection<Application> Applications { get; set; }
        public string Notes { get; set; }

    }
}
