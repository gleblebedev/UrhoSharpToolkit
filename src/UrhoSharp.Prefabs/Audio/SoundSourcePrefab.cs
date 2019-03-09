using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using SoundSource = Urho.Audio.SoundSource;

using Urho.Audio;

namespace UrhoSharp.Prefabs
{
    public partial class SoundSourcePrefab: AbstractComponentPrefab<SoundSource>, IPrefab
    {
        public override string TypeName { get { return SoundSource.TypeNameStatic; } }
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
        public SoundSourcePrefab()
        {
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
        public SoundSourcePrefab(SoundSource val)
        {
            ID = val.ID;
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
        public override SoundSource Create()
        {
            var result = new SoundSource();
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

        internal class FrequencyAccessor : SingleAccessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly FrequencyAccessor Instance = new FrequencyAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.Frequency);
            public override float GetPrefab(SoundSourcePrefab instance) { return instance.Frequency; }
            public override void SetPrefab(SoundSourcePrefab instance, float value) { instance.Frequency = value; }
            public override float GetUrho(SoundSource instance) { return instance.Frequency; }
            public override void SetUrho(SoundSource instance, float value) { instance.Frequency = value; }
        }

        internal class GainAccessor : SingleAccessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly GainAccessor Instance = new GainAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.Gain);
            public override float GetPrefab(SoundSourcePrefab instance) { return instance.Gain; }
            public override void SetPrefab(SoundSourcePrefab instance, float value) { instance.Gain = value; }
            public override float GetUrho(SoundSource instance) { return instance.Gain; }
            public override void SetUrho(SoundSource instance, float value) { instance.Gain = value; }
        }

        internal class AttenuationAccessor : SingleAccessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly AttenuationAccessor Instance = new AttenuationAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.Attenuation);
            public override float GetPrefab(SoundSourcePrefab instance) { return instance.Attenuation; }
            public override void SetPrefab(SoundSourcePrefab instance, float value) { instance.Attenuation = value; }
            public override float GetUrho(SoundSource instance) { return instance.Attenuation; }
            public override void SetUrho(SoundSource instance, float value) { instance.Attenuation = value; }
        }

        internal class PanningAccessor : SingleAccessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly PanningAccessor Instance = new PanningAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.Panning);
            public override float GetPrefab(SoundSourcePrefab instance) { return instance.Panning; }
            public override void SetPrefab(SoundSourcePrefab instance, float value) { instance.Panning = value; }
            public override float GetUrho(SoundSource instance) { return instance.Panning; }
            public override void SetUrho(SoundSource instance, float value) { instance.Panning = value; }
        }

        internal class AutoRemoveModeAccessor : EnumAccessor<SoundSourcePrefab, SoundSource, AutoRemoveMode>
        {
            public static readonly AutoRemoveModeAccessor Instance = new AutoRemoveModeAccessor();
            public static readonly AutoRemoveMode DefaultValue = AutoRemoveMode.Disabled;
            public override AutoRemoveMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.AutoRemoveMode);
            public override AutoRemoveMode GetPrefab(SoundSourcePrefab instance) { return instance.AutoRemoveMode; }
            public override void SetPrefab(SoundSourcePrefab instance, AutoRemoveMode value) { instance.AutoRemoveMode = value; }
            public override AutoRemoveMode GetUrho(SoundSource instance) { return instance.AutoRemoveMode; }
            public override void SetUrho(SoundSource instance, AutoRemoveMode value) { instance.AutoRemoveMode = value; }
        }

        internal class PositionAttrAccessor : Int32Accessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly PositionAttrAccessor Instance = new PositionAttrAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.PositionAttr);
            public override int GetPrefab(SoundSourcePrefab instance) { return instance.PositionAttr; }
            public override void SetPrefab(SoundSourcePrefab instance, int value) { instance.PositionAttr = value; }
            public override int GetUrho(SoundSource instance) { return instance.PositionAttr; }
            public override void SetUrho(SoundSource instance, int value) { instance.PositionAttr = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.Enabled);
            public override bool GetPrefab(SoundSourcePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(SoundSourcePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(SoundSource instance) { return instance.Enabled; }
            public override void SetUrho(SoundSource instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.AnimationEnabled);
            public override bool GetPrefab(SoundSourcePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(SoundSourcePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(SoundSource instance) { return instance.AnimationEnabled; }
            public override void SetUrho(SoundSource instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.Temporary);
            public override bool GetPrefab(SoundSourcePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(SoundSourcePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(SoundSource instance) { return instance.Temporary; }
            public override void SetUrho(SoundSource instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<SoundSourcePrefab, SoundSource>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SoundSource.BlockEvents);
            public override bool GetPrefab(SoundSourcePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(SoundSourcePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(SoundSource instance) { return instance.BlockEvents; }
            public override void SetUrho(SoundSource instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
