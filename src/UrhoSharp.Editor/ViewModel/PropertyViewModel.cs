using GalaSoft.MvvmLight;
using UrhoSharp.Prefabs;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Editor.ViewModel
{
    public class PropertyViewModel : ViewModelBase
    {
        private readonly IAccessor _accessor;
        private readonly IPrefab _prefab;
        private int _index;

        public PropertyViewModel(IPrefab prefab, IAccessor accessor, int index )
        {
            _prefab = prefab;
            _accessor = accessor;
            Value = _accessor.ToStringPrefab(_accessor.GetPrefab(prefab));
            _index = index;
        }

        public string Name => _accessor.Name;

        public string Value { get; set; }

        public int Index
        {
            get { return _index; }
        }
    }
}