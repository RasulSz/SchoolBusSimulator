using Newtonsoft.Json;
using SchoolBusSimulator.Models;
using SchoolBusSimulator.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Driver = SchoolBusSimulator.Views.Driver;
using Student = SchoolBusSimulator.Views.Student;

namespace SchoolBusSimulator.FileHelper
{
    public class FileHelper
    {
        public static void WriteSchoolBus(List<SchoolBus> car)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"cars.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, car);
                }
            }
        }
        public static List<SchoolBus>? ReadJsonSchoolBus(string fileName)
        {
            List<SchoolBus>? car = new ();
            var context = File.ReadAllText(fileName);
            car = JsonConvert.DeserializeObject<List<SchoolBus>>(context);
            return car;
        }

        public static void WriteStudent(Studentm student)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter($"student.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, student);
                }
            }
        }
        public static List<Studentm>? ReadJsonStudent(string fileName)
        {
            List<Studentm>? student = new();
            var context = File.ReadAllText(fileName);
            student = JsonConvert.DeserializeObject<List<Studentm>>(context);
            return student;
        }

        public static void WriteDriver(List<Driverm> driver)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("driver.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, driver);
                }
            }
        }
        public static List<Driverm>? ReadJsonDriver(string fileName)
        {
            List<Driverm>? driver = new();
            var context = File.ReadAllText(fileName);
            driver = JsonConvert.DeserializeObject<List<Driverm>>(context);
            return driver;
        }
    }
}
