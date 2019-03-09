using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Obstacle = Urho.Navigation.Obstacle;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public partial class ObstaclePrefab: AbstractComponentPrefab<Obstacle>, IPrefab
    {
        public override string TypeName { get { return Obstacle.TypeNameStatic; } }
        public float Height { get; set; }
        public float Radius { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ObstaclePrefab()
        {
            Height = HeightAccessor.DefaultValue;
            Radius = RadiusAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ObstaclePrefab(Obstacle val)
        {
            ID = val.ID;
            Height = val.Height;
            Radius = val.Radius;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Obstacle Create()
        {
            var result = new Obstacle();
            HeightAccessor.Instance.ApplyIfChanged(this, result);
            RadiusAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Height":
                    HeightAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Radius":
                    RadiusAccessor.Instance.ParseAndSet(value, this);
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
                yield return HeightAccessor.Instance;
                yield return RadiusAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class HeightAccessor : SingleAccessor<ObstaclePrefab, Obstacle>
        {
            public static readonly HeightAccessor Instance = new HeightAccessor();
            public static readonly float DefaultValue = 5f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Obstacle.Height);
            public override float GetPrefab(ObstaclePrefab instance) { return instance.Height; }
            public override void SetPrefab(ObstaclePrefab instance, float value) { instance.Height = value; }
            public override float GetUrho(Obstacle instance) { return instance.Height; }
            public override void SetUrho(Obstacle instance, float value) { instance.Height = value; }
        }

        internal class RadiusAccessor : SingleAccessor<ObstaclePrefab, Obstacle>
        {
            public static readonly RadiusAccessor Instance = new RadiusAccessor();
            public static readonly float DefaultValue = 5f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Obstacle.Radius);
            public override float GetPrefab(ObstaclePrefab instance) { return instance.Radius; }
            public override void SetPrefab(ObstaclePrefab instance, float value) { instance.Radius = value; }
            public override float GetUrho(Obstacle instance) { return instance.Radius; }
            public override void SetUrho(Obstacle instance, float value) { instance.Radius = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ObstaclePrefab, Obstacle>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Obstacle.Enabled);
            public override bool GetPrefab(ObstaclePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ObstaclePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Obstacle instance) { return instance.Enabled; }
            public override void SetUrho(Obstacle instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ObstaclePrefab, Obstacle>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Obstacle.AnimationEnabled);
            public override bool GetPrefab(ObstaclePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ObstaclePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Obstacle instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Obstacle instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ObstaclePrefab, Obstacle>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Obstacle.Temporary);
            public override bool GetPrefab(ObstaclePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ObstaclePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Obstacle instance) { return instance.Temporary; }
            public override void SetUrho(Obstacle instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ObstaclePrefab, Obstacle>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Obstacle.BlockEvents);
            public override bool GetPrefab(ObstaclePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ObstaclePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Obstacle instance) { return instance.BlockEvents; }
            public override void SetUrho(Obstacle instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
