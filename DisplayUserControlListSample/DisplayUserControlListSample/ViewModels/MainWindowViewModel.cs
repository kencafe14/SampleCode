using Prism.Mvvm;
using Reactive.Bindings;

namespace DisplayUserControlListSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        public ReactiveCollection<DisplayControlViewModel> DisplayControlViewModels { get; } = new ReactiveCollection<DisplayControlViewModel>();

        public MainWindowViewModel()
        {
            DisplayControlViewModels.Clear();
            DisplayControlViewModels.Add(new ComboBoxControlViewModel());
            DisplayControlViewModels.Add(new TextBoxControlViewModel());
            DisplayControlViewModels.Add(new ComboBoxControlViewModel());
        }
    }
}
