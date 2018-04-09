using System.ComponentModel.DataAnnotations.Schema;

namespace zimdevsapi.Models.Entities
{

    [Table("DeveloperSkills")]
    public class DeveloperSkill : EntityBase
    {
        public int Id { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public Skill Skill { get; set; }
        public int NoOfMonthsUsed { get; set; }
        public bool IsCurrent { get; set; } = true;
    }
}
