using System.Collections.Generic;
using System.Linq;
using UrhoSharp.Prefabs;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Editor.ViewModel
{
    public class NodeViewModel : InspectableViewModel
    {
        private readonly INodePrefab _state;

        public NodeViewModel(INodePrefab state)
        {
            _state = state;
            Children = state.Children.Select(_ => new NodeViewModel(_)).ToList();
            Components = state.Components.Select(_ => new ComponentViewModel(_)).ToList();
            Properties = state.Properties.Select((_,i) => CreatePropertyViewModel(_state,_, i)).ToList();
        }


        public uint Id => _state.ID ?? 0;

        public string Name => _state.Name ?? "Node";

        public List<NodeViewModel> Children { get; set; }

        public List<ComponentViewModel> Components { get; set; }
    }
}