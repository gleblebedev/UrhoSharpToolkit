using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintRevolute2D = Urho.Urho2D.ConstraintRevolute2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintRevolute2DPrefab: AbstractComponentPrefab<ConstraintRevolute2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintRevolute2D.TypeNameStatic; } }
        public Vector2 Anchor { get; set; }
        public bool EnableLimit { get; set; }
        public float LowerAngle { get; set; }
        public float UpperAngle { get; set; }
        public bool EnableMotor { get; set; }
        public float MotorSpeed { get; set; }
        public float MaxMotorTorque { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintRevolute2DPrefab()
        {
            Anchor = AnchorAccessor.DefaultValue;
            EnableLimit = EnableLimitAccessor.DefaultValue;
            LowerAngle = LowerAngleAccessor.DefaultValue;
            UpperAngle = UpperAngleAccessor.DefaultValue;
            EnableMotor = EnableMotorAccessor.DefaultValue;
            MotorSpeed = MotorSpeedAccessor.DefaultValue;
            MaxMotorTorque = MaxMotorTorqueAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintRevolute2DPrefab(ConstraintRevolute2D val)
        {
            ID = val.ID;
            Anchor = val.Anchor;
            EnableLimit = val.EnableLimit;
            LowerAngle = val.LowerAngle;
            UpperAngle = val.UpperAngle;
            EnableMotor = val.EnableMotor;
            MotorSpeed = val.MotorSpeed;
            MaxMotorTorque = val.MaxMotorTorque;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintRevolute2D Create()
        {
            var result = new ConstraintRevolute2D();
            AnchorAccessor.Instance.ApplyIfChanged(this, result);
            EnableLimitAccessor.Instance.ApplyIfChanged(this, result);
            LowerAngleAccessor.Instance.ApplyIfChanged(this, result);
            UpperAngleAccessor.Instance.ApplyIfChanged(this, result);
            EnableMotorAccessor.Instance.ApplyIfChanged(this, result);
            MotorSpeedAccessor.Instance.ApplyIfChanged(this, result);
            MaxMotorTorqueAccessor.Instance.ApplyIfChanged(this, result);
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
                case "EnableLimit":
                    EnableLimitAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LowerAngle":
                    LowerAngleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UpperAngle":
                    UpperAngleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EnableMotor":
                    EnableMotorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MotorSpeed":
                    MotorSpeedAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxMotorTorque":
                    MaxMotorTorqueAccessor.Instance.ParseAndSet(value, this);
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
                yield return EnableLimitAccessor.Instance;
                yield return LowerAngleAccessor.Instance;
                yield return UpperAngleAccessor.Instance;
                yield return EnableMotorAccessor.Instance;
                yield return MotorSpeedAccessor.Instance;
                yield return MaxMotorTorqueAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class AnchorAccessor : Vector2Accessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly AnchorAccessor Instance = new AnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.Anchor);
            public override Vector2 GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.Anchor; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, Vector2 value) { instance.Anchor = value; }
            public override Vector2 GetUrho(ConstraintRevolute2D instance) { return instance.Anchor; }
            public override void SetUrho(ConstraintRevolute2D instance, Vector2 value) { instance.Anchor = value; }
        }

        internal class EnableLimitAccessor : BooleanAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly EnableLimitAccessor Instance = new EnableLimitAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.EnableLimit);
            public override bool GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.EnableLimit; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, bool value) { instance.EnableLimit = value; }
            public override bool GetUrho(ConstraintRevolute2D instance) { return instance.EnableLimit; }
            public override void SetUrho(ConstraintRevolute2D instance, bool value) { instance.EnableLimit = value; }
        }

        internal class LowerAngleAccessor : SingleAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly LowerAngleAccessor Instance = new LowerAngleAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.LowerAngle);
            public override float GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.LowerAngle; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, float value) { instance.LowerAngle = value; }
            public override float GetUrho(ConstraintRevolute2D instance) { return instance.LowerAngle; }
            public override void SetUrho(ConstraintRevolute2D instance, float value) { instance.LowerAngle = value; }
        }

        internal class UpperAngleAccessor : SingleAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly UpperAngleAccessor Instance = new UpperAngleAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.UpperAngle);
            public override float GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.UpperAngle; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, float value) { instance.UpperAngle = value; }
            public override float GetUrho(ConstraintRevolute2D instance) { return instance.UpperAngle; }
            public override void SetUrho(ConstraintRevolute2D instance, float value) { instance.UpperAngle = value; }
        }

        internal class EnableMotorAccessor : BooleanAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly EnableMotorAccessor Instance = new EnableMotorAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.EnableMotor);
            public override bool GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.EnableMotor; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, bool value) { instance.EnableMotor = value; }
            public override bool GetUrho(ConstraintRevolute2D instance) { return instance.EnableMotor; }
            public override void SetUrho(ConstraintRevolute2D instance, bool value) { instance.EnableMotor = value; }
        }

        internal class MotorSpeedAccessor : SingleAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly MotorSpeedAccessor Instance = new MotorSpeedAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.MotorSpeed);
            public override float GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.MotorSpeed; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, float value) { instance.MotorSpeed = value; }
            public override float GetUrho(ConstraintRevolute2D instance) { return instance.MotorSpeed; }
            public override void SetUrho(ConstraintRevolute2D instance, float value) { instance.MotorSpeed = value; }
        }

        internal class MaxMotorTorqueAccessor : SingleAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly MaxMotorTorqueAccessor Instance = new MaxMotorTorqueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.MaxMotorTorque);
            public override float GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.MaxMotorTorque; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, float value) { instance.MaxMotorTorque = value; }
            public override float GetUrho(ConstraintRevolute2D instance) { return instance.MaxMotorTorque; }
            public override void SetUrho(ConstraintRevolute2D instance, float value) { instance.MaxMotorTorque = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintRevolute2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintRevolute2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.CollideConnected);
            public override bool GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintRevolute2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintRevolute2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintRevolute2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintRevolute2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.Enabled);
            public override bool GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintRevolute2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintRevolute2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintRevolute2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintRevolute2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.Temporary);
            public override bool GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintRevolute2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintRevolute2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintRevolute2DPrefab, ConstraintRevolute2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintRevolute2D.BlockEvents);
            public override bool GetPrefab(ConstraintRevolute2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintRevolute2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintRevolute2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintRevolute2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
