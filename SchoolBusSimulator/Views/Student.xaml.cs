using Newtonsoft.Json;
using SchoolBusSimulator.Models;
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
        List<Studentm> students;
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            SchoolBusSimulator.Models.Studentm student = new();
            student.Name = name.Text;
            student.Surname = surname.Text;
            student.Adress = address.Text;
            student.SchoolNumber = school.Text;
            student.Id++;
            combo.Items.Add(student.Name);
            SchoolBusSimulator.FileHelper.FileHelper.WriteStudent(student);
        }
    }
}
