using System;
using System.Xml.Linq;
using Urho;
using ConstraintDistance2D = Urho.Urho2D.ConstraintDistance2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class ConstraintDistance2DPrefab: AbstractComponentPrefab<ConstraintDistance2D>, IPrefab
    {
        private static  Vector2 OwnerBodyAnchorDefaultValue = new Vector2(0f, 0f);
        private static  Vector2 OtherBodyAnchorDefaultValue = new Vector2(0f, 0f);
        private static  float FrequencyHzDefaultValue = 0f;
        private static  float DampingRatioDefaultValue = 0f;
        private static  float LengthDefaultValue = 1f;
        private static  RigidBody2D OtherBodyDefaultValue = null;
        private static  bool CollideConnectedDefaultValue = false;
        private static  Constraint2D AttachedConstraintDefaultValue = null;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector2 _ownerBodyAnchor;
        private Vector2 _otherBodyAnchor;
        private float _frequencyHz;
        private float _dampingRatio;
        private float _length;
        private RigidBody2D _otherBody;
        private bool _collideConnected;
        private Constraint2D _attachedConstraint;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public ConstraintDistance2DPrefab()
        {
            _ownerBodyAnchor = OwnerBodyAnchorDefaultValue;
            _otherBodyAnchor = OtherBodyAnchorDefaultValue;
            _frequencyHz = FrequencyHzDefaultValue;
            _dampingRatio = DampingRatioDefaultValue;
            _length = LengthDefaultValue;
            _otherBody = OtherBodyDefaultValue;
            _collideConnected = CollideConnectedDefaultValue;
            _attachedConstraint = AttachedConstraintDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public ConstraintDistance2DPrefab(ConstraintDistance2D val)
        {
            _ownerBodyAnchor = val.OwnerBodyAnchor;
            _otherBodyAnchor = val.OtherBodyAnchor;
            _frequencyHz = val.FrequencyHz;
            _dampingRatio = val.DampingRatio;
            _length = val.Length;
            _otherBody = val.OtherBody;
            _collideConnected = val.CollideConnected;
            _attachedConstraint = val.AttachedConstraint;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Vector2 OwnerBodyAnchor {get { return _ownerBodyAnchor;} set { _ownerBodyAnchor=value; } }
        public bool OwnerBodyAnchorHasValue {get { return !PrefabUtils.AreEqual(ref _ownerBodyAnchor, ref OwnerBodyAnchorDefaultValue); } }
        public Vector2 OtherBodyAnchor {get { return _otherBodyAnchor;} set { _otherBodyAnchor=value; } }
        public bool OtherBodyAnchorHasValue {get { return !PrefabUtils.AreEqual(ref _otherBodyAnchor, ref OtherBodyAnchorDefaultValue); } }
        public float FrequencyHz {get { return _frequencyHz;} set { _frequencyHz=value; } }
        public bool FrequencyHzHasValue {get { return !PrefabUtils.AreEqual(ref _frequencyHz, ref FrequencyHzDefaultValue); } }
        public float DampingRatio {get { return _dampingRatio;} set { _dampingRatio=value; } }
        public bool DampingRatioHasValue {get { return !PrefabUtils.AreEqual(ref _dampingRatio, ref DampingRatioDefaultValue); } }
        public float Length {get { return _length;} set { _length=value; } }
        public bool LengthHasValue {get { return !PrefabUtils.AreEqual(ref _length, ref LengthDefaultValue); } }
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
        public override ConstraintDistance2D Create()
        {
            var result = new ConstraintDistance2D();
            if(OwnerBodyAnchorHasValue)
                result.OwnerBodyAnchor = _ownerBodyAnchor;
            if(OtherBodyAnchorHasValue)
                result.OtherBodyAnchor = _otherBodyAnchor;
            if(FrequencyHzHasValue)
                result.FrequencyHz = _frequencyHz;
            if(DampingRatioHasValue)
                result.DampingRatio = _dampingRatio;
            if(LengthHasValue)
                result.Length = _length;
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
                case "OwnerBodyAnchor":
                    break;
                case "OtherBodyAnchor":
                    break;
                case "FrequencyHz":
                    break;
                case "DampingRatio":
                    break;
                case "Length":
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
