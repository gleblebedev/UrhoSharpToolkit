using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using SplinePath = Urho.SplinePath;


namespace UrhoSharp.Prefabs
{
    public partial class SplinePathPrefab: AbstractComponentPrefab<SplinePath>, IPrefab
    {
        public override string TypeName { get { return SplinePath.TypeNameStatic; } }
        public InterpolationMode InterpolationMode { get; set; }
        public float Speed { get; set; }
        public Node ControlledNode { get; set; }
        public uint ControlledIdAttr { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public SplinePathPrefab()
        {
            InterpolationMode = InterpolationModeAccessor.DefaultValue;
            Speed = SpeedAccessor.DefaultValue;
            ControlledNode = ControlledNodeAccessor.DefaultValue;
            ControlledIdAttr = ControlledIdAttrAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public SplinePathPrefab(SplinePath val)
        {
            ID = val.ID;
            InterpolationMode = val.InterpolationMode;
            Speed = val.Speed;
            ControlledNode = val.ControlledNode;
            ControlledIdAttr = val.ControlledIdAttr;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override SplinePath Create()
        {
            var result = new SplinePath();
            InterpolationModeAccessor.Instance.ApplyIfChanged(this, result);
            SpeedAccessor.Instance.ApplyIfChanged(this, result);
            ControlledNodeAccessor.Instance.ApplyIfChanged(this, result);
            ControlledIdAttrAccessor.Instance.ApplyIfChanged(this, result);
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
                case "InterpolationMode":
                    InterpolationModeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Speed":
                    SpeedAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ControlledNode":
                    ControlledNodeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ControlledIdAttr":
                    ControlledIdAttrAccessor.Instance.ParseAndSet(value, this);
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
                yield return InterpolationModeAccessor.Instance;
                yield return SpeedAccessor.Instance;
                yield return ControlledNodeAccessor.Instance;
                yield return ControlledIdAttrAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class InterpolationModeAccessor : EnumAccessor<SplinePathPrefab, SplinePath, InterpolationMode>
        {
            public static readonly InterpolationModeAccessor Instance = new InterpolationModeAccessor();
            public static readonly InterpolationMode DefaultValue = InterpolationMode.BezierCurve;
            public override InterpolationMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SplinePath.InterpolationMode);
            public override InterpolationMode GetPrefab(SplinePathPrefab instance) { return instance.InterpolationMode; }
            public override void SetPrefab(SplinePathPrefab instance, InterpolationMode value) { instance.InterpolationMode = value; }
            public override InterpolationMode GetUrho(SplinePath instance) { return instance.InterpolationMode; }
            public override void SetUrho(SplinePath instance, InterpolationMode value) { instance.InterpolationMode = value; }
        }

        internal class SpeedAccessor : SingleAccessor<SplinePathPrefab, SplinePath>
        {
            public static readonly SpeedAccessor Instance = new SpeedAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SplinePath.Speed);
            public override float GetPrefab(SplinePathPrefab instance) { return instance.Speed; }
            public override void SetPrefab(SplinePathPrefab instance, float value) { instance.Speed = value; }
            public override float GetUrho(SplinePath instance) { return instance.Speed; }
            public override void SetUrho(SplinePath instance, float value) { instance.Speed = value; }
        }

        internal class ControlledNodeAccessor : NodeAccessor<SplinePathPrefab, SplinePath>
        {
            public static readonly ControlledNodeAccessor Instance = new ControlledNodeAccessor();
            public static readonly Node DefaultValue = null;
            public override Node DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SplinePath.ControlledNode);
            public override Node GetPrefab(SplinePathPrefab instance) { return instance.ControlledNode; }
            public override void SetPrefab(SplinePathPrefab instance, Node value) { instance.ControlledNode = value; }
            public override Node GetUrho(SplinePath instance) { return instance.ControlledNode; }
            public override void SetUrho(SplinePath instance, Node value) { instance.ControlledNode = value; }
        }

        internal class ControlledIdAttrAccessor : UInt32Accessor<SplinePathPrefab, SplinePath>
        {
            public static readonly ControlledIdAttrAccessor Instance = new ControlledIdAttrAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SplinePath.ControlledIdAttr);
            public override uint GetPrefab(SplinePathPrefab instance) { return instance.ControlledIdAttr; }
            public override void SetPrefab(SplinePathPrefab instance, uint value) { instance.ControlledIdAttr = value; }
            public override uint GetUrho(SplinePath instance) { return instance.ControlledIdAttr; }
            public override void SetUrho(SplinePath instance, uint value) { instance.ControlledIdAttr = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<SplinePathPrefab, SplinePath>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SplinePath.Enabled);
            public override bool GetPrefab(SplinePathPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(SplinePathPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(SplinePath instance) { return instance.Enabled; }
            public override void SetUrho(SplinePath instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<SplinePathPrefab, SplinePath>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SplinePath.AnimationEnabled);
            public override bool GetPrefab(SplinePathPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(SplinePathPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(SplinePath instance) { return instance.AnimationEnabled; }
            public override void SetUrho(SplinePath instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<SplinePathPrefab, SplinePath>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SplinePath.Temporary);
            public override bool GetPrefab(SplinePathPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(SplinePathPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(SplinePath instance) { return instance.Temporary; }
            public override void SetUrho(SplinePath instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<SplinePathPrefab, SplinePath>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SplinePath.BlockEvents);
            public override bool GetPrefab(SplinePathPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(SplinePathPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(SplinePath instance) { return instance.BlockEvents; }
            public override void SetUrho(SplinePath instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
