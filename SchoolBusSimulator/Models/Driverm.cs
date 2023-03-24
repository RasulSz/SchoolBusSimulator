using SchoolBusSimulator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusSimulator.Models
{
    public class Driverm : Entity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Age { get; set; }
        public string? Adress { get; set; }
        public SchoolBus? Bus { get; set; }

        public List<Driverm> Drivers { get; set; }
    }
}
