using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintGear2D = Urho.Urho2D.ConstraintGear2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintGear2DPrefab: AbstractComponentPrefab<ConstraintGear2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintGear2D.TypeNameStatic; } }
        public Constraint2D OwnerConstraint { get; set; }
        public Constraint2D OtherConstraint { get; set; }
        public float Ratio { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintGear2DPrefab()
        {
            OwnerConstraint = OwnerConstraintAccessor.DefaultValue;
            OtherConstraint = OtherConstraintAccessor.DefaultValue;
            Ratio = RatioAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintGear2DPrefab(ConstraintGear2D val)
        {
            ID = val.ID;
            OwnerConstraint = val.OwnerConstraint;
            OtherConstraint = val.OtherConstraint;
            Ratio = val.Ratio;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintGear2D Create()
        {
            var result = new ConstraintGear2D();
            OwnerConstraintAccessor.Instance.ApplyIfChanged(this, result);
            OtherConstraintAccessor.Instance.ApplyIfChanged(this, result);
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
                case "OwnerConstraint":
                    OwnerConstraintAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherConstraint":
                    OtherConstraintAccessor.Instance.ParseAndSet(value, this);
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
                yield return OwnerConstraintAccessor.Instance;
                yield return OtherConstraintAccessor.Instance;
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

        internal class OwnerConstraintAccessor : Constraint2DAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly OwnerConstraintAccessor Instance = new OwnerConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.OwnerConstraint);
            public override Constraint2D GetPrefab(ConstraintGear2DPrefab instance) { return instance.OwnerConstraint; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, Constraint2D value) { instance.OwnerConstraint = value; }
            public override Constraint2D GetUrho(ConstraintGear2D instance) { return instance.OwnerConstraint; }
            public override void SetUrho(ConstraintGear2D instance, Constraint2D value) { instance.OwnerConstraint = value; }
        }

        internal class OtherConstraintAccessor : Constraint2DAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly OtherConstraintAccessor Instance = new OtherConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.OtherConstraint);
            public override Constraint2D GetPrefab(ConstraintGear2DPrefab instance) { return instance.OtherConstraint; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, Constraint2D value) { instance.OtherConstraint = value; }
            public override Constraint2D GetUrho(ConstraintGear2D instance) { return instance.OtherConstraint; }
            public override void SetUrho(ConstraintGear2D instance, Constraint2D value) { instance.OtherConstraint = value; }
        }

        internal class RatioAccessor : SingleAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly RatioAccessor Instance = new RatioAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.Ratio);
            public override float GetPrefab(ConstraintGear2DPrefab instance) { return instance.Ratio; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, float value) { instance.Ratio = value; }
            public override float GetUrho(ConstraintGear2D instance) { return instance.Ratio; }
            public override void SetUrho(ConstraintGear2D instance, float value) { instance.Ratio = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintGear2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintGear2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintGear2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.CollideConnected);
            public override bool GetPrefab(ConstraintGear2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintGear2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintGear2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintGear2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintGear2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintGear2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.Enabled);
            public override bool GetPrefab(ConstraintGear2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintGear2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintGear2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintGear2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintGear2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintGear2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.Temporary);
            public override bool GetPrefab(ConstraintGear2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintGear2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintGear2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintGear2DPrefab, ConstraintGear2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintGear2D.BlockEvents);
            public override bool GetPrefab(ConstraintGear2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintGear2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintGear2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintGear2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
