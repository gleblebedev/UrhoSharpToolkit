using System.Collections.Generic;
using System.Xml.Linq;
using Urho;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Prefabs
{
    public interface IComponentPrefab : IPrefab
    {
        uint? ID { get; }
        string TypeName { get; }
        void ParseXml(XElement element);

        XElement SerializeToXml();

        IEnumerable<IAccessor> Properties { get; }
    }
}