using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
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
            Cars.Add(new CarDto
            {
                Id = 999,
                Brand = "Fiat",
                Model = "126p"
            });
        }

        public ObservableCollection<CarDto> Cars { get; set; }

        public RelayCommand CleanCommand { get; }

        public RelayCommand LoadCommand { get; }

        public RelayCommand AddNewCarCommand { get; }
    }
}