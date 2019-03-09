using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Cone = Urho.Shapes.Cone;

using Urho.Shapes;

namespace UrhoSharp.Prefabs
{
    public partial class ConePrefab: AbstractComponentPrefab<Cone>, IPrefab
    {
        public override string TypeName { get { return Cone.TypeNameStatic; } }
        public Color Color { get; set; }
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
        public ConePrefab()
        {
            Color = ColorAccessor.DefaultValue;
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
        public ConePrefab(Cone val)
        {
            ID = val.ID;
            Color = val.Color;
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
        public override Cone Create()
        {
            var result = new Cone();
            ColorAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Color":
                    ColorAccessor.Instance.ParseAndSet(value, this);
                    break;
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
                yield return ColorAccessor.Instance;
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

        internal class ColorAccessor : ColorAccessor<ConePrefab, Cone>
        {
            public static readonly ColorAccessor Instance = new ColorAccessor();
            public static readonly Color DefaultValue = new Color(1f, 0f, 1f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.Color);
            public override Color GetPrefab(ConePrefab instance) { return instance.Color; }
            public override void SetPrefab(ConePrefab instance, Color value) { instance.Color = value; }
            public override Color GetUrho(Cone instance) { return instance.Color; }
            public override void SetUrho(Cone instance, Color value) { instance.Color = value; }
        }

        internal class MaterialAccessor : MaterialAccessor<ConePrefab, Cone>
        {
            public static readonly MaterialAccessor Instance = new MaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.Material);
            public override Material GetPrefab(ConePrefab instance) { return instance.Material; }
            public override void SetPrefab(ConePrefab instance, Material value) { instance.Material = value; }
            public override Material GetUrho(Cone instance) { return instance.Material; }
            public override void SetUrho(Cone instance, Material value) { instance.Material = value; }
        }

        internal class ModelAccessor : ModelAccessor<ConePrefab, Cone>
        {
            public static readonly ModelAccessor Instance = new ModelAccessor();
            public static readonly Model DefaultValue = null;
            public override Model DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.Model);
            public override Model GetPrefab(ConePrefab instance) { return instance.Model; }
            public override void SetPrefab(ConePrefab instance, Model value) { instance.Model = value; }
            public override Model GetUrho(Cone instance) { return instance.Model; }
            public override void SetUrho(Cone instance, Model value) { instance.Model = value; }
        }

        internal class OcclusionLodLevelAccessor : UInt32Accessor<ConePrefab, Cone>
        {
            public static readonly OcclusionLodLevelAccessor Instance = new OcclusionLodLevelAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.OcclusionLodLevel);
            public override uint GetPrefab(ConePrefab instance) { return instance.OcclusionLodLevel; }
            public override void SetPrefab(ConePrefab instance, uint value) { instance.OcclusionLodLevel = value; }
            public override uint GetUrho(Cone instance) { return instance.OcclusionLodLevel; }
            public override void SetUrho(Cone instance, uint value) { instance.OcclusionLodLevel = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<ConePrefab, Cone>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.DrawDistance);
            public override float GetPrefab(ConePrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(ConePrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(Cone instance) { return instance.DrawDistance; }
            public override void SetUrho(Cone instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<ConePrefab, Cone>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.ShadowDistance);
            public override float GetPrefab(ConePrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(ConePrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(Cone instance) { return instance.ShadowDistance; }
            public override void SetUrho(Cone instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<ConePrefab, Cone>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.LodBias);
            public override float GetPrefab(ConePrefab instance) { return instance.LodBias; }
            public override void SetPrefab(ConePrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(Cone instance) { return instance.LodBias; }
            public override void SetUrho(Cone instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<ConePrefab, Cone>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.ViewMask);
            public override uint GetPrefab(ConePrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(ConePrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(Cone instance) { return instance.ViewMask; }
            public override void SetUrho(Cone instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<ConePrefab, Cone>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.LightMask);
            public override uint GetPrefab(ConePrefab instance) { return instance.LightMask; }
            public override void SetPrefab(ConePrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(Cone instance) { return instance.LightMask; }
            public override void SetUrho(Cone instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<ConePrefab, Cone>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.ShadowMask);
            public override uint GetPrefab(ConePrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(ConePrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(Cone instance) { return instance.ShadowMask; }
            public override void SetUrho(Cone instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<ConePrefab, Cone>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.ZoneMask);
            public override uint GetPrefab(ConePrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(ConePrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(Cone instance) { return instance.ZoneMask; }
            public override void SetUrho(Cone instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<ConePrefab, Cone>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.MaxLights);
            public override uint GetPrefab(ConePrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(ConePrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(Cone instance) { return instance.MaxLights; }
            public override void SetUrho(Cone instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<ConePrefab, Cone>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.CastShadows);
            public override bool GetPrefab(ConePrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(ConePrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(Cone instance) { return instance.CastShadows; }
            public override void SetUrho(Cone instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<ConePrefab, Cone>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.Occluder);
            public override bool GetPrefab(ConePrefab instance) { return instance.Occluder; }
            public override void SetPrefab(ConePrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(Cone instance) { return instance.Occluder; }
            public override void SetUrho(Cone instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<ConePrefab, Cone>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.Occludee);
            public override bool GetPrefab(ConePrefab instance) { return instance.Occludee; }
            public override void SetPrefab(ConePrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(Cone instance) { return instance.Occludee; }
            public override void SetUrho(Cone instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<ConePrefab, Cone>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.SortValue);
            public override float GetPrefab(ConePrefab instance) { return instance.SortValue; }
            public override void SetPrefab(ConePrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(Cone instance) { return instance.SortValue; }
            public override void SetUrho(Cone instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConePrefab, Cone>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.Enabled);
            public override bool GetPrefab(ConePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Cone instance) { return instance.Enabled; }
            public override void SetUrho(Cone instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConePrefab, Cone>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.AnimationEnabled);
            public override bool GetPrefab(ConePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Cone instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Cone instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConePrefab, Cone>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.Temporary);
            public override bool GetPrefab(ConePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Cone instance) { return instance.Temporary; }
            public override void SetUrho(Cone instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConePrefab, Cone>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Cone.BlockEvents);
            public override bool GetPrefab(ConePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Cone instance) { return instance.BlockEvents; }
            public override void SetUrho(Cone instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
