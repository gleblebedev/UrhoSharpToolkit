using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Constraint2D = Urho.Urho2D.Constraint2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class Constraint2DPrefab: AbstractComponentPrefab<Constraint2D>, IPrefab
    {
        public override string TypeName { get { return Constraint2D.TypeNameStatic; } }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public Constraint2DPrefab()
        {
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public Constraint2DPrefab(Constraint2D val)
        {
            ID = val.ID;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Constraint2D Create()
        {
            var result = new Constraint2D();
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
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<Constraint2DPrefab, Constraint2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint2D.OtherBody);
            public override RigidBody2D GetPrefab(Constraint2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(Constraint2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(Constraint2D instance) { return instance.OtherBody; }
            public override void SetUrho(Constraint2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<Constraint2DPrefab, Constraint2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint2D.CollideConnected);
            public override bool GetPrefab(Constraint2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(Constraint2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(Constraint2D instance) { return instance.CollideConnected; }
            public override void SetUrho(Constraint2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<Constraint2DPrefab, Constraint2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint2D.AttachedConstraint);
            public override Constraint2D GetPrefab(Constraint2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(Constraint2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(Constraint2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(Constraint2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<Constraint2DPrefab, Constraint2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint2D.Enabled);
            public override bool GetPrefab(Constraint2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(Constraint2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Constraint2D instance) { return instance.Enabled; }
            public override void SetUrho(Constraint2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<Constraint2DPrefab, Constraint2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint2D.AnimationEnabled);
            public override bool GetPrefab(Constraint2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(Constraint2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Constraint2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Constraint2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<Constraint2DPrefab, Constraint2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint2D.Temporary);
            public override bool GetPrefab(Constraint2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(Constraint2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Constraint2D instance) { return instance.Temporary; }
            public override void SetUrho(Constraint2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<Constraint2DPrefab, Constraint2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint2D.BlockEvents);
            public override bool GetPrefab(Constraint2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(Constraint2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Constraint2D instance) { return instance.BlockEvents; }
            public override void SetUrho(Constraint2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
