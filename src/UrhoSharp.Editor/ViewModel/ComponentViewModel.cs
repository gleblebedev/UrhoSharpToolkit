using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using UrhoSharp.Prefabs;

namespace UrhoSharp.Editor.ViewModel
{
    public class ComponentViewModel : ViewModelBase
    {
        private readonly IComponentPrefab _state;

        public ComponentViewModel(IComponentPrefab state)
        {
            _state = state;
            Properties = state.Properties.Select(_ => new PropertyViewModel(_state, _)).ToList();
        }

        public uint Id => _state.ID ?? 0;

        public string Name => _state.TypeName ?? "Node";

        public List<PropertyViewModel> Properties { get; set; }
    }
}