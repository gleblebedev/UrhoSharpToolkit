using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ParticleEmitter = Urho.ParticleEmitter;


namespace UrhoSharp.Prefabs
{
    public partial class ParticleEmitterPrefab: AbstractComponentPrefab<ParticleEmitter>, IPrefab
    {
        public override string TypeName { get { return ParticleEmitter.TypeNameStatic; } }
        public ParticleEffect Effect { get; set; }
        public uint NumParticles { get; set; }
        public bool Emitting { get; set; }
        public bool SerializeParticles { get; set; }
        public AutoRemoveMode AutoRemoveMode { get; set; }
        public Material Material { get; set; }
        public uint NumBillboards { get; set; }
        public bool Relative { get; set; }
        public bool Scaled { get; set; }
        public bool Sorted { get; set; }
        public bool FixedScreenSize { get; set; }
        public FaceCameraMode FaceCameraMode { get; set; }
        public float MinAngle { get; set; }
        public float AnimationLodBias { get; set; }
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
        public ParticleEmitterPrefab()
        {
            Effect = EffectAccessor.DefaultValue;
            NumParticles = NumParticlesAccessor.DefaultValue;
            Emitting = EmittingAccessor.DefaultValue;
            SerializeParticles = SerializeParticlesAccessor.DefaultValue;
            AutoRemoveMode = AutoRemoveModeAccessor.DefaultValue;
            Material = MaterialAccessor.DefaultValue;
            NumBillboards = NumBillboardsAccessor.DefaultValue;
            Relative = RelativeAccessor.DefaultValue;
            Scaled = ScaledAccessor.DefaultValue;
            Sorted = SortedAccessor.DefaultValue;
            FixedScreenSize = FixedScreenSizeAccessor.DefaultValue;
            FaceCameraMode = FaceCameraModeAccessor.DefaultValue;
            MinAngle = MinAngleAccessor.DefaultValue;
            AnimationLodBias = AnimationLodBiasAccessor.DefaultValue;
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
        public ParticleEmitterPrefab(ParticleEmitter val)
        {
            ID = val.ID;
            Effect = val.Effect;
            NumParticles = val.NumParticles;
            Emitting = val.Emitting;
            SerializeParticles = val.SerializeParticles;
            AutoRemoveMode = val.AutoRemoveMode;
            Material = val.Material;
            NumBillboards = val.NumBillboards;
            Relative = val.Relative;
            Scaled = val.Scaled;
            Sorted = val.Sorted;
            FixedScreenSize = val.FixedScreenSize;
            FaceCameraMode = val.FaceCameraMode;
            MinAngle = val.MinAngle;
            AnimationLodBias = val.AnimationLodBias;
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
        public override ParticleEmitter Create()
        {
            var result = new ParticleEmitter();
            EffectAccessor.Instance.ApplyIfChanged(this, result);
            NumParticlesAccessor.Instance.ApplyIfChanged(this, result);
            EmittingAccessor.Instance.ApplyIfChanged(this, result);
            SerializeParticlesAccessor.Instance.ApplyIfChanged(this, result);
            AutoRemoveModeAccessor.Instance.ApplyIfChanged(this, result);
            MaterialAccessor.Instance.ApplyIfChanged(this, result);
            NumBillboardsAccessor.Instance.ApplyIfChanged(this, result);
            RelativeAccessor.Instance.ApplyIfChanged(this, result);
            ScaledAccessor.Instance.ApplyIfChanged(this, result);
            SortedAccessor.Instance.ApplyIfChanged(this, result);
            FixedScreenSizeAccessor.Instance.ApplyIfChanged(this, result);
            FaceCameraModeAccessor.Instance.ApplyIfChanged(this, result);
            MinAngleAccessor.Instance.ApplyIfChanged(this, result);
            AnimationLodBiasAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Effect":
                    EffectAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "NumParticles":
                    NumParticlesAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Emitting":
                    EmittingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "SerializeParticles":
                    SerializeParticlesAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AutoRemoveMode":
                    AutoRemoveModeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Material":
                    MaterialAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "NumBillboards":
                    NumBillboardsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Relative":
                    RelativeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Scaled":
                    ScaledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Sorted":
                    SortedAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FixedScreenSize":
                    FixedScreenSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FaceCameraMode":
                    FaceCameraModeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MinAngle":
                    MinAngleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AnimationLodBias":
                    AnimationLodBiasAccessor.Instance.ParseAndSet(value, this);
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
                yield return EffectAccessor.Instance;
                yield return NumParticlesAccessor.Instance;
                yield return EmittingAccessor.Instance;
                yield return SerializeParticlesAccessor.Instance;
                yield return AutoRemoveModeAccessor.Instance;
                yield return MaterialAccessor.Instance;
                yield return NumBillboardsAccessor.Instance;
                yield return RelativeAccessor.Instance;
                yield return ScaledAccessor.Instance;
                yield return SortedAccessor.Instance;
                yield return FixedScreenSizeAccessor.Instance;
                yield return FaceCameraModeAccessor.Instance;
                yield return MinAngleAccessor.Instance;
                yield return AnimationLodBiasAccessor.Instance;
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

        internal class EffectAccessor : ParticleEffectAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly EffectAccessor Instance = new EffectAccessor();
            public static readonly ParticleEffect DefaultValue = null;
            public override ParticleEffect DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Effect);
            public override ParticleEffect GetPrefab(ParticleEmitterPrefab instance) { return instance.Effect; }
            public override void SetPrefab(ParticleEmitterPrefab instance, ParticleEffect value) { instance.Effect = value; }
            public override ParticleEffect GetUrho(ParticleEmitter instance) { return instance.Effect; }
            public override void SetUrho(ParticleEmitter instance, ParticleEffect value) { instance.Effect = value; }
        }

        internal class NumParticlesAccessor : UInt32Accessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly NumParticlesAccessor Instance = new NumParticlesAccessor();
            public static readonly uint DefaultValue = 10;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.NumParticles);
            public override uint GetPrefab(ParticleEmitterPrefab instance) { return instance.NumParticles; }
            public override void SetPrefab(ParticleEmitterPrefab instance, uint value) { instance.NumParticles = value; }
            public override uint GetUrho(ParticleEmitter instance) { return instance.NumParticles; }
            public override void SetUrho(ParticleEmitter instance, uint value) { instance.NumParticles = value; }
        }

        internal class EmittingAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly EmittingAccessor Instance = new EmittingAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Emitting);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.Emitting; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.Emitting = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.Emitting; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.Emitting = value; }
        }

        internal class SerializeParticlesAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly SerializeParticlesAccessor Instance = new SerializeParticlesAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.SerializeParticles);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.SerializeParticles; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.SerializeParticles = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.SerializeParticles; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.SerializeParticles = value; }
        }

        internal class AutoRemoveModeAccessor : EnumAccessor<ParticleEmitterPrefab, ParticleEmitter, AutoRemoveMode>
        {
            public static readonly AutoRemoveModeAccessor Instance = new AutoRemoveModeAccessor();
            public static readonly AutoRemoveMode DefaultValue = AutoRemoveMode.Disabled;
            public override AutoRemoveMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.AutoRemoveMode);
            public override AutoRemoveMode GetPrefab(ParticleEmitterPrefab instance) { return instance.AutoRemoveMode; }
            public override void SetPrefab(ParticleEmitterPrefab instance, AutoRemoveMode value) { instance.AutoRemoveMode = value; }
            public override AutoRemoveMode GetUrho(ParticleEmitter instance) { return instance.AutoRemoveMode; }
            public override void SetUrho(ParticleEmitter instance, AutoRemoveMode value) { instance.AutoRemoveMode = value; }
        }

        internal class MaterialAccessor : MaterialAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly MaterialAccessor Instance = new MaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Material);
            public override Material GetPrefab(ParticleEmitterPrefab instance) { return instance.Material; }
            public override void SetPrefab(ParticleEmitterPrefab instance, Material value) { instance.Material = value; }
            public override Material GetUrho(ParticleEmitter instance) { return instance.Material; }
            public override void SetUrho(ParticleEmitter instance, Material value) { instance.Material = value; }
        }

        internal class NumBillboardsAccessor : UInt32Accessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly NumBillboardsAccessor Instance = new NumBillboardsAccessor();
            public static readonly uint DefaultValue = 10;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.NumBillboards);
            public override uint GetPrefab(ParticleEmitterPrefab instance) { return instance.NumBillboards; }
            public override void SetPrefab(ParticleEmitterPrefab instance, uint value) { instance.NumBillboards = value; }
            public override uint GetUrho(ParticleEmitter instance) { return instance.NumBillboards; }
            public override void SetUrho(ParticleEmitter instance, uint value) { instance.NumBillboards = value; }
        }

        internal class RelativeAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly RelativeAccessor Instance = new RelativeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Relative);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.Relative; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.Relative = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.Relative; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.Relative = value; }
        }

        internal class ScaledAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly ScaledAccessor Instance = new ScaledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Scaled);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.Scaled; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.Scaled = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.Scaled; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.Scaled = value; }
        }

        internal class SortedAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly SortedAccessor Instance = new SortedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Sorted);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.Sorted; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.Sorted = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.Sorted; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.Sorted = value; }
        }

        internal class FixedScreenSizeAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly FixedScreenSizeAccessor Instance = new FixedScreenSizeAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.FixedScreenSize);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.FixedScreenSize; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.FixedScreenSize = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.FixedScreenSize; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.FixedScreenSize = value; }
        }

        internal class FaceCameraModeAccessor : EnumAccessor<ParticleEmitterPrefab, ParticleEmitter, FaceCameraMode>
        {
            public static readonly FaceCameraModeAccessor Instance = new FaceCameraModeAccessor();
            public static readonly FaceCameraMode DefaultValue = FaceCameraMode.RotateXyz;
            public override FaceCameraMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.FaceCameraMode);
            public override FaceCameraMode GetPrefab(ParticleEmitterPrefab instance) { return instance.FaceCameraMode; }
            public override void SetPrefab(ParticleEmitterPrefab instance, FaceCameraMode value) { instance.FaceCameraMode = value; }
            public override FaceCameraMode GetUrho(ParticleEmitter instance) { return instance.FaceCameraMode; }
            public override void SetUrho(ParticleEmitter instance, FaceCameraMode value) { instance.FaceCameraMode = value; }
        }

        internal class MinAngleAccessor : SingleAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly MinAngleAccessor Instance = new MinAngleAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.MinAngle);
            public override float GetPrefab(ParticleEmitterPrefab instance) { return instance.MinAngle; }
            public override void SetPrefab(ParticleEmitterPrefab instance, float value) { instance.MinAngle = value; }
            public override float GetUrho(ParticleEmitter instance) { return instance.MinAngle; }
            public override void SetUrho(ParticleEmitter instance, float value) { instance.MinAngle = value; }
        }

        internal class AnimationLodBiasAccessor : SingleAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly AnimationLodBiasAccessor Instance = new AnimationLodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.AnimationLodBias);
            public override float GetPrefab(ParticleEmitterPrefab instance) { return instance.AnimationLodBias; }
            public override void SetPrefab(ParticleEmitterPrefab instance, float value) { instance.AnimationLodBias = value; }
            public override float GetUrho(ParticleEmitter instance) { return instance.AnimationLodBias; }
            public override void SetUrho(ParticleEmitter instance, float value) { instance.AnimationLodBias = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.DrawDistance);
            public override float GetPrefab(ParticleEmitterPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(ParticleEmitterPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(ParticleEmitter instance) { return instance.DrawDistance; }
            public override void SetUrho(ParticleEmitter instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.ShadowDistance);
            public override float GetPrefab(ParticleEmitterPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(ParticleEmitterPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(ParticleEmitter instance) { return instance.ShadowDistance; }
            public override void SetUrho(ParticleEmitter instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.LodBias);
            public override float GetPrefab(ParticleEmitterPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(ParticleEmitterPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(ParticleEmitter instance) { return instance.LodBias; }
            public override void SetUrho(ParticleEmitter instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.ViewMask);
            public override uint GetPrefab(ParticleEmitterPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(ParticleEmitterPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(ParticleEmitter instance) { return instance.ViewMask; }
            public override void SetUrho(ParticleEmitter instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.LightMask);
            public override uint GetPrefab(ParticleEmitterPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(ParticleEmitterPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(ParticleEmitter instance) { return instance.LightMask; }
            public override void SetUrho(ParticleEmitter instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.ShadowMask);
            public override uint GetPrefab(ParticleEmitterPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(ParticleEmitterPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(ParticleEmitter instance) { return instance.ShadowMask; }
            public override void SetUrho(ParticleEmitter instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.ZoneMask);
            public override uint GetPrefab(ParticleEmitterPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(ParticleEmitterPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(ParticleEmitter instance) { return instance.ZoneMask; }
            public override void SetUrho(ParticleEmitter instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.MaxLights);
            public override uint GetPrefab(ParticleEmitterPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(ParticleEmitterPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(ParticleEmitter instance) { return instance.MaxLights; }
            public override void SetUrho(ParticleEmitter instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.CastShadows);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.CastShadows; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Occluder);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.Occluder; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Occludee);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.Occludee; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.SortValue);
            public override float GetPrefab(ParticleEmitterPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(ParticleEmitterPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(ParticleEmitter instance) { return instance.SortValue; }
            public override void SetUrho(ParticleEmitter instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Enabled);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.Enabled; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.AnimationEnabled);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.Temporary);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.Temporary; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ParticleEmitterPrefab, ParticleEmitter>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ParticleEmitter.BlockEvents);
            public override bool GetPrefab(ParticleEmitterPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ParticleEmitterPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ParticleEmitter instance) { return instance.BlockEvents; }
            public override void SetUrho(ParticleEmitter instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
