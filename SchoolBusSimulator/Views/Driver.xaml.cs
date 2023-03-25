using Newtonsoft.Json;
using SchoolBusSimulator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
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
        int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            Driverm driver = new();
            driver.Name = name.Text;
            driver.Surname = surname.Text;
            driver.Adress = address.Text;
            driver.Age = age.Text;
            drivers.Add(driver);
            combo.Items.Add(drivers);
            driver.Id++;
            SchoolBusSimulator.FileHelper.FileHelper.WriteDriver(drivers);
            name.Text = "";
            address.Text = "";
            surname.Text = "";
            age.Text = "";
        }
        private void relay_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
