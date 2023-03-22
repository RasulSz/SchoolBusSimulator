using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using SchoolBusSimulator.Messages;
using SchoolBusSimulator.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INavigationService = SchoolBusSimulator.Service.INavigationService;

namespace SchoolBusSimulator.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;

        public MainViewModel(INavigationService navigationService, IMessenger messenger)
        {
            this.navigationService = navigationService;
            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewModel=App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
                CurrentViewModel = viewModel;
            });
        }
        private ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { Set(ref currentViewModel, value); }
        }
        public RelayCommand RideCommand 
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<RideViewModel>();
            });
        }

        public RelayCommand StudentCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<StudentViewModel>();
            });
        }

        public RelayCommand DriverCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<DriverViewModel>();
            });
        }

        public RelayCommand CarCommand
        {
            get => new RelayCommand(() =>
            {
                navigationService.NavigateTo<CarViewModel>();
            });
        }
    }
}
