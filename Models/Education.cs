using System.ComponentModel.DataAnnotations;

namespace OnlineCV.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        public string Degree { get; set; }
        public string Institution { get; set; }
        public int CompletionYear { get; set; }
    }
}
