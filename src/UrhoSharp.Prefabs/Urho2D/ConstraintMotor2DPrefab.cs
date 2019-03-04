using System;
using System.Xml.Linq;
using Urho;
using ConstraintMotor2D = Urho.Urho2D.ConstraintMotor2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class ConstraintMotor2DPrefab: AbstractComponentPrefab<ConstraintMotor2D>, IPrefab
    {
        private static  Vector2 LinearOffsetDefaultValue = new Vector2(0f, 0f);
        private static  float AngularOffsetDefaultValue = 0f;
        private static  float MaxForceDefaultValue = 1f;
        private static  float MaxTorqueDefaultValue = 1f;
        private static  float CorrectionFactorDefaultValue = 0.3f;
        private static  RigidBody2D OtherBodyDefaultValue = null;
        private static  bool CollideConnectedDefaultValue = false;
        private static  Constraint2D AttachedConstraintDefaultValue = null;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector2 _linearOffset;
        private float _angularOffset;
        private float _maxForce;
        private float _maxTorque;
        private float _correctionFactor;
        private RigidBody2D _otherBody;
        private bool _collideConnected;
        private Constraint2D _attachedConstraint;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public ConstraintMotor2DPrefab()
        {
            _linearOffset = LinearOffsetDefaultValue;
            _angularOffset = AngularOffsetDefaultValue;
            _maxForce = MaxForceDefaultValue;
            _maxTorque = MaxTorqueDefaultValue;
            _correctionFactor = CorrectionFactorDefaultValue;
            _otherBody = OtherBodyDefaultValue;
            _collideConnected = CollideConnectedDefaultValue;
            _attachedConstraint = AttachedConstraintDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public ConstraintMotor2DPrefab(ConstraintMotor2D val)
        {
            _linearOffset = val.LinearOffset;
            _angularOffset = val.AngularOffset;
            _maxForce = val.MaxForce;
            _maxTorque = val.MaxTorque;
            _correctionFactor = val.CorrectionFactor;
            _otherBody = val.OtherBody;
            _collideConnected = val.CollideConnected;
            _attachedConstraint = val.AttachedConstraint;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Vector2 LinearOffset {get { return _linearOffset;} set { _linearOffset=value; } }
        public bool LinearOffsetHasValue {get { return !PrefabUtils.AreEqual(ref _linearOffset, ref LinearOffsetDefaultValue); } }
        public float AngularOffset {get { return _angularOffset;} set { _angularOffset=value; } }
        public bool AngularOffsetHasValue {get { return !PrefabUtils.AreEqual(ref _angularOffset, ref AngularOffsetDefaultValue); } }
        public float MaxForce {get { return _maxForce;} set { _maxForce=value; } }
        public bool MaxForceHasValue {get { return !PrefabUtils.AreEqual(ref _maxForce, ref MaxForceDefaultValue); } }
        public float MaxTorque {get { return _maxTorque;} set { _maxTorque=value; } }
        public bool MaxTorqueHasValue {get { return !PrefabUtils.AreEqual(ref _maxTorque, ref MaxTorqueDefaultValue); } }
        public float CorrectionFactor {get { return _correctionFactor;} set { _correctionFactor=value; } }
        public bool CorrectionFactorHasValue {get { return !PrefabUtils.AreEqual(ref _correctionFactor, ref CorrectionFactorDefaultValue); } }
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
        public override ConstraintMotor2D Create()
        {
            var result = new ConstraintMotor2D();
            if(LinearOffsetHasValue)
                result.LinearOffset = _linearOffset;
            if(AngularOffsetHasValue)
                result.AngularOffset = _angularOffset;
            if(MaxForceHasValue)
                result.MaxForce = _maxForce;
            if(MaxTorqueHasValue)
                result.MaxTorque = _maxTorque;
            if(CorrectionFactorHasValue)
                result.CorrectionFactor = _correctionFactor;
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
                case "LinearOffset":
                    break;
                case "AngularOffset":
                    break;
                case "MaxForce":
                    break;
                case "MaxTorque":
                    break;
                case "CorrectionFactor":
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
