using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGridUI.Models;

namespace WebGridUI.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            var projects = GetAllProjects();
            return View(projects);
        }

        // GET: Project
        public ActionResult Edit(int id)
        {
            var projects = GetAllProjects();
            return View(projects);
        }

        private List<Project> GetAllProjects()
        {
            var projects = new List<Project>();
            projects.Add(new Project
            {
                Id = 1,
                Name = "Project1",
                Owner = "Owner1",
                Client = "Client1"
            });
            projects.Add(new Project
            {
                Id = 2,
                Name = "Project2",
                Owner = "Owner2",
                Client = "Client2"
            });
            projects.Add(new Project
            {
                Id = 3,
                Name = "Project3",
                Owner = "Owner3",
                Client = "Client3"
            });
            projects.Add(new Project
            {
                Id = 4,
                Name = "Project4",
                Owner = "Owner4",
                Client = "Client4"
            });
            projects.Add(new Project
            {
                Id = 5,
                Name = "Project5",
                Owner = "Owner5",
                Client = "Client5"
            });
            projects.Add(new Project
            {
                Id = 6,
                Name = "Project6",
                Owner = "Owner6",
                Client = "Client6"
            });
            projects.Add(new Project
            {
                Id = 7,
                Name = "Project7",
                Owner = "Owner7",
                Client = "Client7"
            });
            projects.Add(new Project
            {
                Id = 8,
                Name = "Project8",
                Owner = "Owner8",
                Client = "Client8"
            });
            projects.Add(new Project
            {
                Id = 9,
                Name = "Project9",
                Owner = "Owner9",
                Client = "Client9"
            });
            projects.Add(new Project
            {
                Id = 10,
                Name = "Project10",
                Owner = "Owner10",
                Client = "Client10"
            });
            projects.Add(new Project
            {
                Id = 11,
                Name = "Project11",
                Owner = "Owner11",
                Client = "Client11"
            });
            projects.Add(new Project
            {
                Id = 12,
                Name = "Project12",
                Owner = "Owner12",
                Client = "Client13"
            });
            return projects;

        }
    }
}