using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Prefabs
{
    public partial class NodePrefab : INodePrefab
    {
        public static StringAccessor<NodePrefab, Node> NameProperty = new NameAccessor();
        public static Vector3Accessor<NodePrefab, Node> PositionProperty = new PositionAccessor();
        private string _name;

        public IList<IComponentPrefab> Components { get; } = new List<IComponentPrefab>();
        public IList<INodePrefab> Children { get; } = new List<INodePrefab>();

        public NodePrefab(Node node)
        {
            var c = new ComponentFactory();
            ID = node.ID;
            Position = node.Position;
            foreach (var component in node.Components)
            {
                Components.Add(c.CreateComponent(component));
            }

            foreach (var child in node.Children)
            {
                Children.Add(new NodePrefab(child));
            }

        }
        public uint? ID { get; set; }
        public Vector3 Position { get; set; }
        public string Name { get; set; }

        public IEnumerable<IAccessor> Properties
        {
            get
            {
                yield return NameProperty;
                yield return PositionProperty;
            }
        }


        object IPrefab.Create()
        {
            return Create();
        }

        public void BackgroundLoadResource()
        {
            foreach (var component in Components)
            {
                component.BackgroundLoadResource();
            }
            foreach (var child in Children)
            {
                child.BackgroundLoadResource();
            }
        }

        public virtual Node Create()
        {
            var result = new Node();
            return result;
        }

        #region Accessors

        internal class PositionAccessor : Vector3Accessor<NodePrefab, Node>
        {
            public static readonly PositionAccessor Instance = new PositionAccessor();
            public static readonly Vector3 DefaultValue = Vector3.Zero;
            public override Vector3 DefaultPrefabValue => DefaultValue;
            public override string Name => nameof(Node.Position);

            public override Vector3 GetPrefab(NodePrefab instance) { return instance.Position; }

            public override void SetPrefab(NodePrefab instance, Vector3 value) { instance.Position = value; }

            public override Vector3 GetUrho(Node instance) { return instance.Position; }

            public override void SetUrho(Node instance, Vector3 value) { instance.Position = value; }
        }
        internal class NameAccessor : StringAccessor<NodePrefab, Node>
        {
            public static readonly PositionAccessor Instance = new PositionAccessor();
            public static readonly string DefaultValue = null;
            public override string DefaultPrefabValue => DefaultValue;
            public override string Name => nameof(Node.Position);

            public override string GetPrefab(NodePrefab instance) { return instance.Name; }

            public override void SetPrefab(NodePrefab instance, string value) { instance.Name = value; }

            public override string GetUrho(Node instance) { return instance.Name; }

            public override void SetUrho(Node instance, string value) { instance.Name = value; }
        }
        #endregion

    }
}