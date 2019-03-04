using System;
using System.Xml.Linq;
using Urho;
using Terrain = Urho.Terrain;


namespace UrhoSharp.Prefabs
{
    public class TerrainPrefab: AbstractComponentPrefab<Terrain>, IPrefab
    {
        private static  int PatchSizeDefaultValue = 32;
        private static  Vector3 SpacingDefaultValue = new Vector3(1f, 0.25f, 1f);
        private static  uint MaxLodLevelsDefaultValue = 4;
        private static  uint OcclusionLodLevelDefaultValue = 4294967295;
        private static  bool SmoothingDefaultValue = false;
        private static  Material MaterialDefaultValue = null;
        private static  Terrain NorthNeighborDefaultValue = null;
        private static  Terrain SouthNeighborDefaultValue = null;
        private static  Terrain WestNeighborDefaultValue = null;
        private static  Terrain EastNeighborDefaultValue = null;
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
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private int _patchSize;
        private Vector3 _spacing;
        private uint _maxLodLevels;
        private uint _occlusionLodLevel;
        private bool _smoothing;
        private Material _material;
        private Terrain _northNeighbor;
        private Terrain _southNeighbor;
        private Terrain _westNeighbor;
        private Terrain _eastNeighbor;
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
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public TerrainPrefab()
        {
            _patchSize = PatchSizeDefaultValue;
            _spacing = SpacingDefaultValue;
            _maxLodLevels = MaxLodLevelsDefaultValue;
            _occlusionLodLevel = OcclusionLodLevelDefaultValue;
            _smoothing = SmoothingDefaultValue;
            _material = MaterialDefaultValue;
            _northNeighbor = NorthNeighborDefaultValue;
            _southNeighbor = SouthNeighborDefaultValue;
            _westNeighbor = WestNeighborDefaultValue;
            _eastNeighbor = EastNeighborDefaultValue;
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
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public TerrainPrefab(Terrain val)
        {
            _patchSize = val.PatchSize;
            _spacing = val.Spacing;
            _maxLodLevels = val.MaxLodLevels;
            _occlusionLodLevel = val.OcclusionLodLevel;
            _smoothing = val.Smoothing;
            _material = val.Material;
            _northNeighbor = val.NorthNeighbor;
            _southNeighbor = val.SouthNeighbor;
            _westNeighbor = val.WestNeighbor;
            _eastNeighbor = val.EastNeighbor;
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
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public int PatchSize {get { return _patchSize;} set { _patchSize=value; } }
        public bool PatchSizeHasValue {get { return !PrefabUtils.AreEqual(ref _patchSize, ref PatchSizeDefaultValue); } }
        public Vector3 Spacing {get { return _spacing;} set { _spacing=value; } }
        public bool SpacingHasValue {get { return !PrefabUtils.AreEqual(ref _spacing, ref SpacingDefaultValue); } }
        public uint MaxLodLevels {get { return _maxLodLevels;} set { _maxLodLevels=value; } }
        public bool MaxLodLevelsHasValue {get { return !PrefabUtils.AreEqual(ref _maxLodLevels, ref MaxLodLevelsDefaultValue); } }
        public uint OcclusionLodLevel {get { return _occlusionLodLevel;} set { _occlusionLodLevel=value; } }
        public bool OcclusionLodLevelHasValue {get { return !PrefabUtils.AreEqual(ref _occlusionLodLevel, ref OcclusionLodLevelDefaultValue); } }
        public bool Smoothing {get { return _smoothing;} set { _smoothing=value; } }
        public bool SmoothingHasValue {get { return !PrefabUtils.AreEqual(ref _smoothing, ref SmoothingDefaultValue); } }
        public Material Material {get { return _material;} set { _material=value; } }
        public bool MaterialHasValue {get { return !PrefabUtils.AreEqual(ref _material, ref MaterialDefaultValue); } }
        public Terrain NorthNeighbor {get { return _northNeighbor;} set { _northNeighbor=value; } }
        public bool NorthNeighborHasValue {get { return !PrefabUtils.AreEqual(ref _northNeighbor, ref NorthNeighborDefaultValue); } }
        public Terrain SouthNeighbor {get { return _southNeighbor;} set { _southNeighbor=value; } }
        public bool SouthNeighborHasValue {get { return !PrefabUtils.AreEqual(ref _southNeighbor, ref SouthNeighborDefaultValue); } }
        public Terrain WestNeighbor {get { return _westNeighbor;} set { _westNeighbor=value; } }
        public bool WestNeighborHasValue {get { return !PrefabUtils.AreEqual(ref _westNeighbor, ref WestNeighborDefaultValue); } }
        public Terrain EastNeighbor {get { return _eastNeighbor;} set { _eastNeighbor=value; } }
        public bool EastNeighborHasValue {get { return !PrefabUtils.AreEqual(ref _eastNeighbor, ref EastNeighborDefaultValue); } }
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
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override Terrain Create()
        {
            var result = new Terrain();
            if(PatchSizeHasValue)
                result.PatchSize = _patchSize;
            if(SpacingHasValue)
                result.Spacing = _spacing;
            if(MaxLodLevelsHasValue)
                result.MaxLodLevels = _maxLodLevels;
            if(OcclusionLodLevelHasValue)
                result.OcclusionLodLevel = _occlusionLodLevel;
            if(SmoothingHasValue)
                result.Smoothing = _smoothing;
            if(MaterialHasValue)
                result.Material = _material;
            if(NorthNeighborHasValue)
                result.NorthNeighbor = _northNeighbor;
            if(SouthNeighborHasValue)
                result.SouthNeighbor = _southNeighbor;
            if(WestNeighborHasValue)
                result.WestNeighbor = _westNeighbor;
            if(EastNeighborHasValue)
                result.EastNeighbor = _eastNeighbor;
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
                case "PatchSize":
                    break;
                case "Spacing":
                    break;
                case "MaxLodLevels":
                    break;
                case "OcclusionLodLevel":
                    break;
                case "Smoothing":
                    break;
                case "Material":
                    break;
                case "NorthNeighbor":
                    break;
                case "SouthNeighbor":
                    break;
                case "WestNeighbor":
                    break;
                case "EastNeighbor":
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
