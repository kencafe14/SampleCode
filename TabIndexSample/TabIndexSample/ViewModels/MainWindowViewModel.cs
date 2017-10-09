using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace TabIndexSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public DelegateCommand NavigateCommand => new DelegateCommand(() =>
        {
            _regionManager.RequestNavigate("ContentRegion","HogeUserControl");
        });
        
    }
}
