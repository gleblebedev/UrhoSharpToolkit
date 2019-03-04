using System;
using System.Xml.Linq;
using Urho;
using Constraint = Urho.Physics.Constraint;

using Urho.Physics;

namespace UrhoSharp.Prefabs
{
    public class ConstraintPrefab: AbstractComponentPrefab<Constraint>, IPrefab
    {
        private static  ConstraintType ConstraintTypeDefaultValue = ConstraintType.Point;
        private static  RigidBody OtherBodyDefaultValue = null;
        private static  Vector3 PositionDefaultValue = new Vector3(0f, 0f, 0f);
        private static  Quaternion RotationDefaultValue = new Quaternion(0f, 0f, 0f, 1f);
        private static  Vector3 OtherPositionDefaultValue = new Vector3(0f, 0f, 0f);
        private static  Quaternion OtherRotationDefaultValue = new Quaternion(0f, 0f, 0f, 1f);
        private static  Vector2 HighLimitDefaultValue = new Vector2(0f, 0f);
        private static  Vector2 LowLimitDefaultValue = new Vector2(0f, 0f);
        private static  float ERPDefaultValue = 0f;
        private static  float CFMDefaultValue = 0f;
        private static  bool DisableCollisionDefaultValue = false;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private ConstraintType _constraintType;
        private RigidBody _otherBody;
        private Vector3 _position;
        private Quaternion _rotation;
        private Vector3 _otherPosition;
        private Quaternion _otherRotation;
        private Vector2 _highLimit;
        private Vector2 _lowLimit;
        private float _eRP;
        private float _cFM;
        private bool _disableCollision;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public ConstraintPrefab()
        {
            _constraintType = ConstraintTypeDefaultValue;
            _otherBody = OtherBodyDefaultValue;
            _position = PositionDefaultValue;
            _rotation = RotationDefaultValue;
            _otherPosition = OtherPositionDefaultValue;
            _otherRotation = OtherRotationDefaultValue;
            _highLimit = HighLimitDefaultValue;
            _lowLimit = LowLimitDefaultValue;
            _eRP = ERPDefaultValue;
            _cFM = CFMDefaultValue;
            _disableCollision = DisableCollisionDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public ConstraintPrefab(Constraint val)
        {
            _constraintType = val.ConstraintType;
            _otherBody = val.OtherBody;
            _position = val.Position;
            _rotation = val.Rotation;
            _otherPosition = val.OtherPosition;
            _otherRotation = val.OtherRotation;
            _highLimit = val.HighLimit;
            _lowLimit = val.LowLimit;
            _eRP = val.ERP;
            _cFM = val.CFM;
            _disableCollision = val.DisableCollision;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public ConstraintType ConstraintType {get { return _constraintType;} set { _constraintType=value; } }
        public bool ConstraintTypeHasValue {get { return !PrefabUtils.AreEqual(ref _constraintType, ref ConstraintTypeDefaultValue); } }
        public RigidBody OtherBody {get { return _otherBody;} set { _otherBody=value; } }
        public bool OtherBodyHasValue {get { return !PrefabUtils.AreEqual(ref _otherBody, ref OtherBodyDefaultValue); } }
        public Vector3 Position {get { return _position;} set { _position=value; } }
        public bool PositionHasValue {get { return !PrefabUtils.AreEqual(ref _position, ref PositionDefaultValue); } }
        public Quaternion Rotation {get { return _rotation;} set { _rotation=value; } }
        public bool RotationHasValue {get { return !PrefabUtils.AreEqual(ref _rotation, ref RotationDefaultValue); } }
        public Vector3 OtherPosition {get { return _otherPosition;} set { _otherPosition=value; } }
        public bool OtherPositionHasValue {get { return !PrefabUtils.AreEqual(ref _otherPosition, ref OtherPositionDefaultValue); } }
        public Quaternion OtherRotation {get { return _otherRotation;} set { _otherRotation=value; } }
        public bool OtherRotationHasValue {get { return !PrefabUtils.AreEqual(ref _otherRotation, ref OtherRotationDefaultValue); } }
        public Vector2 HighLimit {get { return _highLimit;} set { _highLimit=value; } }
        public bool HighLimitHasValue {get { return !PrefabUtils.AreEqual(ref _highLimit, ref HighLimitDefaultValue); } }
        public Vector2 LowLimit {get { return _lowLimit;} set { _lowLimit=value; } }
        public bool LowLimitHasValue {get { return !PrefabUtils.AreEqual(ref _lowLimit, ref LowLimitDefaultValue); } }
        public float ERP {get { return _eRP;} set { _eRP=value; } }
        public bool ERPHasValue {get { return !PrefabUtils.AreEqual(ref _eRP, ref ERPDefaultValue); } }
        public float CFM {get { return _cFM;} set { _cFM=value; } }
        public bool CFMHasValue {get { return !PrefabUtils.AreEqual(ref _cFM, ref CFMDefaultValue); } }
        public bool DisableCollision {get { return _disableCollision;} set { _disableCollision=value; } }
        public bool DisableCollisionHasValue {get { return !PrefabUtils.AreEqual(ref _disableCollision, ref DisableCollisionDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override Constraint Create()
        {
            var result = new Constraint();
            if(ConstraintTypeHasValue)
                result.ConstraintType = _constraintType;
            if(OtherBodyHasValue)
                result.OtherBody = _otherBody;
            if(PositionHasValue)
                result.Position = _position;
            if(RotationHasValue)
                result.Rotation = _rotation;
            if(OtherPositionHasValue)
                result.OtherPosition = _otherPosition;
            if(OtherRotationHasValue)
                result.OtherRotation = _otherRotation;
            if(HighLimitHasValue)
                result.HighLimit = _highLimit;
            if(LowLimitHasValue)
                result.LowLimit = _lowLimit;
            if(ERPHasValue)
                result.ERP = _eRP;
            if(CFMHasValue)
                result.CFM = _cFM;
            if(DisableCollisionHasValue)
                result.DisableCollision = _disableCollision;
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
                case "ConstraintType":
                    break;
                case "OtherBody":
                    break;
                case "Position":
                    break;
                case "Rotation":
                    break;
                case "OtherPosition":
                    break;
                case "OtherRotation":
                    break;
                case "HighLimit":
                    break;
                case "LowLimit":
                    break;
                case "ERP":
                    break;
                case "CFM":
                    break;
                case "DisableCollision":
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
