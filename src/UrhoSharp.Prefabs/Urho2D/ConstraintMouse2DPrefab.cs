using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintMouse2D = Urho.Urho2D.ConstraintMouse2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintMouse2DPrefab: AbstractComponentPrefab<ConstraintMouse2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintMouse2D.TypeNameStatic; } }
        public Vector2 Target { get; set; }
        public float MaxForce { get; set; }
        public float FrequencyHz { get; set; }
        public float DampingRatio { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintMouse2DPrefab()
        {
            Target = TargetAccessor.DefaultValue;
            MaxForce = MaxForceAccessor.DefaultValue;
            FrequencyHz = FrequencyHzAccessor.DefaultValue;
            DampingRatio = DampingRatioAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintMouse2DPrefab(ConstraintMouse2D val)
        {
            ID = val.ID;
            Target = val.Target;
            MaxForce = val.MaxForce;
            FrequencyHz = val.FrequencyHz;
            DampingRatio = val.DampingRatio;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintMouse2D Create()
        {
            var result = new ConstraintMouse2D();
            TargetAccessor.Instance.ApplyIfChanged(this, result);
            MaxForceAccessor.Instance.ApplyIfChanged(this, result);
            FrequencyHzAccessor.Instance.ApplyIfChanged(this, result);
            DampingRatioAccessor.Instance.ApplyIfChanged(this, result);
            OtherBodyAccessor.Instance.ApplyIfChanged(this, result);
            CollideConnectedAccessor.Instance.ApplyIfChanged(this, result);
            AttachedConstraintAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Target":
                    TargetAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxForce":
                    MaxForceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FrequencyHz":
                    FrequencyHzAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DampingRatio":
                    DampingRatioAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherBody":
                    OtherBodyAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CollideConnected":
                    CollideConnectedAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AttachedConstraint":
                    AttachedConstraintAccessor.Instance.ParseAndSet(value, this);
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
                yield return TargetAccessor.Instance;
                yield return MaxForceAccessor.Instance;
                yield return FrequencyHzAccessor.Instance;
                yield return DampingRatioAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class TargetAccessor : Vector2Accessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly TargetAccessor Instance = new TargetAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.Target);
            public override Vector2 GetPrefab(ConstraintMouse2DPrefab instance) { return instance.Target; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, Vector2 value) { instance.Target = value; }
            public override Vector2 GetUrho(ConstraintMouse2D instance) { return instance.Target; }
            public override void SetUrho(ConstraintMouse2D instance, Vector2 value) { instance.Target = value; }
        }

        internal class MaxForceAccessor : SingleAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly MaxForceAccessor Instance = new MaxForceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.MaxForce);
            public override float GetPrefab(ConstraintMouse2DPrefab instance) { return instance.MaxForce; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, float value) { instance.MaxForce = value; }
            public override float GetUrho(ConstraintMouse2D instance) { return instance.MaxForce; }
            public override void SetUrho(ConstraintMouse2D instance, float value) { instance.MaxForce = value; }
        }

        internal class FrequencyHzAccessor : SingleAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly FrequencyHzAccessor Instance = new FrequencyHzAccessor();
            public static readonly float DefaultValue = 5f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.FrequencyHz);
            public override float GetPrefab(ConstraintMouse2DPrefab instance) { return instance.FrequencyHz; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, float value) { instance.FrequencyHz = value; }
            public override float GetUrho(ConstraintMouse2D instance) { return instance.FrequencyHz; }
            public override void SetUrho(ConstraintMouse2D instance, float value) { instance.FrequencyHz = value; }
        }

        internal class DampingRatioAccessor : SingleAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly DampingRatioAccessor Instance = new DampingRatioAccessor();
            public static readonly float DefaultValue = 0.7f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.DampingRatio);
            public override float GetPrefab(ConstraintMouse2DPrefab instance) { return instance.DampingRatio; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, float value) { instance.DampingRatio = value; }
            public override float GetUrho(ConstraintMouse2D instance) { return instance.DampingRatio; }
            public override void SetUrho(ConstraintMouse2D instance, float value) { instance.DampingRatio = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintMouse2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintMouse2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintMouse2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.CollideConnected);
            public override bool GetPrefab(ConstraintMouse2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintMouse2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintMouse2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintMouse2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintMouse2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintMouse2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.Enabled);
            public override bool GetPrefab(ConstraintMouse2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintMouse2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintMouse2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintMouse2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintMouse2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintMouse2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.Temporary);
            public override bool GetPrefab(ConstraintMouse2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintMouse2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintMouse2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintMouse2DPrefab, ConstraintMouse2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMouse2D.BlockEvents);
            public override bool GetPrefab(ConstraintMouse2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintMouse2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintMouse2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintMouse2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
