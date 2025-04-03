using Microsoft.EntityFrameworkCore;
using OnlineCV.Models;

namespace OnlineCV.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CVModel> CVs { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<TechnicalSkill> TechnicalSkills { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CVModel>()
                .HasMany(cv => cv.WorkExperiences)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CVModel>()
                .HasMany(cv => cv.Educations)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CVModel>()
                .HasMany(cv => cv.Projects)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            // 🔥 Fix for TechnicalSkills - Save as CSV
            modelBuilder.Entity<CVModel>()
                .Property(cv => cv.TechnicalSkills)
                .HasConversion(
                    v => string.Join(",", v.Select(s => s.SkillName)),  // Store as CSV
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                          .Select(skill => new TechnicalSkill { SkillName = skill })
                          .ToList()
                );
        }
    }
}
