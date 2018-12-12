using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WPF.Exercises.Framework;
using WPF.Exercises.Service;
using WPF.Exercises.Service.Dto;

namespace WPF.Exercises.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly FleetService _fleetService;

        private readonly INavigationService _navigationService;

        private string _searchInput;

        public MainViewModel(FleetService fleetService, INavigationService navigationService)
        {
            _fleetService = fleetService;
            _navigationService = navigationService;
            Load();
            CleanCommand = new RelayCommand(CleanCars, CanClearCars);
            LoadCommand = new RelayCommand(Load, CanLoad);
            AddNewCarCommand = new RelayCommand(AddNewCar);
        }

        public string SearchInput
        {
            get { return _searchInput; }
            set
            {
                if (_searchInput == value)
                {
                    return;
                }

                _searchInput = value;
                RaisePropertyChanged();
                CarsFiltered.Refresh();
            }
        }

        public ICollectionView CarsFiltered
        {
            get; private set;
        }

        public ObservableCollection<CarDto> Cars { get; set; }

        public RelayCommand CleanCommand { get; }

        public RelayCommand LoadCommand { get; }

        public RelayCommand AddNewCarCommand { get; }

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

        private void Load()
        {
            Cars = new ObservableCollection<CarDto>(_fleetService.GetAllCars());
            CarsFiltered = new ListCollectionView(Cars)
            {
                Filter = x => Search(x as CarDto)
            };

            RaisePropertyChanged(() => CarsFiltered);
        }

        private bool Search(CarDto car)
        {
            if (string.IsNullOrWhiteSpace(SearchInput))
            {
                return true;
            }

            return car.Model.ContainsIgnoreDiacritics(SearchInput)
                || car.Brand.ContainsIgnoreDiacritics(SearchInput)
                || (car.DateOfLastInspection != null && car.DateOfLastInspection.ToShortDateString().ContainsIgnoreDiacritics(SearchInput));
        }

        private void AddNewCar()
        {
            _navigationService.Open<AddNewCarViewModel>();
            Load();
        }

      
    }
}