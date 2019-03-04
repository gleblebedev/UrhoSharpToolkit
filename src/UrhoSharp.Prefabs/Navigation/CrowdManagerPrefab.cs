using System;
using System.Xml.Linq;
using Urho;
using CrowdManager = Urho.Navigation.CrowdManager;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public class CrowdManagerPrefab: AbstractComponentPrefab<CrowdManager>, IPrefab
    {
        private static  uint MaxAgentsDefaultValue = 512;
        private static  float MaxAgentRadiusDefaultValue = 0f;
        private static  NavigationMesh NavigationMeshDefaultValue = null;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private uint _maxAgents;
        private float _maxAgentRadius;
        private NavigationMesh _navigationMesh;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public CrowdManagerPrefab()
        {
            _maxAgents = MaxAgentsDefaultValue;
            _maxAgentRadius = MaxAgentRadiusDefaultValue;
            _navigationMesh = NavigationMeshDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public CrowdManagerPrefab(CrowdManager val)
        {
            _maxAgents = val.MaxAgents;
            _maxAgentRadius = val.MaxAgentRadius;
            _navigationMesh = val.NavigationMesh;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public uint MaxAgents {get { return _maxAgents;} set { _maxAgents=value; } }
        public bool MaxAgentsHasValue {get { return !PrefabUtils.AreEqual(ref _maxAgents, ref MaxAgentsDefaultValue); } }
        public float MaxAgentRadius {get { return _maxAgentRadius;} set { _maxAgentRadius=value; } }
        public bool MaxAgentRadiusHasValue {get { return !PrefabUtils.AreEqual(ref _maxAgentRadius, ref MaxAgentRadiusDefaultValue); } }
        public NavigationMesh NavigationMesh {get { return _navigationMesh;} set { _navigationMesh=value; } }
        public bool NavigationMeshHasValue {get { return !PrefabUtils.AreEqual(ref _navigationMesh, ref NavigationMeshDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override CrowdManager Create()
        {
            var result = new CrowdManager();
            if(MaxAgentsHasValue)
                result.MaxAgents = _maxAgents;
            if(MaxAgentRadiusHasValue)
                result.MaxAgentRadius = _maxAgentRadius;
            if(NavigationMeshHasValue)
                result.NavigationMesh = _navigationMesh;
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
                case "MaxAgents":
                    break;
                case "MaxAgentRadius":
                    break;
                case "NavigationMesh":
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
