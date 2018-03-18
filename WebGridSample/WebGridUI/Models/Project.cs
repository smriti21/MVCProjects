using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGridUI.Models
{
    public class Project
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Client { get;set;}
    }
}