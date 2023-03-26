using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using SchoolBusSimulator.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusSimulator.ViewModels
{
    public class RideViewModel : ViewModelBase
    {
        //private readonly INavigationService navigationService;

        //public RideViewModel (INavigationService navigationService, IMessenger messenger)
        //{
        //    this.navigationService = navigationService;
        //    messenger.Register<NavigationMessage>(this, message =>
        //    {
        //        var viewModel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
        //        CCurrentViewModel = viewModel;
        //    });
        //}

        //private ViewModelBase ccurrentViewModel;
        //public ViewModelBase CCurrentViewModel
        //{
        //    get { return ccurrentViewModel; }
        //    set { Set(ref ccurrentViewModel, value); }
        //}

        //public RelayCommand GoCommand
        //{
        //    get => new RelayCommand(() =>
        //    {
        //        //navigationService.NavigateTo<SimulationViewModel>();
        //    });
        //}
    }
}
