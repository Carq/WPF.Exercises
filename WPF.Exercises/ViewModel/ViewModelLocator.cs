using Autofac;

namespace WPF.Exercises.ViewModel
{
    public class ViewModelLocator
    {
        private static readonly ViewModelLocator _instance = new ViewModelLocator();

        private static IContainer _container;

        public MainViewModel MainViewModel => _container.Resolve<MainViewModel>();

        public static void Initialize(IContainer container)
        {
            _container = container;
        }

        public static void Cleanup()
        {
        }
    }
}