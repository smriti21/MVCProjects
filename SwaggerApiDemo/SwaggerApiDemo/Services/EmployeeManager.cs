using SwaggerApiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerApiDemo.Services
{
    public class EmployeeManager
    {
        /// <summary>
        /// Get details of all employees
        /// </summary>
        /// <returns>List of employees</returns>
        public List<Employee> GetAllEmployees()
        {
            var employee1 = new Employee
            {
                Id = 1,
                Name = "A",
                Designation = "Admin",
                Experience = 15.2m,
                Gender = 'M'
            };
            var employee2 = new Employee
            {
                Id = 2,
                Name = "B",
                Designation = "Developer",
                Experience = 2m,
                Gender = 'M'
            };
            var employee3 = new Employee
            {
                Id = 3,
                Name = "C",
                Designation = "Tester",
                Experience = 1.5m,
                Gender = 'M'
            };
            return new List<Employee> { employee1, employee2, employee3 };
        }
    }
}