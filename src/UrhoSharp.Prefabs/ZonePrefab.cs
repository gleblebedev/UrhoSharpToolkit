using System;
using System.Xml.Linq;
using Urho;
using Zone = Urho.Zone;


namespace UrhoSharp.Prefabs
{
    public class ZonePrefab: AbstractComponentPrefab<Zone>, IPrefab
    {
        private static  Color AmbientColorDefaultValue = new Color(0.1f, 0.1f, 0.1f, 1f);
        private static  Color FogColorDefaultValue = new Color(0f, 0f, 0f, 1f);
        private static  float FogStartDefaultValue = 250f;
        private static  float FogEndDefaultValue = 1000f;
        private static  float FogHeightDefaultValue = 0f;
        private static  float FogHeightScaleDefaultValue = 0.5f;
        private static  int PriorityDefaultValue = 0;
        private static  bool HeightFogDefaultValue = false;
        private static  bool OverrideDefaultValue = false;
        private static  bool AmbientGradientDefaultValue = false;
        private static  Texture ZoneTextureDefaultValue = null;
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
        private Color _ambientColor;
        private Color _fogColor;
        private float _fogStart;
        private float _fogEnd;
        private float _fogHeight;
        private float _fogHeightScale;
        private int _priority;
        private bool _heightFog;
        private bool _override;
        private bool _ambientGradient;
        private Texture _zoneTexture;
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
        public ZonePrefab()
        {
            _ambientColor = AmbientColorDefaultValue;
            _fogColor = FogColorDefaultValue;
            _fogStart = FogStartDefaultValue;
            _fogEnd = FogEndDefaultValue;
            _fogHeight = FogHeightDefaultValue;
            _fogHeightScale = FogHeightScaleDefaultValue;
            _priority = PriorityDefaultValue;
            _heightFog = HeightFogDefaultValue;
            _override = OverrideDefaultValue;
            _ambientGradient = AmbientGradientDefaultValue;
            _zoneTexture = ZoneTextureDefaultValue;
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
        public ZonePrefab(Zone val)
        {
            _ambientColor = val.AmbientColor;
            _fogColor = val.FogColor;
            _fogStart = val.FogStart;
            _fogEnd = val.FogEnd;
            _fogHeight = val.FogHeight;
            _fogHeightScale = val.FogHeightScale;
            _priority = val.Priority;
            _heightFog = val.HeightFog;
            _override = val.Override;
            _ambientGradient = val.AmbientGradient;
            _zoneTexture = val.ZoneTexture;
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
        public Color AmbientColor {get { return _ambientColor;} set { _ambientColor=value; } }
        public bool AmbientColorHasValue {get { return !PrefabUtils.AreEqual(ref _ambientColor, ref AmbientColorDefaultValue); } }
        public Color FogColor {get { return _fogColor;} set { _fogColor=value; } }
        public bool FogColorHasValue {get { return !PrefabUtils.AreEqual(ref _fogColor, ref FogColorDefaultValue); } }
        public float FogStart {get { return _fogStart;} set { _fogStart=value; } }
        public bool FogStartHasValue {get { return !PrefabUtils.AreEqual(ref _fogStart, ref FogStartDefaultValue); } }
        public float FogEnd {get { return _fogEnd;} set { _fogEnd=value; } }
        public bool FogEndHasValue {get { return !PrefabUtils.AreEqual(ref _fogEnd, ref FogEndDefaultValue); } }
        public float FogHeight {get { return _fogHeight;} set { _fogHeight=value; } }
        public bool FogHeightHasValue {get { return !PrefabUtils.AreEqual(ref _fogHeight, ref FogHeightDefaultValue); } }
        public float FogHeightScale {get { return _fogHeightScale;} set { _fogHeightScale=value; } }
        public bool FogHeightScaleHasValue {get { return !PrefabUtils.AreEqual(ref _fogHeightScale, ref FogHeightScaleDefaultValue); } }
        public int Priority {get { return _priority;} set { _priority=value; } }
        public bool PriorityHasValue {get { return !PrefabUtils.AreEqual(ref _priority, ref PriorityDefaultValue); } }
        public bool HeightFog {get { return _heightFog;} set { _heightFog=value; } }
        public bool HeightFogHasValue {get { return !PrefabUtils.AreEqual(ref _heightFog, ref HeightFogDefaultValue); } }
        public bool Override {get { return _override;} set { _override=value; } }
        public bool OverrideHasValue {get { return !PrefabUtils.AreEqual(ref _override, ref OverrideDefaultValue); } }
        public bool AmbientGradient {get { return _ambientGradient;} set { _ambientGradient=value; } }
        public bool AmbientGradientHasValue {get { return !PrefabUtils.AreEqual(ref _ambientGradient, ref AmbientGradientDefaultValue); } }
        public Texture ZoneTexture {get { return _zoneTexture;} set { _zoneTexture=value; } }
        public bool ZoneTextureHasValue {get { return !PrefabUtils.AreEqual(ref _zoneTexture, ref ZoneTextureDefaultValue); } }
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
        public override Zone Create()
        {
            var result = new Zone();
            if(AmbientColorHasValue)
                result.AmbientColor = _ambientColor;
            if(FogColorHasValue)
                result.FogColor = _fogColor;
            if(FogStartHasValue)
                result.FogStart = _fogStart;
            if(FogEndHasValue)
                result.FogEnd = _fogEnd;
            if(FogHeightHasValue)
                result.FogHeight = _fogHeight;
            if(FogHeightScaleHasValue)
                result.FogHeightScale = _fogHeightScale;
            if(PriorityHasValue)
                result.Priority = _priority;
            if(HeightFogHasValue)
                result.HeightFog = _heightFog;
            if(OverrideHasValue)
                result.Override = _override;
            if(AmbientGradientHasValue)
                result.AmbientGradient = _ambientGradient;
            if(ZoneTextureHasValue)
                result.ZoneTexture = _zoneTexture;
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
                case "AmbientColor":
                    break;
                case "FogColor":
                    break;
                case "FogStart":
                    break;
                case "FogEnd":
                    break;
                case "FogHeight":
                    break;
                case "FogHeightScale":
                    break;
                case "Priority":
                    break;
                case "HeightFog":
                    break;
                case "Override":
                    break;
                case "AmbientGradient":
                    break;
                case "ZoneTexture":
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
