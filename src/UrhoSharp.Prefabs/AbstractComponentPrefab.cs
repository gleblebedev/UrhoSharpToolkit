using System;
using System.Xml.Linq;
using Urho;

namespace UrhoSharp.Prefabs
{
    public abstract class AbstractComponentPrefab<T> : AbstractPrefab, IComponentPrefab where T : Component
    {
        public abstract string TypeName { get; }
        object IPrefab.Create()
        {
            return Create();
        }

        public virtual uint? ID { get; set; }
        public abstract T Create();

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
            element.SetAttributeValue(XmlAttribute.Type, TypeName);
            foreach (var property in Properties)
            {
                if (property.PrefabHasValue(this))
                {
                    var value = property.ToStringPrefab(this);
                    element.Add(new XElement(XmlElement.Attribute, new XAttribute(XmlAttribute.Name, property.Name), new XAttribute(XmlAttribute.Value, value)));
                }
            }
            return element;
        }


        public abstract void ParseXmlAttribute(string name, string value);

        protected static class XmlElement
        {
            public static readonly XName Component = XName.Get("component");
            public static readonly XName Attribute = XName.Get("attribute");
        }

        protected static class XmlAttribute
        {
            public static readonly XName Type = XName.Get("type");
            public static readonly XName Name = XName.Get("name");
            public static readonly XName Value = XName.Get("value");
        }
    }
}