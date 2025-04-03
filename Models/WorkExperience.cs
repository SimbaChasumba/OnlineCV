using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineCV.Models
{
    public class WorkExperience
    {
        [Key]
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } // Nullable for ongoing jobs
        public string Responsibilities { get; set; }
    }
}
