using GalaSoft.MvvmLight;
using System;
using WPF.Exercises.Service;
using WPF.Exercises.Service.Dto;

namespace WPF.Exercises.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly FleetService _fleetService;

        private string _brand;

        private string _model;

        private DateTime _dateOfLastInspection;

        private bool _isUsed;

        private string _photo;

        public MainViewModel(FleetService fleetService)
        {
            _fleetService = fleetService;
            DisplayCarDetails(_fleetService.GetAllCars()[0]);
        }

        public string FullName
        {
            get => $"{_model}, {_brand}";
        }

        public string Brand
        {
            get => _brand;

            set
            {
                if (value == _brand)
                {
                    return;
                }

                _brand = value;
                RaisePropertyChanged();
                RaisePropertyChanged(() => FullName);
            }
        }

        public string Model
        {
            get => _model;

            set
            {
                if (value == _model)
                {
                    return;
                }

                _model = value;
                RaisePropertyChanged();
                RaisePropertyChanged(() => FullName);
            }
        }

        public DateTime DateOfLastInspection
        {
            get => _dateOfLastInspection;

            set
            {
                if (value == _dateOfLastInspection)
                {
                    return;
                }

                _dateOfLastInspection = value;
                RaisePropertyChanged();
            }
        }

        public bool IsUsed
        {
            get => _isUsed;

            set
            {
                if (value == _isUsed)
                {
                    return;
                }

                _isUsed = value;
                RaisePropertyChanged();
            }
        }

        public string Photo
        {
            get => _photo;

            set
            {
                if (value == _photo)
                {
                    return;
                }

                _photo = value;
                RaisePropertyChanged();
            }
        }

        private void DisplayCarDetails(CarDto carDto)
        {
            Brand = carDto.Brand;
            Model = carDto.Model;
            DateOfLastInspection = carDto.DateOfLastInspection;
            IsUsed = carDto.IsUsed;
            Photo = carDto.Photo;
        }
    }
}