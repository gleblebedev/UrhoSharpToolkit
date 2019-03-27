using System.Linq;
using UrhoSharp.Prefabs;

namespace UrhoSharp.Editor.ViewModel
{
    public class ComponentViewModel : InspectableViewModel
    {
        private readonly IComponentPrefab _state;

        public ComponentViewModel(IComponentPrefab state)
        {
            _state = state;
            Properties = state.Properties.Select((_, i) => CreatePropertyViewModel(_state, _, i)).ToList();
        }

        public uint Id => _state.ID ?? 0;

        public string Name => _state.TypeName ?? "Node";
    }
}