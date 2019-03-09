using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintPrismatic2D = Urho.Urho2D.ConstraintPrismatic2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintPrismatic2DPrefab: AbstractComponentPrefab<ConstraintPrismatic2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintPrismatic2D.TypeNameStatic; } }
        public Vector2 Anchor { get; set; }
        public Vector2 Axis { get; set; }
        public bool EnableLimit { get; set; }
        public float LowerTranslation { get; set; }
        public float UpperTranslation { get; set; }
        public bool EnableMotor { get; set; }
        public float MaxMotorForce { get; set; }
        public float MotorSpeed { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintPrismatic2DPrefab()
        {
            Anchor = AnchorAccessor.DefaultValue;
            Axis = AxisAccessor.DefaultValue;
            EnableLimit = EnableLimitAccessor.DefaultValue;
            LowerTranslation = LowerTranslationAccessor.DefaultValue;
            UpperTranslation = UpperTranslationAccessor.DefaultValue;
            EnableMotor = EnableMotorAccessor.DefaultValue;
            MaxMotorForce = MaxMotorForceAccessor.DefaultValue;
            MotorSpeed = MotorSpeedAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintPrismatic2DPrefab(ConstraintPrismatic2D val)
        {
            ID = val.ID;
            Anchor = val.Anchor;
            Axis = val.Axis;
            EnableLimit = val.EnableLimit;
            LowerTranslation = val.LowerTranslation;
            UpperTranslation = val.UpperTranslation;
            EnableMotor = val.EnableMotor;
            MaxMotorForce = val.MaxMotorForce;
            MotorSpeed = val.MotorSpeed;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintPrismatic2D Create()
        {
            var result = new ConstraintPrismatic2D();
            AnchorAccessor.Instance.ApplyIfChanged(this, result);
            AxisAccessor.Instance.ApplyIfChanged(this, result);
            EnableLimitAccessor.Instance.ApplyIfChanged(this, result);
            LowerTranslationAccessor.Instance.ApplyIfChanged(this, result);
            UpperTranslationAccessor.Instance.ApplyIfChanged(this, result);
            EnableMotorAccessor.Instance.ApplyIfChanged(this, result);
            MaxMotorForceAccessor.Instance.ApplyIfChanged(this, result);
            MotorSpeedAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Axis":
                    AxisAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EnableLimit":
                    EnableLimitAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LowerTranslation":
                    LowerTranslationAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UpperTranslation":
                    UpperTranslationAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EnableMotor":
                    EnableMotorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxMotorForce":
                    MaxMotorForceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MotorSpeed":
                    MotorSpeedAccessor.Instance.ParseAndSet(value, this);
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
                yield return AxisAccessor.Instance;
                yield return EnableLimitAccessor.Instance;
                yield return LowerTranslationAccessor.Instance;
                yield return UpperTranslationAccessor.Instance;
                yield return EnableMotorAccessor.Instance;
                yield return MaxMotorForceAccessor.Instance;
                yield return MotorSpeedAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class AnchorAccessor : Vector2Accessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly AnchorAccessor Instance = new AnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.Anchor);
            public override Vector2 GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.Anchor; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, Vector2 value) { instance.Anchor = value; }
            public override Vector2 GetUrho(ConstraintPrismatic2D instance) { return instance.Anchor; }
            public override void SetUrho(ConstraintPrismatic2D instance, Vector2 value) { instance.Anchor = value; }
        }

        internal class AxisAccessor : Vector2Accessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly AxisAccessor Instance = new AxisAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(1f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.Axis);
            public override Vector2 GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.Axis; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, Vector2 value) { instance.Axis = value; }
            public override Vector2 GetUrho(ConstraintPrismatic2D instance) { return instance.Axis; }
            public override void SetUrho(ConstraintPrismatic2D instance, Vector2 value) { instance.Axis = value; }
        }

        internal class EnableLimitAccessor : BooleanAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly EnableLimitAccessor Instance = new EnableLimitAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.EnableLimit);
            public override bool GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.EnableLimit; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, bool value) { instance.EnableLimit = value; }
            public override bool GetUrho(ConstraintPrismatic2D instance) { return instance.EnableLimit; }
            public override void SetUrho(ConstraintPrismatic2D instance, bool value) { instance.EnableLimit = value; }
        }

        internal class LowerTranslationAccessor : SingleAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly LowerTranslationAccessor Instance = new LowerTranslationAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.LowerTranslation);
            public override float GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.LowerTranslation; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, float value) { instance.LowerTranslation = value; }
            public override float GetUrho(ConstraintPrismatic2D instance) { return instance.LowerTranslation; }
            public override void SetUrho(ConstraintPrismatic2D instance, float value) { instance.LowerTranslation = value; }
        }

        internal class UpperTranslationAccessor : SingleAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly UpperTranslationAccessor Instance = new UpperTranslationAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.UpperTranslation);
            public override float GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.UpperTranslation; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, float value) { instance.UpperTranslation = value; }
            public override float GetUrho(ConstraintPrismatic2D instance) { return instance.UpperTranslation; }
            public override void SetUrho(ConstraintPrismatic2D instance, float value) { instance.UpperTranslation = value; }
        }

        internal class EnableMotorAccessor : BooleanAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly EnableMotorAccessor Instance = new EnableMotorAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.EnableMotor);
            public override bool GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.EnableMotor; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, bool value) { instance.EnableMotor = value; }
            public override bool GetUrho(ConstraintPrismatic2D instance) { return instance.EnableMotor; }
            public override void SetUrho(ConstraintPrismatic2D instance, bool value) { instance.EnableMotor = value; }
        }

        internal class MaxMotorForceAccessor : SingleAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly MaxMotorForceAccessor Instance = new MaxMotorForceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.MaxMotorForce);
            public override float GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.MaxMotorForce; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, float value) { instance.MaxMotorForce = value; }
            public override float GetUrho(ConstraintPrismatic2D instance) { return instance.MaxMotorForce; }
            public override void SetUrho(ConstraintPrismatic2D instance, float value) { instance.MaxMotorForce = value; }
        }

        internal class MotorSpeedAccessor : SingleAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly MotorSpeedAccessor Instance = new MotorSpeedAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.MotorSpeed);
            public override float GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.MotorSpeed; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, float value) { instance.MotorSpeed = value; }
            public override float GetUrho(ConstraintPrismatic2D instance) { return instance.MotorSpeed; }
            public override void SetUrho(ConstraintPrismatic2D instance, float value) { instance.MotorSpeed = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintPrismatic2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintPrismatic2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.CollideConnected);
            public override bool GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintPrismatic2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintPrismatic2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintPrismatic2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintPrismatic2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.Enabled);
            public override bool GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintPrismatic2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintPrismatic2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintPrismatic2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintPrismatic2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.Temporary);
            public override bool GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintPrismatic2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintPrismatic2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintPrismatic2DPrefab, ConstraintPrismatic2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintPrismatic2D.BlockEvents);
            public override bool GetPrefab(ConstraintPrismatic2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintPrismatic2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintPrismatic2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintPrismatic2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
