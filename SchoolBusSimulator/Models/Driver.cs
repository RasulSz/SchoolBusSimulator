using SchoolBusSimulator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusSimulator.Models
{
    public class Driver : NotifyPropertyChangedHandler
    {
        private string? name;
        private string? surname;
        private string? age;
        private string? address;
        public int Id { get; set; }
        public string? Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged("Name"); }
        }
        public string? Surname 
        {
            get { return surname; }
            set { surname = value; NotifyPropertyChanged("Surname"); }
        }
        public string? Age
        {
            get { return age; }
            set { age = value; NotifyPropertyChanged("Age"); }
        }
        public string? Adress
        {
            get { return address; }
            set { address = value; NotifyPropertyChanged("Adress"); }
        }
        public SchoolBus? Bus { get; set; }

        public List<Driver> Drivers { get; set; }
    }
}
