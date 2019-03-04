using System;
using System.Xml.Linq;
using Urho;
using SoundSource3D = Urho.Audio.SoundSource3D;

using Urho.Audio;

namespace UrhoSharp.Prefabs
{
    public class SoundSource3DPrefab: AbstractComponentPrefab<SoundSource3D>, IPrefab
    {
        private static  float NearDistanceDefaultValue = 0f;
        private static  float FarDistanceDefaultValue = 100f;
        private static  float InnerAngleDefaultValue = 360f;
        private static  float OuterAngleDefaultValue = 360f;
        private static  float FrequencyDefaultValue = 0f;
        private static  float GainDefaultValue = 1f;
        private static  float AttenuationDefaultValue = 0f;
        private static  float PanningDefaultValue = 0f;
        private static  AutoRemoveMode AutoRemoveModeDefaultValue = AutoRemoveMode.Disabled;
        private static  int PositionAttrDefaultValue = 0;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private float _nearDistance;
        private float _farDistance;
        private float _innerAngle;
        private float _outerAngle;
        private float _frequency;
        private float _gain;
        private float _attenuation;
        private float _panning;
        private AutoRemoveMode _autoRemoveMode;
        private int _positionAttr;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public SoundSource3DPrefab()
        {
            _nearDistance = NearDistanceDefaultValue;
            _farDistance = FarDistanceDefaultValue;
            _innerAngle = InnerAngleDefaultValue;
            _outerAngle = OuterAngleDefaultValue;
            _frequency = FrequencyDefaultValue;
            _gain = GainDefaultValue;
            _attenuation = AttenuationDefaultValue;
            _panning = PanningDefaultValue;
            _autoRemoveMode = AutoRemoveModeDefaultValue;
            _positionAttr = PositionAttrDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public SoundSource3DPrefab(SoundSource3D val)
        {
            _nearDistance = val.NearDistance;
            _farDistance = val.FarDistance;
            _innerAngle = val.InnerAngle;
            _outerAngle = val.OuterAngle;
            _frequency = val.Frequency;
            _gain = val.Gain;
            _attenuation = val.Attenuation;
            _panning = val.Panning;
            _autoRemoveMode = val.AutoRemoveMode;
            _positionAttr = val.PositionAttr;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public float NearDistance {get { return _nearDistance;} set { _nearDistance=value; } }
        public bool NearDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _nearDistance, ref NearDistanceDefaultValue); } }
        public float FarDistance {get { return _farDistance;} set { _farDistance=value; } }
        public bool FarDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _farDistance, ref FarDistanceDefaultValue); } }
        public float InnerAngle {get { return _innerAngle;} set { _innerAngle=value; } }
        public bool InnerAngleHasValue {get { return !PrefabUtils.AreEqual(ref _innerAngle, ref InnerAngleDefaultValue); } }
        public float OuterAngle {get { return _outerAngle;} set { _outerAngle=value; } }
        public bool OuterAngleHasValue {get { return !PrefabUtils.AreEqual(ref _outerAngle, ref OuterAngleDefaultValue); } }
        public float Frequency {get { return _frequency;} set { _frequency=value; } }
        public bool FrequencyHasValue {get { return !PrefabUtils.AreEqual(ref _frequency, ref FrequencyDefaultValue); } }
        public float Gain {get { return _gain;} set { _gain=value; } }
        public bool GainHasValue {get { return !PrefabUtils.AreEqual(ref _gain, ref GainDefaultValue); } }
        public float Attenuation {get { return _attenuation;} set { _attenuation=value; } }
        public bool AttenuationHasValue {get { return !PrefabUtils.AreEqual(ref _attenuation, ref AttenuationDefaultValue); } }
        public float Panning {get { return _panning;} set { _panning=value; } }
        public bool PanningHasValue {get { return !PrefabUtils.AreEqual(ref _panning, ref PanningDefaultValue); } }
        public AutoRemoveMode AutoRemoveMode {get { return _autoRemoveMode;} set { _autoRemoveMode=value; } }
        public bool AutoRemoveModeHasValue {get { return !PrefabUtils.AreEqual(ref _autoRemoveMode, ref AutoRemoveModeDefaultValue); } }
        public int PositionAttr {get { return _positionAttr;} set { _positionAttr=value; } }
        public bool PositionAttrHasValue {get { return !PrefabUtils.AreEqual(ref _positionAttr, ref PositionAttrDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override SoundSource3D Create()
        {
            var result = new SoundSource3D();
            if(NearDistanceHasValue)
                result.NearDistance = _nearDistance;
            if(FarDistanceHasValue)
                result.FarDistance = _farDistance;
            if(InnerAngleHasValue)
                result.InnerAngle = _innerAngle;
            if(OuterAngleHasValue)
                result.OuterAngle = _outerAngle;
            if(FrequencyHasValue)
                result.Frequency = _frequency;
            if(GainHasValue)
                result.Gain = _gain;
            if(AttenuationHasValue)
                result.Attenuation = _attenuation;
            if(PanningHasValue)
                result.Panning = _panning;
            if(AutoRemoveModeHasValue)
                result.AutoRemoveMode = _autoRemoveMode;
            if(PositionAttrHasValue)
                result.PositionAttr = _positionAttr;
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
                case "NearDistance":
                    break;
                case "FarDistance":
                    break;
                case "InnerAngle":
                    break;
                case "OuterAngle":
                    break;
                case "Frequency":
                    break;
                case "Gain":
                    break;
                case "Attenuation":
                    break;
                case "Panning":
                    break;
                case "AutoRemoveMode":
                    break;
                case "PositionAttr":
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
