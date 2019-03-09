using GalaSoft.MvvmLight;

namespace UrhoSharp.Editor.ViewModel
{
    public class InspectorViewModel : ViewModelBase
    {
        private NodeViewModel _valueViewModel;

        public NodeViewModel ValueViewModel
        {
            get => _valueViewModel;
            set => Set(ref _valueViewModel, value);
        }
    }
}