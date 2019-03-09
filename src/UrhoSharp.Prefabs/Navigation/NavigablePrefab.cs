using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Navigable = Urho.Navigation.Navigable;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public partial class NavigablePrefab: AbstractComponentPrefab<Navigable>, IPrefab
    {
        public override string TypeName { get { return Navigable.TypeNameStatic; } }
        public bool Recursive { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public NavigablePrefab()
        {
            Recursive = RecursiveAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public NavigablePrefab(Navigable val)
        {
            ID = val.ID;
            Recursive = val.Recursive;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Navigable Create()
        {
            var result = new Navigable();
            RecursiveAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Recursive":
                    RecursiveAccessor.Instance.ParseAndSet(value, this);
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
                yield return RecursiveAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class RecursiveAccessor : BooleanAccessor<NavigablePrefab, Navigable>
        {
            public static readonly RecursiveAccessor Instance = new RecursiveAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Navigable.Recursive);
            public override bool GetPrefab(NavigablePrefab instance) { return instance.Recursive; }
            public override void SetPrefab(NavigablePrefab instance, bool value) { instance.Recursive = value; }
            public override bool GetUrho(Navigable instance) { return instance.Recursive; }
            public override void SetUrho(Navigable instance, bool value) { instance.Recursive = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<NavigablePrefab, Navigable>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Navigable.Enabled);
            public override bool GetPrefab(NavigablePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(NavigablePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Navigable instance) { return instance.Enabled; }
            public override void SetUrho(Navigable instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<NavigablePrefab, Navigable>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Navigable.AnimationEnabled);
            public override bool GetPrefab(NavigablePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(NavigablePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Navigable instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Navigable instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<NavigablePrefab, Navigable>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Navigable.Temporary);
            public override bool GetPrefab(NavigablePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(NavigablePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Navigable instance) { return instance.Temporary; }
            public override void SetUrho(Navigable instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<NavigablePrefab, Navigable>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Navigable.BlockEvents);
            public override bool GetPrefab(NavigablePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(NavigablePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Navigable instance) { return instance.BlockEvents; }
            public override void SetUrho(Navigable instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
