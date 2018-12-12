using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using WPF.Exercises.Framework;
using WPF.Exercises.Service;
using WPF.Exercises.Service.Dto;

namespace WPF.Exercises.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly FleetService _fleetService;

        private readonly INavigationService _navigationService;

        public MainViewModel(FleetService fleetService, INavigationService navigationService)
        {
            _fleetService = fleetService;
            _navigationService = navigationService;
            Cars = new ObservableCollection<CarDto>(_fleetService.GetAllCars());
            CleanCommand = new RelayCommand(CleanCars, CanClearCars);
            LoadCommand = new RelayCommand(Load, CanLoad);
            AddNewCarCommand = new RelayCommand(AddNewCar);
            
        }

        private bool CanClearCars()
        {
            return Cars.Count > 0;
        }

        private void CleanCars()
        {
            Cars.Clear();
        }

        private bool CanLoad()
        {
            return Cars.Count == 0;
        }

        public void Load()
        {
            Cars = new ObservableCollection<CarDto>(_fleetService.GetAllCars());
            RaisePropertyChanged(() => Cars);
        }

        private void AddNewCar()
        {
            _navigationService.Open<AddNewCarViewModel>();
            Load();
        }

        public ObservableCollection<CarDto> Cars { get; set; }

        public RelayCommand CleanCommand { get; }

        public RelayCommand LoadCommand { get; }

        public RelayCommand AddNewCarCommand { get; }
    }
}