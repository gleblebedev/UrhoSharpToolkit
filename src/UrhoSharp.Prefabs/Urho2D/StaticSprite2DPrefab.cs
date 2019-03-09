using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using StaticSprite2D = Urho.Urho2D.StaticSprite2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class StaticSprite2DPrefab: AbstractComponentPrefab<StaticSprite2D>, IPrefab
    {
        public override string TypeName { get { return StaticSprite2D.TypeNameStatic; } }
        public Sprite2D Sprite { get; set; }
        public BlendMode BlendMode { get; set; }
        public bool FlipX { get; set; }
        public bool FlipY { get; set; }
        public Color Color { get; set; }
        public float Alpha { get; set; }
        public bool UseHotSpot { get; set; }
        public bool UseDrawRect { get; set; }
        public bool UseTextureRect { get; set; }
        public Vector2 HotSpot { get; set; }
        public Material CustomMaterial { get; set; }
        public int Layer { get; set; }
        public int OrderInLayer { get; set; }
        public float DrawDistance { get; set; }
        public float ShadowDistance { get; set; }
        public float LodBias { get; set; }
        public uint ViewMask { get; set; }
        public uint LightMask { get; set; }
        public uint ShadowMask { get; set; }
        public uint ZoneMask { get; set; }
        public uint MaxLights { get; set; }
        public bool CastShadows { get; set; }
        public bool Occluder { get; set; }
        public bool Occludee { get; set; }
        public float SortValue { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public StaticSprite2DPrefab()
        {
            Sprite = SpriteAccessor.DefaultValue;
            BlendMode = BlendModeAccessor.DefaultValue;
            FlipX = FlipXAccessor.DefaultValue;
            FlipY = FlipYAccessor.DefaultValue;
            Color = ColorAccessor.DefaultValue;
            Alpha = AlphaAccessor.DefaultValue;
            UseHotSpot = UseHotSpotAccessor.DefaultValue;
            UseDrawRect = UseDrawRectAccessor.DefaultValue;
            UseTextureRect = UseTextureRectAccessor.DefaultValue;
            HotSpot = HotSpotAccessor.DefaultValue;
            CustomMaterial = CustomMaterialAccessor.DefaultValue;
            Layer = LayerAccessor.DefaultValue;
            OrderInLayer = OrderInLayerAccessor.DefaultValue;
            DrawDistance = DrawDistanceAccessor.DefaultValue;
            ShadowDistance = ShadowDistanceAccessor.DefaultValue;
            LodBias = LodBiasAccessor.DefaultValue;
            ViewMask = ViewMaskAccessor.DefaultValue;
            LightMask = LightMaskAccessor.DefaultValue;
            ShadowMask = ShadowMaskAccessor.DefaultValue;
            ZoneMask = ZoneMaskAccessor.DefaultValue;
            MaxLights = MaxLightsAccessor.DefaultValue;
            CastShadows = CastShadowsAccessor.DefaultValue;
            Occluder = OccluderAccessor.DefaultValue;
            Occludee = OccludeeAccessor.DefaultValue;
            SortValue = SortValueAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public StaticSprite2DPrefab(StaticSprite2D val)
        {
            ID = val.ID;
            Sprite = val.Sprite;
            BlendMode = val.BlendMode;
            FlipX = val.FlipX;
            FlipY = val.FlipY;
            Color = val.Color;
            Alpha = val.Alpha;
            UseHotSpot = val.UseHotSpot;
            UseDrawRect = val.UseDrawRect;
            UseTextureRect = val.UseTextureRect;
            HotSpot = val.HotSpot;
            CustomMaterial = val.CustomMaterial;
            Layer = val.Layer;
            OrderInLayer = val.OrderInLayer;
            DrawDistance = val.DrawDistance;
            ShadowDistance = val.ShadowDistance;
            LodBias = val.LodBias;
            ViewMask = val.ViewMask;
            LightMask = val.LightMask;
            ShadowMask = val.ShadowMask;
            ZoneMask = val.ZoneMask;
            MaxLights = val.MaxLights;
            CastShadows = val.CastShadows;
            Occluder = val.Occluder;
            Occludee = val.Occludee;
            SortValue = val.SortValue;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override StaticSprite2D Create()
        {
            var result = new StaticSprite2D();
            SpriteAccessor.Instance.ApplyIfChanged(this, result);
            BlendModeAccessor.Instance.ApplyIfChanged(this, result);
            FlipXAccessor.Instance.ApplyIfChanged(this, result);
            FlipYAccessor.Instance.ApplyIfChanged(this, result);
            ColorAccessor.Instance.ApplyIfChanged(this, result);
            AlphaAccessor.Instance.ApplyIfChanged(this, result);
            UseHotSpotAccessor.Instance.ApplyIfChanged(this, result);
            UseDrawRectAccessor.Instance.ApplyIfChanged(this, result);
            UseTextureRectAccessor.Instance.ApplyIfChanged(this, result);
            HotSpotAccessor.Instance.ApplyIfChanged(this, result);
            CustomMaterialAccessor.Instance.ApplyIfChanged(this, result);
            LayerAccessor.Instance.ApplyIfChanged(this, result);
            OrderInLayerAccessor.Instance.ApplyIfChanged(this, result);
            DrawDistanceAccessor.Instance.ApplyIfChanged(this, result);
            ShadowDistanceAccessor.Instance.ApplyIfChanged(this, result);
            LodBiasAccessor.Instance.ApplyIfChanged(this, result);
            ViewMaskAccessor.Instance.ApplyIfChanged(this, result);
            LightMaskAccessor.Instance.ApplyIfChanged(this, result);
            ShadowMaskAccessor.Instance.ApplyIfChanged(this, result);
            ZoneMaskAccessor.Instance.ApplyIfChanged(this, result);
            MaxLightsAccessor.Instance.ApplyIfChanged(this, result);
            CastShadowsAccessor.Instance.ApplyIfChanged(this, result);
            OccluderAccessor.Instance.ApplyIfChanged(this, result);
            OccludeeAccessor.Instance.ApplyIfChanged(this, result);
            SortValueAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Sprite":
                    SpriteAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "BlendMode":
                    BlendModeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FlipX":
                    FlipXAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FlipY":
                    FlipYAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Color":
                    ColorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Alpha":
                    AlphaAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UseHotSpot":
                    UseHotSpotAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UseDrawRect":
                    UseDrawRectAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UseTextureRect":
                    UseTextureRectAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "HotSpot":
                    HotSpotAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CustomMaterial":
                    CustomMaterialAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Layer":
                    LayerAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OrderInLayer":
                    OrderInLayerAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawDistance":
                    DrawDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowDistance":
                    ShadowDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LodBias":
                    LodBiasAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ViewMask":
                    ViewMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LightMask":
                    LightMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowMask":
                    ShadowMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ZoneMask":
                    ZoneMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxLights":
                    MaxLightsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CastShadows":
                    CastShadowsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Occluder":
                    OccluderAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Occludee":
                    OccludeeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "SortValue":
                    SortValueAccessor.Instance.ParseAndSet(value, this);
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
                yield return SpriteAccessor.Instance;
                yield return BlendModeAccessor.Instance;
                yield return FlipXAccessor.Instance;
                yield return FlipYAccessor.Instance;
                yield return ColorAccessor.Instance;
                yield return AlphaAccessor.Instance;
                yield return UseHotSpotAccessor.Instance;
                yield return UseDrawRectAccessor.Instance;
                yield return UseTextureRectAccessor.Instance;
                yield return HotSpotAccessor.Instance;
                yield return CustomMaterialAccessor.Instance;
                yield return LayerAccessor.Instance;
                yield return OrderInLayerAccessor.Instance;
                yield return DrawDistanceAccessor.Instance;
                yield return ShadowDistanceAccessor.Instance;
                yield return LodBiasAccessor.Instance;
                yield return ViewMaskAccessor.Instance;
                yield return LightMaskAccessor.Instance;
                yield return ShadowMaskAccessor.Instance;
                yield return ZoneMaskAccessor.Instance;
                yield return MaxLightsAccessor.Instance;
                yield return CastShadowsAccessor.Instance;
                yield return OccluderAccessor.Instance;
                yield return OccludeeAccessor.Instance;
                yield return SortValueAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class SpriteAccessor : Sprite2DAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly SpriteAccessor Instance = new SpriteAccessor();
            public static readonly Sprite2D DefaultValue = null;
            public override Sprite2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.Sprite);
            public override Sprite2D GetPrefab(StaticSprite2DPrefab instance) { return instance.Sprite; }
            public override void SetPrefab(StaticSprite2DPrefab instance, Sprite2D value) { instance.Sprite = value; }
            public override Sprite2D GetUrho(StaticSprite2D instance) { return instance.Sprite; }
            public override void SetUrho(StaticSprite2D instance, Sprite2D value) { instance.Sprite = value; }
        }

        internal class BlendModeAccessor : EnumAccessor<StaticSprite2DPrefab, StaticSprite2D, BlendMode>
        {
            public static readonly BlendModeAccessor Instance = new BlendModeAccessor();
            public static readonly BlendMode DefaultValue = BlendMode.Alpha;
            public override BlendMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.BlendMode);
            public override BlendMode GetPrefab(StaticSprite2DPrefab instance) { return instance.BlendMode; }
            public override void SetPrefab(StaticSprite2DPrefab instance, BlendMode value) { instance.BlendMode = value; }
            public override BlendMode GetUrho(StaticSprite2D instance) { return instance.BlendMode; }
            public override void SetUrho(StaticSprite2D instance, BlendMode value) { instance.BlendMode = value; }
        }

        internal class FlipXAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly FlipXAccessor Instance = new FlipXAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.FlipX);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.FlipX; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.FlipX = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.FlipX; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.FlipX = value; }
        }

        internal class FlipYAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly FlipYAccessor Instance = new FlipYAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.FlipY);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.FlipY; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.FlipY = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.FlipY; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.FlipY = value; }
        }

        internal class ColorAccessor : ColorAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly ColorAccessor Instance = new ColorAccessor();
            public static readonly Color DefaultValue = new Color(1f, 1f, 1f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.Color);
            public override Color GetPrefab(StaticSprite2DPrefab instance) { return instance.Color; }
            public override void SetPrefab(StaticSprite2DPrefab instance, Color value) { instance.Color = value; }
            public override Color GetUrho(StaticSprite2D instance) { return instance.Color; }
            public override void SetUrho(StaticSprite2D instance, Color value) { instance.Color = value; }
        }

        internal class AlphaAccessor : SingleAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly AlphaAccessor Instance = new AlphaAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.Alpha);
            public override float GetPrefab(StaticSprite2DPrefab instance) { return instance.Alpha; }
            public override void SetPrefab(StaticSprite2DPrefab instance, float value) { instance.Alpha = value; }
            public override float GetUrho(StaticSprite2D instance) { return instance.Alpha; }
            public override void SetUrho(StaticSprite2D instance, float value) { instance.Alpha = value; }
        }

        internal class UseHotSpotAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly UseHotSpotAccessor Instance = new UseHotSpotAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.UseHotSpot);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.UseHotSpot; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.UseHotSpot = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.UseHotSpot; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.UseHotSpot = value; }
        }

        internal class UseDrawRectAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly UseDrawRectAccessor Instance = new UseDrawRectAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.UseDrawRect);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.UseDrawRect; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.UseDrawRect = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.UseDrawRect; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.UseDrawRect = value; }
        }

        internal class UseTextureRectAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly UseTextureRectAccessor Instance = new UseTextureRectAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.UseTextureRect);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.UseTextureRect; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.UseTextureRect = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.UseTextureRect; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.UseTextureRect = value; }
        }

        internal class HotSpotAccessor : Vector2Accessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly HotSpotAccessor Instance = new HotSpotAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0.5f, 0.5f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.HotSpot);
            public override Vector2 GetPrefab(StaticSprite2DPrefab instance) { return instance.HotSpot; }
            public override void SetPrefab(StaticSprite2DPrefab instance, Vector2 value) { instance.HotSpot = value; }
            public override Vector2 GetUrho(StaticSprite2D instance) { return instance.HotSpot; }
            public override void SetUrho(StaticSprite2D instance, Vector2 value) { instance.HotSpot = value; }
        }

        internal class CustomMaterialAccessor : MaterialAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly CustomMaterialAccessor Instance = new CustomMaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.CustomMaterial);
            public override Material GetPrefab(StaticSprite2DPrefab instance) { return instance.CustomMaterial; }
            public override void SetPrefab(StaticSprite2DPrefab instance, Material value) { instance.CustomMaterial = value; }
            public override Material GetUrho(StaticSprite2D instance) { return instance.CustomMaterial; }
            public override void SetUrho(StaticSprite2D instance, Material value) { instance.CustomMaterial = value; }
        }

        internal class LayerAccessor : Int32Accessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly LayerAccessor Instance = new LayerAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.Layer);
            public override int GetPrefab(StaticSprite2DPrefab instance) { return instance.Layer; }
            public override void SetPrefab(StaticSprite2DPrefab instance, int value) { instance.Layer = value; }
            public override int GetUrho(StaticSprite2D instance) { return instance.Layer; }
            public override void SetUrho(StaticSprite2D instance, int value) { instance.Layer = value; }
        }

        internal class OrderInLayerAccessor : Int32Accessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly OrderInLayerAccessor Instance = new OrderInLayerAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.OrderInLayer);
            public override int GetPrefab(StaticSprite2DPrefab instance) { return instance.OrderInLayer; }
            public override void SetPrefab(StaticSprite2DPrefab instance, int value) { instance.OrderInLayer = value; }
            public override int GetUrho(StaticSprite2D instance) { return instance.OrderInLayer; }
            public override void SetUrho(StaticSprite2D instance, int value) { instance.OrderInLayer = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.DrawDistance);
            public override float GetPrefab(StaticSprite2DPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(StaticSprite2DPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(StaticSprite2D instance) { return instance.DrawDistance; }
            public override void SetUrho(StaticSprite2D instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.ShadowDistance);
            public override float GetPrefab(StaticSprite2DPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(StaticSprite2DPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(StaticSprite2D instance) { return instance.ShadowDistance; }
            public override void SetUrho(StaticSprite2D instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.LodBias);
            public override float GetPrefab(StaticSprite2DPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(StaticSprite2DPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(StaticSprite2D instance) { return instance.LodBias; }
            public override void SetUrho(StaticSprite2D instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.ViewMask);
            public override uint GetPrefab(StaticSprite2DPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(StaticSprite2DPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(StaticSprite2D instance) { return instance.ViewMask; }
            public override void SetUrho(StaticSprite2D instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.LightMask);
            public override uint GetPrefab(StaticSprite2DPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(StaticSprite2DPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(StaticSprite2D instance) { return instance.LightMask; }
            public override void SetUrho(StaticSprite2D instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.ShadowMask);
            public override uint GetPrefab(StaticSprite2DPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(StaticSprite2DPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(StaticSprite2D instance) { return instance.ShadowMask; }
            public override void SetUrho(StaticSprite2D instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.ZoneMask);
            public override uint GetPrefab(StaticSprite2DPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(StaticSprite2DPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(StaticSprite2D instance) { return instance.ZoneMask; }
            public override void SetUrho(StaticSprite2D instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.MaxLights);
            public override uint GetPrefab(StaticSprite2DPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(StaticSprite2DPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(StaticSprite2D instance) { return instance.MaxLights; }
            public override void SetUrho(StaticSprite2D instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.CastShadows);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.CastShadows; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.Occluder);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.Occluder; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.Occludee);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.Occludee; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.SortValue);
            public override float GetPrefab(StaticSprite2DPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(StaticSprite2DPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(StaticSprite2D instance) { return instance.SortValue; }
            public override void SetUrho(StaticSprite2D instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.Enabled);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.Enabled; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.AnimationEnabled);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.Temporary);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.Temporary; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<StaticSprite2DPrefab, StaticSprite2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticSprite2D.BlockEvents);
            public override bool GetPrefab(StaticSprite2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(StaticSprite2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(StaticSprite2D instance) { return instance.BlockEvents; }
            public override void SetUrho(StaticSprite2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
