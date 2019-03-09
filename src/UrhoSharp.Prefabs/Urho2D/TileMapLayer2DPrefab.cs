using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using TileMapLayer2D = Urho.Urho2D.TileMapLayer2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class TileMapLayer2DPrefab: AbstractComponentPrefab<TileMapLayer2D>, IPrefab
    {
        public override string TypeName { get { return TileMapLayer2D.TypeNameStatic; } }
        public int DrawOrder { get; set; }
        public bool Visible { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public TileMapLayer2DPrefab()
        {
            DrawOrder = DrawOrderAccessor.DefaultValue;
            Visible = VisibleAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public TileMapLayer2DPrefab(TileMapLayer2D val)
        {
            ID = val.ID;
            DrawOrder = val.DrawOrder;
            Visible = val.Visible;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override TileMapLayer2D Create()
        {
            var result = new TileMapLayer2D();
            DrawOrderAccessor.Instance.ApplyIfChanged(this, result);
            VisibleAccessor.Instance.ApplyIfChanged(this, result);
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
                case "DrawOrder":
                    DrawOrderAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Visible":
                    VisibleAccessor.Instance.ParseAndSet(value, this);
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
                yield return DrawOrderAccessor.Instance;
                yield return VisibleAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class DrawOrderAccessor : Int32Accessor<TileMapLayer2DPrefab, TileMapLayer2D>
        {
            public static readonly DrawOrderAccessor Instance = new DrawOrderAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMapLayer2D.DrawOrder);
            public override int GetPrefab(TileMapLayer2DPrefab instance) { return instance.DrawOrder; }
            public override void SetPrefab(TileMapLayer2DPrefab instance, int value) { instance.DrawOrder = value; }
            public override int GetUrho(TileMapLayer2D instance) { return instance.DrawOrder; }
            public override void SetUrho(TileMapLayer2D instance, int value) { instance.DrawOrder = value; }
        }

        internal class VisibleAccessor : BooleanAccessor<TileMapLayer2DPrefab, TileMapLayer2D>
        {
            public static readonly VisibleAccessor Instance = new VisibleAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMapLayer2D.Visible);
            public override bool GetPrefab(TileMapLayer2DPrefab instance) { return instance.Visible; }
            public override void SetPrefab(TileMapLayer2DPrefab instance, bool value) { instance.Visible = value; }
            public override bool GetUrho(TileMapLayer2D instance) { return instance.Visible; }
            public override void SetUrho(TileMapLayer2D instance, bool value) { instance.Visible = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<TileMapLayer2DPrefab, TileMapLayer2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMapLayer2D.Enabled);
            public override bool GetPrefab(TileMapLayer2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(TileMapLayer2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(TileMapLayer2D instance) { return instance.Enabled; }
            public override void SetUrho(TileMapLayer2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<TileMapLayer2DPrefab, TileMapLayer2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMapLayer2D.AnimationEnabled);
            public override bool GetPrefab(TileMapLayer2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(TileMapLayer2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(TileMapLayer2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(TileMapLayer2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<TileMapLayer2DPrefab, TileMapLayer2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMapLayer2D.Temporary);
            public override bool GetPrefab(TileMapLayer2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(TileMapLayer2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(TileMapLayer2D instance) { return instance.Temporary; }
            public override void SetUrho(TileMapLayer2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<TileMapLayer2DPrefab, TileMapLayer2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TileMapLayer2D.BlockEvents);
            public override bool GetPrefab(TileMapLayer2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(TileMapLayer2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(TileMapLayer2D instance) { return instance.BlockEvents; }
            public override void SetUrho(TileMapLayer2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
