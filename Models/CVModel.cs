using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineCV.Models
{
    public class CVModel
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProfessionalTitle { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string LinkedIn { get; set; }
        public string Summary { get; set; }

        public List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<TechnicalSkill> TechnicalSkills { get; set; } = new List<TechnicalSkill>();
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
