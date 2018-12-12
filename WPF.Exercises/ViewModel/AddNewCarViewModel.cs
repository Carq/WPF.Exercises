using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.ComponentModel;
using System.Windows;
using WPF.Exercises.Service;

namespace WPF.Exercises.ViewModel
{
    public class AddNewCarViewModel : ViewModelBase, IDataErrorInfo
    {
        private readonly FleetService _fleetService;

        private string _brand;

        private string _model;

        private DateTime? _dateOfLastInspection;

        private bool _isUsed;

        public AddNewCarViewModel(FleetService fleetService)
        {
            _fleetService = fleetService;
            SaveCommand = new RelayCommand<Window>(Save);
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(Brand) && string.IsNullOrEmpty(Brand))
                {
                    return "Brand is empty";
                }

                if (columnName == nameof(Model) && string.IsNullOrEmpty(Model))
                {
                    return "Model is empty";
                }

                if (columnName == nameof(DateOfLastInspection) && DateOfLastInspection == null)
                {
                    return "Date of last inspection is not selected";
                }

                return null;
            }
        }

        public RelayCommand<Window> SaveCommand { get; private set; }

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

        public DateTime? DateOfLastInspection
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

        public string Error => throw new NotImplementedException();

        private void Save(Window window)
        {
            try
            {
                _fleetService.AddNewCar(new Service.Dto.CarDto
                {
                    Brand = Brand,
                    Model = Model,
                    DateOfLastInspection = DateOfLastInspection.Value,
                    IsUsed = IsUsed
                });

                CloseWindow(window);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
    }
}