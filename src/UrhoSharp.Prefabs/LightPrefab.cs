using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Light = Urho.Light;


namespace UrhoSharp.Prefabs
{
    public partial class LightPrefab: AbstractComponentPrefab<Light>, IPrefab
    {
        public override string TypeName { get { return Light.TypeNameStatic; } }
        public LightType LightType { get; set; }
        public bool PerVertex { get; set; }
        public Color Color { get; set; }
        public float Temperature { get; set; }
        public float Radius { get; set; }
        public float Length { get; set; }
        public bool UsePhysicalValues { get; set; }
        public float SpecularIntensity { get; set; }
        public float Brightness { get; set; }
        public float Range { get; set; }
        public float Fov { get; set; }
        public float AspectRatio { get; set; }
        public float FadeDistance { get; set; }
        public float ShadowFadeDistance { get; set; }
        public BiasParameters ShadowBias { get; set; }
        public CascadeParameters ShadowCascade { get; set; }
        public FocusParameters ShadowFocus { get; set; }
        public float ShadowIntensity { get; set; }
        public float ShadowResolution { get; set; }
        public float ShadowNearFarRatio { get; set; }
        public float ShadowMaxExtrusion { get; set; }
        public Texture RampTexture { get; set; }
        public Texture ShapeTexture { get; set; }
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
        public LightPrefab()
        {
            LightType = LightTypeAccessor.DefaultValue;
            PerVertex = PerVertexAccessor.DefaultValue;
            Color = ColorAccessor.DefaultValue;
            Temperature = TemperatureAccessor.DefaultValue;
            Radius = RadiusAccessor.DefaultValue;
            Length = LengthAccessor.DefaultValue;
            UsePhysicalValues = UsePhysicalValuesAccessor.DefaultValue;
            SpecularIntensity = SpecularIntensityAccessor.DefaultValue;
            Brightness = BrightnessAccessor.DefaultValue;
            Range = RangeAccessor.DefaultValue;
            Fov = FovAccessor.DefaultValue;
            AspectRatio = AspectRatioAccessor.DefaultValue;
            FadeDistance = FadeDistanceAccessor.DefaultValue;
            ShadowFadeDistance = ShadowFadeDistanceAccessor.DefaultValue;
            ShadowBias = ShadowBiasAccessor.DefaultValue;
            ShadowCascade = ShadowCascadeAccessor.DefaultValue;
            ShadowFocus = ShadowFocusAccessor.DefaultValue;
            ShadowIntensity = ShadowIntensityAccessor.DefaultValue;
            ShadowResolution = ShadowResolutionAccessor.DefaultValue;
            ShadowNearFarRatio = ShadowNearFarRatioAccessor.DefaultValue;
            ShadowMaxExtrusion = ShadowMaxExtrusionAccessor.DefaultValue;
            RampTexture = RampTextureAccessor.DefaultValue;
            ShapeTexture = ShapeTextureAccessor.DefaultValue;
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
        public LightPrefab(Light val)
        {
            ID = val.ID;
            LightType = val.LightType;
            PerVertex = val.PerVertex;
            Color = val.Color;
            Temperature = val.Temperature;
            Radius = val.Radius;
            Length = val.Length;
            UsePhysicalValues = val.UsePhysicalValues;
            SpecularIntensity = val.SpecularIntensity;
            Brightness = val.Brightness;
            Range = val.Range;
            Fov = val.Fov;
            AspectRatio = val.AspectRatio;
            FadeDistance = val.FadeDistance;
            ShadowFadeDistance = val.ShadowFadeDistance;
            ShadowBias = val.ShadowBias;
            ShadowCascade = val.ShadowCascade;
            ShadowFocus = val.ShadowFocus;
            ShadowIntensity = val.ShadowIntensity;
            ShadowResolution = val.ShadowResolution;
            ShadowNearFarRatio = val.ShadowNearFarRatio;
            ShadowMaxExtrusion = val.ShadowMaxExtrusion;
            RampTexture = val.RampTexture;
            ShapeTexture = val.ShapeTexture;
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
        public override Light Create()
        {
            var result = new Light();
            LightTypeAccessor.Instance.ApplyIfChanged(this, result);
            PerVertexAccessor.Instance.ApplyIfChanged(this, result);
            ColorAccessor.Instance.ApplyIfChanged(this, result);
            TemperatureAccessor.Instance.ApplyIfChanged(this, result);
            RadiusAccessor.Instance.ApplyIfChanged(this, result);
            LengthAccessor.Instance.ApplyIfChanged(this, result);
            UsePhysicalValuesAccessor.Instance.ApplyIfChanged(this, result);
            SpecularIntensityAccessor.Instance.ApplyIfChanged(this, result);
            BrightnessAccessor.Instance.ApplyIfChanged(this, result);
            RangeAccessor.Instance.ApplyIfChanged(this, result);
            FovAccessor.Instance.ApplyIfChanged(this, result);
            AspectRatioAccessor.Instance.ApplyIfChanged(this, result);
            FadeDistanceAccessor.Instance.ApplyIfChanged(this, result);
            ShadowFadeDistanceAccessor.Instance.ApplyIfChanged(this, result);
            ShadowBiasAccessor.Instance.ApplyIfChanged(this, result);
            ShadowCascadeAccessor.Instance.ApplyIfChanged(this, result);
            ShadowFocusAccessor.Instance.ApplyIfChanged(this, result);
            ShadowIntensityAccessor.Instance.ApplyIfChanged(this, result);
            ShadowResolutionAccessor.Instance.ApplyIfChanged(this, result);
            ShadowNearFarRatioAccessor.Instance.ApplyIfChanged(this, result);
            ShadowMaxExtrusionAccessor.Instance.ApplyIfChanged(this, result);
            RampTextureAccessor.Instance.ApplyIfChanged(this, result);
            ShapeTextureAccessor.Instance.ApplyIfChanged(this, result);
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
                case "LightType":
                    LightTypeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "PerVertex":
                    PerVertexAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Color":
                    ColorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Temperature":
                    TemperatureAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Radius":
                    RadiusAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Length":
                    LengthAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UsePhysicalValues":
                    UsePhysicalValuesAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "SpecularIntensity":
                    SpecularIntensityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Brightness":
                    BrightnessAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Range":
                    RangeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Fov":
                    FovAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AspectRatio":
                    AspectRatioAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FadeDistance":
                    FadeDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowFadeDistance":
                    ShadowFadeDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowBias":
                    ShadowBiasAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowCascade":
                    ShadowCascadeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowFocus":
                    ShadowFocusAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowIntensity":
                    ShadowIntensityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowResolution":
                    ShadowResolutionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowNearFarRatio":
                    ShadowNearFarRatioAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowMaxExtrusion":
                    ShadowMaxExtrusionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "RampTexture":
                    RampTextureAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShapeTexture":
                    ShapeTextureAccessor.Instance.ParseAndSet(value, this);
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
                yield return LightTypeAccessor.Instance;
                yield return PerVertexAccessor.Instance;
                yield return ColorAccessor.Instance;
                yield return TemperatureAccessor.Instance;
                yield return RadiusAccessor.Instance;
                yield return LengthAccessor.Instance;
                yield return UsePhysicalValuesAccessor.Instance;
                yield return SpecularIntensityAccessor.Instance;
                yield return BrightnessAccessor.Instance;
                yield return RangeAccessor.Instance;
                yield return FovAccessor.Instance;
                yield return AspectRatioAccessor.Instance;
                yield return FadeDistanceAccessor.Instance;
                yield return ShadowFadeDistanceAccessor.Instance;
                yield return ShadowBiasAccessor.Instance;
                yield return ShadowCascadeAccessor.Instance;
                yield return ShadowFocusAccessor.Instance;
                yield return ShadowIntensityAccessor.Instance;
                yield return ShadowResolutionAccessor.Instance;
                yield return ShadowNearFarRatioAccessor.Instance;
                yield return ShadowMaxExtrusionAccessor.Instance;
                yield return RampTextureAccessor.Instance;
                yield return ShapeTextureAccessor.Instance;
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

        internal class LightTypeAccessor : EnumAccessor<LightPrefab, Light, LightType>
        {
            public static readonly LightTypeAccessor Instance = new LightTypeAccessor();
            public static readonly LightType DefaultValue = LightType.Point;
            public override LightType DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.LightType);
            public override LightType GetPrefab(LightPrefab instance) { return instance.LightType; }
            public override void SetPrefab(LightPrefab instance, LightType value) { instance.LightType = value; }
            public override LightType GetUrho(Light instance) { return instance.LightType; }
            public override void SetUrho(Light instance, LightType value) { instance.LightType = value; }
        }

        internal class PerVertexAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly PerVertexAccessor Instance = new PerVertexAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.PerVertex);
            public override bool GetPrefab(LightPrefab instance) { return instance.PerVertex; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.PerVertex = value; }
            public override bool GetUrho(Light instance) { return instance.PerVertex; }
            public override void SetUrho(Light instance, bool value) { instance.PerVertex = value; }
        }

        internal class ColorAccessor : ColorAccessor<LightPrefab, Light>
        {
            public static readonly ColorAccessor Instance = new ColorAccessor();
            public static readonly Color DefaultValue = new Color(1f, 1f, 1f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Color);
            public override Color GetPrefab(LightPrefab instance) { return instance.Color; }
            public override void SetPrefab(LightPrefab instance, Color value) { instance.Color = value; }
            public override Color GetUrho(Light instance) { return instance.Color; }
            public override void SetUrho(Light instance, Color value) { instance.Color = value; }
        }

        internal class TemperatureAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly TemperatureAccessor Instance = new TemperatureAccessor();
            public static readonly float DefaultValue = 6590f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Temperature);
            public override float GetPrefab(LightPrefab instance) { return instance.Temperature; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.Temperature = value; }
            public override float GetUrho(Light instance) { return instance.Temperature; }
            public override void SetUrho(Light instance, float value) { instance.Temperature = value; }
        }

        internal class RadiusAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly RadiusAccessor Instance = new RadiusAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Radius);
            public override float GetPrefab(LightPrefab instance) { return instance.Radius; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.Radius = value; }
            public override float GetUrho(Light instance) { return instance.Radius; }
            public override void SetUrho(Light instance, float value) { instance.Radius = value; }
        }

        internal class LengthAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly LengthAccessor Instance = new LengthAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Length);
            public override float GetPrefab(LightPrefab instance) { return instance.Length; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.Length = value; }
            public override float GetUrho(Light instance) { return instance.Length; }
            public override void SetUrho(Light instance, float value) { instance.Length = value; }
        }

        internal class UsePhysicalValuesAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly UsePhysicalValuesAccessor Instance = new UsePhysicalValuesAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.UsePhysicalValues);
            public override bool GetPrefab(LightPrefab instance) { return instance.UsePhysicalValues; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.UsePhysicalValues = value; }
            public override bool GetUrho(Light instance) { return instance.UsePhysicalValues; }
            public override void SetUrho(Light instance, bool value) { instance.UsePhysicalValues = value; }
        }

        internal class SpecularIntensityAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly SpecularIntensityAccessor Instance = new SpecularIntensityAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.SpecularIntensity);
            public override float GetPrefab(LightPrefab instance) { return instance.SpecularIntensity; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.SpecularIntensity = value; }
            public override float GetUrho(Light instance) { return instance.SpecularIntensity; }
            public override void SetUrho(Light instance, float value) { instance.SpecularIntensity = value; }
        }

        internal class BrightnessAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly BrightnessAccessor Instance = new BrightnessAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Brightness);
            public override float GetPrefab(LightPrefab instance) { return instance.Brightness; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.Brightness = value; }
            public override float GetUrho(Light instance) { return instance.Brightness; }
            public override void SetUrho(Light instance, float value) { instance.Brightness = value; }
        }

        internal class RangeAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly RangeAccessor Instance = new RangeAccessor();
            public static readonly float DefaultValue = 10f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Range);
            public override float GetPrefab(LightPrefab instance) { return instance.Range; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.Range = value; }
            public override float GetUrho(Light instance) { return instance.Range; }
            public override void SetUrho(Light instance, float value) { instance.Range = value; }
        }

        internal class FovAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly FovAccessor Instance = new FovAccessor();
            public static readonly float DefaultValue = 30f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Fov);
            public override float GetPrefab(LightPrefab instance) { return instance.Fov; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.Fov = value; }
            public override float GetUrho(Light instance) { return instance.Fov; }
            public override void SetUrho(Light instance, float value) { instance.Fov = value; }
        }

        internal class AspectRatioAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly AspectRatioAccessor Instance = new AspectRatioAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.AspectRatio);
            public override float GetPrefab(LightPrefab instance) { return instance.AspectRatio; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.AspectRatio = value; }
            public override float GetUrho(Light instance) { return instance.AspectRatio; }
            public override void SetUrho(Light instance, float value) { instance.AspectRatio = value; }
        }

        internal class FadeDistanceAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly FadeDistanceAccessor Instance = new FadeDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.FadeDistance);
            public override float GetPrefab(LightPrefab instance) { return instance.FadeDistance; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.FadeDistance = value; }
            public override float GetUrho(Light instance) { return instance.FadeDistance; }
            public override void SetUrho(Light instance, float value) { instance.FadeDistance = value; }
        }

        internal class ShadowFadeDistanceAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly ShadowFadeDistanceAccessor Instance = new ShadowFadeDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowFadeDistance);
            public override float GetPrefab(LightPrefab instance) { return instance.ShadowFadeDistance; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.ShadowFadeDistance = value; }
            public override float GetUrho(Light instance) { return instance.ShadowFadeDistance; }
            public override void SetUrho(Light instance, float value) { instance.ShadowFadeDistance = value; }
        }

        internal class ShadowBiasAccessor : BiasParametersAccessor<LightPrefab, Light>
        {
            public static readonly ShadowBiasAccessor Instance = new ShadowBiasAccessor();
            public static readonly BiasParameters DefaultValue = new BiasParameters(0f, 0f, 0f);
            public override BiasParameters DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowBias);
            public override BiasParameters GetPrefab(LightPrefab instance) { return instance.ShadowBias; }
            public override void SetPrefab(LightPrefab instance, BiasParameters value) { instance.ShadowBias = value; }
            public override BiasParameters GetUrho(Light instance) { return instance.ShadowBias; }
            public override void SetUrho(Light instance, BiasParameters value) { instance.ShadowBias = value; }
        }

        internal class ShadowCascadeAccessor : CascadeParametersAccessor<LightPrefab, Light>
        {
            public static readonly ShadowCascadeAccessor Instance = new ShadowCascadeAccessor();
            public static readonly CascadeParameters DefaultValue = new CascadeParameters(0f, 0f, 0f, 0f, 0f, 0f);
            public override CascadeParameters DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowCascade);
            public override CascadeParameters GetPrefab(LightPrefab instance) { return instance.ShadowCascade; }
            public override void SetPrefab(LightPrefab instance, CascadeParameters value) { instance.ShadowCascade = value; }
            public override CascadeParameters GetUrho(Light instance) { return instance.ShadowCascade; }
            public override void SetUrho(Light instance, CascadeParameters value) { instance.ShadowCascade = value; }
        }

        internal class ShadowFocusAccessor : FocusParametersAccessor<LightPrefab, Light>
        {
            public static readonly ShadowFocusAccessor Instance = new ShadowFocusAccessor();
            public static readonly FocusParameters DefaultValue = new FocusParameters() {Focus = 0, AutoSize = 0, MinView = 0f, NonUniform = 0, Quantize = 0f};
            public override FocusParameters DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowFocus);
            public override FocusParameters GetPrefab(LightPrefab instance) { return instance.ShadowFocus; }
            public override void SetPrefab(LightPrefab instance, FocusParameters value) { instance.ShadowFocus = value; }
            public override FocusParameters GetUrho(Light instance) { return instance.ShadowFocus; }
            public override void SetUrho(Light instance, FocusParameters value) { instance.ShadowFocus = value; }
        }

        internal class ShadowIntensityAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly ShadowIntensityAccessor Instance = new ShadowIntensityAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowIntensity);
            public override float GetPrefab(LightPrefab instance) { return instance.ShadowIntensity; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.ShadowIntensity = value; }
            public override float GetUrho(Light instance) { return instance.ShadowIntensity; }
            public override void SetUrho(Light instance, float value) { instance.ShadowIntensity = value; }
        }

        internal class ShadowResolutionAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly ShadowResolutionAccessor Instance = new ShadowResolutionAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowResolution);
            public override float GetPrefab(LightPrefab instance) { return instance.ShadowResolution; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.ShadowResolution = value; }
            public override float GetUrho(Light instance) { return instance.ShadowResolution; }
            public override void SetUrho(Light instance, float value) { instance.ShadowResolution = value; }
        }

        internal class ShadowNearFarRatioAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly ShadowNearFarRatioAccessor Instance = new ShadowNearFarRatioAccessor();
            public static readonly float DefaultValue = 0.002f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowNearFarRatio);
            public override float GetPrefab(LightPrefab instance) { return instance.ShadowNearFarRatio; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.ShadowNearFarRatio = value; }
            public override float GetUrho(Light instance) { return instance.ShadowNearFarRatio; }
            public override void SetUrho(Light instance, float value) { instance.ShadowNearFarRatio = value; }
        }

        internal class ShadowMaxExtrusionAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly ShadowMaxExtrusionAccessor Instance = new ShadowMaxExtrusionAccessor();
            public static readonly float DefaultValue = 1000f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowMaxExtrusion);
            public override float GetPrefab(LightPrefab instance) { return instance.ShadowMaxExtrusion; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.ShadowMaxExtrusion = value; }
            public override float GetUrho(Light instance) { return instance.ShadowMaxExtrusion; }
            public override void SetUrho(Light instance, float value) { instance.ShadowMaxExtrusion = value; }
        }

        internal class RampTextureAccessor : TextureAccessor<LightPrefab, Light>
        {
            public static readonly RampTextureAccessor Instance = new RampTextureAccessor();
            public static readonly Texture DefaultValue = null;
            public override Texture DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.RampTexture);
            public override Texture GetPrefab(LightPrefab instance) { return instance.RampTexture; }
            public override void SetPrefab(LightPrefab instance, Texture value) { instance.RampTexture = value; }
            public override Texture GetUrho(Light instance) { return instance.RampTexture; }
            public override void SetUrho(Light instance, Texture value) { instance.RampTexture = value; }
        }

        internal class ShapeTextureAccessor : TextureAccessor<LightPrefab, Light>
        {
            public static readonly ShapeTextureAccessor Instance = new ShapeTextureAccessor();
            public static readonly Texture DefaultValue = null;
            public override Texture DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShapeTexture);
            public override Texture GetPrefab(LightPrefab instance) { return instance.ShapeTexture; }
            public override void SetPrefab(LightPrefab instance, Texture value) { instance.ShapeTexture = value; }
            public override Texture GetUrho(Light instance) { return instance.ShapeTexture; }
            public override void SetUrho(Light instance, Texture value) { instance.ShapeTexture = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.DrawDistance);
            public override float GetPrefab(LightPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(Light instance) { return instance.DrawDistance; }
            public override void SetUrho(Light instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowDistance);
            public override float GetPrefab(LightPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(Light instance) { return instance.ShadowDistance; }
            public override void SetUrho(Light instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.LodBias);
            public override float GetPrefab(LightPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(Light instance) { return instance.LodBias; }
            public override void SetUrho(Light instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<LightPrefab, Light>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ViewMask);
            public override uint GetPrefab(LightPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(LightPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(Light instance) { return instance.ViewMask; }
            public override void SetUrho(Light instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<LightPrefab, Light>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.LightMask);
            public override uint GetPrefab(LightPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(LightPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(Light instance) { return instance.LightMask; }
            public override void SetUrho(Light instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<LightPrefab, Light>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ShadowMask);
            public override uint GetPrefab(LightPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(LightPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(Light instance) { return instance.ShadowMask; }
            public override void SetUrho(Light instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<LightPrefab, Light>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.ZoneMask);
            public override uint GetPrefab(LightPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(LightPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(Light instance) { return instance.ZoneMask; }
            public override void SetUrho(Light instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<LightPrefab, Light>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.MaxLights);
            public override uint GetPrefab(LightPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(LightPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(Light instance) { return instance.MaxLights; }
            public override void SetUrho(Light instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.CastShadows);
            public override bool GetPrefab(LightPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(Light instance) { return instance.CastShadows; }
            public override void SetUrho(Light instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Occluder);
            public override bool GetPrefab(LightPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(Light instance) { return instance.Occluder; }
            public override void SetUrho(Light instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Occludee);
            public override bool GetPrefab(LightPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(Light instance) { return instance.Occludee; }
            public override void SetUrho(Light instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<LightPrefab, Light>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.SortValue);
            public override float GetPrefab(LightPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(LightPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(Light instance) { return instance.SortValue; }
            public override void SetUrho(Light instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Enabled);
            public override bool GetPrefab(LightPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Light instance) { return instance.Enabled; }
            public override void SetUrho(Light instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.AnimationEnabled);
            public override bool GetPrefab(LightPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Light instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Light instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.Temporary);
            public override bool GetPrefab(LightPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Light instance) { return instance.Temporary; }
            public override void SetUrho(Light instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<LightPrefab, Light>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Light.BlockEvents);
            public override bool GetPrefab(LightPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(LightPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Light instance) { return instance.BlockEvents; }
            public override void SetUrho(Light instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
