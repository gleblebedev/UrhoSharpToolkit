using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintMotor2D = Urho.Urho2D.ConstraintMotor2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintMotor2DPrefab: AbstractComponentPrefab<ConstraintMotor2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintMotor2D.TypeNameStatic; } }
        public Vector2 LinearOffset { get; set; }
        public float AngularOffset { get; set; }
        public float MaxForce { get; set; }
        public float MaxTorque { get; set; }
        public float CorrectionFactor { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintMotor2DPrefab()
        {
            LinearOffset = LinearOffsetAccessor.DefaultValue;
            AngularOffset = AngularOffsetAccessor.DefaultValue;
            MaxForce = MaxForceAccessor.DefaultValue;
            MaxTorque = MaxTorqueAccessor.DefaultValue;
            CorrectionFactor = CorrectionFactorAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintMotor2DPrefab(ConstraintMotor2D val)
        {
            ID = val.ID;
            LinearOffset = val.LinearOffset;
            AngularOffset = val.AngularOffset;
            MaxForce = val.MaxForce;
            MaxTorque = val.MaxTorque;
            CorrectionFactor = val.CorrectionFactor;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintMotor2D Create()
        {
            var result = new ConstraintMotor2D();
            LinearOffsetAccessor.Instance.ApplyIfChanged(this, result);
            AngularOffsetAccessor.Instance.ApplyIfChanged(this, result);
            MaxForceAccessor.Instance.ApplyIfChanged(this, result);
            MaxTorqueAccessor.Instance.ApplyIfChanged(this, result);
            CorrectionFactorAccessor.Instance.ApplyIfChanged(this, result);
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
                case "LinearOffset":
                    LinearOffsetAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AngularOffset":
                    AngularOffsetAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxForce":
                    MaxForceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxTorque":
                    MaxTorqueAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CorrectionFactor":
                    CorrectionFactorAccessor.Instance.ParseAndSet(value, this);
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
                yield return LinearOffsetAccessor.Instance;
                yield return AngularOffsetAccessor.Instance;
                yield return MaxForceAccessor.Instance;
                yield return MaxTorqueAccessor.Instance;
                yield return CorrectionFactorAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class LinearOffsetAccessor : Vector2Accessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly LinearOffsetAccessor Instance = new LinearOffsetAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.LinearOffset);
            public override Vector2 GetPrefab(ConstraintMotor2DPrefab instance) { return instance.LinearOffset; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, Vector2 value) { instance.LinearOffset = value; }
            public override Vector2 GetUrho(ConstraintMotor2D instance) { return instance.LinearOffset; }
            public override void SetUrho(ConstraintMotor2D instance, Vector2 value) { instance.LinearOffset = value; }
        }

        internal class AngularOffsetAccessor : SingleAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly AngularOffsetAccessor Instance = new AngularOffsetAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.AngularOffset);
            public override float GetPrefab(ConstraintMotor2DPrefab instance) { return instance.AngularOffset; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, float value) { instance.AngularOffset = value; }
            public override float GetUrho(ConstraintMotor2D instance) { return instance.AngularOffset; }
            public override void SetUrho(ConstraintMotor2D instance, float value) { instance.AngularOffset = value; }
        }

        internal class MaxForceAccessor : SingleAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly MaxForceAccessor Instance = new MaxForceAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.MaxForce);
            public override float GetPrefab(ConstraintMotor2DPrefab instance) { return instance.MaxForce; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, float value) { instance.MaxForce = value; }
            public override float GetUrho(ConstraintMotor2D instance) { return instance.MaxForce; }
            public override void SetUrho(ConstraintMotor2D instance, float value) { instance.MaxForce = value; }
        }

        internal class MaxTorqueAccessor : SingleAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly MaxTorqueAccessor Instance = new MaxTorqueAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.MaxTorque);
            public override float GetPrefab(ConstraintMotor2DPrefab instance) { return instance.MaxTorque; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, float value) { instance.MaxTorque = value; }
            public override float GetUrho(ConstraintMotor2D instance) { return instance.MaxTorque; }
            public override void SetUrho(ConstraintMotor2D instance, float value) { instance.MaxTorque = value; }
        }

        internal class CorrectionFactorAccessor : SingleAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly CorrectionFactorAccessor Instance = new CorrectionFactorAccessor();
            public static readonly float DefaultValue = 0.3f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.CorrectionFactor);
            public override float GetPrefab(ConstraintMotor2DPrefab instance) { return instance.CorrectionFactor; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, float value) { instance.CorrectionFactor = value; }
            public override float GetUrho(ConstraintMotor2D instance) { return instance.CorrectionFactor; }
            public override void SetUrho(ConstraintMotor2D instance, float value) { instance.CorrectionFactor = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintMotor2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintMotor2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintMotor2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.CollideConnected);
            public override bool GetPrefab(ConstraintMotor2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintMotor2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintMotor2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintMotor2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintMotor2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintMotor2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.Enabled);
            public override bool GetPrefab(ConstraintMotor2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintMotor2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintMotor2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintMotor2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintMotor2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintMotor2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.Temporary);
            public override bool GetPrefab(ConstraintMotor2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintMotor2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintMotor2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintMotor2DPrefab, ConstraintMotor2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintMotor2D.BlockEvents);
            public override bool GetPrefab(ConstraintMotor2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintMotor2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintMotor2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintMotor2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
