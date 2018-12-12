using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using WPF.Exercises.Service;
using WPF.Exercises.Service.Dto;

namespace WPF.Exercises.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly FleetService _fleetService;

        public MainViewModel(FleetService fleetService)
        {
            _fleetService = fleetService;
            Cars = new ObservableCollection<CarDto>(_fleetService.GetAllCars());
        }

        public ObservableCollection<CarDto> Cars { get; set; }
    }
}