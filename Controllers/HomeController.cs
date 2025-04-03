using Microsoft.AspNetCore.Mvc;
using OnlineCV.Models;
using System;
using System.Collections.Generic;

namespace OnlineCV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new CVModel
            {
                FullName = "Simba Chasumba",
                ProfessionalTitle = "Software Developer",
                Email = "simba@example.com",
                Phone = "+1234567890",
                Location = "South Africa",
                LinkedIn = "https://linkedin.com/in/simbachasumba",
                Summary = "Passionate software developer with experience in web and mobile applications.",
                WorkExperiences = new List<WorkExperience>
                {
                    new WorkExperience
                    {
                        JobTitle = "Software Engineer",
                        CompanyName = "Tech Solutions",
                        StartDate = new DateTime(2019, 1, 1),
                        EndDate = new DateTime(2023, 6, 1),
                        Responsibilities = "Developed scalable web applications using ASP.NET Core."
                    }
                },
                Educations = new List<Education>
                {
                    new Education
                    {
                        Degree = "BSc in Computer Science",
                        Institution = "Varsity College",
                        CompletionYear = 2018
                    }
                },
                TechnicalSkills = new List<TechnicalSkill>
                {
                    new TechnicalSkill { SkillName = "C#" },
                    new TechnicalSkill { SkillName = "ASP.NET Core" },
                    new TechnicalSkill { SkillName = "React.js" }
                },
                Projects = new List<Project>
                {
                    new Project
                    {
                        Name = "Local Business Finder",
                        Description = "An application that helps users find local businesses using Mapbox.",
                        GitHubLink = "https://github.com/simbachasumba/localbusinessfinder"
                    }
                }
            };

            return View(model);
        }
    }
}
