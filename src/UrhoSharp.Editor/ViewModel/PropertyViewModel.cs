using GalaSoft.MvvmLight;
using UrhoSharp.Prefabs;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Editor.ViewModel
{
    public class PropertyViewModel : ViewModelBase
    {
        private readonly IAccessor _accessor;
        private readonly IPrefab _prefab;

        public PropertyViewModel(IPrefab prefab, IAccessor accessor)
        {
            _prefab = prefab;
            _accessor = accessor;
            Value = _accessor.ToStringPrefab(_accessor.GetPrefab(prefab));
        }

        public string Name => _accessor.Name;

        public string Value { get; set; }
    }
}