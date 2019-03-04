using System;
using System.Xml.Linq;
using Urho;
using ConstraintRevolute2D = Urho.Urho2D.ConstraintRevolute2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class ConstraintRevolute2DPrefab: AbstractComponentPrefab<ConstraintRevolute2D>, IPrefab
    {
        private static  Vector2 AnchorDefaultValue = new Vector2(0f, 0f);
        private static  bool EnableLimitDefaultValue = false;
        private static  float LowerAngleDefaultValue = 0f;
        private static  float UpperAngleDefaultValue = 0f;
        private static  bool EnableMotorDefaultValue = false;
        private static  float MotorSpeedDefaultValue = 0f;
        private static  float MaxMotorTorqueDefaultValue = 0f;
        private static  RigidBody2D OtherBodyDefaultValue = null;
        private static  bool CollideConnectedDefaultValue = false;
        private static  Constraint2D AttachedConstraintDefaultValue = null;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector2 _anchor;
        private bool _enableLimit;
        private float _lowerAngle;
        private float _upperAngle;
        private bool _enableMotor;
        private float _motorSpeed;
        private float _maxMotorTorque;
        private RigidBody2D _otherBody;
        private bool _collideConnected;
        private Constraint2D _attachedConstraint;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public ConstraintRevolute2DPrefab()
        {
            _anchor = AnchorDefaultValue;
            _enableLimit = EnableLimitDefaultValue;
            _lowerAngle = LowerAngleDefaultValue;
            _upperAngle = UpperAngleDefaultValue;
            _enableMotor = EnableMotorDefaultValue;
            _motorSpeed = MotorSpeedDefaultValue;
            _maxMotorTorque = MaxMotorTorqueDefaultValue;
            _otherBody = OtherBodyDefaultValue;
            _collideConnected = CollideConnectedDefaultValue;
            _attachedConstraint = AttachedConstraintDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public ConstraintRevolute2DPrefab(ConstraintRevolute2D val)
        {
            _anchor = val.Anchor;
            _enableLimit = val.EnableLimit;
            _lowerAngle = val.LowerAngle;
            _upperAngle = val.UpperAngle;
            _enableMotor = val.EnableMotor;
            _motorSpeed = val.MotorSpeed;
            _maxMotorTorque = val.MaxMotorTorque;
            _otherBody = val.OtherBody;
            _collideConnected = val.CollideConnected;
            _attachedConstraint = val.AttachedConstraint;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Vector2 Anchor {get { return _anchor;} set { _anchor=value; } }
        public bool AnchorHasValue {get { return !PrefabUtils.AreEqual(ref _anchor, ref AnchorDefaultValue); } }
        public bool EnableLimit {get { return _enableLimit;} set { _enableLimit=value; } }
        public bool EnableLimitHasValue {get { return !PrefabUtils.AreEqual(ref _enableLimit, ref EnableLimitDefaultValue); } }
        public float LowerAngle {get { return _lowerAngle;} set { _lowerAngle=value; } }
        public bool LowerAngleHasValue {get { return !PrefabUtils.AreEqual(ref _lowerAngle, ref LowerAngleDefaultValue); } }
        public float UpperAngle {get { return _upperAngle;} set { _upperAngle=value; } }
        public bool UpperAngleHasValue {get { return !PrefabUtils.AreEqual(ref _upperAngle, ref UpperAngleDefaultValue); } }
        public bool EnableMotor {get { return _enableMotor;} set { _enableMotor=value; } }
        public bool EnableMotorHasValue {get { return !PrefabUtils.AreEqual(ref _enableMotor, ref EnableMotorDefaultValue); } }
        public float MotorSpeed {get { return _motorSpeed;} set { _motorSpeed=value; } }
        public bool MotorSpeedHasValue {get { return !PrefabUtils.AreEqual(ref _motorSpeed, ref MotorSpeedDefaultValue); } }
        public float MaxMotorTorque {get { return _maxMotorTorque;} set { _maxMotorTorque=value; } }
        public bool MaxMotorTorqueHasValue {get { return !PrefabUtils.AreEqual(ref _maxMotorTorque, ref MaxMotorTorqueDefaultValue); } }
        public RigidBody2D OtherBody {get { return _otherBody;} set { _otherBody=value; } }
        public bool OtherBodyHasValue {get { return !PrefabUtils.AreEqual(ref _otherBody, ref OtherBodyDefaultValue); } }
        public bool CollideConnected {get { return _collideConnected;} set { _collideConnected=value; } }
        public bool CollideConnectedHasValue {get { return !PrefabUtils.AreEqual(ref _collideConnected, ref CollideConnectedDefaultValue); } }
        public Constraint2D AttachedConstraint {get { return _attachedConstraint;} set { _attachedConstraint=value; } }
        public bool AttachedConstraintHasValue {get { return !PrefabUtils.AreEqual(ref _attachedConstraint, ref AttachedConstraintDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override ConstraintRevolute2D Create()
        {
            var result = new ConstraintRevolute2D();
            if(AnchorHasValue)
                result.Anchor = _anchor;
            if(EnableLimitHasValue)
                result.EnableLimit = _enableLimit;
            if(LowerAngleHasValue)
                result.LowerAngle = _lowerAngle;
            if(UpperAngleHasValue)
                result.UpperAngle = _upperAngle;
            if(EnableMotorHasValue)
                result.EnableMotor = _enableMotor;
            if(MotorSpeedHasValue)
                result.MotorSpeed = _motorSpeed;
            if(MaxMotorTorqueHasValue)
                result.MaxMotorTorque = _maxMotorTorque;
            if(OtherBodyHasValue)
                result.OtherBody = _otherBody;
            if(CollideConnectedHasValue)
                result.CollideConnected = _collideConnected;
            if(AttachedConstraintHasValue)
                result.AttachedConstraint = _attachedConstraint;
            if(EnabledHasValue)
                result.Enabled = _enabled;
            if(AnimationEnabledHasValue)
                result.AnimationEnabled = _animationEnabled;
            if(TemporaryHasValue)
                result.Temporary = _temporary;
            if(BlockEventsHasValue)
                result.BlockEvents = _blockEvents;
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "Anchor":
                    break;
                case "EnableLimit":
                    break;
                case "LowerAngle":
                    break;
                case "UpperAngle":
                    break;
                case "EnableMotor":
                    break;
                case "MotorSpeed":
                    break;
                case "MaxMotorTorque":
                    break;
                case "OtherBody":
                    break;
                case "CollideConnected":
                    break;
                case "AttachedConstraint":
                    break;
                case "Enabled":
                    break;
                case "AnimationEnabled":
                    break;
                case "Temporary":
                    break;
                case "BlockEvents":
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
    }
}
