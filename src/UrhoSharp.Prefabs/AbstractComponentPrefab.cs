using System.Xml.Linq;
using Urho;

namespace UrhoSharp.Prefabs
{
    public abstract class AbstractComponentPrefab<T> : IComponentPrefab where T : Component
    {
        object IPrefab.Create()
        {
            return Create();
        }

        Component IComponentPrefab.Create()
        {
            return Create();
        }

        public virtual void ParseXml(XElement element)
        {
            foreach (var childElement in element.Elements())
                if (childElement.Name == XmlElement.Attribute)
                {
                    var name = childElement.Attribute(XmlAttribute.Name)?.Value;
                    var value = childElement.Attribute(XmlAttribute.Value)?.Value;
                    if (!string.IsNullOrWhiteSpace(name)) ParseXmlAttribute(name, value);
                }
        }

        public virtual XElement SerializeToXml()
        {
            var element = new XElement(XmlElement.Component);
            element.SetAttributeValue(XmlAttribute.Type, "Camera");
            return element;
        }

        public abstract T Create();

        public abstract void ParseXmlAttribute(string name, string value);

        protected static class XmlElement
        {
            public static readonly XName Component = XName.Get("component");
            public static readonly XName Attribute = XName.Get("attribute");
        }

        protected static class XmlAttribute
        {
            public static readonly XName Type = XName.Get("yype");
            public static readonly XName Name = XName.Get("name");
            public static readonly XName Value = XName.Get("value");
        }
    }
}