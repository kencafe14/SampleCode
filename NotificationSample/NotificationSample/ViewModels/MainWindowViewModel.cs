using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Reactive.Bindings;

namespace NotificationSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public ReactiveProperty<string> OwnerInputValue { get; } = new ReactiveProperty<string>();

        public DelegateCommand OpenChildDialogCommand { get; }

        public InteractionRequest<InputValueNotification> OpenChildDialogRequest { get; } = new InteractionRequest<InputValueNotification>();

        public MainWindowViewModel()
        {
            //テストのためコメント追加
            OpenChildDialogCommand = new DelegateCommand(() =>
            {
                var inputValueNotification = new InputValueNotification() { Title = "NotificationSample" };
                OpenChildDialogRequest.Raise(inputValueNotification);
                if (inputValueNotification.InputValue != null)
                {
                    OwnerInputValue.Value = inputValueNotification.InputValue;
                }
            });

        }
    }
}