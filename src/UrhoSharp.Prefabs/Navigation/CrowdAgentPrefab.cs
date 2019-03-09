using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using CrowdAgent = Urho.Navigation.CrowdAgent;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public partial class CrowdAgentPrefab: AbstractComponentPrefab<CrowdAgent>, IPrefab
    {
        public override string TypeName { get { return CrowdAgent.TypeNameStatic; } }
        public Vector3 TargetPosition { get; set; }
        public Vector3 TargetVelocity { get; set; }
        public bool UpdateNodePosition { get; set; }
        public float MaxAccel { get; set; }
        public float MaxSpeed { get; set; }
        public float Radius { get; set; }
        public float Height { get; set; }
        public uint QueryFilterType { get; set; }
        public uint ObstacleAvoidanceType { get; set; }
        public NavigationQuality NavigationQuality { get; set; }
        public NavigationPushiness NavigationPushiness { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public CrowdAgentPrefab()
        {
            TargetPosition = TargetPositionAccessor.DefaultValue;
            TargetVelocity = TargetVelocityAccessor.DefaultValue;
            UpdateNodePosition = UpdateNodePositionAccessor.DefaultValue;
            MaxAccel = MaxAccelAccessor.DefaultValue;
            MaxSpeed = MaxSpeedAccessor.DefaultValue;
            Radius = RadiusAccessor.DefaultValue;
            Height = HeightAccessor.DefaultValue;
            QueryFilterType = QueryFilterTypeAccessor.DefaultValue;
            ObstacleAvoidanceType = ObstacleAvoidanceTypeAccessor.DefaultValue;
            NavigationQuality = NavigationQualityAccessor.DefaultValue;
            NavigationPushiness = NavigationPushinessAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public CrowdAgentPrefab(CrowdAgent val)
        {
            ID = val.ID;
            TargetPosition = val.TargetPosition;
            TargetVelocity = val.TargetVelocity;
            UpdateNodePosition = val.UpdateNodePosition;
            MaxAccel = val.MaxAccel;
            MaxSpeed = val.MaxSpeed;
            Radius = val.Radius;
            Height = val.Height;
            QueryFilterType = val.QueryFilterType;
            ObstacleAvoidanceType = val.ObstacleAvoidanceType;
            NavigationQuality = val.NavigationQuality;
            NavigationPushiness = val.NavigationPushiness;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override CrowdAgent Create()
        {
            var result = new CrowdAgent();
            TargetPositionAccessor.Instance.ApplyIfChanged(this, result);
            TargetVelocityAccessor.Instance.ApplyIfChanged(this, result);
            UpdateNodePositionAccessor.Instance.ApplyIfChanged(this, result);
            MaxAccelAccessor.Instance.ApplyIfChanged(this, result);
            MaxSpeedAccessor.Instance.ApplyIfChanged(this, result);
            RadiusAccessor.Instance.ApplyIfChanged(this, result);
            HeightAccessor.Instance.ApplyIfChanged(this, result);
            QueryFilterTypeAccessor.Instance.ApplyIfChanged(this, result);
            ObstacleAvoidanceTypeAccessor.Instance.ApplyIfChanged(this, result);
            NavigationQualityAccessor.Instance.ApplyIfChanged(this, result);
            NavigationPushinessAccessor.Instance.ApplyIfChanged(this, result);
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
                case "TargetPosition":
                    TargetPositionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "TargetVelocity":
                    TargetVelocityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UpdateNodePosition":
                    UpdateNodePositionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxAccel":
                    MaxAccelAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxSpeed":
                    MaxSpeedAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Radius":
                    RadiusAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Height":
                    HeightAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "QueryFilterType":
                    QueryFilterTypeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ObstacleAvoidanceType":
                    ObstacleAvoidanceTypeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "NavigationQuality":
                    NavigationQualityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "NavigationPushiness":
                    NavigationPushinessAccessor.Instance.ParseAndSet(value, this);
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
                yield return TargetPositionAccessor.Instance;
                yield return TargetVelocityAccessor.Instance;
                yield return UpdateNodePositionAccessor.Instance;
                yield return MaxAccelAccessor.Instance;
                yield return MaxSpeedAccessor.Instance;
                yield return RadiusAccessor.Instance;
                yield return HeightAccessor.Instance;
                yield return QueryFilterTypeAccessor.Instance;
                yield return ObstacleAvoidanceTypeAccessor.Instance;
                yield return NavigationQualityAccessor.Instance;
                yield return NavigationPushinessAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class TargetPositionAccessor : Vector3Accessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly TargetPositionAccessor Instance = new TargetPositionAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(0f, 0f, 0f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.TargetPosition);
            public override Vector3 GetPrefab(CrowdAgentPrefab instance) { return instance.TargetPosition; }
            public override void SetPrefab(CrowdAgentPrefab instance, Vector3 value) { instance.TargetPosition = value; }
            public override Vector3 GetUrho(CrowdAgent instance) { return instance.TargetPosition; }
            public override void SetUrho(CrowdAgent instance, Vector3 value) { instance.TargetPosition = value; }
        }

        internal class TargetVelocityAccessor : Vector3Accessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly TargetVelocityAccessor Instance = new TargetVelocityAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(0f, 0f, 0f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.TargetVelocity);
            public override Vector3 GetPrefab(CrowdAgentPrefab instance) { return instance.TargetVelocity; }
            public override void SetPrefab(CrowdAgentPrefab instance, Vector3 value) { instance.TargetVelocity = value; }
            public override Vector3 GetUrho(CrowdAgent instance) { return instance.TargetVelocity; }
            public override void SetUrho(CrowdAgent instance, Vector3 value) { instance.TargetVelocity = value; }
        }

        internal class UpdateNodePositionAccessor : BooleanAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly UpdateNodePositionAccessor Instance = new UpdateNodePositionAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.UpdateNodePosition);
            public override bool GetPrefab(CrowdAgentPrefab instance) { return instance.UpdateNodePosition; }
            public override void SetPrefab(CrowdAgentPrefab instance, bool value) { instance.UpdateNodePosition = value; }
            public override bool GetUrho(CrowdAgent instance) { return instance.UpdateNodePosition; }
            public override void SetUrho(CrowdAgent instance, bool value) { instance.UpdateNodePosition = value; }
        }

        internal class MaxAccelAccessor : SingleAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly MaxAccelAccessor Instance = new MaxAccelAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.MaxAccel);
            public override float GetPrefab(CrowdAgentPrefab instance) { return instance.MaxAccel; }
            public override void SetPrefab(CrowdAgentPrefab instance, float value) { instance.MaxAccel = value; }
            public override float GetUrho(CrowdAgent instance) { return instance.MaxAccel; }
            public override void SetUrho(CrowdAgent instance, float value) { instance.MaxAccel = value; }
        }

        internal class MaxSpeedAccessor : SingleAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly MaxSpeedAccessor Instance = new MaxSpeedAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.MaxSpeed);
            public override float GetPrefab(CrowdAgentPrefab instance) { return instance.MaxSpeed; }
            public override void SetPrefab(CrowdAgentPrefab instance, float value) { instance.MaxSpeed = value; }
            public override float GetUrho(CrowdAgent instance) { return instance.MaxSpeed; }
            public override void SetUrho(CrowdAgent instance, float value) { instance.MaxSpeed = value; }
        }

        internal class RadiusAccessor : SingleAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly RadiusAccessor Instance = new RadiusAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.Radius);
            public override float GetPrefab(CrowdAgentPrefab instance) { return instance.Radius; }
            public override void SetPrefab(CrowdAgentPrefab instance, float value) { instance.Radius = value; }
            public override float GetUrho(CrowdAgent instance) { return instance.Radius; }
            public override void SetUrho(CrowdAgent instance, float value) { instance.Radius = value; }
        }

        internal class HeightAccessor : SingleAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly HeightAccessor Instance = new HeightAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.Height);
            public override float GetPrefab(CrowdAgentPrefab instance) { return instance.Height; }
            public override void SetPrefab(CrowdAgentPrefab instance, float value) { instance.Height = value; }
            public override float GetUrho(CrowdAgent instance) { return instance.Height; }
            public override void SetUrho(CrowdAgent instance, float value) { instance.Height = value; }
        }

        internal class QueryFilterTypeAccessor : UInt32Accessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly QueryFilterTypeAccessor Instance = new QueryFilterTypeAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.QueryFilterType);
            public override uint GetPrefab(CrowdAgentPrefab instance) { return instance.QueryFilterType; }
            public override void SetPrefab(CrowdAgentPrefab instance, uint value) { instance.QueryFilterType = value; }
            public override uint GetUrho(CrowdAgent instance) { return instance.QueryFilterType; }
            public override void SetUrho(CrowdAgent instance, uint value) { instance.QueryFilterType = value; }
        }

        internal class ObstacleAvoidanceTypeAccessor : UInt32Accessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly ObstacleAvoidanceTypeAccessor Instance = new ObstacleAvoidanceTypeAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.ObstacleAvoidanceType);
            public override uint GetPrefab(CrowdAgentPrefab instance) { return instance.ObstacleAvoidanceType; }
            public override void SetPrefab(CrowdAgentPrefab instance, uint value) { instance.ObstacleAvoidanceType = value; }
            public override uint GetUrho(CrowdAgent instance) { return instance.ObstacleAvoidanceType; }
            public override void SetUrho(CrowdAgent instance, uint value) { instance.ObstacleAvoidanceType = value; }
        }

        internal class NavigationQualityAccessor : EnumAccessor<CrowdAgentPrefab, CrowdAgent, NavigationQuality>
        {
            public static readonly NavigationQualityAccessor Instance = new NavigationQualityAccessor();
            public static readonly NavigationQuality DefaultValue = NavigationQuality.High;
            public override NavigationQuality DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.NavigationQuality);
            public override NavigationQuality GetPrefab(CrowdAgentPrefab instance) { return instance.NavigationQuality; }
            public override void SetPrefab(CrowdAgentPrefab instance, NavigationQuality value) { instance.NavigationQuality = value; }
            public override NavigationQuality GetUrho(CrowdAgent instance) { return instance.NavigationQuality; }
            public override void SetUrho(CrowdAgent instance, NavigationQuality value) { instance.NavigationQuality = value; }
        }

        internal class NavigationPushinessAccessor : EnumAccessor<CrowdAgentPrefab, CrowdAgent, NavigationPushiness>
        {
            public static readonly NavigationPushinessAccessor Instance = new NavigationPushinessAccessor();
            public static readonly NavigationPushiness DefaultValue = NavigationPushiness.Medium;
            public override NavigationPushiness DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.NavigationPushiness);
            public override NavigationPushiness GetPrefab(CrowdAgentPrefab instance) { return instance.NavigationPushiness; }
            public override void SetPrefab(CrowdAgentPrefab instance, NavigationPushiness value) { instance.NavigationPushiness = value; }
            public override NavigationPushiness GetUrho(CrowdAgent instance) { return instance.NavigationPushiness; }
            public override void SetUrho(CrowdAgent instance, NavigationPushiness value) { instance.NavigationPushiness = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.Enabled);
            public override bool GetPrefab(CrowdAgentPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(CrowdAgentPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(CrowdAgent instance) { return instance.Enabled; }
            public override void SetUrho(CrowdAgent instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.AnimationEnabled);
            public override bool GetPrefab(CrowdAgentPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(CrowdAgentPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(CrowdAgent instance) { return instance.AnimationEnabled; }
            public override void SetUrho(CrowdAgent instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.Temporary);
            public override bool GetPrefab(CrowdAgentPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(CrowdAgentPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(CrowdAgent instance) { return instance.Temporary; }
            public override void SetUrho(CrowdAgent instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<CrowdAgentPrefab, CrowdAgent>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CrowdAgent.BlockEvents);
            public override bool GetPrefab(CrowdAgentPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(CrowdAgentPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(CrowdAgent instance) { return instance.BlockEvents; }
            public override void SetUrho(CrowdAgent instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
