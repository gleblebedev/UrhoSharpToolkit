using GalaSoft.MvvmLight;

namespace UrhoSharp.Editor.ViewModel
{
    public class LabelViewModel : ViewModelBase
    {
        private readonly PropertyViewModel _property;

        public LabelViewModel(PropertyViewModel property)
        {
            _property = property;
        }

        public string Name => _property.Name;

        public int Index => _property.Index;
    }
}