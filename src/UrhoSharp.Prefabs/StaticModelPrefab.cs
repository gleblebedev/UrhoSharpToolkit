using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using StaticModel = Urho.StaticModel;


namespace UrhoSharp.Prefabs
{
    public partial class StaticModelPrefab: AbstractComponentPrefab<StaticModel>, IPrefab
    {
        public override string TypeName { get { return StaticModel.TypeNameStatic; } }
        public Material Material { get; set; }
        public Model Model { get; set; }
        public uint OcclusionLodLevel { get; set; }
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
        public StaticModelPrefab()
        {
            Material = MaterialAccessor.DefaultValue;
            Model = ModelAccessor.DefaultValue;
            OcclusionLodLevel = OcclusionLodLevelAccessor.DefaultValue;
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
        public StaticModelPrefab(StaticModel val)
        {
            ID = val.ID;
            Material = val.Material;
            Model = val.Model;
            OcclusionLodLevel = val.OcclusionLodLevel;
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
        public override StaticModel Create()
        {
            var result = new StaticModel();
            MaterialAccessor.Instance.ApplyIfChanged(this, result);
            ModelAccessor.Instance.ApplyIfChanged(this, result);
            OcclusionLodLevelAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Model":
                    ModelAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OcclusionLodLevel":
                    OcclusionLodLevelAccessor.Instance.ParseAndSet(value, this);
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
                yield return ModelAccessor.Instance;
                yield return OcclusionLodLevelAccessor.Instance;
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

        internal class MaterialAccessor : MaterialAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly MaterialAccessor Instance = new MaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.Material);
            public override Material GetPrefab(StaticModelPrefab instance) { return instance.Material; }
            public override void SetPrefab(StaticModelPrefab instance, Material value) { instance.Material = value; }
            public override Material GetUrho(StaticModel instance) { return instance.Material; }
            public override void SetUrho(StaticModel instance, Material value) { instance.Material = value; }
        }

        internal class ModelAccessor : ModelAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly ModelAccessor Instance = new ModelAccessor();
            public static readonly Model DefaultValue = null;
            public override Model DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.Model);
            public override Model GetPrefab(StaticModelPrefab instance) { return instance.Model; }
            public override void SetPrefab(StaticModelPrefab instance, Model value) { instance.Model = value; }
            public override Model GetUrho(StaticModel instance) { return instance.Model; }
            public override void SetUrho(StaticModel instance, Model value) { instance.Model = value; }
        }

        internal class OcclusionLodLevelAccessor : UInt32Accessor<StaticModelPrefab, StaticModel>
        {
            public static readonly OcclusionLodLevelAccessor Instance = new OcclusionLodLevelAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.OcclusionLodLevel);
            public override uint GetPrefab(StaticModelPrefab instance) { return instance.OcclusionLodLevel; }
            public override void SetPrefab(StaticModelPrefab instance, uint value) { instance.OcclusionLodLevel = value; }
            public override uint GetUrho(StaticModel instance) { return instance.OcclusionLodLevel; }
            public override void SetUrho(StaticModel instance, uint value) { instance.OcclusionLodLevel = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.DrawDistance);
            public override float GetPrefab(StaticModelPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(StaticModelPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(StaticModel instance) { return instance.DrawDistance; }
            public override void SetUrho(StaticModel instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.ShadowDistance);
            public override float GetPrefab(StaticModelPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(StaticModelPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(StaticModel instance) { return instance.ShadowDistance; }
            public override void SetUrho(StaticModel instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.LodBias);
            public override float GetPrefab(StaticModelPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(StaticModelPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(StaticModel instance) { return instance.LodBias; }
            public override void SetUrho(StaticModel instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<StaticModelPrefab, StaticModel>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.ViewMask);
            public override uint GetPrefab(StaticModelPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(StaticModelPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(StaticModel instance) { return instance.ViewMask; }
            public override void SetUrho(StaticModel instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<StaticModelPrefab, StaticModel>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.LightMask);
            public override uint GetPrefab(StaticModelPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(StaticModelPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(StaticModel instance) { return instance.LightMask; }
            public override void SetUrho(StaticModel instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<StaticModelPrefab, StaticModel>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.ShadowMask);
            public override uint GetPrefab(StaticModelPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(StaticModelPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(StaticModel instance) { return instance.ShadowMask; }
            public override void SetUrho(StaticModel instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<StaticModelPrefab, StaticModel>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.ZoneMask);
            public override uint GetPrefab(StaticModelPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(StaticModelPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(StaticModel instance) { return instance.ZoneMask; }
            public override void SetUrho(StaticModel instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<StaticModelPrefab, StaticModel>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.MaxLights);
            public override uint GetPrefab(StaticModelPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(StaticModelPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(StaticModel instance) { return instance.MaxLights; }
            public override void SetUrho(StaticModel instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.CastShadows);
            public override bool GetPrefab(StaticModelPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(StaticModelPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(StaticModel instance) { return instance.CastShadows; }
            public override void SetUrho(StaticModel instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.Occluder);
            public override bool GetPrefab(StaticModelPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(StaticModelPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(StaticModel instance) { return instance.Occluder; }
            public override void SetUrho(StaticModel instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.Occludee);
            public override bool GetPrefab(StaticModelPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(StaticModelPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(StaticModel instance) { return instance.Occludee; }
            public override void SetUrho(StaticModel instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.SortValue);
            public override float GetPrefab(StaticModelPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(StaticModelPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(StaticModel instance) { return instance.SortValue; }
            public override void SetUrho(StaticModel instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.Enabled);
            public override bool GetPrefab(StaticModelPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(StaticModelPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(StaticModel instance) { return instance.Enabled; }
            public override void SetUrho(StaticModel instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.AnimationEnabled);
            public override bool GetPrefab(StaticModelPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(StaticModelPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(StaticModel instance) { return instance.AnimationEnabled; }
            public override void SetUrho(StaticModel instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.Temporary);
            public override bool GetPrefab(StaticModelPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(StaticModelPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(StaticModel instance) { return instance.Temporary; }
            public override void SetUrho(StaticModel instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<StaticModelPrefab, StaticModel>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(StaticModel.BlockEvents);
            public override bool GetPrefab(StaticModelPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(StaticModelPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(StaticModel instance) { return instance.BlockEvents; }
            public override void SetUrho(StaticModel instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
