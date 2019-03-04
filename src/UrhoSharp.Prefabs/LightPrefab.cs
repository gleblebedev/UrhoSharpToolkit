using System;
using System.Xml.Linq;
using Urho;
using Light = Urho.Light;


namespace UrhoSharp.Prefabs
{
    public class LightPrefab: AbstractComponentPrefab<Light>, IPrefab
    {
        private static  LightType LightTypeDefaultValue = LightType.Point;
        private static  bool PerVertexDefaultValue = false;
        private static  Color ColorDefaultValue = new Color(1f, 1f, 1f, 1f);
        private static  float TemperatureDefaultValue = 6590f;
        private static  float RadiusDefaultValue = 0f;
        private static  float LengthDefaultValue = 0f;
        private static  bool UsePhysicalValuesDefaultValue = false;
        private static  float SpecularIntensityDefaultValue = 1f;
        private static  float BrightnessDefaultValue = 1f;
        private static  float RangeDefaultValue = 10f;
        private static  float FovDefaultValue = 30f;
        private static  float AspectRatioDefaultValue = 1f;
        private static  float FadeDistanceDefaultValue = 0f;
        private static  float ShadowFadeDistanceDefaultValue = 0f;
        private static  BiasParameters ShadowBiasDefaultValue = new BiasParameters(0f, 0f, 0f);
        private static  CascadeParameters ShadowCascadeDefaultValue = new CascadeParameters(0f, 0f, 0f, 0f, 0f, 0f);
        private static  FocusParameters ShadowFocusDefaultValue = new FocusParameters() {Focus = 0, AutoSize = 0, MinView = 0f, NonUniform = 0, Quantize = 0f};
        private static  float ShadowIntensityDefaultValue = 0f;
        private static  float ShadowResolutionDefaultValue = 1f;
        private static  float ShadowNearFarRatioDefaultValue = 0.002f;
        private static  float ShadowMaxExtrusionDefaultValue = 1000f;
        private static  Texture RampTextureDefaultValue = null;
        private static  Texture ShapeTextureDefaultValue = null;
        private static  float DrawDistanceDefaultValue = 0f;
        private static  float ShadowDistanceDefaultValue = 0f;
        private static  float LodBiasDefaultValue = 1f;
        private static  uint ViewMaskDefaultValue = 4294967295;
        private static  uint LightMaskDefaultValue = 4294967295;
        private static  uint ShadowMaskDefaultValue = 4294967295;
        private static  uint ZoneMaskDefaultValue = 4294967295;
        private static  uint MaxLightsDefaultValue = 0;
        private static  bool CastShadowsDefaultValue = false;
        private static  bool OccluderDefaultValue = false;
        private static  bool OccludeeDefaultValue = true;
        private static  float SortValueDefaultValue = 0f;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private LightType _lightType;
        private bool _perVertex;
        private Color _color;
        private float _temperature;
        private float _radius;
        private float _length;
        private bool _usePhysicalValues;
        private float _specularIntensity;
        private float _brightness;
        private float _range;
        private float _fov;
        private float _aspectRatio;
        private float _fadeDistance;
        private float _shadowFadeDistance;
        private BiasParameters _shadowBias;
        private CascadeParameters _shadowCascade;
        private FocusParameters _shadowFocus;
        private float _shadowIntensity;
        private float _shadowResolution;
        private float _shadowNearFarRatio;
        private float _shadowMaxExtrusion;
        private Texture _rampTexture;
        private Texture _shapeTexture;
        private float _drawDistance;
        private float _shadowDistance;
        private float _lodBias;
        private uint _viewMask;
        private uint _lightMask;
        private uint _shadowMask;
        private uint _zoneMask;
        private uint _maxLights;
        private bool _castShadows;
        private bool _occluder;
        private bool _occludee;
        private float _sortValue;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public LightPrefab()
        {
            _lightType = LightTypeDefaultValue;
            _perVertex = PerVertexDefaultValue;
            _color = ColorDefaultValue;
            _temperature = TemperatureDefaultValue;
            _radius = RadiusDefaultValue;
            _length = LengthDefaultValue;
            _usePhysicalValues = UsePhysicalValuesDefaultValue;
            _specularIntensity = SpecularIntensityDefaultValue;
            _brightness = BrightnessDefaultValue;
            _range = RangeDefaultValue;
            _fov = FovDefaultValue;
            _aspectRatio = AspectRatioDefaultValue;
            _fadeDistance = FadeDistanceDefaultValue;
            _shadowFadeDistance = ShadowFadeDistanceDefaultValue;
            _shadowBias = ShadowBiasDefaultValue;
            _shadowCascade = ShadowCascadeDefaultValue;
            _shadowFocus = ShadowFocusDefaultValue;
            _shadowIntensity = ShadowIntensityDefaultValue;
            _shadowResolution = ShadowResolutionDefaultValue;
            _shadowNearFarRatio = ShadowNearFarRatioDefaultValue;
            _shadowMaxExtrusion = ShadowMaxExtrusionDefaultValue;
            _rampTexture = RampTextureDefaultValue;
            _shapeTexture = ShapeTextureDefaultValue;
            _drawDistance = DrawDistanceDefaultValue;
            _shadowDistance = ShadowDistanceDefaultValue;
            _lodBias = LodBiasDefaultValue;
            _viewMask = ViewMaskDefaultValue;
            _lightMask = LightMaskDefaultValue;
            _shadowMask = ShadowMaskDefaultValue;
            _zoneMask = ZoneMaskDefaultValue;
            _maxLights = MaxLightsDefaultValue;
            _castShadows = CastShadowsDefaultValue;
            _occluder = OccluderDefaultValue;
            _occludee = OccludeeDefaultValue;
            _sortValue = SortValueDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public LightPrefab(Light val)
        {
            _lightType = val.LightType;
            _perVertex = val.PerVertex;
            _color = val.Color;
            _temperature = val.Temperature;
            _radius = val.Radius;
            _length = val.Length;
            _usePhysicalValues = val.UsePhysicalValues;
            _specularIntensity = val.SpecularIntensity;
            _brightness = val.Brightness;
            _range = val.Range;
            _fov = val.Fov;
            _aspectRatio = val.AspectRatio;
            _fadeDistance = val.FadeDistance;
            _shadowFadeDistance = val.ShadowFadeDistance;
            _shadowBias = val.ShadowBias;
            _shadowCascade = val.ShadowCascade;
            _shadowFocus = val.ShadowFocus;
            _shadowIntensity = val.ShadowIntensity;
            _shadowResolution = val.ShadowResolution;
            _shadowNearFarRatio = val.ShadowNearFarRatio;
            _shadowMaxExtrusion = val.ShadowMaxExtrusion;
            _rampTexture = val.RampTexture;
            _shapeTexture = val.ShapeTexture;
            _drawDistance = val.DrawDistance;
            _shadowDistance = val.ShadowDistance;
            _lodBias = val.LodBias;
            _viewMask = val.ViewMask;
            _lightMask = val.LightMask;
            _shadowMask = val.ShadowMask;
            _zoneMask = val.ZoneMask;
            _maxLights = val.MaxLights;
            _castShadows = val.CastShadows;
            _occluder = val.Occluder;
            _occludee = val.Occludee;
            _sortValue = val.SortValue;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public LightType LightType {get { return _lightType;} set { _lightType=value; } }
        public bool LightTypeHasValue {get { return !PrefabUtils.AreEqual(ref _lightType, ref LightTypeDefaultValue); } }
        public bool PerVertex {get { return _perVertex;} set { _perVertex=value; } }
        public bool PerVertexHasValue {get { return !PrefabUtils.AreEqual(ref _perVertex, ref PerVertexDefaultValue); } }
        public Color Color {get { return _color;} set { _color=value; } }
        public bool ColorHasValue {get { return !PrefabUtils.AreEqual(ref _color, ref ColorDefaultValue); } }
        public float Temperature {get { return _temperature;} set { _temperature=value; } }
        public bool TemperatureHasValue {get { return !PrefabUtils.AreEqual(ref _temperature, ref TemperatureDefaultValue); } }
        public float Radius {get { return _radius;} set { _radius=value; } }
        public bool RadiusHasValue {get { return !PrefabUtils.AreEqual(ref _radius, ref RadiusDefaultValue); } }
        public float Length {get { return _length;} set { _length=value; } }
        public bool LengthHasValue {get { return !PrefabUtils.AreEqual(ref _length, ref LengthDefaultValue); } }
        public bool UsePhysicalValues {get { return _usePhysicalValues;} set { _usePhysicalValues=value; } }
        public bool UsePhysicalValuesHasValue {get { return !PrefabUtils.AreEqual(ref _usePhysicalValues, ref UsePhysicalValuesDefaultValue); } }
        public float SpecularIntensity {get { return _specularIntensity;} set { _specularIntensity=value; } }
        public bool SpecularIntensityHasValue {get { return !PrefabUtils.AreEqual(ref _specularIntensity, ref SpecularIntensityDefaultValue); } }
        public float Brightness {get { return _brightness;} set { _brightness=value; } }
        public bool BrightnessHasValue {get { return !PrefabUtils.AreEqual(ref _brightness, ref BrightnessDefaultValue); } }
        public float Range {get { return _range;} set { _range=value; } }
        public bool RangeHasValue {get { return !PrefabUtils.AreEqual(ref _range, ref RangeDefaultValue); } }
        public float Fov {get { return _fov;} set { _fov=value; } }
        public bool FovHasValue {get { return !PrefabUtils.AreEqual(ref _fov, ref FovDefaultValue); } }
        public float AspectRatio {get { return _aspectRatio;} set { _aspectRatio=value; } }
        public bool AspectRatioHasValue {get { return !PrefabUtils.AreEqual(ref _aspectRatio, ref AspectRatioDefaultValue); } }
        public float FadeDistance {get { return _fadeDistance;} set { _fadeDistance=value; } }
        public bool FadeDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _fadeDistance, ref FadeDistanceDefaultValue); } }
        public float ShadowFadeDistance {get { return _shadowFadeDistance;} set { _shadowFadeDistance=value; } }
        public bool ShadowFadeDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _shadowFadeDistance, ref ShadowFadeDistanceDefaultValue); } }
        public BiasParameters ShadowBias {get { return _shadowBias;} set { _shadowBias=value; } }
        public bool ShadowBiasHasValue {get { return !PrefabUtils.AreEqual(ref _shadowBias, ref ShadowBiasDefaultValue); } }
        public CascadeParameters ShadowCascade {get { return _shadowCascade;} set { _shadowCascade=value; } }
        public bool ShadowCascadeHasValue {get { return !PrefabUtils.AreEqual(ref _shadowCascade, ref ShadowCascadeDefaultValue); } }
        public FocusParameters ShadowFocus {get { return _shadowFocus;} set { _shadowFocus=value; } }
        public bool ShadowFocusHasValue {get { return !PrefabUtils.AreEqual(ref _shadowFocus, ref ShadowFocusDefaultValue); } }
        public float ShadowIntensity {get { return _shadowIntensity;} set { _shadowIntensity=value; } }
        public bool ShadowIntensityHasValue {get { return !PrefabUtils.AreEqual(ref _shadowIntensity, ref ShadowIntensityDefaultValue); } }
        public float ShadowResolution {get { return _shadowResolution;} set { _shadowResolution=value; } }
        public bool ShadowResolutionHasValue {get { return !PrefabUtils.AreEqual(ref _shadowResolution, ref ShadowResolutionDefaultValue); } }
        public float ShadowNearFarRatio {get { return _shadowNearFarRatio;} set { _shadowNearFarRatio=value; } }
        public bool ShadowNearFarRatioHasValue {get { return !PrefabUtils.AreEqual(ref _shadowNearFarRatio, ref ShadowNearFarRatioDefaultValue); } }
        public float ShadowMaxExtrusion {get { return _shadowMaxExtrusion;} set { _shadowMaxExtrusion=value; } }
        public bool ShadowMaxExtrusionHasValue {get { return !PrefabUtils.AreEqual(ref _shadowMaxExtrusion, ref ShadowMaxExtrusionDefaultValue); } }
        public Texture RampTexture {get { return _rampTexture;} set { _rampTexture=value; } }
        public bool RampTextureHasValue {get { return !PrefabUtils.AreEqual(ref _rampTexture, ref RampTextureDefaultValue); } }
        public Texture ShapeTexture {get { return _shapeTexture;} set { _shapeTexture=value; } }
        public bool ShapeTextureHasValue {get { return !PrefabUtils.AreEqual(ref _shapeTexture, ref ShapeTextureDefaultValue); } }
        public float DrawDistance {get { return _drawDistance;} set { _drawDistance=value; } }
        public bool DrawDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _drawDistance, ref DrawDistanceDefaultValue); } }
        public float ShadowDistance {get { return _shadowDistance;} set { _shadowDistance=value; } }
        public bool ShadowDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _shadowDistance, ref ShadowDistanceDefaultValue); } }
        public float LodBias {get { return _lodBias;} set { _lodBias=value; } }
        public bool LodBiasHasValue {get { return !PrefabUtils.AreEqual(ref _lodBias, ref LodBiasDefaultValue); } }
        public uint ViewMask {get { return _viewMask;} set { _viewMask=value; } }
        public bool ViewMaskHasValue {get { return !PrefabUtils.AreEqual(ref _viewMask, ref ViewMaskDefaultValue); } }
        public uint LightMask {get { return _lightMask;} set { _lightMask=value; } }
        public bool LightMaskHasValue {get { return !PrefabUtils.AreEqual(ref _lightMask, ref LightMaskDefaultValue); } }
        public uint ShadowMask {get { return _shadowMask;} set { _shadowMask=value; } }
        public bool ShadowMaskHasValue {get { return !PrefabUtils.AreEqual(ref _shadowMask, ref ShadowMaskDefaultValue); } }
        public uint ZoneMask {get { return _zoneMask;} set { _zoneMask=value; } }
        public bool ZoneMaskHasValue {get { return !PrefabUtils.AreEqual(ref _zoneMask, ref ZoneMaskDefaultValue); } }
        public uint MaxLights {get { return _maxLights;} set { _maxLights=value; } }
        public bool MaxLightsHasValue {get { return !PrefabUtils.AreEqual(ref _maxLights, ref MaxLightsDefaultValue); } }
        public bool CastShadows {get { return _castShadows;} set { _castShadows=value; } }
        public bool CastShadowsHasValue {get { return !PrefabUtils.AreEqual(ref _castShadows, ref CastShadowsDefaultValue); } }
        public bool Occluder {get { return _occluder;} set { _occluder=value; } }
        public bool OccluderHasValue {get { return !PrefabUtils.AreEqual(ref _occluder, ref OccluderDefaultValue); } }
        public bool Occludee {get { return _occludee;} set { _occludee=value; } }
        public bool OccludeeHasValue {get { return !PrefabUtils.AreEqual(ref _occludee, ref OccludeeDefaultValue); } }
        public float SortValue {get { return _sortValue;} set { _sortValue=value; } }
        public bool SortValueHasValue {get { return !PrefabUtils.AreEqual(ref _sortValue, ref SortValueDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override Light Create()
        {
            var result = new Light();
            if(LightTypeHasValue)
                result.LightType = _lightType;
            if(PerVertexHasValue)
                result.PerVertex = _perVertex;
            if(ColorHasValue)
                result.Color = _color;
            if(TemperatureHasValue)
                result.Temperature = _temperature;
            if(RadiusHasValue)
                result.Radius = _radius;
            if(LengthHasValue)
                result.Length = _length;
            if(UsePhysicalValuesHasValue)
                result.UsePhysicalValues = _usePhysicalValues;
            if(SpecularIntensityHasValue)
                result.SpecularIntensity = _specularIntensity;
            if(BrightnessHasValue)
                result.Brightness = _brightness;
            if(RangeHasValue)
                result.Range = _range;
            if(FovHasValue)
                result.Fov = _fov;
            if(AspectRatioHasValue)
                result.AspectRatio = _aspectRatio;
            if(FadeDistanceHasValue)
                result.FadeDistance = _fadeDistance;
            if(ShadowFadeDistanceHasValue)
                result.ShadowFadeDistance = _shadowFadeDistance;
            if(ShadowBiasHasValue)
                result.ShadowBias = _shadowBias;
            if(ShadowCascadeHasValue)
                result.ShadowCascade = _shadowCascade;
            if(ShadowFocusHasValue)
                result.ShadowFocus = _shadowFocus;
            if(ShadowIntensityHasValue)
                result.ShadowIntensity = _shadowIntensity;
            if(ShadowResolutionHasValue)
                result.ShadowResolution = _shadowResolution;
            if(ShadowNearFarRatioHasValue)
                result.ShadowNearFarRatio = _shadowNearFarRatio;
            if(ShadowMaxExtrusionHasValue)
                result.ShadowMaxExtrusion = _shadowMaxExtrusion;
            if(RampTextureHasValue)
                result.RampTexture = _rampTexture;
            if(ShapeTextureHasValue)
                result.ShapeTexture = _shapeTexture;
            if(DrawDistanceHasValue)
                result.DrawDistance = _drawDistance;
            if(ShadowDistanceHasValue)
                result.ShadowDistance = _shadowDistance;
            if(LodBiasHasValue)
                result.LodBias = _lodBias;
            if(ViewMaskHasValue)
                result.ViewMask = _viewMask;
            if(LightMaskHasValue)
                result.LightMask = _lightMask;
            if(ShadowMaskHasValue)
                result.ShadowMask = _shadowMask;
            if(ZoneMaskHasValue)
                result.ZoneMask = _zoneMask;
            if(MaxLightsHasValue)
                result.MaxLights = _maxLights;
            if(CastShadowsHasValue)
                result.CastShadows = _castShadows;
            if(OccluderHasValue)
                result.Occluder = _occluder;
            if(OccludeeHasValue)
                result.Occludee = _occludee;
            if(SortValueHasValue)
                result.SortValue = _sortValue;
            if(EnabledHasValue)
                result.Enabled = _enabled;
            if(AnimationEnabledHasValue)
                result.AnimationEnabled = _animationEnabled;
            if(TemporaryHasValue)
                result.Temporary = _temporary;
            if(BlockEventsHasValue)
                result.BlockEvents = _blockEvents;
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "LightType":
                    break;
                case "PerVertex":
                    break;
                case "Color":
                    break;
                case "Temperature":
                    break;
                case "Radius":
                    break;
                case "Length":
                    break;
                case "UsePhysicalValues":
                    break;
                case "SpecularIntensity":
                    break;
                case "Brightness":
                    break;
                case "Range":
                    break;
                case "Fov":
                    break;
                case "AspectRatio":
                    break;
                case "FadeDistance":
                    break;
                case "ShadowFadeDistance":
                    break;
                case "ShadowBias":
                    break;
                case "ShadowCascade":
                    break;
                case "ShadowFocus":
                    break;
                case "ShadowIntensity":
                    break;
                case "ShadowResolution":
                    break;
                case "ShadowNearFarRatio":
                    break;
                case "ShadowMaxExtrusion":
                    break;
                case "RampTexture":
                    break;
                case "ShapeTexture":
                    break;
                case "DrawDistance":
                    break;
                case "ShadowDistance":
                    break;
                case "LodBias":
                    break;
                case "ViewMask":
                    break;
                case "LightMask":
                    break;
                case "ShadowMask":
                    break;
                case "ZoneMask":
                    break;
                case "MaxLights":
                    break;
                case "CastShadows":
                    break;
                case "Occluder":
                    break;
                case "Occludee":
                    break;
                case "SortValue":
                    break;
                case "Enabled":
                    break;
                case "AnimationEnabled":
                    break;
                case "Temporary":
                    break;
                case "BlockEvents":
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
    }
}
