﻿using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace SchoolBusSimulator.Views
{
    /// <summary>
    /// Interaction logic for Simulation.xaml
    /// </summary>
    public partial class Simulation : Window
    {
        public ApplicationIdCredentialsProvider ApiKey { get; set; } = new ApplicationIdCredentialsProvider(ConfigurationManager.AppSettings["apikey"]);
        public Simulation()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
