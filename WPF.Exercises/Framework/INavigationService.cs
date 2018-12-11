using GalaSoft.MvvmLight;

namespace WPF.Exercises.Framework
{
    public interface INavigationService
    {
        void Open<TViewModel>() where TViewModel : ViewModelBase;
    }
}
