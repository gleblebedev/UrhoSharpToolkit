using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using DebugRenderer = Urho.DebugRenderer;


namespace UrhoSharp.Prefabs
{
    public partial class DebugRendererPrefab: AbstractComponentPrefab<DebugRenderer>, IPrefab
    {
        public override string TypeName { get { return DebugRenderer.TypeNameStatic; } }
        public bool LineAntiAlias { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public DebugRendererPrefab()
        {
            LineAntiAlias = LineAntiAliasAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public DebugRendererPrefab(DebugRenderer val)
        {
            ID = val.ID;
            LineAntiAlias = val.LineAntiAlias;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override DebugRenderer Create()
        {
            var result = new DebugRenderer();
            LineAntiAliasAccessor.Instance.ApplyIfChanged(this, result);
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
                case "LineAntiAlias":
                    LineAntiAliasAccessor.Instance.ParseAndSet(value, this);
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
                yield return LineAntiAliasAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class LineAntiAliasAccessor : BooleanAccessor<DebugRendererPrefab, DebugRenderer>
        {
            public static readonly LineAntiAliasAccessor Instance = new LineAntiAliasAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DebugRenderer.LineAntiAlias);
            public override bool GetPrefab(DebugRendererPrefab instance) { return instance.LineAntiAlias; }
            public override void SetPrefab(DebugRendererPrefab instance, bool value) { instance.LineAntiAlias = value; }
            public override bool GetUrho(DebugRenderer instance) { return instance.LineAntiAlias; }
            public override void SetUrho(DebugRenderer instance, bool value) { instance.LineAntiAlias = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<DebugRendererPrefab, DebugRenderer>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DebugRenderer.Enabled);
            public override bool GetPrefab(DebugRendererPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(DebugRendererPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(DebugRenderer instance) { return instance.Enabled; }
            public override void SetUrho(DebugRenderer instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<DebugRendererPrefab, DebugRenderer>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DebugRenderer.AnimationEnabled);
            public override bool GetPrefab(DebugRendererPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(DebugRendererPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(DebugRenderer instance) { return instance.AnimationEnabled; }
            public override void SetUrho(DebugRenderer instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<DebugRendererPrefab, DebugRenderer>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DebugRenderer.Temporary);
            public override bool GetPrefab(DebugRendererPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(DebugRendererPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(DebugRenderer instance) { return instance.Temporary; }
            public override void SetUrho(DebugRenderer instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<DebugRendererPrefab, DebugRenderer>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DebugRenderer.BlockEvents);
            public override bool GetPrefab(DebugRendererPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(DebugRendererPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(DebugRenderer instance) { return instance.BlockEvents; }
            public override void SetUrho(DebugRenderer instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
