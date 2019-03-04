using System;
using System.Xml.Linq;
using Urho;
using SplinePath = Urho.SplinePath;


namespace UrhoSharp.Prefabs
{
    public class SplinePathPrefab: AbstractComponentPrefab<SplinePath>, IPrefab
    {
        private static  InterpolationMode InterpolationModeDefaultValue = InterpolationMode.BezierCurve;
        private static  float SpeedDefaultValue = 1f;
        private static  Node ControlledNodeDefaultValue = null;
        private static  uint ControlledIdAttrDefaultValue = 0;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private InterpolationMode _interpolationMode;
        private float _speed;
        private Node _controlledNode;
        private uint _controlledIdAttr;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public SplinePathPrefab()
        {
            _interpolationMode = InterpolationModeDefaultValue;
            _speed = SpeedDefaultValue;
            _controlledNode = ControlledNodeDefaultValue;
            _controlledIdAttr = ControlledIdAttrDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public SplinePathPrefab(SplinePath val)
        {
            _interpolationMode = val.InterpolationMode;
            _speed = val.Speed;
            _controlledNode = val.ControlledNode;
            _controlledIdAttr = val.ControlledIdAttr;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public InterpolationMode InterpolationMode {get { return _interpolationMode;} set { _interpolationMode=value; } }
        public bool InterpolationModeHasValue {get { return !PrefabUtils.AreEqual(ref _interpolationMode, ref InterpolationModeDefaultValue); } }
        public float Speed {get { return _speed;} set { _speed=value; } }
        public bool SpeedHasValue {get { return !PrefabUtils.AreEqual(ref _speed, ref SpeedDefaultValue); } }
        public Node ControlledNode {get { return _controlledNode;} set { _controlledNode=value; } }
        public bool ControlledNodeHasValue {get { return !PrefabUtils.AreEqual(ref _controlledNode, ref ControlledNodeDefaultValue); } }
        public uint ControlledIdAttr {get { return _controlledIdAttr;} set { _controlledIdAttr=value; } }
        public bool ControlledIdAttrHasValue {get { return !PrefabUtils.AreEqual(ref _controlledIdAttr, ref ControlledIdAttrDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override SplinePath Create()
        {
            var result = new SplinePath();
            if(InterpolationModeHasValue)
                result.InterpolationMode = _interpolationMode;
            if(SpeedHasValue)
                result.Speed = _speed;
            if(ControlledNodeHasValue)
                result.ControlledNode = _controlledNode;
            if(ControlledIdAttrHasValue)
                result.ControlledIdAttr = _controlledIdAttr;
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
                case "InterpolationMode":
                    break;
                case "Speed":
                    break;
                case "ControlledNode":
                    break;
                case "ControlledIdAttr":
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
