using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using SoundSource3D = Urho.Audio.SoundSource3D;

using Urho.Audio;

namespace UrhoSharp.Prefabs
{
    public partial class SoundSource3DPrefab: AbstractComponentPrefab<SoundSource3D>, IPrefab
    {
        public override string TypeName { get { return SoundSource3D.TypeNameStatic; } }
        public float NearDistance { get; set; }
        public float FarDistance { get; set; }
        public float InnerAngle { get; set; }
        public float OuterAngle { get; set; }
        public float Frequency { get; set; }
        public float Gain { get; set; }
        public float Attenuation { get; set; }
        public float Panning { get; set; }
        public AutoRemoveMode AutoRemoveMode { get; set; }
        public int PositionAttr { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public SoundSource3DPrefab()
        {
            NearDistance = NearDistanceAccessor.DefaultValue;
            FarDistance = FarDistanceAccessor.DefaultValue;
            InnerAngle = InnerAngleAccessor.DefaultValue;
            OuterAngle = OuterAngleAccessor.DefaultValue;
            Frequency = FrequencyAccessor.DefaultValue;
            Gain = GainAccessor.DefaultValue;
            Attenuation = AttenuationAccessor.DefaultValue;
            Panning = PanningAccessor.DefaultValue;
            AutoRemoveMode = AutoRemoveModeAccessor.DefaultValue;
            PositionAttr = PositionAttrAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public SoundSource3DPrefab(SoundSource3D val)
        {
            ID = val.ID;
            NearDistance = val.NearDistance;
            FarDistance = val.FarDistance;
            InnerAngle = val.InnerAngle;
            OuterAngle = val.OuterAngle;
            Frequency = val.Frequency;
            Gain = val.Gain;
            Attenuation = val.Attenuation;
            Panning = val.Panning;
            AutoRemoveMode = val.AutoRemoveMode;
            PositionAttr = val.PositionAttr;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override SoundSource3D Create()
        {
            var result = new SoundSource3D();
            NearDistanceAccessor.Instance.ApplyIfChanged(this, result);
            FarDistanceAccessor.Instance.ApplyIfChanged(this, result);
            InnerAngleAccessor.Instance.ApplyIfChanged(this, result);
            OuterAngleAccessor.Instance.ApplyIfChanged(this, result);
            FrequencyAccessor.Instance.ApplyIfChanged(this, result);
            GainAccessor.Instance.ApplyIfChanged(this, result);
            AttenuationAccessor.Instance.ApplyIfChanged(this, result);
            PanningAccessor.Instance.ApplyIfChanged(this, result);
            AutoRemoveModeAccessor.Instance.ApplyIfChanged(this, result);
            PositionAttrAccessor.Instance.ApplyIfChanged(this, result);
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
                case "NearDistance":
                    NearDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FarDistance":
                    FarDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "InnerAngle":
                    InnerAngleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OuterAngle":
                    OuterAngleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Frequency":
                    FrequencyAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Gain":
                    GainAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Attenuation":
                    AttenuationAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Panning":
                    PanningAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AutoRemoveMode":
                    AutoRemoveModeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "PositionAttr":
                    PositionAttrAccessor.Instance.ParseAndSet(value, this);
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
                yield return NearDistanceAccessor.Instance;
                yield return FarDistanceAccessor.Instance;
                yield return InnerAngleAccessor.Instance;
                yield return OuterAngleAccessor.Instance;
                yield return FrequencyAccessor.Instance;
                yield return GainAccessor.Instance;
                yield return AttenuationAccessor.Instance;
                yield return PanningAccessor.Instance;
                yield return AutoRemoveModeAccessor.Instance;
                yield return PositionAttrAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class NearDistanceAccessor : SingleAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly NearDistanceAccessor Instance = new NearDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.NearDistance);
            public override float GetPrefab(SoundSource3DPrefab instance) { return instance.NearDistance; }
            public override void SetPrefab(SoundSource3DPrefab instance, float value) { instance.NearDistance = value; }
            public override float GetUrho(SoundSource3D instance) { return instance.NearDistance; }
            public override void SetUrho(SoundSource3D instance, float value) { instance.NearDistance = value; }
        }

        internal class FarDistanceAccessor : SingleAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly FarDistanceAccessor Instance = new FarDistanceAccessor();
            public static readonly float DefaultValue = 100f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.FarDistance);
            public override float GetPrefab(SoundSource3DPrefab instance) { return instance.FarDistance; }
            public override void SetPrefab(SoundSource3DPrefab instance, float value) { instance.FarDistance = value; }
            public override float GetUrho(SoundSource3D instance) { return instance.FarDistance; }
            public override void SetUrho(SoundSource3D instance, float value) { instance.FarDistance = value; }
        }

        internal class InnerAngleAccessor : SingleAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly InnerAngleAccessor Instance = new InnerAngleAccessor();
            public static readonly float DefaultValue = 360f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.InnerAngle);
            public override float GetPrefab(SoundSource3DPrefab instance) { return instance.InnerAngle; }
            public override void SetPrefab(SoundSource3DPrefab instance, float value) { instance.InnerAngle = value; }
            public override float GetUrho(SoundSource3D instance) { return instance.InnerAngle; }
            public override void SetUrho(SoundSource3D instance, float value) { instance.InnerAngle = value; }
        }

        internal class OuterAngleAccessor : SingleAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly OuterAngleAccessor Instance = new OuterAngleAccessor();
            public static readonly float DefaultValue = 360f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.OuterAngle);
            public override float GetPrefab(SoundSource3DPrefab instance) { return instance.OuterAngle; }
            public override void SetPrefab(SoundSource3DPrefab instance, float value) { instance.OuterAngle = value; }
            public override float GetUrho(SoundSource3D instance) { return instance.OuterAngle; }
            public override void SetUrho(SoundSource3D instance, float value) { instance.OuterAngle = value; }
        }

        internal class FrequencyAccessor : SingleAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly FrequencyAccessor Instance = new FrequencyAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.Frequency);
            public override float GetPrefab(SoundSource3DPrefab instance) { return instance.Frequency; }
            public override void SetPrefab(SoundSource3DPrefab instance, float value) { instance.Frequency = value; }
            public override float GetUrho(SoundSource3D instance) { return instance.Frequency; }
            public override void SetUrho(SoundSource3D instance, float value) { instance.Frequency = value; }
        }

        internal class GainAccessor : SingleAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly GainAccessor Instance = new GainAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.Gain);
            public override float GetPrefab(SoundSource3DPrefab instance) { return instance.Gain; }
            public override void SetPrefab(SoundSource3DPrefab instance, float value) { instance.Gain = value; }
            public override float GetUrho(SoundSource3D instance) { return instance.Gain; }
            public override void SetUrho(SoundSource3D instance, float value) { instance.Gain = value; }
        }

        internal class AttenuationAccessor : SingleAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly AttenuationAccessor Instance = new AttenuationAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.Attenuation);
            public override float GetPrefab(SoundSource3DPrefab instance) { return instance.Attenuation; }
            public override void SetPrefab(SoundSource3DPrefab instance, float value) { instance.Attenuation = value; }
            public override float GetUrho(SoundSource3D instance) { return instance.Attenuation; }
            public override void SetUrho(SoundSource3D instance, float value) { instance.Attenuation = value; }
        }

        internal class PanningAccessor : SingleAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly PanningAccessor Instance = new PanningAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.Panning);
            public override float GetPrefab(SoundSource3DPrefab instance) { return instance.Panning; }
            public override void SetPrefab(SoundSource3DPrefab instance, float value) { instance.Panning = value; }
            public override float GetUrho(SoundSource3D instance) { return instance.Panning; }
            public override void SetUrho(SoundSource3D instance, float value) { instance.Panning = value; }
        }

        internal class AutoRemoveModeAccessor : EnumAccessor<SoundSource3DPrefab, SoundSource3D, AutoRemoveMode>
        {
            public static readonly AutoRemoveModeAccessor Instance = new AutoRemoveModeAccessor();
            public static readonly AutoRemoveMode DefaultValue = AutoRemoveMode.Disabled;
            public override AutoRemoveMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.AutoRemoveMode);
            public override AutoRemoveMode GetPrefab(SoundSource3DPrefab instance) { return instance.AutoRemoveMode; }
            public override void SetPrefab(SoundSource3DPrefab instance, AutoRemoveMode value) { instance.AutoRemoveMode = value; }
            public override AutoRemoveMode GetUrho(SoundSource3D instance) { return instance.AutoRemoveMode; }
            public override void SetUrho(SoundSource3D instance, AutoRemoveMode value) { instance.AutoRemoveMode = value; }
        }

        internal class PositionAttrAccessor : Int32Accessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly PositionAttrAccessor Instance = new PositionAttrAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.PositionAttr);
            public override int GetPrefab(SoundSource3DPrefab instance) { return instance.PositionAttr; }
            public override void SetPrefab(SoundSource3DPrefab instance, int value) { instance.PositionAttr = value; }
            public override int GetUrho(SoundSource3D instance) { return instance.PositionAttr; }
            public override void SetUrho(SoundSource3D instance, int value) { instance.PositionAttr = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.Enabled);
            public override bool GetPrefab(SoundSource3DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(SoundSource3DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(SoundSource3D instance) { return instance.Enabled; }
            public override void SetUrho(SoundSource3D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.AnimationEnabled);
            public override bool GetPrefab(SoundSource3DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(SoundSource3DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(SoundSource3D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(SoundSource3D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.Temporary);
            public override bool GetPrefab(SoundSource3DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(SoundSource3DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(SoundSource3D instance) { return instance.Temporary; }
            public override void SetUrho(SoundSource3D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<SoundSource3DPrefab, SoundSource3D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource3D.BlockEvents);
            public override bool GetPrefab(SoundSource3DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(SoundSource3DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(SoundSource3D instance) { return instance.BlockEvents; }
            public override void SetUrho(SoundSource3D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
