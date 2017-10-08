using Reactive.Bindings;

namespace DisplayUserControlListSample.ViewModels
{
    public class ComboBoxControlViewModel : DisplayControlViewModel
    {
        /// <summary>
        /// コンボボックスに表示されるItemのコレクション
        /// </summary>
        public ReactiveCollection<string> Items { get; }

        public ComboBoxControlViewModel()
        {
            Items = new ReactiveCollection<string>() { "Apple", "Banana", "Peach" };
        }
    }
}
