using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using CrowdManager = Urho.Navigation.CrowdManager;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public partial class CrowdManagerPrefab: AbstractComponentPrefab<CrowdManager>, IPrefab
    {
        public override string TypeName { get { return CrowdManager.TypeNameStatic; } }
        public uint MaxAgents { get; set; }
        public float MaxAgentRadius { get; set; }
        public NavigationMesh NavigationMesh { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public CrowdManagerPrefab()
        {
            MaxAgents = MaxAgentsAccessor.DefaultValue;
            MaxAgentRadius = MaxAgentRadiusAccessor.DefaultValue;
            NavigationMesh = NavigationMeshAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public CrowdManagerPrefab(CrowdManager val)
        {
            ID = val.ID;
            MaxAgents = val.MaxAgents;
            MaxAgentRadius = val.MaxAgentRadius;
            NavigationMesh = val.NavigationMesh;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override CrowdManager Create()
        {
            var result = new CrowdManager();
            MaxAgentsAccessor.Instance.ApplyIfChanged(this, result);
            MaxAgentRadiusAccessor.Instance.ApplyIfChanged(this, result);
            NavigationMeshAccessor.Instance.ApplyIfChanged(this, result);
            EnabledAccessor.Instance.ApplyIfChanged(this, result);
            AnimationEnabledAccessor.Instance.ApplyIfChanged(this, result);
            TemporaryAccessor.Instance.ApplyIfChanged(this, result);
            BlockEventsAccessor.Instance.ApplyIfChanged(this, result);
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "MaxAgents":
                    MaxAgentsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxAgentRadius":
                    MaxAgentRadiusAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "NavigationMesh":
                    NavigationMeshAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Is Enabled":
                    EnabledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AnimationEnabled":
                    AnimationEnabledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Temporary":
                    TemporaryAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "BlockEvents":
                    BlockEventsAccessor.Instance.ParseAndSet(value, this);
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
        #region Accessors
        public override IEnumerable<IAccessor> Properties {
            get {
                yield return MaxAgentsAccessor.Instance;
                yield return MaxAgentRadiusAccessor.Instance;
                yield return NavigationMeshAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class MaxAgentsAccessor : UInt32Accessor<CrowdManagerPrefab, CrowdManager>
        {
            public static readonly MaxAgentsAccessor Instance = new MaxAgentsAccessor();
            public static readonly uint DefaultValue = 512;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdManager.MaxAgents);
            public override uint GetPrefab(CrowdManagerPrefab instance) { return instance.MaxAgents; }
            public override void SetPrefab(CrowdManagerPrefab instance, uint value) { instance.MaxAgents = value; }
            public override uint GetUrho(CrowdManager instance) { return instance.MaxAgents; }
            public override void SetUrho(CrowdManager instance, uint value) { instance.MaxAgents = value; }
        }

        internal class MaxAgentRadiusAccessor : SingleAccessor<CrowdManagerPrefab, CrowdManager>
        {
            public static readonly MaxAgentRadiusAccessor Instance = new MaxAgentRadiusAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdManager.MaxAgentRadius);
            public override float GetPrefab(CrowdManagerPrefab instance) { return instance.MaxAgentRadius; }
            public override void SetPrefab(CrowdManagerPrefab instance, float value) { instance.MaxAgentRadius = value; }
            public override float GetUrho(CrowdManager instance) { return instance.MaxAgentRadius; }
            public override void SetUrho(CrowdManager instance, float value) { instance.MaxAgentRadius = value; }
        }

        internal class NavigationMeshAccessor : NavigationMeshAccessor<CrowdManagerPrefab, CrowdManager>
        {
            public static readonly NavigationMeshAccessor Instance = new NavigationMeshAccessor();
            public static readonly NavigationMesh DefaultValue = null;
            public override NavigationMesh DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdManager.NavigationMesh);
            public override NavigationMesh GetPrefab(CrowdManagerPrefab instance) { return instance.NavigationMesh; }
            public override void SetPrefab(CrowdManagerPrefab instance, NavigationMesh value) { instance.NavigationMesh = value; }
            public override NavigationMesh GetUrho(CrowdManager instance) { return instance.NavigationMesh; }
            public override void SetUrho(CrowdManager instance, NavigationMesh value) { instance.NavigationMesh = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<CrowdManagerPrefab, CrowdManager>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdManager.Enabled);
            public override bool GetPrefab(CrowdManagerPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(CrowdManagerPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(CrowdManager instance) { return instance.Enabled; }
            public override void SetUrho(CrowdManager instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<CrowdManagerPrefab, CrowdManager>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdManager.AnimationEnabled);
            public override bool GetPrefab(CrowdManagerPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(CrowdManagerPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(CrowdManager instance) { return instance.AnimationEnabled; }
            public override void SetUrho(CrowdManager instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<CrowdManagerPrefab, CrowdManager>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdManager.Temporary);
            public override bool GetPrefab(CrowdManagerPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(CrowdManagerPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(CrowdManager instance) { return instance.Temporary; }
            public override void SetUrho(CrowdManager instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<CrowdManagerPrefab, CrowdManager>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdManager.BlockEvents);
            public override bool GetPrefab(CrowdManagerPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(CrowdManagerPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(CrowdManager instance) { return instance.BlockEvents; }
            public override void SetUrho(CrowdManager instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
