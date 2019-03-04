using System.Xml.Linq;
using Urho;

namespace UrhoSharp.Prefabs
{
    public interface IComponentPrefab : IPrefab
    {
        Component Create();
        void ParseXml(XElement element);

        XElement SerializeToXml();
    }
}