using System.ComponentModel.DataAnnotations;

namespace OnlineCV.Models
{
    public class TechnicalSkill
    {
        [Key]
        public int Id { get; set; }
        public string SkillName { get; set; }
    }
}
