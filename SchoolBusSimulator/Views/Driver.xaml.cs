using Newtonsoft.Json;
using SchoolBusSimulator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
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
    /// Interaction logic for Driver.xaml
    /// </summary>
    public partial class Driver : UserControl
    {
        public Driver()
        {
            InitializeComponent();
        }
        List<Driverm> drivers = new();
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            Driverm driver = new();
            driver.Name = name.Text;
            driver.Surname = surname.Text;
            driver.Adress = address.Text;
            driver.Age = age.Text;
            drivers.Add(driver);
            combo.Items.Add(driver.Name);
            driver.Id++;
            SchoolBusSimulator.FileHelper.FileHelper.WriteDriver(drivers);
            name.Text = "";
            address.Text = "";
            surname.Text = "";
            age.Text = "";
        }
    }
}
