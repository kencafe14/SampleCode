using Prism.Mvvm;
using Reactive.Bindings;
using System.Reactive.Linq;

namespace ReactiveCommandSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ReactiveProperty<bool> IsActive { get; } = new ReactiveProperty<bool>(true);
        public ReactiveCommand HogeCommand { get; }

        public MainWindowViewModel()
        {
            HogeCommand = IsActive.Select(x => x == true).ToReactiveCommand();
            HogeCommand.Subscribe(OnClick);
        }

        public void OnClick()
        {
            //ボタンが押下された際の処理
        }
    }
}
