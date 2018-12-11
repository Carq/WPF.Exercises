using GalaSoft.MvvmLight;
using WPF.Exercises.Service;

namespace WPF.Exercises.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly FleetService _fleetService;

        public MainViewModel(FleetService fleetService)
        {
            _fleetService = fleetService;
        }

        public string HelloWorld { get; set; } = "Hello World ^_^";
    }
}