using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for Ride.xaml
    /// </summary>
    public partial class Ride : UserControl
    {
        public Ride()
        {
            InitializeComponent();
        }
        
        private void stuinc_Click(object sender, RoutedEventArgs e)
        {
            student.Text = "0";
            int digit = Int32.Parse(student.Text);

            if (digit < 0)
            {
                student.Text = "30";
                digit--;
            }
        }

        private void guiinc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void guidis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void studis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tour_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
