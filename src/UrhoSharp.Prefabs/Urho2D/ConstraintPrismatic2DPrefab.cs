using System;
using System.Xml.Linq;
using Urho;
using ConstraintPrismatic2D = Urho.Urho2D.ConstraintPrismatic2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class ConstraintPrismatic2DPrefab: AbstractComponentPrefab<ConstraintPrismatic2D>, IPrefab
    {
        private static  Vector2 AnchorDefaultValue = new Vector2(0f, 0f);
        private static  Vector2 AxisDefaultValue = new Vector2(1f, 0f);
        private static  bool EnableLimitDefaultValue = false;
        private static  float LowerTranslationDefaultValue = 0f;
        private static  float UpperTranslationDefaultValue = 0f;
        private static  bool EnableMotorDefaultValue = false;
        private static  float MaxMotorForceDefaultValue = 0f;
        private static  float MotorSpeedDefaultValue = 0f;
        private static  RigidBody2D OtherBodyDefaultValue = null;
        private static  bool CollideConnectedDefaultValue = false;
        private static  Constraint2D AttachedConstraintDefaultValue = null;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector2 _anchor;
        private Vector2 _axis;
        private bool _enableLimit;
        private float _lowerTranslation;
        private float _upperTranslation;
        private bool _enableMotor;
        private float _maxMotorForce;
        private float _motorSpeed;
        private RigidBody2D _otherBody;
        private bool _collideConnected;
        private Constraint2D _attachedConstraint;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public ConstraintPrismatic2DPrefab()
        {
            _anchor = AnchorDefaultValue;
            _axis = AxisDefaultValue;
            _enableLimit = EnableLimitDefaultValue;
            _lowerTranslation = LowerTranslationDefaultValue;
            _upperTranslation = UpperTranslationDefaultValue;
            _enableMotor = EnableMotorDefaultValue;
            _maxMotorForce = MaxMotorForceDefaultValue;
            _motorSpeed = MotorSpeedDefaultValue;
            _otherBody = OtherBodyDefaultValue;
            _collideConnected = CollideConnectedDefaultValue;
            _attachedConstraint = AttachedConstraintDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public ConstraintPrismatic2DPrefab(ConstraintPrismatic2D val)
        {
            _anchor = val.Anchor;
            _axis = val.Axis;
            _enableLimit = val.EnableLimit;
            _lowerTranslation = val.LowerTranslation;
            _upperTranslation = val.UpperTranslation;
            _enableMotor = val.EnableMotor;
            _maxMotorForce = val.MaxMotorForce;
            _motorSpeed = val.MotorSpeed;
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
        public Vector2 Axis {get { return _axis;} set { _axis=value; } }
        public bool AxisHasValue {get { return !PrefabUtils.AreEqual(ref _axis, ref AxisDefaultValue); } }
        public bool EnableLimit {get { return _enableLimit;} set { _enableLimit=value; } }
        public bool EnableLimitHasValue {get { return !PrefabUtils.AreEqual(ref _enableLimit, ref EnableLimitDefaultValue); } }
        public float LowerTranslation {get { return _lowerTranslation;} set { _lowerTranslation=value; } }
        public bool LowerTranslationHasValue {get { return !PrefabUtils.AreEqual(ref _lowerTranslation, ref LowerTranslationDefaultValue); } }
        public float UpperTranslation {get { return _upperTranslation;} set { _upperTranslation=value; } }
        public bool UpperTranslationHasValue {get { return !PrefabUtils.AreEqual(ref _upperTranslation, ref UpperTranslationDefaultValue); } }
        public bool EnableMotor {get { return _enableMotor;} set { _enableMotor=value; } }
        public bool EnableMotorHasValue {get { return !PrefabUtils.AreEqual(ref _enableMotor, ref EnableMotorDefaultValue); } }
        public float MaxMotorForce {get { return _maxMotorForce;} set { _maxMotorForce=value; } }
        public bool MaxMotorForceHasValue {get { return !PrefabUtils.AreEqual(ref _maxMotorForce, ref MaxMotorForceDefaultValue); } }
        public float MotorSpeed {get { return _motorSpeed;} set { _motorSpeed=value; } }
        public bool MotorSpeedHasValue {get { return !PrefabUtils.AreEqual(ref _motorSpeed, ref MotorSpeedDefaultValue); } }
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
        public override ConstraintPrismatic2D Create()
        {
            var result = new ConstraintPrismatic2D();
            if(AnchorHasValue)
                result.Anchor = _anchor;
            if(AxisHasValue)
                result.Axis = _axis;
            if(EnableLimitHasValue)
                result.EnableLimit = _enableLimit;
            if(LowerTranslationHasValue)
                result.LowerTranslation = _lowerTranslation;
            if(UpperTranslationHasValue)
                result.UpperTranslation = _upperTranslation;
            if(EnableMotorHasValue)
                result.EnableMotor = _enableMotor;
            if(MaxMotorForceHasValue)
                result.MaxMotorForce = _maxMotorForce;
            if(MotorSpeedHasValue)
                result.MotorSpeed = _motorSpeed;
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
                case "Axis":
                    break;
                case "EnableLimit":
                    break;
                case "LowerTranslation":
                    break;
                case "UpperTranslation":
                    break;
                case "EnableMotor":
                    break;
                case "MaxMotorForce":
                    break;
                case "MotorSpeed":
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
