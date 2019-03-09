using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using NetworkPriority = Urho.Network.NetworkPriority;

using Urho.Network;

namespace UrhoSharp.Prefabs
{
    public partial class NetworkPriorityPrefab: AbstractComponentPrefab<NetworkPriority>, IPrefab
    {
        public override string TypeName { get { return NetworkPriority.TypeNameStatic; } }
        public float BasePriority { get; set; }
        public float DistanceFactor { get; set; }
        public float MinPriority { get; set; }
        public bool AlwaysUpdateOwner { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public NetworkPriorityPrefab()
        {
            BasePriority = BasePriorityAccessor.DefaultValue;
            DistanceFactor = DistanceFactorAccessor.DefaultValue;
            MinPriority = MinPriorityAccessor.DefaultValue;
            AlwaysUpdateOwner = AlwaysUpdateOwnerAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public NetworkPriorityPrefab(NetworkPriority val)
        {
            ID = val.ID;
            BasePriority = val.BasePriority;
            DistanceFactor = val.DistanceFactor;
            MinPriority = val.MinPriority;
            AlwaysUpdateOwner = val.AlwaysUpdateOwner;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override NetworkPriority Create()
        {
            var result = new NetworkPriority();
            BasePriorityAccessor.Instance.ApplyIfChanged(this, result);
            DistanceFactorAccessor.Instance.ApplyIfChanged(this, result);
            MinPriorityAccessor.Instance.ApplyIfChanged(this, result);
            AlwaysUpdateOwnerAccessor.Instance.ApplyIfChanged(this, result);
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
                case "BasePriority":
                    BasePriorityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DistanceFactor":
                    DistanceFactorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MinPriority":
                    MinPriorityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AlwaysUpdateOwner":
                    AlwaysUpdateOwnerAccessor.Instance.ParseAndSet(value, this);
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
                yield return BasePriorityAccessor.Instance;
                yield return DistanceFactorAccessor.Instance;
                yield return MinPriorityAccessor.Instance;
                yield return AlwaysUpdateOwnerAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class BasePriorityAccessor : SingleAccessor<NetworkPriorityPrefab, NetworkPriority>
        {
            public static readonly BasePriorityAccessor Instance = new BasePriorityAccessor();
            public static readonly float DefaultValue = 100f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NetworkPriority.BasePriority);
            public override float GetPrefab(NetworkPriorityPrefab instance) { return instance.BasePriority; }
            public override void SetPrefab(NetworkPriorityPrefab instance, float value) { instance.BasePriority = value; }
            public override float GetUrho(NetworkPriority instance) { return instance.BasePriority; }
            public override void SetUrho(NetworkPriority instance, float value) { instance.BasePriority = value; }
        }

        internal class DistanceFactorAccessor : SingleAccessor<NetworkPriorityPrefab, NetworkPriority>
        {
            public static readonly DistanceFactorAccessor Instance = new DistanceFactorAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NetworkPriority.DistanceFactor);
            public override float GetPrefab(NetworkPriorityPrefab instance) { return instance.DistanceFactor; }
            public override void SetPrefab(NetworkPriorityPrefab instance, float value) { instance.DistanceFactor = value; }
            public override float GetUrho(NetworkPriority instance) { return instance.DistanceFactor; }
            public override void SetUrho(NetworkPriority instance, float value) { instance.DistanceFactor = value; }
        }

        internal class MinPriorityAccessor : SingleAccessor<NetworkPriorityPrefab, NetworkPriority>
        {
            public static readonly MinPriorityAccessor Instance = new MinPriorityAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NetworkPriority.MinPriority);
            public override float GetPrefab(NetworkPriorityPrefab instance) { return instance.MinPriority; }
            public override void SetPrefab(NetworkPriorityPrefab instance, float value) { instance.MinPriority = value; }
            public override float GetUrho(NetworkPriority instance) { return instance.MinPriority; }
            public override void SetUrho(NetworkPriority instance, float value) { instance.MinPriority = value; }
        }

        internal class AlwaysUpdateOwnerAccessor : BooleanAccessor<NetworkPriorityPrefab, NetworkPriority>
        {
            public static readonly AlwaysUpdateOwnerAccessor Instance = new AlwaysUpdateOwnerAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NetworkPriority.AlwaysUpdateOwner);
            public override bool GetPrefab(NetworkPriorityPrefab instance) { return instance.AlwaysUpdateOwner; }
            public override void SetPrefab(NetworkPriorityPrefab instance, bool value) { instance.AlwaysUpdateOwner = value; }
            public override bool GetUrho(NetworkPriority instance) { return instance.AlwaysUpdateOwner; }
            public override void SetUrho(NetworkPriority instance, bool value) { instance.AlwaysUpdateOwner = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<NetworkPriorityPrefab, NetworkPriority>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NetworkPriority.Enabled);
            public override bool GetPrefab(NetworkPriorityPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(NetworkPriorityPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(NetworkPriority instance) { return instance.Enabled; }
            public override void SetUrho(NetworkPriority instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<NetworkPriorityPrefab, NetworkPriority>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NetworkPriority.AnimationEnabled);
            public override bool GetPrefab(NetworkPriorityPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(NetworkPriorityPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(NetworkPriority instance) { return instance.AnimationEnabled; }
            public override void SetUrho(NetworkPriority instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<NetworkPriorityPrefab, NetworkPriority>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NetworkPriority.Temporary);
            public override bool GetPrefab(NetworkPriorityPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(NetworkPriorityPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(NetworkPriority instance) { return instance.Temporary; }
            public override void SetUrho(NetworkPriority instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<NetworkPriorityPrefab, NetworkPriority>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NetworkPriority.BlockEvents);
            public override bool GetPrefab(NetworkPriorityPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(NetworkPriorityPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(NetworkPriority instance) { return instance.BlockEvents; }
            public override void SetUrho(NetworkPriority instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
