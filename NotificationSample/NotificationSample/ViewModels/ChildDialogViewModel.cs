using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSample.ViewModels
{
    public class ChildDialogViewModel : BindableBase, IInteractionRequestAware
    {
        public INotification Notification { get; set; }
        public Action FinishInteraction { get; set; }
        public ReactiveProperty<string> ChildInputValue { get; } = new ReactiveProperty<string>();


        public DelegateCommand NavigateOwnerCommand => new DelegateCommand(() =>
        {
            ((InputValueNotification)Notification).InputValue = ChildInputValue.Value;
            FinishInteraction();
        });


    }
}
