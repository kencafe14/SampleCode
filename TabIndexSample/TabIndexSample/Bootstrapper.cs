using Autofac;
using Prism.Autofac;
using TabIndexSample.Views;
using System.Windows;
using TabIndexSample.ViewModels;
using System.Reflection;
using System;
using Prism.Mvvm;

namespace TabIndexSample
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


        protected override void ConfigureContainerBuilder(ContainerBuilder builder)
        {

            builder.RegisterTypeForNavigation<HogeUserControl>();
            base.ConfigureContainerBuilder(builder);

        }


    }
}
