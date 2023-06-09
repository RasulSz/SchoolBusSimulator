﻿using MaterialDesignThemes.Wpf;
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
            int digit = int.Parse(student.Text);
            digit--;

            if (digit < 1)
            {
                digit = 30;
            }
            student.Text = digit.ToString();
        }

        private void studis_Click(object sender, RoutedEventArgs e)
        {
            int digit=int.Parse(student.Text);
            digit++;
            if (digit > 30)
            {
                digit = 1;
            }
            student.Text=digit.ToString();
        }

        private void guiinc_Click(object sender, RoutedEventArgs e)
        {
            int digit = int.Parse(guide.Text);
            digit--;
            if (digit < 1)
            {
                digit = 4;
            }
            guide.Text = digit.ToString();
            
        }

        private void guidis_Click(object sender, RoutedEventArgs e)
        {
            int digit = int.Parse(guide.Text);
            digit++;
            if (digit > 4)
            {
                digit = 1;
            }
            guide.Text = digit.ToString();
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            Map map = new();
            map.ShowDialog();
        }
    }
}
