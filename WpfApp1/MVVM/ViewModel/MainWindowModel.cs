using System.Collections.Generic;
using WpfApp1.Core;
using WpfApp1.MVVM.View;

namespace WpfApp1.MVVM.ViewModel
{
    internal class MainWindowModel : ObservibleObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public HomeViewModel HomeVm { get; set; }
        public DiscoveryView DiscoveryVm { get; set; }


        private object? _currentView;

        public object? CurrentView
        {
            get => _currentView;
            set => Set(ref _currentView, value);
        }


        public MainWindowModel()
        {
            HomeVm = new HomeViewModel();
            DiscoveryVm = new DiscoveryView();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVm; });
            DiscoveryViewCommand = new RelayCommand(o => { CurrentView = DiscoveryVm; });
        }
    }
}
