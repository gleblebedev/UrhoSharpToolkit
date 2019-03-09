using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using TileMap2D = Urho.Urho2D.TileMap2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class TileMap2DPrefab: AbstractComponentPrefab<TileMap2D>, IPrefab
    {
        public override string TypeName { get { return TileMap2D.TypeNameStatic; } }
        public TmxFile2D TmxFile { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public TileMap2DPrefab()
        {
            TmxFile = TmxFileAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public TileMap2DPrefab(TileMap2D val)
        {
            ID = val.ID;
            TmxFile = val.TmxFile;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override TileMap2D Create()
        {
            var result = new TileMap2D();
            TmxFileAccessor.Instance.ApplyIfChanged(this, result);
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
                case "TmxFile":
                    TmxFileAccessor.Instance.ParseAndSet(value, this);
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
                yield return TmxFileAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class TmxFileAccessor : TmxFile2DAccessor<TileMap2DPrefab, TileMap2D>
        {
            public static readonly TmxFileAccessor Instance = new TmxFileAccessor();
            public static readonly TmxFile2D DefaultValue = null;
            public override TmxFile2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMap2D.TmxFile);
            public override TmxFile2D GetPrefab(TileMap2DPrefab instance) { return instance.TmxFile; }
            public override void SetPrefab(TileMap2DPrefab instance, TmxFile2D value) { instance.TmxFile = value; }
            public override TmxFile2D GetUrho(TileMap2D instance) { return instance.TmxFile; }
            public override void SetUrho(TileMap2D instance, TmxFile2D value) { instance.TmxFile = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<TileMap2DPrefab, TileMap2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMap2D.Enabled);
            public override bool GetPrefab(TileMap2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(TileMap2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(TileMap2D instance) { return instance.Enabled; }
            public override void SetUrho(TileMap2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<TileMap2DPrefab, TileMap2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMap2D.AnimationEnabled);
            public override bool GetPrefab(TileMap2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(TileMap2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(TileMap2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(TileMap2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<TileMap2DPrefab, TileMap2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMap2D.Temporary);
            public override bool GetPrefab(TileMap2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(TileMap2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(TileMap2D instance) { return instance.Temporary; }
            public override void SetUrho(TileMap2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<TileMap2DPrefab, TileMap2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMap2D.BlockEvents);
            public override bool GetPrefab(TileMap2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(TileMap2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(TileMap2D instance) { return instance.BlockEvents; }
            public override void SetUrho(TileMap2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
