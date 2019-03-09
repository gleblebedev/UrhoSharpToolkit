using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using BillboardSet = Urho.BillboardSet;


namespace UrhoSharp.Prefabs
{
    public partial class BillboardSetPrefab: AbstractComponentPrefab<BillboardSet>, IPrefab
    {
        public override string TypeName { get { return BillboardSet.TypeNameStatic; } }
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
        public BillboardSetPrefab()
        {
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
        public BillboardSetPrefab(BillboardSet val)
        {
            ID = val.ID;
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
        public override BillboardSet Create()
        {
            var result = new BillboardSet();
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

        internal class MaterialAccessor : MaterialAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly MaterialAccessor Instance = new MaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.Material);
            public override Material GetPrefab(BillboardSetPrefab instance) { return instance.Material; }
            public override void SetPrefab(BillboardSetPrefab instance, Material value) { instance.Material = value; }
            public override Material GetUrho(BillboardSet instance) { return instance.Material; }
            public override void SetUrho(BillboardSet instance, Material value) { instance.Material = value; }
        }

        internal class NumBillboardsAccessor : UInt32Accessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly NumBillboardsAccessor Instance = new NumBillboardsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.NumBillboards);
            public override uint GetPrefab(BillboardSetPrefab instance) { return instance.NumBillboards; }
            public override void SetPrefab(BillboardSetPrefab instance, uint value) { instance.NumBillboards = value; }
            public override uint GetUrho(BillboardSet instance) { return instance.NumBillboards; }
            public override void SetUrho(BillboardSet instance, uint value) { instance.NumBillboards = value; }
        }

        internal class RelativeAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly RelativeAccessor Instance = new RelativeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.Relative);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.Relative; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.Relative = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.Relative; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.Relative = value; }
        }

        internal class ScaledAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly ScaledAccessor Instance = new ScaledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.Scaled);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.Scaled; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.Scaled = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.Scaled; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.Scaled = value; }
        }

        internal class SortedAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly SortedAccessor Instance = new SortedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.Sorted);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.Sorted; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.Sorted = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.Sorted; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.Sorted = value; }
        }

        internal class FixedScreenSizeAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly FixedScreenSizeAccessor Instance = new FixedScreenSizeAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.FixedScreenSize);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.FixedScreenSize; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.FixedScreenSize = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.FixedScreenSize; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.FixedScreenSize = value; }
        }

        internal class FaceCameraModeAccessor : EnumAccessor<BillboardSetPrefab, BillboardSet, FaceCameraMode>
        {
            public static readonly FaceCameraModeAccessor Instance = new FaceCameraModeAccessor();
            public static readonly FaceCameraMode DefaultValue = FaceCameraMode.RotateXyz;
            public override FaceCameraMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.FaceCameraMode);
            public override FaceCameraMode GetPrefab(BillboardSetPrefab instance) { return instance.FaceCameraMode; }
            public override void SetPrefab(BillboardSetPrefab instance, FaceCameraMode value) { instance.FaceCameraMode = value; }
            public override FaceCameraMode GetUrho(BillboardSet instance) { return instance.FaceCameraMode; }
            public override void SetUrho(BillboardSet instance, FaceCameraMode value) { instance.FaceCameraMode = value; }
        }

        internal class MinAngleAccessor : SingleAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly MinAngleAccessor Instance = new MinAngleAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.MinAngle);
            public override float GetPrefab(BillboardSetPrefab instance) { return instance.MinAngle; }
            public override void SetPrefab(BillboardSetPrefab instance, float value) { instance.MinAngle = value; }
            public override float GetUrho(BillboardSet instance) { return instance.MinAngle; }
            public override void SetUrho(BillboardSet instance, float value) { instance.MinAngle = value; }
        }

        internal class AnimationLodBiasAccessor : SingleAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly AnimationLodBiasAccessor Instance = new AnimationLodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.AnimationLodBias);
            public override float GetPrefab(BillboardSetPrefab instance) { return instance.AnimationLodBias; }
            public override void SetPrefab(BillboardSetPrefab instance, float value) { instance.AnimationLodBias = value; }
            public override float GetUrho(BillboardSet instance) { return instance.AnimationLodBias; }
            public override void SetUrho(BillboardSet instance, float value) { instance.AnimationLodBias = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.DrawDistance);
            public override float GetPrefab(BillboardSetPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(BillboardSetPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(BillboardSet instance) { return instance.DrawDistance; }
            public override void SetUrho(BillboardSet instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.ShadowDistance);
            public override float GetPrefab(BillboardSetPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(BillboardSetPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(BillboardSet instance) { return instance.ShadowDistance; }
            public override void SetUrho(BillboardSet instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.LodBias);
            public override float GetPrefab(BillboardSetPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(BillboardSetPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(BillboardSet instance) { return instance.LodBias; }
            public override void SetUrho(BillboardSet instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.ViewMask);
            public override uint GetPrefab(BillboardSetPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(BillboardSetPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(BillboardSet instance) { return instance.ViewMask; }
            public override void SetUrho(BillboardSet instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.LightMask);
            public override uint GetPrefab(BillboardSetPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(BillboardSetPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(BillboardSet instance) { return instance.LightMask; }
            public override void SetUrho(BillboardSet instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.ShadowMask);
            public override uint GetPrefab(BillboardSetPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(BillboardSetPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(BillboardSet instance) { return instance.ShadowMask; }
            public override void SetUrho(BillboardSet instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.ZoneMask);
            public override uint GetPrefab(BillboardSetPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(BillboardSetPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(BillboardSet instance) { return instance.ZoneMask; }
            public override void SetUrho(BillboardSet instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.MaxLights);
            public override uint GetPrefab(BillboardSetPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(BillboardSetPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(BillboardSet instance) { return instance.MaxLights; }
            public override void SetUrho(BillboardSet instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.CastShadows);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.CastShadows; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.Occluder);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.Occluder; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.Occludee);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.Occludee; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.SortValue);
            public override float GetPrefab(BillboardSetPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(BillboardSetPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(BillboardSet instance) { return instance.SortValue; }
            public override void SetUrho(BillboardSet instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.Enabled);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.Enabled; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.AnimationEnabled);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.AnimationEnabled; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.Temporary);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.Temporary; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<BillboardSetPrefab, BillboardSet>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(BillboardSet.BlockEvents);
            public override bool GetPrefab(BillboardSetPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(BillboardSetPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(BillboardSet instance) { return instance.BlockEvents; }
            public override void SetUrho(BillboardSet instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
