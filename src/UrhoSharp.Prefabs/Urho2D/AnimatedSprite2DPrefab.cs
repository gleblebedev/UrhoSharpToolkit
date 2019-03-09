using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using AnimatedSprite2D = Urho.Urho2D.AnimatedSprite2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class AnimatedSprite2DPrefab: AbstractComponentPrefab<AnimatedSprite2D>, IPrefab
    {
        public override string TypeName { get { return AnimatedSprite2D.TypeNameStatic; } }
        public AnimationSet2D AnimationSet { get; set; }
        public String Entity { get; set; }
        public LoopMode2D LoopMode { get; set; }
        public float Speed { get; set; }
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
        public AnimatedSprite2DPrefab()
        {
            AnimationSet = AnimationSetAccessor.DefaultValue;
            Entity = EntityAccessor.DefaultValue;
            LoopMode = LoopModeAccessor.DefaultValue;
            Speed = SpeedAccessor.DefaultValue;
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
        public AnimatedSprite2DPrefab(AnimatedSprite2D val)
        {
            ID = val.ID;
            AnimationSet = val.AnimationSet;
            Entity = val.Entity;
            LoopMode = val.LoopMode;
            Speed = val.Speed;
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
        public override AnimatedSprite2D Create()
        {
            var result = new AnimatedSprite2D();
            AnimationSetAccessor.Instance.ApplyIfChanged(this, result);
            EntityAccessor.Instance.ApplyIfChanged(this, result);
            LoopModeAccessor.Instance.ApplyIfChanged(this, result);
            SpeedAccessor.Instance.ApplyIfChanged(this, result);
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
                case "AnimationSet":
                    AnimationSetAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Entity":
                    EntityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LoopMode":
                    LoopModeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Speed":
                    SpeedAccessor.Instance.ParseAndSet(value, this);
                    break;
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
                yield return AnimationSetAccessor.Instance;
                yield return EntityAccessor.Instance;
                yield return LoopModeAccessor.Instance;
                yield return SpeedAccessor.Instance;
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

        internal class AnimationSetAccessor : AnimationSet2DAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly AnimationSetAccessor Instance = new AnimationSetAccessor();
            public static readonly AnimationSet2D DefaultValue = null;
            public override AnimationSet2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.AnimationSet);
            public override AnimationSet2D GetPrefab(AnimatedSprite2DPrefab instance) { return instance.AnimationSet; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, AnimationSet2D value) { instance.AnimationSet = value; }
            public override AnimationSet2D GetUrho(AnimatedSprite2D instance) { return instance.AnimationSet; }
            public override void SetUrho(AnimatedSprite2D instance, AnimationSet2D value) { instance.AnimationSet = value; }
        }

        internal class EntityAccessor : StringAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly EntityAccessor Instance = new EntityAccessor();
            public static readonly String DefaultValue = "";
            public override String DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Entity);
            public override String GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Entity; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, String value) { instance.Entity = value; }
            public override String GetUrho(AnimatedSprite2D instance) { return instance.Entity; }
            public override void SetUrho(AnimatedSprite2D instance, String value) { instance.Entity = value; }
        }

        internal class LoopModeAccessor : EnumAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D, LoopMode2D>
        {
            public static readonly LoopModeAccessor Instance = new LoopModeAccessor();
            public static readonly LoopMode2D DefaultValue = LoopMode2D.Default;
            public override LoopMode2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.LoopMode);
            public override LoopMode2D GetPrefab(AnimatedSprite2DPrefab instance) { return instance.LoopMode; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, LoopMode2D value) { instance.LoopMode = value; }
            public override LoopMode2D GetUrho(AnimatedSprite2D instance) { return instance.LoopMode; }
            public override void SetUrho(AnimatedSprite2D instance, LoopMode2D value) { instance.LoopMode = value; }
        }

        internal class SpeedAccessor : SingleAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly SpeedAccessor Instance = new SpeedAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Speed);
            public override float GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Speed; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, float value) { instance.Speed = value; }
            public override float GetUrho(AnimatedSprite2D instance) { return instance.Speed; }
            public override void SetUrho(AnimatedSprite2D instance, float value) { instance.Speed = value; }
        }

        internal class SpriteAccessor : Sprite2DAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly SpriteAccessor Instance = new SpriteAccessor();
            public static readonly Sprite2D DefaultValue = null;
            public override Sprite2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Sprite);
            public override Sprite2D GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Sprite; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, Sprite2D value) { instance.Sprite = value; }
            public override Sprite2D GetUrho(AnimatedSprite2D instance) { return instance.Sprite; }
            public override void SetUrho(AnimatedSprite2D instance, Sprite2D value) { instance.Sprite = value; }
        }

        internal class BlendModeAccessor : EnumAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D, BlendMode>
        {
            public static readonly BlendModeAccessor Instance = new BlendModeAccessor();
            public static readonly BlendMode DefaultValue = BlendMode.Alpha;
            public override BlendMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.BlendMode);
            public override BlendMode GetPrefab(AnimatedSprite2DPrefab instance) { return instance.BlendMode; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, BlendMode value) { instance.BlendMode = value; }
            public override BlendMode GetUrho(AnimatedSprite2D instance) { return instance.BlendMode; }
            public override void SetUrho(AnimatedSprite2D instance, BlendMode value) { instance.BlendMode = value; }
        }

        internal class FlipXAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly FlipXAccessor Instance = new FlipXAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.FlipX);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.FlipX; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.FlipX = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.FlipX; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.FlipX = value; }
        }

        internal class FlipYAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly FlipYAccessor Instance = new FlipYAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.FlipY);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.FlipY; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.FlipY = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.FlipY; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.FlipY = value; }
        }

        internal class ColorAccessor : ColorAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly ColorAccessor Instance = new ColorAccessor();
            public static readonly Color DefaultValue = new Color(1f, 1f, 1f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Color);
            public override Color GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Color; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, Color value) { instance.Color = value; }
            public override Color GetUrho(AnimatedSprite2D instance) { return instance.Color; }
            public override void SetUrho(AnimatedSprite2D instance, Color value) { instance.Color = value; }
        }

        internal class AlphaAccessor : SingleAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly AlphaAccessor Instance = new AlphaAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Alpha);
            public override float GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Alpha; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, float value) { instance.Alpha = value; }
            public override float GetUrho(AnimatedSprite2D instance) { return instance.Alpha; }
            public override void SetUrho(AnimatedSprite2D instance, float value) { instance.Alpha = value; }
        }

        internal class UseHotSpotAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly UseHotSpotAccessor Instance = new UseHotSpotAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.UseHotSpot);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.UseHotSpot; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.UseHotSpot = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.UseHotSpot; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.UseHotSpot = value; }
        }

        internal class UseDrawRectAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly UseDrawRectAccessor Instance = new UseDrawRectAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.UseDrawRect);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.UseDrawRect; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.UseDrawRect = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.UseDrawRect; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.UseDrawRect = value; }
        }

        internal class UseTextureRectAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly UseTextureRectAccessor Instance = new UseTextureRectAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.UseTextureRect);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.UseTextureRect; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.UseTextureRect = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.UseTextureRect; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.UseTextureRect = value; }
        }

        internal class HotSpotAccessor : Vector2Accessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly HotSpotAccessor Instance = new HotSpotAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0.5f, 0.5f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.HotSpot);
            public override Vector2 GetPrefab(AnimatedSprite2DPrefab instance) { return instance.HotSpot; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, Vector2 value) { instance.HotSpot = value; }
            public override Vector2 GetUrho(AnimatedSprite2D instance) { return instance.HotSpot; }
            public override void SetUrho(AnimatedSprite2D instance, Vector2 value) { instance.HotSpot = value; }
        }

        internal class CustomMaterialAccessor : MaterialAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly CustomMaterialAccessor Instance = new CustomMaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.CustomMaterial);
            public override Material GetPrefab(AnimatedSprite2DPrefab instance) { return instance.CustomMaterial; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, Material value) { instance.CustomMaterial = value; }
            public override Material GetUrho(AnimatedSprite2D instance) { return instance.CustomMaterial; }
            public override void SetUrho(AnimatedSprite2D instance, Material value) { instance.CustomMaterial = value; }
        }

        internal class LayerAccessor : Int32Accessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly LayerAccessor Instance = new LayerAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Layer);
            public override int GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Layer; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, int value) { instance.Layer = value; }
            public override int GetUrho(AnimatedSprite2D instance) { return instance.Layer; }
            public override void SetUrho(AnimatedSprite2D instance, int value) { instance.Layer = value; }
        }

        internal class OrderInLayerAccessor : Int32Accessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly OrderInLayerAccessor Instance = new OrderInLayerAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.OrderInLayer);
            public override int GetPrefab(AnimatedSprite2DPrefab instance) { return instance.OrderInLayer; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, int value) { instance.OrderInLayer = value; }
            public override int GetUrho(AnimatedSprite2D instance) { return instance.OrderInLayer; }
            public override void SetUrho(AnimatedSprite2D instance, int value) { instance.OrderInLayer = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.DrawDistance);
            public override float GetPrefab(AnimatedSprite2DPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(AnimatedSprite2D instance) { return instance.DrawDistance; }
            public override void SetUrho(AnimatedSprite2D instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.ShadowDistance);
            public override float GetPrefab(AnimatedSprite2DPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(AnimatedSprite2D instance) { return instance.ShadowDistance; }
            public override void SetUrho(AnimatedSprite2D instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.LodBias);
            public override float GetPrefab(AnimatedSprite2DPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(AnimatedSprite2D instance) { return instance.LodBias; }
            public override void SetUrho(AnimatedSprite2D instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.ViewMask);
            public override uint GetPrefab(AnimatedSprite2DPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(AnimatedSprite2D instance) { return instance.ViewMask; }
            public override void SetUrho(AnimatedSprite2D instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.LightMask);
            public override uint GetPrefab(AnimatedSprite2DPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(AnimatedSprite2D instance) { return instance.LightMask; }
            public override void SetUrho(AnimatedSprite2D instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.ShadowMask);
            public override uint GetPrefab(AnimatedSprite2DPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(AnimatedSprite2D instance) { return instance.ShadowMask; }
            public override void SetUrho(AnimatedSprite2D instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.ZoneMask);
            public override uint GetPrefab(AnimatedSprite2DPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(AnimatedSprite2D instance) { return instance.ZoneMask; }
            public override void SetUrho(AnimatedSprite2D instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.MaxLights);
            public override uint GetPrefab(AnimatedSprite2DPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(AnimatedSprite2D instance) { return instance.MaxLights; }
            public override void SetUrho(AnimatedSprite2D instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.CastShadows);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.CastShadows; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Occluder);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.Occluder; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Occludee);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.Occludee; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.SortValue);
            public override float GetPrefab(AnimatedSprite2DPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(AnimatedSprite2D instance) { return instance.SortValue; }
            public override void SetUrho(AnimatedSprite2D instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Enabled);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.Enabled; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.AnimationEnabled);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.Temporary);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.Temporary; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<AnimatedSprite2DPrefab, AnimatedSprite2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimatedSprite2D.BlockEvents);
            public override bool GetPrefab(AnimatedSprite2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(AnimatedSprite2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(AnimatedSprite2D instance) { return instance.BlockEvents; }
            public override void SetUrho(AnimatedSprite2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
