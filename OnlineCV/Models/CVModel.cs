namespace OnlineCV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CVModel
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string ProfessionalTitle { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string LinkedIn { get; set; }
        public string PersonalWebsite { get; set; }
        public string Summary { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<string> TechnicalSkills { get; set; }
        public List<Project> Projects { get; set; }
    }

    public class WorkExperience
    {
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string Responsibilities { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class Education
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public int CompletionYear { get; set; }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string GitHubLink { get; set; }
    }
}
