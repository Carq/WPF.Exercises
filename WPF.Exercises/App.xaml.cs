using Autofac;
using GalaSoft.MvvmLight;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows;
using WPF.Exercises.Framework;
using WPF.Exercises.Service;
using WPF.Exercises.View;
using WPF.Exercises.ViewModel;

namespace WPF.Exercises
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            InitializeDependecyInjection();
            base.OnStartup(e);
        }

        private void InitializeDependecyInjection()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var builder = new ContainerBuilder();

            builder.RegisterType<SimpleNavigationService>()
                   .As<INavigationService>();

            RegisterAllViewModels(builder, currentAssembly);
            RegisterAllViews(builder, currentAssembly);
            RegisterServices(builder);

            ViewModelLocator.Initialize(builder.Build());
        }

        private void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<FleetService>();
        }

        private void RegisterAllViews(ContainerBuilder builder, Assembly currentAssembly)
        {
            builder.RegisterType<About>().Named<Window>(nameof(About));
            builder.RegisterType<AddNewCar>().Named<Window>(nameof(AddNewCar));
        }

        private void RegisterAllViewModels(ContainerBuilder builder, Assembly currentAssembly)
        {
            builder.RegisterAssemblyTypes(currentAssembly)
                .Where(x => x.IsSubclassOf(typeof(ViewModelBase)));
        }
    }
}