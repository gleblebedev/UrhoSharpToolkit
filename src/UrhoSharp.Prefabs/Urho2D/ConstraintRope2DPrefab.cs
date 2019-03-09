using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintRope2D = Urho.Urho2D.ConstraintRope2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintRope2DPrefab: AbstractComponentPrefab<ConstraintRope2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintRope2D.TypeNameStatic; } }
        public Vector2 OwnerBodyAnchor { get; set; }
        public Vector2 OtherBodyAnchor { get; set; }
        public float MaxLength { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintRope2DPrefab()
        {
            OwnerBodyAnchor = OwnerBodyAnchorAccessor.DefaultValue;
            OtherBodyAnchor = OtherBodyAnchorAccessor.DefaultValue;
            MaxLength = MaxLengthAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintRope2DPrefab(ConstraintRope2D val)
        {
            ID = val.ID;
            OwnerBodyAnchor = val.OwnerBodyAnchor;
            OtherBodyAnchor = val.OtherBodyAnchor;
            MaxLength = val.MaxLength;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintRope2D Create()
        {
            var result = new ConstraintRope2D();
            OwnerBodyAnchorAccessor.Instance.ApplyIfChanged(this, result);
            OtherBodyAnchorAccessor.Instance.ApplyIfChanged(this, result);
            MaxLengthAccessor.Instance.ApplyIfChanged(this, result);
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
                case "OwnerBodyAnchor":
                    OwnerBodyAnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherBodyAnchor":
                    OtherBodyAnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxLength":
                    MaxLengthAccessor.Instance.ParseAndSet(value, this);
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
                yield return OwnerBodyAnchorAccessor.Instance;
                yield return OtherBodyAnchorAccessor.Instance;
                yield return MaxLengthAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class OwnerBodyAnchorAccessor : Vector2Accessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly OwnerBodyAnchorAccessor Instance = new OwnerBodyAnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.OwnerBodyAnchor);
            public override Vector2 GetPrefab(ConstraintRope2DPrefab instance) { return instance.OwnerBodyAnchor; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, Vector2 value) { instance.OwnerBodyAnchor = value; }
            public override Vector2 GetUrho(ConstraintRope2D instance) { return instance.OwnerBodyAnchor; }
            public override void SetUrho(ConstraintRope2D instance, Vector2 value) { instance.OwnerBodyAnchor = value; }
        }

        internal class OtherBodyAnchorAccessor : Vector2Accessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly OtherBodyAnchorAccessor Instance = new OtherBodyAnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.OtherBodyAnchor);
            public override Vector2 GetPrefab(ConstraintRope2DPrefab instance) { return instance.OtherBodyAnchor; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, Vector2 value) { instance.OtherBodyAnchor = value; }
            public override Vector2 GetUrho(ConstraintRope2D instance) { return instance.OtherBodyAnchor; }
            public override void SetUrho(ConstraintRope2D instance, Vector2 value) { instance.OtherBodyAnchor = value; }
        }

        internal class MaxLengthAccessor : SingleAccessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly MaxLengthAccessor Instance = new MaxLengthAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.MaxLength);
            public override float GetPrefab(ConstraintRope2DPrefab instance) { return instance.MaxLength; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, float value) { instance.MaxLength = value; }
            public override float GetUrho(ConstraintRope2D instance) { return instance.MaxLength; }
            public override void SetUrho(ConstraintRope2D instance, float value) { instance.MaxLength = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintRope2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintRope2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintRope2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.CollideConnected);
            public override bool GetPrefab(ConstraintRope2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintRope2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintRope2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintRope2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintRope2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintRope2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.Enabled);
            public override bool GetPrefab(ConstraintRope2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintRope2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintRope2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintRope2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintRope2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintRope2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.Temporary);
            public override bool GetPrefab(ConstraintRope2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintRope2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintRope2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintRope2DPrefab, ConstraintRope2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRope2D.BlockEvents);
            public override bool GetPrefab(ConstraintRope2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintRope2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintRope2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintRope2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
