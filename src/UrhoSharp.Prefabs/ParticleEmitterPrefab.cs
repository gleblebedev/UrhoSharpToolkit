using System;
using System.Xml.Linq;
using Urho;
using ParticleEmitter = Urho.ParticleEmitter;


namespace UrhoSharp.Prefabs
{
    public class ParticleEmitterPrefab: AbstractComponentPrefab<ParticleEmitter>, IPrefab
    {
        private static  ParticleEffect EffectDefaultValue = null;
        private static  uint NumParticlesDefaultValue = 10;
        private static  bool EmittingDefaultValue = true;
        private static  bool SerializeParticlesDefaultValue = true;
        private static  AutoRemoveMode AutoRemoveModeDefaultValue = AutoRemoveMode.Disabled;
        private static  Material MaterialDefaultValue = null;
        private static  uint NumBillboardsDefaultValue = 10;
        private static  bool RelativeDefaultValue = true;
        private static  bool ScaledDefaultValue = true;
        private static  bool SortedDefaultValue = false;
        private static  bool FixedScreenSizeDefaultValue = false;
        private static  FaceCameraMode FaceCameraModeDefaultValue = FaceCameraMode.RotateXyz;
        private static  float MinAngleDefaultValue = 0f;
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
        private ParticleEffect _effect;
        private uint _numParticles;
        private bool _emitting;
        private bool _serializeParticles;
        private AutoRemoveMode _autoRemoveMode;
        private Material _material;
        private uint _numBillboards;
        private bool _relative;
        private bool _scaled;
        private bool _sorted;
        private bool _fixedScreenSize;
        private FaceCameraMode _faceCameraMode;
        private float _minAngle;
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
        public ParticleEmitterPrefab()
        {
            _effect = EffectDefaultValue;
            _numParticles = NumParticlesDefaultValue;
            _emitting = EmittingDefaultValue;
            _serializeParticles = SerializeParticlesDefaultValue;
            _autoRemoveMode = AutoRemoveModeDefaultValue;
            _material = MaterialDefaultValue;
            _numBillboards = NumBillboardsDefaultValue;
            _relative = RelativeDefaultValue;
            _scaled = ScaledDefaultValue;
            _sorted = SortedDefaultValue;
            _fixedScreenSize = FixedScreenSizeDefaultValue;
            _faceCameraMode = FaceCameraModeDefaultValue;
            _minAngle = MinAngleDefaultValue;
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
        public ParticleEmitterPrefab(ParticleEmitter val)
        {
            _effect = val.Effect;
            _numParticles = val.NumParticles;
            _emitting = val.Emitting;
            _serializeParticles = val.SerializeParticles;
            _autoRemoveMode = val.AutoRemoveMode;
            _material = val.Material;
            _numBillboards = val.NumBillboards;
            _relative = val.Relative;
            _scaled = val.Scaled;
            _sorted = val.Sorted;
            _fixedScreenSize = val.FixedScreenSize;
            _faceCameraMode = val.FaceCameraMode;
            _minAngle = val.MinAngle;
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
        public ParticleEffect Effect {get { return _effect;} set { _effect=value; } }
        public bool EffectHasValue {get { return !PrefabUtils.AreEqual(ref _effect, ref EffectDefaultValue); } }
        public uint NumParticles {get { return _numParticles;} set { _numParticles=value; } }
        public bool NumParticlesHasValue {get { return !PrefabUtils.AreEqual(ref _numParticles, ref NumParticlesDefaultValue); } }
        public bool Emitting {get { return _emitting;} set { _emitting=value; } }
        public bool EmittingHasValue {get { return !PrefabUtils.AreEqual(ref _emitting, ref EmittingDefaultValue); } }
        public bool SerializeParticles {get { return _serializeParticles;} set { _serializeParticles=value; } }
        public bool SerializeParticlesHasValue {get { return !PrefabUtils.AreEqual(ref _serializeParticles, ref SerializeParticlesDefaultValue); } }
        public AutoRemoveMode AutoRemoveMode {get { return _autoRemoveMode;} set { _autoRemoveMode=value; } }
        public bool AutoRemoveModeHasValue {get { return !PrefabUtils.AreEqual(ref _autoRemoveMode, ref AutoRemoveModeDefaultValue); } }
        public Material Material {get { return _material;} set { _material=value; } }
        public bool MaterialHasValue {get { return !PrefabUtils.AreEqual(ref _material, ref MaterialDefaultValue); } }
        public uint NumBillboards {get { return _numBillboards;} set { _numBillboards=value; } }
        public bool NumBillboardsHasValue {get { return !PrefabUtils.AreEqual(ref _numBillboards, ref NumBillboardsDefaultValue); } }
        public bool Relative {get { return _relative;} set { _relative=value; } }
        public bool RelativeHasValue {get { return !PrefabUtils.AreEqual(ref _relative, ref RelativeDefaultValue); } }
        public bool Scaled {get { return _scaled;} set { _scaled=value; } }
        public bool ScaledHasValue {get { return !PrefabUtils.AreEqual(ref _scaled, ref ScaledDefaultValue); } }
        public bool Sorted {get { return _sorted;} set { _sorted=value; } }
        public bool SortedHasValue {get { return !PrefabUtils.AreEqual(ref _sorted, ref SortedDefaultValue); } }
        public bool FixedScreenSize {get { return _fixedScreenSize;} set { _fixedScreenSize=value; } }
        public bool FixedScreenSizeHasValue {get { return !PrefabUtils.AreEqual(ref _fixedScreenSize, ref FixedScreenSizeDefaultValue); } }
        public FaceCameraMode FaceCameraMode {get { return _faceCameraMode;} set { _faceCameraMode=value; } }
        public bool FaceCameraModeHasValue {get { return !PrefabUtils.AreEqual(ref _faceCameraMode, ref FaceCameraModeDefaultValue); } }
        public float MinAngle {get { return _minAngle;} set { _minAngle=value; } }
        public bool MinAngleHasValue {get { return !PrefabUtils.AreEqual(ref _minAngle, ref MinAngleDefaultValue); } }
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
        public override ParticleEmitter Create()
        {
            var result = new ParticleEmitter();
            if(EffectHasValue)
                result.Effect = _effect;
            if(NumParticlesHasValue)
                result.NumParticles = _numParticles;
            if(EmittingHasValue)
                result.Emitting = _emitting;
            if(SerializeParticlesHasValue)
                result.SerializeParticles = _serializeParticles;
            if(AutoRemoveModeHasValue)
                result.AutoRemoveMode = _autoRemoveMode;
            if(MaterialHasValue)
                result.Material = _material;
            if(NumBillboardsHasValue)
                result.NumBillboards = _numBillboards;
            if(RelativeHasValue)
                result.Relative = _relative;
            if(ScaledHasValue)
                result.Scaled = _scaled;
            if(SortedHasValue)
                result.Sorted = _sorted;
            if(FixedScreenSizeHasValue)
                result.FixedScreenSize = _fixedScreenSize;
            if(FaceCameraModeHasValue)
                result.FaceCameraMode = _faceCameraMode;
            if(MinAngleHasValue)
                result.MinAngle = _minAngle;
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
                case "Effect":
                    break;
                case "NumParticles":
                    break;
                case "Emitting":
                    break;
                case "SerializeParticles":
                    break;
                case "AutoRemoveMode":
                    break;
                case "Material":
                    break;
                case "NumBillboards":
                    break;
                case "Relative":
                    break;
                case "Scaled":
                    break;
                case "Sorted":
                    break;
                case "FixedScreenSize":
                    break;
                case "FaceCameraMode":
                    break;
                case "MinAngle":
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
