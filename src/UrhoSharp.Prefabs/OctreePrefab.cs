using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Octree = Urho.Octree;


namespace UrhoSharp.Prefabs
{
    public partial class OctreePrefab: AbstractComponentPrefab<Octree>, IPrefab
    {
        public override string TypeName { get { return Octree.TypeNameStatic; } }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public OctreePrefab()
        {
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public OctreePrefab(Octree val)
        {
            ID = val.ID;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Octree Create()
        {
            var result = new Octree();
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
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class EnabledAccessor : BooleanAccessor<OctreePrefab, Octree>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Octree.Enabled);
            public override bool GetPrefab(OctreePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(OctreePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Octree instance) { return instance.Enabled; }
            public override void SetUrho(Octree instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<OctreePrefab, Octree>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Octree.AnimationEnabled);
            public override bool GetPrefab(OctreePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(OctreePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Octree instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Octree instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<OctreePrefab, Octree>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Octree.Temporary);
            public override bool GetPrefab(OctreePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(OctreePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Octree instance) { return instance.Temporary; }
            public override void SetUrho(Octree instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<OctreePrefab, Octree>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Octree.BlockEvents);
            public override bool GetPrefab(OctreePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(OctreePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Octree instance) { return instance.BlockEvents; }
            public override void SetUrho(Octree instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
