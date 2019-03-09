using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintFriction2D = Urho.Urho2D.ConstraintFriction2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintFriction2DPrefab: AbstractComponentPrefab<ConstraintFriction2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintFriction2D.TypeNameStatic; } }
        public Vector2 Anchor { get; set; }
        public float MaxForce { get; set; }
        public float MaxTorque { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintFriction2DPrefab()
        {
            Anchor = AnchorAccessor.DefaultValue;
            MaxForce = MaxForceAccessor.DefaultValue;
            MaxTorque = MaxTorqueAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintFriction2DPrefab(ConstraintFriction2D val)
        {
            ID = val.ID;
            Anchor = val.Anchor;
            MaxForce = val.MaxForce;
            MaxTorque = val.MaxTorque;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintFriction2D Create()
        {
            var result = new ConstraintFriction2D();
            AnchorAccessor.Instance.ApplyIfChanged(this, result);
            MaxForceAccessor.Instance.ApplyIfChanged(this, result);
            MaxTorqueAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Anchor":
                    AnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxForce":
                    MaxForceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxTorque":
                    MaxTorqueAccessor.Instance.ParseAndSet(value, this);
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
                yield return AnchorAccessor.Instance;
                yield return MaxForceAccessor.Instance;
                yield return MaxTorqueAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class AnchorAccessor : Vector2Accessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly AnchorAccessor Instance = new AnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.Anchor);
            public override Vector2 GetPrefab(ConstraintFriction2DPrefab instance) { return instance.Anchor; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, Vector2 value) { instance.Anchor = value; }
            public override Vector2 GetUrho(ConstraintFriction2D instance) { return instance.Anchor; }
            public override void SetUrho(ConstraintFriction2D instance, Vector2 value) { instance.Anchor = value; }
        }

        internal class MaxForceAccessor : SingleAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly MaxForceAccessor Instance = new MaxForceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.MaxForce);
            public override float GetPrefab(ConstraintFriction2DPrefab instance) { return instance.MaxForce; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, float value) { instance.MaxForce = value; }
            public override float GetUrho(ConstraintFriction2D instance) { return instance.MaxForce; }
            public override void SetUrho(ConstraintFriction2D instance, float value) { instance.MaxForce = value; }
        }

        internal class MaxTorqueAccessor : SingleAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly MaxTorqueAccessor Instance = new MaxTorqueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.MaxTorque);
            public override float GetPrefab(ConstraintFriction2DPrefab instance) { return instance.MaxTorque; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, float value) { instance.MaxTorque = value; }
            public override float GetUrho(ConstraintFriction2D instance) { return instance.MaxTorque; }
            public override void SetUrho(ConstraintFriction2D instance, float value) { instance.MaxTorque = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintFriction2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintFriction2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintFriction2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.CollideConnected);
            public override bool GetPrefab(ConstraintFriction2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintFriction2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintFriction2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintFriction2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintFriction2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintFriction2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.Enabled);
            public override bool GetPrefab(ConstraintFriction2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintFriction2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintFriction2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintFriction2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintFriction2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintFriction2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.Temporary);
            public override bool GetPrefab(ConstraintFriction2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintFriction2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintFriction2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintFriction2DPrefab, ConstraintFriction2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintFriction2D.BlockEvents);
            public override bool GetPrefab(ConstraintFriction2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintFriction2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintFriction2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintFriction2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
