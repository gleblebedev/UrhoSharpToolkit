using System;
using System.Xml.Linq;
using Urho;
using RibbonTrail = Urho.RibbonTrail;


namespace UrhoSharp.Prefabs
{
    public class RibbonTrailPrefab: AbstractComponentPrefab<RibbonTrail>, IPrefab
    {
        private static  Material MaterialDefaultValue = null;
        private static  float VertexDistanceDefaultValue = 0.1f;
        private static  float WidthDefaultValue = 0.2f;
        private static  Color StartColorDefaultValue = new Color(1f, 1f, 1f, 1f);
        private static  Color EndColorDefaultValue = new Color(1f, 1f, 1f, 0f);
        private static  float StartScaleDefaultValue = 1f;
        private static  float EndScaleDefaultValue = 1f;
        private static  TrailType TrailTypeDefaultValue = TrailType.FaceCamera;
        private static  bool SortedDefaultValue = false;
        private static  float LifetimeDefaultValue = 1f;
        private static  bool EmittingDefaultValue = true;
        private static  bool UpdateInvisibleDefaultValue = false;
        private static  uint TailColumnDefaultValue = 1;
        private static  float AnimationLodBiasDefaultValue = 1f;
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
        private Material _material;
        private float _vertexDistance;
        private float _width;
        private Color _startColor;
        private Color _endColor;
        private float _startScale;
        private float _endScale;
        private TrailType _trailType;
        private bool _sorted;
        private float _lifetime;
        private bool _emitting;
        private bool _updateInvisible;
        private uint _tailColumn;
        private float _animationLodBias;
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
        public RibbonTrailPrefab()
        {
            _material = MaterialDefaultValue;
            _vertexDistance = VertexDistanceDefaultValue;
            _width = WidthDefaultValue;
            _startColor = StartColorDefaultValue;
            _endColor = EndColorDefaultValue;
            _startScale = StartScaleDefaultValue;
            _endScale = EndScaleDefaultValue;
            _trailType = TrailTypeDefaultValue;
            _sorted = SortedDefaultValue;
            _lifetime = LifetimeDefaultValue;
            _emitting = EmittingDefaultValue;
            _updateInvisible = UpdateInvisibleDefaultValue;
            _tailColumn = TailColumnDefaultValue;
            _animationLodBias = AnimationLodBiasDefaultValue;
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
        public RibbonTrailPrefab(RibbonTrail val)
        {
            _material = val.Material;
            _vertexDistance = val.VertexDistance;
            _width = val.Width;
            _startColor = val.StartColor;
            _endColor = val.EndColor;
            _startScale = val.StartScale;
            _endScale = val.EndScale;
            _trailType = val.TrailType;
            _sorted = val.Sorted;
            _lifetime = val.Lifetime;
            _emitting = val.Emitting;
            _updateInvisible = val.UpdateInvisible;
            _tailColumn = val.TailColumn;
            _animationLodBias = val.AnimationLodBias;
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
        public Material Material {get { return _material;} set { _material=value; } }
        public bool MaterialHasValue {get { return !PrefabUtils.AreEqual(ref _material, ref MaterialDefaultValue); } }
        public float VertexDistance {get { return _vertexDistance;} set { _vertexDistance=value; } }
        public bool VertexDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _vertexDistance, ref VertexDistanceDefaultValue); } }
        public float Width {get { return _width;} set { _width=value; } }
        public bool WidthHasValue {get { return !PrefabUtils.AreEqual(ref _width, ref WidthDefaultValue); } }
        public Color StartColor {get { return _startColor;} set { _startColor=value; } }
        public bool StartColorHasValue {get { return !PrefabUtils.AreEqual(ref _startColor, ref StartColorDefaultValue); } }
        public Color EndColor {get { return _endColor;} set { _endColor=value; } }
        public bool EndColorHasValue {get { return !PrefabUtils.AreEqual(ref _endColor, ref EndColorDefaultValue); } }
        public float StartScale {get { return _startScale;} set { _startScale=value; } }
        public bool StartScaleHasValue {get { return !PrefabUtils.AreEqual(ref _startScale, ref StartScaleDefaultValue); } }
        public float EndScale {get { return _endScale;} set { _endScale=value; } }
        public bool EndScaleHasValue {get { return !PrefabUtils.AreEqual(ref _endScale, ref EndScaleDefaultValue); } }
        public TrailType TrailType {get { return _trailType;} set { _trailType=value; } }
        public bool TrailTypeHasValue {get { return !PrefabUtils.AreEqual(ref _trailType, ref TrailTypeDefaultValue); } }
        public bool Sorted {get { return _sorted;} set { _sorted=value; } }
        public bool SortedHasValue {get { return !PrefabUtils.AreEqual(ref _sorted, ref SortedDefaultValue); } }
        public float Lifetime {get { return _lifetime;} set { _lifetime=value; } }
        public bool LifetimeHasValue {get { return !PrefabUtils.AreEqual(ref _lifetime, ref LifetimeDefaultValue); } }
        public bool Emitting {get { return _emitting;} set { _emitting=value; } }
        public bool EmittingHasValue {get { return !PrefabUtils.AreEqual(ref _emitting, ref EmittingDefaultValue); } }
        public bool UpdateInvisible {get { return _updateInvisible;} set { _updateInvisible=value; } }
        public bool UpdateInvisibleHasValue {get { return !PrefabUtils.AreEqual(ref _updateInvisible, ref UpdateInvisibleDefaultValue); } }
        public uint TailColumn {get { return _tailColumn;} set { _tailColumn=value; } }
        public bool TailColumnHasValue {get { return !PrefabUtils.AreEqual(ref _tailColumn, ref TailColumnDefaultValue); } }
        public float AnimationLodBias {get { return _animationLodBias;} set { _animationLodBias=value; } }
        public bool AnimationLodBiasHasValue {get { return !PrefabUtils.AreEqual(ref _animationLodBias, ref AnimationLodBiasDefaultValue); } }
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
        public override RibbonTrail Create()
        {
            var result = new RibbonTrail();
            if(MaterialHasValue)
                result.Material = _material;
            if(VertexDistanceHasValue)
                result.VertexDistance = _vertexDistance;
            if(WidthHasValue)
                result.Width = _width;
            if(StartColorHasValue)
                result.StartColor = _startColor;
            if(EndColorHasValue)
                result.EndColor = _endColor;
            if(StartScaleHasValue)
                result.StartScale = _startScale;
            if(EndScaleHasValue)
                result.EndScale = _endScale;
            if(TrailTypeHasValue)
                result.TrailType = _trailType;
            if(SortedHasValue)
                result.Sorted = _sorted;
            if(LifetimeHasValue)
                result.Lifetime = _lifetime;
            if(EmittingHasValue)
                result.Emitting = _emitting;
            if(UpdateInvisibleHasValue)
                result.UpdateInvisible = _updateInvisible;
            if(TailColumnHasValue)
                result.TailColumn = _tailColumn;
            if(AnimationLodBiasHasValue)
                result.AnimationLodBias = _animationLodBias;
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
                case "Material":
                    break;
                case "VertexDistance":
                    break;
                case "Width":
                    break;
                case "StartColor":
                    break;
                case "EndColor":
                    break;
                case "StartScale":
                    break;
                case "EndScale":
                    break;
                case "TrailType":
                    break;
                case "Sorted":
                    break;
                case "Lifetime":
                    break;
                case "Emitting":
                    break;
                case "UpdateInvisible":
                    break;
                case "TailColumn":
                    break;
                case "AnimationLodBias":
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
