using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusSimulator.Models
{
    public class SchoolBus : Entity
    {
        public string? Brand { get; set; }
        public string? RelaysDate { get; set; }
        public string? SerialNumber { get; set; }
        public string? SeatCount { get; set; }
    }
}
