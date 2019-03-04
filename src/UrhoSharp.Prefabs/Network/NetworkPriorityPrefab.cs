using System;
using System.Xml.Linq;
using Urho;
using NetworkPriority = Urho.Network.NetworkPriority;

using Urho.Network;

namespace UrhoSharp.Prefabs
{
    public class NetworkPriorityPrefab: AbstractComponentPrefab<NetworkPriority>, IPrefab
    {
        private static  float BasePriorityDefaultValue = 100f;
        private static  float DistanceFactorDefaultValue = 0f;
        private static  float MinPriorityDefaultValue = 0f;
        private static  bool AlwaysUpdateOwnerDefaultValue = true;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private float _basePriority;
        private float _distanceFactor;
        private float _minPriority;
        private bool _alwaysUpdateOwner;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public NetworkPriorityPrefab()
        {
            _basePriority = BasePriorityDefaultValue;
            _distanceFactor = DistanceFactorDefaultValue;
            _minPriority = MinPriorityDefaultValue;
            _alwaysUpdateOwner = AlwaysUpdateOwnerDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public NetworkPriorityPrefab(NetworkPriority val)
        {
            _basePriority = val.BasePriority;
            _distanceFactor = val.DistanceFactor;
            _minPriority = val.MinPriority;
            _alwaysUpdateOwner = val.AlwaysUpdateOwner;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public float BasePriority {get { return _basePriority;} set { _basePriority=value; } }
        public bool BasePriorityHasValue {get { return !PrefabUtils.AreEqual(ref _basePriority, ref BasePriorityDefaultValue); } }
        public float DistanceFactor {get { return _distanceFactor;} set { _distanceFactor=value; } }
        public bool DistanceFactorHasValue {get { return !PrefabUtils.AreEqual(ref _distanceFactor, ref DistanceFactorDefaultValue); } }
        public float MinPriority {get { return _minPriority;} set { _minPriority=value; } }
        public bool MinPriorityHasValue {get { return !PrefabUtils.AreEqual(ref _minPriority, ref MinPriorityDefaultValue); } }
        public bool AlwaysUpdateOwner {get { return _alwaysUpdateOwner;} set { _alwaysUpdateOwner=value; } }
        public bool AlwaysUpdateOwnerHasValue {get { return !PrefabUtils.AreEqual(ref _alwaysUpdateOwner, ref AlwaysUpdateOwnerDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override NetworkPriority Create()
        {
            var result = new NetworkPriority();
            if(BasePriorityHasValue)
                result.BasePriority = _basePriority;
            if(DistanceFactorHasValue)
                result.DistanceFactor = _distanceFactor;
            if(MinPriorityHasValue)
                result.MinPriority = _minPriority;
            if(AlwaysUpdateOwnerHasValue)
                result.AlwaysUpdateOwner = _alwaysUpdateOwner;
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
                case "BasePriority":
                    break;
                case "DistanceFactor":
                    break;
                case "MinPriority":
                    break;
                case "AlwaysUpdateOwner":
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
