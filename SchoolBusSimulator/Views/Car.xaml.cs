using Newtonsoft.Json;
using SchoolBusSimulator.FileHelper;
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
    /// Interaction logic for Car.xaml
    /// </summary>
    public partial class Car : UserControl
    {
        public Car()
        {
            InitializeComponent();
        }
        List<SchoolBus> schoolBuses = new();
        int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            SchoolBus schoolBus = new SchoolBus();
            schoolBus.Brand=brand.Text;
            schoolBus.SerialNumber = seria.Text;
            schoolBus.RelaysDate = relay.Text;
            schoolBus.SeatCount = seat.Text;
            schoolBuses.Add(schoolBus);
            schoolBus.Id++;
            SchoolBusSimulator.FileHelper.FileHelper.WriteSchoolBus(schoolBuses);

            brand.Text = "";
            seria.Text = "";
            relay.Text = "";
            seat.Text = "";
        }
    }
}
