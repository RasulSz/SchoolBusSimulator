using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using SchoolBusSimulator.Service;
using SchoolBusSimulator.ViewModels;
using SchoolBusSimulator.Views;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Container = SimpleInjector.Container;
using INavigationService = SchoolBusSimulator.Service.INavigationService;
using NavigationService = SchoolBusSimulator.Service.NavigationService;

namespace SchoolBusSimulator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container? Container { get; set; }
        public static Container? Containerr { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            Register();
            Window window = new MainView();
            var viewModel = Container.GetInstance<MainViewModel>();
            window.DataContext = viewModel;
            window.ShowDialog();
            base.OnStartup(e);
        }

        private void Register()
        {
            Container = new Container();
            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IMessenger,Messenger>();
            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<RideViewModel>();
            Container.RegisterSingleton<StudentViewModel>();
            Container.RegisterSingleton<DriverViewModel>();
            Container.RegisterSingleton<CarViewModel>();
            Container.Verify();

        }
    }
}
