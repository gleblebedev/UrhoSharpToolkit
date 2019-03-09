using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Component = Urho.Component;


namespace UrhoSharp.Prefabs
{
    public partial class ComponentPrefab: AbstractComponentPrefab<Component>, IPrefab
    {
        public override string TypeName { get { return Component.TypeNameStatic; } }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ComponentPrefab()
        {
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ComponentPrefab(Component val)
        {
            ID = val.ID;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Component Create()
        {
            var result = new Component();
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

        internal class EnabledAccessor : BooleanAccessor<ComponentPrefab, Component>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Component.Enabled);
            public override bool GetPrefab(ComponentPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ComponentPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Component instance) { return instance.Enabled; }
            public override void SetUrho(Component instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ComponentPrefab, Component>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Component.AnimationEnabled);
            public override bool GetPrefab(ComponentPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ComponentPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Component instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Component instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ComponentPrefab, Component>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Component.Temporary);
            public override bool GetPrefab(ComponentPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ComponentPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Component instance) { return instance.Temporary; }
            public override void SetUrho(Component instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ComponentPrefab, Component>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Component.BlockEvents);
            public override bool GetPrefab(ComponentPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ComponentPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Component instance) { return instance.BlockEvents; }
            public override void SetUrho(Component instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
