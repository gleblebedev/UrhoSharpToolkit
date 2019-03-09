using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ScriptInstance = Urho.Portable.ScriptInstance;

using Urho.Portable;

namespace UrhoSharp.Prefabs
{
    public partial class ScriptInstancePrefab: AbstractComponentPrefab<ScriptInstance>, IPrefab
    {
        public override string TypeName { get { return ScriptInstance.TypeNameStatic; } }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ScriptInstancePrefab()
        {
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ScriptInstancePrefab(ScriptInstance val)
        {
            ID = val.ID;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ScriptInstance Create()
        {
            var result = new ScriptInstance();
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

        internal class EnabledAccessor : BooleanAccessor<ScriptInstancePrefab, ScriptInstance>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ScriptInstance.Enabled);
            public override bool GetPrefab(ScriptInstancePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ScriptInstancePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ScriptInstance instance) { return instance.Enabled; }
            public override void SetUrho(ScriptInstance instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ScriptInstancePrefab, ScriptInstance>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ScriptInstance.AnimationEnabled);
            public override bool GetPrefab(ScriptInstancePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ScriptInstancePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ScriptInstance instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ScriptInstance instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ScriptInstancePrefab, ScriptInstance>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ScriptInstance.Temporary);
            public override bool GetPrefab(ScriptInstancePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ScriptInstancePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ScriptInstance instance) { return instance.Temporary; }
            public override void SetUrho(ScriptInstance instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ScriptInstancePrefab, ScriptInstance>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ScriptInstance.BlockEvents);
            public override bool GetPrefab(ScriptInstancePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ScriptInstancePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ScriptInstance instance) { return instance.BlockEvents; }
            public override void SetUrho(ScriptInstance instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
