using System;
using System.Xml.Linq;
using Urho;
using ConstraintFriction2D = Urho.Urho2D.ConstraintFriction2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class ConstraintFriction2DPrefab: AbstractComponentPrefab<ConstraintFriction2D>, IPrefab
    {
        private static  Vector2 AnchorDefaultValue = new Vector2(0f, 0f);
        private static  float MaxForceDefaultValue = 0f;
        private static  float MaxTorqueDefaultValue = 0f;
        private static  RigidBody2D OtherBodyDefaultValue = null;
        private static  bool CollideConnectedDefaultValue = false;
        private static  Constraint2D AttachedConstraintDefaultValue = null;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector2 _anchor;
        private float _maxForce;
        private float _maxTorque;
        private RigidBody2D _otherBody;
        private bool _collideConnected;
        private Constraint2D _attachedConstraint;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public ConstraintFriction2DPrefab()
        {
            _anchor = AnchorDefaultValue;
            _maxForce = MaxForceDefaultValue;
            _maxTorque = MaxTorqueDefaultValue;
            _otherBody = OtherBodyDefaultValue;
            _collideConnected = CollideConnectedDefaultValue;
            _attachedConstraint = AttachedConstraintDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public ConstraintFriction2DPrefab(ConstraintFriction2D val)
        {
            _anchor = val.Anchor;
            _maxForce = val.MaxForce;
            _maxTorque = val.MaxTorque;
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
        public float MaxForce {get { return _maxForce;} set { _maxForce=value; } }
        public bool MaxForceHasValue {get { return !PrefabUtils.AreEqual(ref _maxForce, ref MaxForceDefaultValue); } }
        public float MaxTorque {get { return _maxTorque;} set { _maxTorque=value; } }
        public bool MaxTorqueHasValue {get { return !PrefabUtils.AreEqual(ref _maxTorque, ref MaxTorqueDefaultValue); } }
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
        public override ConstraintFriction2D Create()
        {
            var result = new ConstraintFriction2D();
            if(AnchorHasValue)
                result.Anchor = _anchor;
            if(MaxForceHasValue)
                result.MaxForce = _maxForce;
            if(MaxTorqueHasValue)
                result.MaxTorque = _maxTorque;
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
                case "MaxForce":
                    break;
                case "MaxTorque":
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
