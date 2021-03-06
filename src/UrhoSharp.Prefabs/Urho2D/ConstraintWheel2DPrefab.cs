using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintWheel2D = Urho.Urho2D.ConstraintWheel2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintWheel2DPrefab: AbstractComponentPrefab<ConstraintWheel2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintWheel2D.TypeNameStatic; } }
        public Vector2 Anchor { get; set; }
        public Vector2 Axis { get; set; }
        public bool EnableMotor { get; set; }
        public float MaxMotorTorque { get; set; }
        public float MotorSpeed { get; set; }
        public float FrequencyHz { get; set; }
        public float DampingRatio { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintWheel2DPrefab()
        {
            Anchor = AnchorAccessor.DefaultValue;
            Axis = AxisAccessor.DefaultValue;
            EnableMotor = EnableMotorAccessor.DefaultValue;
            MaxMotorTorque = MaxMotorTorqueAccessor.DefaultValue;
            MotorSpeed = MotorSpeedAccessor.DefaultValue;
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
        public ConstraintWheel2DPrefab(ConstraintWheel2D val)
        {
            ID = val.ID;
            Anchor = val.Anchor;
            Axis = val.Axis;
            EnableMotor = val.EnableMotor;
            MaxMotorTorque = val.MaxMotorTorque;
            MotorSpeed = val.MotorSpeed;
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
        public override ConstraintWheel2D Create()
        {
            var result = new ConstraintWheel2D();
            AnchorAccessor.Instance.ApplyIfChanged(this, result);
            AxisAccessor.Instance.ApplyIfChanged(this, result);
            EnableMotorAccessor.Instance.ApplyIfChanged(this, result);
            MaxMotorTorqueAccessor.Instance.ApplyIfChanged(this, result);
            MotorSpeedAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Anchor":
                    AnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Axis":
                    AxisAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EnableMotor":
                    EnableMotorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxMotorTorque":
                    MaxMotorTorqueAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MotorSpeed":
                    MotorSpeedAccessor.Instance.ParseAndSet(value, this);
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
                yield return AnchorAccessor.Instance;
                yield return AxisAccessor.Instance;
                yield return EnableMotorAccessor.Instance;
                yield return MaxMotorTorqueAccessor.Instance;
                yield return MotorSpeedAccessor.Instance;
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

        internal class AnchorAccessor : Vector2Accessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly AnchorAccessor Instance = new AnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.Anchor);
            public override Vector2 GetPrefab(ConstraintWheel2DPrefab instance) { return instance.Anchor; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, Vector2 value) { instance.Anchor = value; }
            public override Vector2 GetUrho(ConstraintWheel2D instance) { return instance.Anchor; }
            public override void SetUrho(ConstraintWheel2D instance, Vector2 value) { instance.Anchor = value; }
        }

        internal class AxisAccessor : Vector2Accessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly AxisAccessor Instance = new AxisAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(1f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.Axis);
            public override Vector2 GetPrefab(ConstraintWheel2DPrefab instance) { return instance.Axis; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, Vector2 value) { instance.Axis = value; }
            public override Vector2 GetUrho(ConstraintWheel2D instance) { return instance.Axis; }
            public override void SetUrho(ConstraintWheel2D instance, Vector2 value) { instance.Axis = value; }
        }

        internal class EnableMotorAccessor : BooleanAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly EnableMotorAccessor Instance = new EnableMotorAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.EnableMotor);
            public override bool GetPrefab(ConstraintWheel2DPrefab instance) { return instance.EnableMotor; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, bool value) { instance.EnableMotor = value; }
            public override bool GetUrho(ConstraintWheel2D instance) { return instance.EnableMotor; }
            public override void SetUrho(ConstraintWheel2D instance, bool value) { instance.EnableMotor = value; }
        }

        internal class MaxMotorTorqueAccessor : SingleAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly MaxMotorTorqueAccessor Instance = new MaxMotorTorqueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.MaxMotorTorque);
            public override float GetPrefab(ConstraintWheel2DPrefab instance) { return instance.MaxMotorTorque; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, float value) { instance.MaxMotorTorque = value; }
            public override float GetUrho(ConstraintWheel2D instance) { return instance.MaxMotorTorque; }
            public override void SetUrho(ConstraintWheel2D instance, float value) { instance.MaxMotorTorque = value; }
        }

        internal class MotorSpeedAccessor : SingleAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly MotorSpeedAccessor Instance = new MotorSpeedAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.MotorSpeed);
            public override float GetPrefab(ConstraintWheel2DPrefab instance) { return instance.MotorSpeed; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, float value) { instance.MotorSpeed = value; }
            public override float GetUrho(ConstraintWheel2D instance) { return instance.MotorSpeed; }
            public override void SetUrho(ConstraintWheel2D instance, float value) { instance.MotorSpeed = value; }
        }

        internal class FrequencyHzAccessor : SingleAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly FrequencyHzAccessor Instance = new FrequencyHzAccessor();
            public static readonly float DefaultValue = 2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.FrequencyHz);
            public override float GetPrefab(ConstraintWheel2DPrefab instance) { return instance.FrequencyHz; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, float value) { instance.FrequencyHz = value; }
            public override float GetUrho(ConstraintWheel2D instance) { return instance.FrequencyHz; }
            public override void SetUrho(ConstraintWheel2D instance, float value) { instance.FrequencyHz = value; }
        }

        internal class DampingRatioAccessor : SingleAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly DampingRatioAccessor Instance = new DampingRatioAccessor();
            public static readonly float DefaultValue = 0.7f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.DampingRatio);
            public override float GetPrefab(ConstraintWheel2DPrefab instance) { return instance.DampingRatio; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, float value) { instance.DampingRatio = value; }
            public override float GetUrho(ConstraintWheel2D instance) { return instance.DampingRatio; }
            public override void SetUrho(ConstraintWheel2D instance, float value) { instance.DampingRatio = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintWheel2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintWheel2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintWheel2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.CollideConnected);
            public override bool GetPrefab(ConstraintWheel2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintWheel2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintWheel2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintWheel2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintWheel2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintWheel2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.Enabled);
            public override bool GetPrefab(ConstraintWheel2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintWheel2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintWheel2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintWheel2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintWheel2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintWheel2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.Temporary);
            public override bool GetPrefab(ConstraintWheel2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintWheel2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintWheel2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintWheel2DPrefab, ConstraintWheel2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintWheel2D.BlockEvents);
            public override bool GetPrefab(ConstraintWheel2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintWheel2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintWheel2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintWheel2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
