using Microsoft.EntityFrameworkCore;
using OnlineCV.Models; // Ensure this matches the actual namespace of your models

namespace OnlineCV.Data
{
    public class CVContext : DbContext
    {
        public CVContext(DbContextOptions<CVContext> options) : base(options) { }

        public DbSet<CVModel> CVs { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
