using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerApiDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }

        public char Gender { get; set; }

        public decimal Experience { get; set; }
    }
}