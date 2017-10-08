using Autofac;
using Prism.Autofac;
using ReactiveCommandSample.Views;
using System.Windows;

namespace ReactiveCommandSample
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
    }
}
