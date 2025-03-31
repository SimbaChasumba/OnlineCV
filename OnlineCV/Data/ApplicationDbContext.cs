using Microsoft.EntityFrameworkCore;
using OnlineCV.Models; // Ensure this matches the correct namespace

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<CVModel> CVs { get; set; }
    public DbSet<WorkExperience> WorkExperiences { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Project> Projects { get; set; }
}
