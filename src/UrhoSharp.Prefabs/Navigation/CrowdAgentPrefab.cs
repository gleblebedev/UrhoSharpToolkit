using System;
using System.Xml.Linq;
using Urho;
using CrowdAgent = Urho.Navigation.CrowdAgent;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public class CrowdAgentPrefab: AbstractComponentPrefab<CrowdAgent>, IPrefab
    {
        private static  Vector3 TargetPositionDefaultValue = new Vector3(0f, 0f, 0f);
        private static  Vector3 TargetVelocityDefaultValue = new Vector3(0f, 0f, 0f);
        private static  bool UpdateNodePositionDefaultValue = true;
        private static  float MaxAccelDefaultValue = 0f;
        private static  float MaxSpeedDefaultValue = 0f;
        private static  float RadiusDefaultValue = 0f;
        private static  float HeightDefaultValue = 0f;
        private static  uint QueryFilterTypeDefaultValue = 0;
        private static  uint ObstacleAvoidanceTypeDefaultValue = 0;
        private static  NavigationQuality NavigationQualityDefaultValue = NavigationQuality.High;
        private static  NavigationPushiness NavigationPushinessDefaultValue = NavigationPushiness.Medium;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector3 _targetPosition;
        private Vector3 _targetVelocity;
        private bool _updateNodePosition;
        private float _maxAccel;
        private float _maxSpeed;
        private float _radius;
        private float _height;
        private uint _queryFilterType;
        private uint _obstacleAvoidanceType;
        private NavigationQuality _navigationQuality;
        private NavigationPushiness _navigationPushiness;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public CrowdAgentPrefab()
        {
            _targetPosition = TargetPositionDefaultValue;
            _targetVelocity = TargetVelocityDefaultValue;
            _updateNodePosition = UpdateNodePositionDefaultValue;
            _maxAccel = MaxAccelDefaultValue;
            _maxSpeed = MaxSpeedDefaultValue;
            _radius = RadiusDefaultValue;
            _height = HeightDefaultValue;
            _queryFilterType = QueryFilterTypeDefaultValue;
            _obstacleAvoidanceType = ObstacleAvoidanceTypeDefaultValue;
            _navigationQuality = NavigationQualityDefaultValue;
            _navigationPushiness = NavigationPushinessDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public CrowdAgentPrefab(CrowdAgent val)
        {
            _targetPosition = val.TargetPosition;
            _targetVelocity = val.TargetVelocity;
            _updateNodePosition = val.UpdateNodePosition;
            _maxAccel = val.MaxAccel;
            _maxSpeed = val.MaxSpeed;
            _radius = val.Radius;
            _height = val.Height;
            _queryFilterType = val.QueryFilterType;
            _obstacleAvoidanceType = val.ObstacleAvoidanceType;
            _navigationQuality = val.NavigationQuality;
            _navigationPushiness = val.NavigationPushiness;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Vector3 TargetPosition {get { return _targetPosition;} set { _targetPosition=value; } }
        public bool TargetPositionHasValue {get { return !PrefabUtils.AreEqual(ref _targetPosition, ref TargetPositionDefaultValue); } }
        public Vector3 TargetVelocity {get { return _targetVelocity;} set { _targetVelocity=value; } }
        public bool TargetVelocityHasValue {get { return !PrefabUtils.AreEqual(ref _targetVelocity, ref TargetVelocityDefaultValue); } }
        public bool UpdateNodePosition {get { return _updateNodePosition;} set { _updateNodePosition=value; } }
        public bool UpdateNodePositionHasValue {get { return !PrefabUtils.AreEqual(ref _updateNodePosition, ref UpdateNodePositionDefaultValue); } }
        public float MaxAccel {get { return _maxAccel;} set { _maxAccel=value; } }
        public bool MaxAccelHasValue {get { return !PrefabUtils.AreEqual(ref _maxAccel, ref MaxAccelDefaultValue); } }
        public float MaxSpeed {get { return _maxSpeed;} set { _maxSpeed=value; } }
        public bool MaxSpeedHasValue {get { return !PrefabUtils.AreEqual(ref _maxSpeed, ref MaxSpeedDefaultValue); } }
        public float Radius {get { return _radius;} set { _radius=value; } }
        public bool RadiusHasValue {get { return !PrefabUtils.AreEqual(ref _radius, ref RadiusDefaultValue); } }
        public float Height {get { return _height;} set { _height=value; } }
        public bool HeightHasValue {get { return !PrefabUtils.AreEqual(ref _height, ref HeightDefaultValue); } }
        public uint QueryFilterType {get { return _queryFilterType;} set { _queryFilterType=value; } }
        public bool QueryFilterTypeHasValue {get { return !PrefabUtils.AreEqual(ref _queryFilterType, ref QueryFilterTypeDefaultValue); } }
        public uint ObstacleAvoidanceType {get { return _obstacleAvoidanceType;} set { _obstacleAvoidanceType=value; } }
        public bool ObstacleAvoidanceTypeHasValue {get { return !PrefabUtils.AreEqual(ref _obstacleAvoidanceType, ref ObstacleAvoidanceTypeDefaultValue); } }
        public NavigationQuality NavigationQuality {get { return _navigationQuality;} set { _navigationQuality=value; } }
        public bool NavigationQualityHasValue {get { return !PrefabUtils.AreEqual(ref _navigationQuality, ref NavigationQualityDefaultValue); } }
        public NavigationPushiness NavigationPushiness {get { return _navigationPushiness;} set { _navigationPushiness=value; } }
        public bool NavigationPushinessHasValue {get { return !PrefabUtils.AreEqual(ref _navigationPushiness, ref NavigationPushinessDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override CrowdAgent Create()
        {
            var result = new CrowdAgent();
            if(TargetPositionHasValue)
                result.TargetPosition = _targetPosition;
            if(TargetVelocityHasValue)
                result.TargetVelocity = _targetVelocity;
            if(UpdateNodePositionHasValue)
                result.UpdateNodePosition = _updateNodePosition;
            if(MaxAccelHasValue)
                result.MaxAccel = _maxAccel;
            if(MaxSpeedHasValue)
                result.MaxSpeed = _maxSpeed;
            if(RadiusHasValue)
                result.Radius = _radius;
            if(HeightHasValue)
                result.Height = _height;
            if(QueryFilterTypeHasValue)
                result.QueryFilterType = _queryFilterType;
            if(ObstacleAvoidanceTypeHasValue)
                result.ObstacleAvoidanceType = _obstacleAvoidanceType;
            if(NavigationQualityHasValue)
                result.NavigationQuality = _navigationQuality;
            if(NavigationPushinessHasValue)
                result.NavigationPushiness = _navigationPushiness;
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
                case "TargetVelocity":
                    break;
                case "UpdateNodePosition":
                    break;
                case "MaxAccel":
                    break;
                case "MaxSpeed":
                    break;
                case "Radius":
                    break;
                case "Height":
                    break;
                case "QueryFilterType":
                    break;
                case "ObstacleAvoidanceType":
                    break;
                case "NavigationQuality":
                    break;
                case "NavigationPushiness":
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
