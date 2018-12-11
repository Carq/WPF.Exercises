using Autofac;
using GalaSoft.MvvmLight;
using System.Windows;

namespace WPF.Exercises.Framework
{
    public class SimpleNavigationService : INavigationService
    {
        private readonly ILifetimeScope _container;

        public SimpleNavigationService(ILifetimeScope container)
        {
            _container = container;
        }

        public void Open<TViewModel>() where TViewModel : ViewModelBase
        {
            var viewModel = _container.Resolve(typeof(TViewModel)) as TViewModel;
            var view = _container.ResolveNamed<Window>(typeof(TViewModel).Name.Replace("ViewModel", string.Empty)) as Window;
            view.Show();
        }
    }
}
