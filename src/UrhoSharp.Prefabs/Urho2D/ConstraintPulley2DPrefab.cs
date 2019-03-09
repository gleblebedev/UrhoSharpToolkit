using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintPulley2D = Urho.Urho2D.ConstraintPulley2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintPulley2DPrefab: AbstractComponentPrefab<ConstraintPulley2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintPulley2D.TypeNameStatic; } }
        public Vector2 OwnerBodyGroundAnchor { get; set; }
        public Vector2 OtherBodyGroundAnchor { get; set; }
        public Vector2 OwnerBodyAnchor { get; set; }
        public Vector2 OtherBodyAnchor { get; set; }
        public float Ratio { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintPulley2DPrefab()
        {
            OwnerBodyGroundAnchor = OwnerBodyGroundAnchorAccessor.DefaultValue;
            OtherBodyGroundAnchor = OtherBodyGroundAnchorAccessor.DefaultValue;
            OwnerBodyAnchor = OwnerBodyAnchorAccessor.DefaultValue;
            OtherBodyAnchor = OtherBodyAnchorAccessor.DefaultValue;
            Ratio = RatioAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintPulley2DPrefab(ConstraintPulley2D val)
        {
            ID = val.ID;
            OwnerBodyGroundAnchor = val.OwnerBodyGroundAnchor;
            OtherBodyGroundAnchor = val.OtherBodyGroundAnchor;
            OwnerBodyAnchor = val.OwnerBodyAnchor;
            OtherBodyAnchor = val.OtherBodyAnchor;
            Ratio = val.Ratio;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintPulley2D Create()
        {
            var result = new ConstraintPulley2D();
            OwnerBodyGroundAnchorAccessor.Instance.ApplyIfChanged(this, result);
            OtherBodyGroundAnchorAccessor.Instance.ApplyIfChanged(this, result);
            OwnerBodyAnchorAccessor.Instance.ApplyIfChanged(this, result);
            OtherBodyAnchorAccessor.Instance.ApplyIfChanged(this, result);
            RatioAccessor.Instance.ApplyIfChanged(this, result);
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
                case "OwnerBodyGroundAnchor":
                    OwnerBodyGroundAnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherBodyGroundAnchor":
                    OtherBodyGroundAnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OwnerBodyAnchor":
                    OwnerBodyAnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherBodyAnchor":
                    OtherBodyAnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Ratio":
                    RatioAccessor.Instance.ParseAndSet(value, this);
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
                yield return OwnerBodyGroundAnchorAccessor.Instance;
                yield return OtherBodyGroundAnchorAccessor.Instance;
                yield return OwnerBodyAnchorAccessor.Instance;
                yield return OtherBodyAnchorAccessor.Instance;
                yield return RatioAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class OwnerBodyGroundAnchorAccessor : Vector2Accessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly OwnerBodyGroundAnchorAccessor Instance = new OwnerBodyGroundAnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(-1f, 1f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.OwnerBodyGroundAnchor);
            public override Vector2 GetPrefab(ConstraintPulley2DPrefab instance) { return instance.OwnerBodyGroundAnchor; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, Vector2 value) { instance.OwnerBodyGroundAnchor = value; }
            public override Vector2 GetUrho(ConstraintPulley2D instance) { return instance.OwnerBodyGroundAnchor; }
            public override void SetUrho(ConstraintPulley2D instance, Vector2 value) { instance.OwnerBodyGroundAnchor = value; }
        }

        internal class OtherBodyGroundAnchorAccessor : Vector2Accessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly OtherBodyGroundAnchorAccessor Instance = new OtherBodyGroundAnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(1f, 1f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.OtherBodyGroundAnchor);
            public override Vector2 GetPrefab(ConstraintPulley2DPrefab instance) { return instance.OtherBodyGroundAnchor; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, Vector2 value) { instance.OtherBodyGroundAnchor = value; }
            public override Vector2 GetUrho(ConstraintPulley2D instance) { return instance.OtherBodyGroundAnchor; }
            public override void SetUrho(ConstraintPulley2D instance, Vector2 value) { instance.OtherBodyGroundAnchor = value; }
        }

        internal class OwnerBodyAnchorAccessor : Vector2Accessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly OwnerBodyAnchorAccessor Instance = new OwnerBodyAnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(-1f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.OwnerBodyAnchor);
            public override Vector2 GetPrefab(ConstraintPulley2DPrefab instance) { return instance.OwnerBodyAnchor; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, Vector2 value) { instance.OwnerBodyAnchor = value; }
            public override Vector2 GetUrho(ConstraintPulley2D instance) { return instance.OwnerBodyAnchor; }
            public override void SetUrho(ConstraintPulley2D instance, Vector2 value) { instance.OwnerBodyAnchor = value; }
        }

        internal class OtherBodyAnchorAccessor : Vector2Accessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly OtherBodyAnchorAccessor Instance = new OtherBodyAnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(1f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.OtherBodyAnchor);
            public override Vector2 GetPrefab(ConstraintPulley2DPrefab instance) { return instance.OtherBodyAnchor; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, Vector2 value) { instance.OtherBodyAnchor = value; }
            public override Vector2 GetUrho(ConstraintPulley2D instance) { return instance.OtherBodyAnchor; }
            public override void SetUrho(ConstraintPulley2D instance, Vector2 value) { instance.OtherBodyAnchor = value; }
        }

        internal class RatioAccessor : SingleAccessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly RatioAccessor Instance = new RatioAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.Ratio);
            public override float GetPrefab(ConstraintPulley2DPrefab instance) { return instance.Ratio; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, float value) { instance.Ratio = value; }
            public override float GetUrho(ConstraintPulley2D instance) { return instance.Ratio; }
            public override void SetUrho(ConstraintPulley2D instance, float value) { instance.Ratio = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintPulley2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintPulley2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintPulley2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.CollideConnected);
            public override bool GetPrefab(ConstraintPulley2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintPulley2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintPulley2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintPulley2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintPulley2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintPulley2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.Enabled);
            public override bool GetPrefab(ConstraintPulley2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintPulley2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintPulley2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintPulley2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintPulley2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintPulley2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.Temporary);
            public override bool GetPrefab(ConstraintPulley2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintPulley2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintPulley2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintPulley2DPrefab, ConstraintPulley2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPulley2D.BlockEvents);
            public override bool GetPrefab(ConstraintPulley2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintPulley2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintPulley2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintPulley2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
