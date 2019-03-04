using System;
using System.Xml.Linq;
using Urho;
using ParticleEmitter2D = Urho.Urho2D.ParticleEmitter2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class ParticleEmitter2DPrefab: AbstractComponentPrefab<ParticleEmitter2D>, IPrefab
    {
        private static  ParticleEffect2D EffectDefaultValue = null;
        private static  Sprite2D SpriteDefaultValue = null;
        private static  BlendMode BlendModeDefaultValue = BlendMode.Addalpha;
        private static  uint MaxParticlesDefaultValue = 0;
        private static  bool EmittingDefaultValue = true;
        private static  int LayerDefaultValue = 0;
        private static  int OrderInLayerDefaultValue = 0;
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
        private ParticleEffect2D _effect;
        private Sprite2D _sprite;
        private BlendMode _blendMode;
        private uint _maxParticles;
        private bool _emitting;
        private int _layer;
        private int _orderInLayer;
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
        public ParticleEmitter2DPrefab()
        {
            _effect = EffectDefaultValue;
            _sprite = SpriteDefaultValue;
            _blendMode = BlendModeDefaultValue;
            _maxParticles = MaxParticlesDefaultValue;
            _emitting = EmittingDefaultValue;
            _layer = LayerDefaultValue;
            _orderInLayer = OrderInLayerDefaultValue;
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
        public ParticleEmitter2DPrefab(ParticleEmitter2D val)
        {
            _effect = val.Effect;
            _sprite = val.Sprite;
            _blendMode = val.BlendMode;
            _maxParticles = val.MaxParticles;
            _emitting = val.Emitting;
            _layer = val.Layer;
            _orderInLayer = val.OrderInLayer;
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
        public ParticleEffect2D Effect {get { return _effect;} set { _effect=value; } }
        public bool EffectHasValue {get { return !PrefabUtils.AreEqual(ref _effect, ref EffectDefaultValue); } }
        public Sprite2D Sprite {get { return _sprite;} set { _sprite=value; } }
        public bool SpriteHasValue {get { return !PrefabUtils.AreEqual(ref _sprite, ref SpriteDefaultValue); } }
        public BlendMode BlendMode {get { return _blendMode;} set { _blendMode=value; } }
        public bool BlendModeHasValue {get { return !PrefabUtils.AreEqual(ref _blendMode, ref BlendModeDefaultValue); } }
        public uint MaxParticles {get { return _maxParticles;} set { _maxParticles=value; } }
        public bool MaxParticlesHasValue {get { return !PrefabUtils.AreEqual(ref _maxParticles, ref MaxParticlesDefaultValue); } }
        public bool Emitting {get { return _emitting;} set { _emitting=value; } }
        public bool EmittingHasValue {get { return !PrefabUtils.AreEqual(ref _emitting, ref EmittingDefaultValue); } }
        public int Layer {get { return _layer;} set { _layer=value; } }
        public bool LayerHasValue {get { return !PrefabUtils.AreEqual(ref _layer, ref LayerDefaultValue); } }
        public int OrderInLayer {get { return _orderInLayer;} set { _orderInLayer=value; } }
        public bool OrderInLayerHasValue {get { return !PrefabUtils.AreEqual(ref _orderInLayer, ref OrderInLayerDefaultValue); } }
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
        public override ParticleEmitter2D Create()
        {
            var result = new ParticleEmitter2D();
            if(EffectHasValue)
                result.Effect = _effect;
            if(SpriteHasValue)
                result.Sprite = _sprite;
            if(BlendModeHasValue)
                result.BlendMode = _blendMode;
            if(MaxParticlesHasValue)
                result.MaxParticles = _maxParticles;
            if(EmittingHasValue)
                result.Emitting = _emitting;
            if(LayerHasValue)
                result.Layer = _layer;
            if(OrderInLayerHasValue)
                result.OrderInLayer = _orderInLayer;
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
                case "Sprite":
                    break;
                case "BlendMode":
                    break;
                case "MaxParticles":
                    break;
                case "Emitting":
                    break;
                case "Layer":
                    break;
                case "OrderInLayer":
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
