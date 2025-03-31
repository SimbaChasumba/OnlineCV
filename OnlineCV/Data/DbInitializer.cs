using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using OnlineCV.Models; // Replace with the actual namespace for your models
using OnlineCV.Data;   // Replace with the actual namespace for your ApplicationDbContext

public static class DbInitializer
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            // Ensure the database is created
            context.Database.EnsureCreated();

            // Prevent duplicate seeding
            if (context.CVs.Any()) return;

            // Seed the database with an example CV
            context.CVs.AddRange(
                new CVModel
                {
                    FullName = "John Doe",
                    ProfessionalTitle = "Software Developer",
                    Email = "john.doe@example.com",
                    Phone = "123-456-7890",
                    Location = "City, Country",
                    LinkedIn = "https://www.linkedin.com/in/johndoe/",
                    PersonalWebsite = "https://www.johndoe.com",
                    Summary = "Passionate software developer with experience in building web applications.",
                    WorkExperiences = new List<WorkExperience>
                    {
                        new WorkExperience
                        {
                            CompanyName = "Tech Company",
                            JobTitle = "Junior Developer",
                            Responsibilities = "Developed web applications.",
                            StartDate = new DateTime(2020, 1, 1),
                            EndDate = new DateTime(2022, 1, 1)
                        }
                    },
                    Educations = new List<Education>
                    {
                        new Education
                        {
                            Degree = "B.Sc. in Computer Science",
                            Institution = "University Name",
                            CompletionYear = 2020
                        }
                    },
                    TechnicalSkills = new List<string> { "C#", "ASP.NET", "JavaScript" },
                    Projects = new List<Project>
                    {
                        new Project
                        {
                            Name = "Project 1",
                            Description = "Description of Project 1.",
                            GitHubLink = "https://github.com/johndoe/project1"
                        }
                    }
                }
            );

            // Save changes to the database
            context.SaveChanges();
        }
    }
}
