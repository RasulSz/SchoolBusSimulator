using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusSimulator.Models
{
    public class Student : Entity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? ParentName { get; set; }
        public string? SchoolNumber { get; set; }
        public string? Adress { get; set; }
    }
}
