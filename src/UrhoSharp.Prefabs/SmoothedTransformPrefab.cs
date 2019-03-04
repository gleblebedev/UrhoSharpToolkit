using System;
using System.Xml.Linq;
using Urho;
using SmoothedTransform = Urho.SmoothedTransform;


namespace UrhoSharp.Prefabs
{
    public class SmoothedTransformPrefab: AbstractComponentPrefab<SmoothedTransform>, IPrefab
    {
        private static  Vector3 TargetPositionDefaultValue = new Vector3(0f, 0f, 0f);
        private static  Quaternion TargetRotationDefaultValue = new Quaternion(0f, 0f, 0f, 1f);
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector3 _targetPosition;
        private Quaternion _targetRotation;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public SmoothedTransformPrefab()
        {
            _targetPosition = TargetPositionDefaultValue;
            _targetRotation = TargetRotationDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public SmoothedTransformPrefab(SmoothedTransform val)
        {
            _targetPosition = val.TargetPosition;
            _targetRotation = val.TargetRotation;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Vector3 TargetPosition {get { return _targetPosition;} set { _targetPosition=value; } }
        public bool TargetPositionHasValue {get { return !PrefabUtils.AreEqual(ref _targetPosition, ref TargetPositionDefaultValue); } }
        public Quaternion TargetRotation {get { return _targetRotation;} set { _targetRotation=value; } }
        public bool TargetRotationHasValue {get { return !PrefabUtils.AreEqual(ref _targetRotation, ref TargetRotationDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override SmoothedTransform Create()
        {
            var result = new SmoothedTransform();
            if(TargetPositionHasValue)
                result.TargetPosition = _targetPosition;
            if(TargetRotationHasValue)
                result.TargetRotation = _targetRotation;
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
                case "TargetPosition":
                    break;
                case "TargetRotation":
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
