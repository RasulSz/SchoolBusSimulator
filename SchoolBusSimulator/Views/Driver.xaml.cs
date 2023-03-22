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
    /// Interaction logic for Driver.xaml
    /// </summary>
    public partial class Driver : UserControl
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            SchoolBusSimulator.Models.Driver driver = new();
            driver.Name = name.Text;
            driver.Surname = surname.Text;
            driver.Adress = address.Text;
            driver.Age = age.Text;
            SchoolBusSimulator.Views.Car car = new();
            combo.Items.Add(driver.Name);
            var json = JsonSerializer.Serialize(combo.Items);
            File.WriteAllText("drivers.json", json);
        }
    }
}
