using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.ViewModel.Properties;
using UrhoSharp.Prefabs;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Editor.ViewModel
{
    public class InspectableViewModel : ViewModelBase
    {
        private List<PropertyViewModel> _properties;
        private bool _isCollapsed;

        public InspectableViewModel()
        {
            ToggleCollapseCommand = new ActionCommand(ToggleCollapse);
        }

        private void ToggleCollapse()
        {
            IsCollapsed = !IsCollapsed;
        }

        public List<PropertyViewModel> Properties
        {
            get => _properties;
            set
            {
                if (Set(ref _properties, value))
                    UpdatePairs();
            }
        }

        public bool IsCollapsed
        {
            get => _isCollapsed;
            set => Set(ref _isCollapsed, value);
        }

        public ICommand ToggleCollapseCommand { get; }

        protected PropertyViewModel CreatePropertyViewModel(IPrefab prefab, IAccessor accessor, int index)
        {
            if (accessor.PrefabPropertyType == typeof(bool))
                return new BooleanPropertyViewModel(prefab, accessor, index);
            return new PropertyViewModel(prefab, accessor, index);
        }

        public IEnumerable<ViewModelBase> PropertiesAndLabels
        {
            get => _properties.Select(_=>new ViewModelBase[]{new LabelViewModel(_),_}).SelectMany(_=>_);
        }
        private void UpdatePairs()
        {
            RaisePropertyChanged(nameof(PropertiesAndLabels));
        }
    }
}