using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using DecalSet = Urho.DecalSet;


namespace UrhoSharp.Prefabs
{
    public partial class DecalSetPrefab: AbstractComponentPrefab<DecalSet>, IPrefab
    {
        public override string TypeName { get { return DecalSet.TypeNameStatic; } }
        public Material Material { get; set; }
        public uint MaxVertices { get; set; }
        public uint MaxIndices { get; set; }
        public bool OptimizeBufferSize { get; set; }
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
        public DecalSetPrefab()
        {
            Material = MaterialAccessor.DefaultValue;
            MaxVertices = MaxVerticesAccessor.DefaultValue;
            MaxIndices = MaxIndicesAccessor.DefaultValue;
            OptimizeBufferSize = OptimizeBufferSizeAccessor.DefaultValue;
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
        public DecalSetPrefab(DecalSet val)
        {
            ID = val.ID;
            Material = val.Material;
            MaxVertices = val.MaxVertices;
            MaxIndices = val.MaxIndices;
            OptimizeBufferSize = val.OptimizeBufferSize;
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
        public override DecalSet Create()
        {
            var result = new DecalSet();
            MaterialAccessor.Instance.ApplyIfChanged(this, result);
            MaxVerticesAccessor.Instance.ApplyIfChanged(this, result);
            MaxIndicesAccessor.Instance.ApplyIfChanged(this, result);
            OptimizeBufferSizeAccessor.Instance.ApplyIfChanged(this, result);
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
                case "MaxVertices":
                    MaxVerticesAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxIndices":
                    MaxIndicesAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OptimizeBufferSize":
                    OptimizeBufferSizeAccessor.Instance.ParseAndSet(value, this);
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
                yield return MaxVerticesAccessor.Instance;
                yield return MaxIndicesAccessor.Instance;
                yield return OptimizeBufferSizeAccessor.Instance;
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

        internal class MaterialAccessor : MaterialAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly MaterialAccessor Instance = new MaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.Material);
            public override Material GetPrefab(DecalSetPrefab instance) { return instance.Material; }
            public override void SetPrefab(DecalSetPrefab instance, Material value) { instance.Material = value; }
            public override Material GetUrho(DecalSet instance) { return instance.Material; }
            public override void SetUrho(DecalSet instance, Material value) { instance.Material = value; }
        }

        internal class MaxVerticesAccessor : UInt32Accessor<DecalSetPrefab, DecalSet>
        {
            public static readonly MaxVerticesAccessor Instance = new MaxVerticesAccessor();
            public static readonly uint DefaultValue = 512;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.MaxVertices);
            public override uint GetPrefab(DecalSetPrefab instance) { return instance.MaxVertices; }
            public override void SetPrefab(DecalSetPrefab instance, uint value) { instance.MaxVertices = value; }
            public override uint GetUrho(DecalSet instance) { return instance.MaxVertices; }
            public override void SetUrho(DecalSet instance, uint value) { instance.MaxVertices = value; }
        }

        internal class MaxIndicesAccessor : UInt32Accessor<DecalSetPrefab, DecalSet>
        {
            public static readonly MaxIndicesAccessor Instance = new MaxIndicesAccessor();
            public static readonly uint DefaultValue = 1024;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.MaxIndices);
            public override uint GetPrefab(DecalSetPrefab instance) { return instance.MaxIndices; }
            public override void SetPrefab(DecalSetPrefab instance, uint value) { instance.MaxIndices = value; }
            public override uint GetUrho(DecalSet instance) { return instance.MaxIndices; }
            public override void SetUrho(DecalSet instance, uint value) { instance.MaxIndices = value; }
        }

        internal class OptimizeBufferSizeAccessor : BooleanAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly OptimizeBufferSizeAccessor Instance = new OptimizeBufferSizeAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.OptimizeBufferSize);
            public override bool GetPrefab(DecalSetPrefab instance) { return instance.OptimizeBufferSize; }
            public override void SetPrefab(DecalSetPrefab instance, bool value) { instance.OptimizeBufferSize = value; }
            public override bool GetUrho(DecalSet instance) { return instance.OptimizeBufferSize; }
            public override void SetUrho(DecalSet instance, bool value) { instance.OptimizeBufferSize = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.DrawDistance);
            public override float GetPrefab(DecalSetPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(DecalSetPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(DecalSet instance) { return instance.DrawDistance; }
            public override void SetUrho(DecalSet instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.ShadowDistance);
            public override float GetPrefab(DecalSetPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(DecalSetPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(DecalSet instance) { return instance.ShadowDistance; }
            public override void SetUrho(DecalSet instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.LodBias);
            public override float GetPrefab(DecalSetPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(DecalSetPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(DecalSet instance) { return instance.LodBias; }
            public override void SetUrho(DecalSet instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<DecalSetPrefab, DecalSet>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.ViewMask);
            public override uint GetPrefab(DecalSetPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(DecalSetPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(DecalSet instance) { return instance.ViewMask; }
            public override void SetUrho(DecalSet instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<DecalSetPrefab, DecalSet>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.LightMask);
            public override uint GetPrefab(DecalSetPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(DecalSetPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(DecalSet instance) { return instance.LightMask; }
            public override void SetUrho(DecalSet instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<DecalSetPrefab, DecalSet>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.ShadowMask);
            public override uint GetPrefab(DecalSetPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(DecalSetPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(DecalSet instance) { return instance.ShadowMask; }
            public override void SetUrho(DecalSet instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<DecalSetPrefab, DecalSet>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.ZoneMask);
            public override uint GetPrefab(DecalSetPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(DecalSetPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(DecalSet instance) { return instance.ZoneMask; }
            public override void SetUrho(DecalSet instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<DecalSetPrefab, DecalSet>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.MaxLights);
            public override uint GetPrefab(DecalSetPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(DecalSetPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(DecalSet instance) { return instance.MaxLights; }
            public override void SetUrho(DecalSet instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.CastShadows);
            public override bool GetPrefab(DecalSetPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(DecalSetPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(DecalSet instance) { return instance.CastShadows; }
            public override void SetUrho(DecalSet instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.Occluder);
            public override bool GetPrefab(DecalSetPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(DecalSetPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(DecalSet instance) { return instance.Occluder; }
            public override void SetUrho(DecalSet instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.Occludee);
            public override bool GetPrefab(DecalSetPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(DecalSetPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(DecalSet instance) { return instance.Occludee; }
            public override void SetUrho(DecalSet instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.SortValue);
            public override float GetPrefab(DecalSetPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(DecalSetPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(DecalSet instance) { return instance.SortValue; }
            public override void SetUrho(DecalSet instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.Enabled);
            public override bool GetPrefab(DecalSetPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(DecalSetPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(DecalSet instance) { return instance.Enabled; }
            public override void SetUrho(DecalSet instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.AnimationEnabled);
            public override bool GetPrefab(DecalSetPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(DecalSetPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(DecalSet instance) { return instance.AnimationEnabled; }
            public override void SetUrho(DecalSet instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.Temporary);
            public override bool GetPrefab(DecalSetPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(DecalSetPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(DecalSet instance) { return instance.Temporary; }
            public override void SetUrho(DecalSet instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<DecalSetPrefab, DecalSet>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DecalSet.BlockEvents);
            public override bool GetPrefab(DecalSetPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(DecalSetPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(DecalSet instance) { return instance.BlockEvents; }
            public override void SetUrho(DecalSet instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
