using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using WirePlane = Urho.WirePlane;


namespace UrhoSharp.Prefabs
{
    public partial class WirePlanePrefab: AbstractComponentPrefab<WirePlane>, IPrefab
    {
        public override string TypeName { get { return WirePlane.TypeNameStatic; } }
        public int Size { get; set; }
        public float Scale { get; set; }
        public Color Color { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public WirePlanePrefab()
        {
            Size = SizeAccessor.DefaultValue;
            Scale = ScaleAccessor.DefaultValue;
            Color = ColorAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public WirePlanePrefab(WirePlane val)
        {
            ID = val.ID;
            Size = val.Size;
            Scale = val.Scale;
            Color = val.Color;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override WirePlane Create()
        {
            var result = new WirePlane();
            SizeAccessor.Instance.ApplyIfChanged(this, result);
            ScaleAccessor.Instance.ApplyIfChanged(this, result);
            ColorAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Size":
                    SizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Scale":
                    ScaleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Color":
                    ColorAccessor.Instance.ParseAndSet(value, this);
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
                yield return SizeAccessor.Instance;
                yield return ScaleAccessor.Instance;
                yield return ColorAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class SizeAccessor : Int32Accessor<WirePlanePrefab, WirePlane>
        {
            public static readonly SizeAccessor Instance = new SizeAccessor();
            public static readonly int DefaultValue = 50;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(WirePlane.Size);
            public override int GetPrefab(WirePlanePrefab instance) { return instance.Size; }
            public override void SetPrefab(WirePlanePrefab instance, int value) { instance.Size = value; }
            public override int GetUrho(WirePlane instance) { return instance.Size; }
            public override void SetUrho(WirePlane instance, int value) { instance.Size = value; }
        }

        internal class ScaleAccessor : SingleAccessor<WirePlanePrefab, WirePlane>
        {
            public static readonly ScaleAccessor Instance = new ScaleAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(WirePlane.Scale);
            public override float GetPrefab(WirePlanePrefab instance) { return instance.Scale; }
            public override void SetPrefab(WirePlanePrefab instance, float value) { instance.Scale = value; }
            public override float GetUrho(WirePlane instance) { return instance.Scale; }
            public override void SetUrho(WirePlane instance, float value) { instance.Scale = value; }
        }

        internal class ColorAccessor : ColorAccessor<WirePlanePrefab, WirePlane>
        {
            public static readonly ColorAccessor Instance = new ColorAccessor();
            public static readonly Color DefaultValue = new Color(0.7f, 0.7f, 0.7f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(WirePlane.Color);
            public override Color GetPrefab(WirePlanePrefab instance) { return instance.Color; }
            public override void SetPrefab(WirePlanePrefab instance, Color value) { instance.Color = value; }
            public override Color GetUrho(WirePlane instance) { return instance.Color; }
            public override void SetUrho(WirePlane instance, Color value) { instance.Color = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<WirePlanePrefab, WirePlane>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(WirePlane.Enabled);
            public override bool GetPrefab(WirePlanePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(WirePlanePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(WirePlane instance) { return instance.Enabled; }
            public override void SetUrho(WirePlane instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<WirePlanePrefab, WirePlane>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(WirePlane.AnimationEnabled);
            public override bool GetPrefab(WirePlanePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(WirePlanePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(WirePlane instance) { return instance.AnimationEnabled; }
            public override void SetUrho(WirePlane instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<WirePlanePrefab, WirePlane>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(WirePlane.Temporary);
            public override bool GetPrefab(WirePlanePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(WirePlanePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(WirePlane instance) { return instance.Temporary; }
            public override void SetUrho(WirePlane instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<WirePlanePrefab, WirePlane>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(WirePlane.BlockEvents);
            public override bool GetPrefab(WirePlanePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(WirePlanePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(WirePlane instance) { return instance.BlockEvents; }
            public override void SetUrho(WirePlane instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
