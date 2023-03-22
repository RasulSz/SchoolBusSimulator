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
            DataContext = this;
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            SchoolBusSimulator.Models.SchoolBus schoolBus = new();
            schoolBus.Brand=brand.Text;
            schoolBus.SerialNumber = seria.Text;
            schoolBus.RelaysDate = relay.Text;
            schoolBus.SeatCount = seat.Text;
            carcombo.Items.Add(schoolBus.Brand);
            List<SchoolBusSimulator.Models.SchoolBus> schoolBuses = new();
            var json=JsonSerializer.Serialize(carcombo.Items);
            File.WriteAllText("cars.json", json);
        }
    }
}
