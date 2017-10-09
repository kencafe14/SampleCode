using Autofac;
using Prism.Autofac;
using NotificationSample.Views;
using System.Windows;
using NotificationSample.ViewModels;
using System.Reflection;
using System;
using Prism.Mvvm;

namespace NotificationSample
{
    class Bootstrapper : AutofacBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }


        ViewTypeToViewModelTypeResolver _resolver;
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            _resolver = new ViewTypeToViewModelTypeResolver(typeof(MainWindowViewModel).Assembly);
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(_resolver.Resolve);
        }



        protected override void ConfigureContainerBuilder(ContainerBuilder builder)
        {

            builder.RegisterTypeForNavigation<ChildDialog>();
            builder.RegisterType<ChildDialogViewModel>();

            base.ConfigureContainerBuilder(builder);

        }

        public class ViewTypeToViewModelTypeResolver
        {
            private readonly Assembly _assembly;

            public ViewTypeToViewModelTypeResolver(Assembly assembly)
            {
                _assembly = assembly;
            }

            public Type Resolve(Type viewType)
            {
                if (viewType == null) throw new ArgumentNullException(nameof(viewType));
                var vmTypeName = $"{viewType.Namespace.Replace("Views", "ViewModels")}.{viewType.Name}ViewModel";
                var vmType = _assembly.GetType(vmTypeName);
                return vmType;
            }
        }

    }
}
