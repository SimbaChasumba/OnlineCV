using Microsoft.EntityFrameworkCore;
using OnlineCV.Models;  


namespace OnlineCV.Data
{
    public class CVContext : DbContext
    {
        public CVContext(DbContextOptions<CVContext> options) : base(options) { }

        public DbSet<CVModel> CVs { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TechnicalSkill> TechnicalSkills { get; set; } 
    }
}
