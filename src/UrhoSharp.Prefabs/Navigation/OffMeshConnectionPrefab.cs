using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using OffMeshConnection = Urho.Navigation.OffMeshConnection;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public partial class OffMeshConnectionPrefab: AbstractComponentPrefab<OffMeshConnection>, IPrefab
    {
        public override string TypeName { get { return OffMeshConnection.TypeNameStatic; } }
        public Node EndPoint { get; set; }
        public float Radius { get; set; }
        public bool Bidirectional { get; set; }
        public uint Mask { get; set; }
        public uint AreaID { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public OffMeshConnectionPrefab()
        {
            EndPoint = EndPointAccessor.DefaultValue;
            Radius = RadiusAccessor.DefaultValue;
            Bidirectional = BidirectionalAccessor.DefaultValue;
            Mask = MaskAccessor.DefaultValue;
            AreaID = AreaIDAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public OffMeshConnectionPrefab(OffMeshConnection val)
        {
            ID = val.ID;
            EndPoint = val.EndPoint;
            Radius = val.Radius;
            Bidirectional = val.Bidirectional;
            Mask = val.Mask;
            AreaID = val.AreaID;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override OffMeshConnection Create()
        {
            var result = new OffMeshConnection();
            EndPointAccessor.Instance.ApplyIfChanged(this, result);
            RadiusAccessor.Instance.ApplyIfChanged(this, result);
            BidirectionalAccessor.Instance.ApplyIfChanged(this, result);
            MaskAccessor.Instance.ApplyIfChanged(this, result);
            AreaIDAccessor.Instance.ApplyIfChanged(this, result);
            EnabledAccessor.Instance.ApplyIfChanged(this, result);
            AnimationEnabledAccessor.Instance.ApplyIfChanged(this, result);
            TemporaryAccessor.Instance.ApplyIfChanged(this, result);
            BlockEventsAccessor.Instance.ApplyIfChanged(this, result);
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "EndPoint":
                    EndPointAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Radius":
                    RadiusAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Bidirectional":
                    BidirectionalAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Mask":
                    MaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AreaID":
                    AreaIDAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Is Enabled":
                    EnabledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AnimationEnabled":
                    AnimationEnabledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Temporary":
                    TemporaryAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "BlockEvents":
                    BlockEventsAccessor.Instance.ParseAndSet(value, this);
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
        #region Accessors
        public override IEnumerable<IAccessor> Properties {
            get {
                yield return EndPointAccessor.Instance;
                yield return RadiusAccessor.Instance;
                yield return BidirectionalAccessor.Instance;
                yield return MaskAccessor.Instance;
                yield return AreaIDAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class EndPointAccessor : NodeAccessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly EndPointAccessor Instance = new EndPointAccessor();
            public static readonly Node DefaultValue = null;
            public override Node DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.EndPoint);
            public override Node GetPrefab(OffMeshConnectionPrefab instance) { return instance.EndPoint; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, Node value) { instance.EndPoint = value; }
            public override Node GetUrho(OffMeshConnection instance) { return instance.EndPoint; }
            public override void SetUrho(OffMeshConnection instance, Node value) { instance.EndPoint = value; }
        }

        internal class RadiusAccessor : SingleAccessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly RadiusAccessor Instance = new RadiusAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.Radius);
            public override float GetPrefab(OffMeshConnectionPrefab instance) { return instance.Radius; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, float value) { instance.Radius = value; }
            public override float GetUrho(OffMeshConnection instance) { return instance.Radius; }
            public override void SetUrho(OffMeshConnection instance, float value) { instance.Radius = value; }
        }

        internal class BidirectionalAccessor : BooleanAccessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly BidirectionalAccessor Instance = new BidirectionalAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.Bidirectional);
            public override bool GetPrefab(OffMeshConnectionPrefab instance) { return instance.Bidirectional; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, bool value) { instance.Bidirectional = value; }
            public override bool GetUrho(OffMeshConnection instance) { return instance.Bidirectional; }
            public override void SetUrho(OffMeshConnection instance, bool value) { instance.Bidirectional = value; }
        }

        internal class MaskAccessor : UInt32Accessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly MaskAccessor Instance = new MaskAccessor();
            public static readonly uint DefaultValue = 1;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.Mask);
            public override uint GetPrefab(OffMeshConnectionPrefab instance) { return instance.Mask; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, uint value) { instance.Mask = value; }
            public override uint GetUrho(OffMeshConnection instance) { return instance.Mask; }
            public override void SetUrho(OffMeshConnection instance, uint value) { instance.Mask = value; }
        }

        internal class AreaIDAccessor : UInt32Accessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly AreaIDAccessor Instance = new AreaIDAccessor();
            public static readonly uint DefaultValue = 1;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.AreaID);
            public override uint GetPrefab(OffMeshConnectionPrefab instance) { return instance.AreaID; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, uint value) { instance.AreaID = value; }
            public override uint GetUrho(OffMeshConnection instance) { return instance.AreaID; }
            public override void SetUrho(OffMeshConnection instance, uint value) { instance.AreaID = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.Enabled);
            public override bool GetPrefab(OffMeshConnectionPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(OffMeshConnection instance) { return instance.Enabled; }
            public override void SetUrho(OffMeshConnection instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.AnimationEnabled);
            public override bool GetPrefab(OffMeshConnectionPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(OffMeshConnection instance) { return instance.AnimationEnabled; }
            public override void SetUrho(OffMeshConnection instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.Temporary);
            public override bool GetPrefab(OffMeshConnectionPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(OffMeshConnection instance) { return instance.Temporary; }
            public override void SetUrho(OffMeshConnection instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<OffMeshConnectionPrefab, OffMeshConnection>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(OffMeshConnection.BlockEvents);
            public override bool GetPrefab(OffMeshConnectionPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(OffMeshConnectionPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(OffMeshConnection instance) { return instance.BlockEvents; }
            public override void SetUrho(OffMeshConnection instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
