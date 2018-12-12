using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows;

namespace WPF.Exercises.ViewModel
{
    public class AddNewCarViewModel : ViewModelBase
    {
        public RelayCommand<Window> SaveCommand { get; private set; }

        public AddNewCarViewModel()
        {
            SaveCommand = new RelayCommand<Window>(Save);
        }

        private void Save(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
    }
}
