using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolBusSimulator.Views
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            SchoolBusSimulator.Models.Student student = new();
            student.Name = name.Text;
            student.Surname = surname.Text;
            student.Adress = address.Text;
            student.SchoolNumber = school.Text;
            combo.Items.Add(student.Name);
            var json = JsonSerializer.Serialize(combo.Items);
            File.WriteAllText("students.json", json);
        }
    }
}
