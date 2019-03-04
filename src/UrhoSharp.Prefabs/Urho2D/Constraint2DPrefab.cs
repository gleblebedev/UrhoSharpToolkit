using System;
using System.Xml.Linq;
using Urho;
using Constraint2D = Urho.Urho2D.Constraint2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class Constraint2DPrefab: AbstractComponentPrefab<Constraint2D>, IPrefab
    {
        private static  RigidBody2D OtherBodyDefaultValue = null;
        private static  bool CollideConnectedDefaultValue = false;
        private static  Constraint2D AttachedConstraintDefaultValue = null;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private RigidBody2D _otherBody;
        private bool _collideConnected;
        private Constraint2D _attachedConstraint;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public Constraint2DPrefab()
        {
            _otherBody = OtherBodyDefaultValue;
            _collideConnected = CollideConnectedDefaultValue;
            _attachedConstraint = AttachedConstraintDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public Constraint2DPrefab(Constraint2D val)
        {
            _otherBody = val.OtherBody;
            _collideConnected = val.CollideConnected;
            _attachedConstraint = val.AttachedConstraint;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
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
        public override Constraint2D Create()
        {
            var result = new Constraint2D();
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
