using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineCV.Models;  // Ensure this is correct for your models  // Explicitly using the CVModel namespace for these models
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineCV.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Check if data already exists
                if (context.CVs.Any())
                {
                    return; // DB has been seeded
                }

                var cv = new CVModel
                {
                    FullName = "Simba Chasumba",
                    ProfessionalTitle = "Software Developer",
                    Email = "simbachasumba2@gmail.com",
                    Location = "Johannesburg, South Africa",
                    LinkedIn = "https://za.linkedin.com/in/simba-chasumba-b52762251",
                    Summary = "Passionate software developer with experience in building web applications.",
                    TechnicalSkills = new List<TechnicalSkill>
    {
        new TechnicalSkill { SkillName = "C#" },
        new TechnicalSkill { SkillName = "ASP.NET" },
        new TechnicalSkill { SkillName = "JavaScript" },
        new TechnicalSkill { SkillName = "SQL" }
    },
                    WorkExperiences = new List<WorkExperience>
    {
        new WorkExperience
        {
            CompanyName = "TechCorp",
            JobTitle = "Software Engineer",
            Responsibilities = "Developing web applications",
            StartDate = DateTime.Parse("2020-01-01"),
            EndDate = DateTime.Parse("2022-12-31")
        }
    },
                    Educations = new List<Education>
    {
        new Education
        {
            Degree = "Bachelor's in Computer Science",
            Institution = "Varsity College",
            CompletionYear = 2025
        }
    },
                    Projects = new List<Project>
    {
        new Project
        {
            Name = "Project 1",
            Description = "Description of Project 1.",
            GitHubLink = "https://github.com/simbachasumba/project1"
        }
    }
                };

                context.CVs.Add(cv);
                context.SaveChanges();

            }
        }
    }
}