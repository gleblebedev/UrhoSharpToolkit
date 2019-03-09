using System.Collections.Generic;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Prefabs
{
    public interface INodePrefab:IPrefab
    {
        uint? ID { get; }
        string Name { get; }
        IList<INodePrefab> Children { get; }
        IList<IComponentPrefab> Components { get; }
        IEnumerable<IAccessor> Properties { get; }
    }
}