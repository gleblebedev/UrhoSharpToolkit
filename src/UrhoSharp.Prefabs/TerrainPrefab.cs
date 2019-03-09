using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Terrain = Urho.Terrain;


namespace UrhoSharp.Prefabs
{
    public partial class TerrainPrefab: AbstractComponentPrefab<Terrain>, IPrefab
    {
        public override string TypeName { get { return Terrain.TypeNameStatic; } }
        public int PatchSize { get; set; }
        public Vector3 Spacing { get; set; }
        public uint MaxLodLevels { get; set; }
        public uint OcclusionLodLevel { get; set; }
        public bool Smoothing { get; set; }
        public Material Material { get; set; }
        public Terrain NorthNeighbor { get; set; }
        public Terrain SouthNeighbor { get; set; }
        public Terrain WestNeighbor { get; set; }
        public Terrain EastNeighbor { get; set; }
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
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public TerrainPrefab()
        {
            PatchSize = PatchSizeAccessor.DefaultValue;
            Spacing = SpacingAccessor.DefaultValue;
            MaxLodLevels = MaxLodLevelsAccessor.DefaultValue;
            OcclusionLodLevel = OcclusionLodLevelAccessor.DefaultValue;
            Smoothing = SmoothingAccessor.DefaultValue;
            Material = MaterialAccessor.DefaultValue;
            NorthNeighbor = NorthNeighborAccessor.DefaultValue;
            SouthNeighbor = SouthNeighborAccessor.DefaultValue;
            WestNeighbor = WestNeighborAccessor.DefaultValue;
            EastNeighbor = EastNeighborAccessor.DefaultValue;
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
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public TerrainPrefab(Terrain val)
        {
            ID = val.ID;
            PatchSize = val.PatchSize;
            Spacing = val.Spacing;
            MaxLodLevels = val.MaxLodLevels;
            OcclusionLodLevel = val.OcclusionLodLevel;
            Smoothing = val.Smoothing;
            Material = val.Material;
            NorthNeighbor = val.NorthNeighbor;
            SouthNeighbor = val.SouthNeighbor;
            WestNeighbor = val.WestNeighbor;
            EastNeighbor = val.EastNeighbor;
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
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Terrain Create()
        {
            var result = new Terrain();
            PatchSizeAccessor.Instance.ApplyIfChanged(this, result);
            SpacingAccessor.Instance.ApplyIfChanged(this, result);
            MaxLodLevelsAccessor.Instance.ApplyIfChanged(this, result);
            OcclusionLodLevelAccessor.Instance.ApplyIfChanged(this, result);
            SmoothingAccessor.Instance.ApplyIfChanged(this, result);
            MaterialAccessor.Instance.ApplyIfChanged(this, result);
            NorthNeighborAccessor.Instance.ApplyIfChanged(this, result);
            SouthNeighborAccessor.Instance.ApplyIfChanged(this, result);
            WestNeighborAccessor.Instance.ApplyIfChanged(this, result);
            EastNeighborAccessor.Instance.ApplyIfChanged(this, result);
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
                case "PatchSize":
                    PatchSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Spacing":
                    SpacingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxLodLevels":
                    MaxLodLevelsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OcclusionLodLevel":
                    OcclusionLodLevelAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Smoothing":
                    SmoothingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Material":
                    MaterialAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "NorthNeighbor":
                    NorthNeighborAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "SouthNeighbor":
                    SouthNeighborAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "WestNeighbor":
                    WestNeighborAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EastNeighbor":
                    EastNeighborAccessor.Instance.ParseAndSet(value, this);
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
                yield return PatchSizeAccessor.Instance;
                yield return SpacingAccessor.Instance;
                yield return MaxLodLevelsAccessor.Instance;
                yield return OcclusionLodLevelAccessor.Instance;
                yield return SmoothingAccessor.Instance;
                yield return MaterialAccessor.Instance;
                yield return NorthNeighborAccessor.Instance;
                yield return SouthNeighborAccessor.Instance;
                yield return WestNeighborAccessor.Instance;
                yield return EastNeighborAccessor.Instance;
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
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class PatchSizeAccessor : Int32Accessor<TerrainPrefab, Terrain>
        {
            public static readonly PatchSizeAccessor Instance = new PatchSizeAccessor();
            public static readonly int DefaultValue = 32;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.PatchSize);
            public override int GetPrefab(TerrainPrefab instance) { return instance.PatchSize; }
            public override void SetPrefab(TerrainPrefab instance, int value) { instance.PatchSize = value; }
            public override int GetUrho(Terrain instance) { return instance.PatchSize; }
            public override void SetUrho(Terrain instance, int value) { instance.PatchSize = value; }
        }

        internal class SpacingAccessor : Vector3Accessor<TerrainPrefab, Terrain>
        {
            public static readonly SpacingAccessor Instance = new SpacingAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(1f, 0.25f, 1f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.Spacing);
            public override Vector3 GetPrefab(TerrainPrefab instance) { return instance.Spacing; }
            public override void SetPrefab(TerrainPrefab instance, Vector3 value) { instance.Spacing = value; }
            public override Vector3 GetUrho(Terrain instance) { return instance.Spacing; }
            public override void SetUrho(Terrain instance, Vector3 value) { instance.Spacing = value; }
        }

        internal class MaxLodLevelsAccessor : UInt32Accessor<TerrainPrefab, Terrain>
        {
            public static readonly MaxLodLevelsAccessor Instance = new MaxLodLevelsAccessor();
            public static readonly uint DefaultValue = 4;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.MaxLodLevels);
            public override uint GetPrefab(TerrainPrefab instance) { return instance.MaxLodLevels; }
            public override void SetPrefab(TerrainPrefab instance, uint value) { instance.MaxLodLevels = value; }
            public override uint GetUrho(Terrain instance) { return instance.MaxLodLevels; }
            public override void SetUrho(Terrain instance, uint value) { instance.MaxLodLevels = value; }
        }

        internal class OcclusionLodLevelAccessor : UInt32Accessor<TerrainPrefab, Terrain>
        {
            public static readonly OcclusionLodLevelAccessor Instance = new OcclusionLodLevelAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.OcclusionLodLevel);
            public override uint GetPrefab(TerrainPrefab instance) { return instance.OcclusionLodLevel; }
            public override void SetPrefab(TerrainPrefab instance, uint value) { instance.OcclusionLodLevel = value; }
            public override uint GetUrho(Terrain instance) { return instance.OcclusionLodLevel; }
            public override void SetUrho(Terrain instance, uint value) { instance.OcclusionLodLevel = value; }
        }

        internal class SmoothingAccessor : BooleanAccessor<TerrainPrefab, Terrain>
        {
            public static readonly SmoothingAccessor Instance = new SmoothingAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.Smoothing);
            public override bool GetPrefab(TerrainPrefab instance) { return instance.Smoothing; }
            public override void SetPrefab(TerrainPrefab instance, bool value) { instance.Smoothing = value; }
            public override bool GetUrho(Terrain instance) { return instance.Smoothing; }
            public override void SetUrho(Terrain instance, bool value) { instance.Smoothing = value; }
        }

        internal class MaterialAccessor : MaterialAccessor<TerrainPrefab, Terrain>
        {
            public static readonly MaterialAccessor Instance = new MaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.Material);
            public override Material GetPrefab(TerrainPrefab instance) { return instance.Material; }
            public override void SetPrefab(TerrainPrefab instance, Material value) { instance.Material = value; }
            public override Material GetUrho(Terrain instance) { return instance.Material; }
            public override void SetUrho(Terrain instance, Material value) { instance.Material = value; }
        }

        internal class NorthNeighborAccessor : TerrainAccessor<TerrainPrefab, Terrain>
        {
            public static readonly NorthNeighborAccessor Instance = new NorthNeighborAccessor();
            public static readonly Terrain DefaultValue = null;
            public override Terrain DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.NorthNeighbor);
            public override Terrain GetPrefab(TerrainPrefab instance) { return instance.NorthNeighbor; }
            public override void SetPrefab(TerrainPrefab instance, Terrain value) { instance.NorthNeighbor = value; }
            public override Terrain GetUrho(Terrain instance) { return instance.NorthNeighbor; }
            public override void SetUrho(Terrain instance, Terrain value) { instance.NorthNeighbor = value; }
        }

        internal class SouthNeighborAccessor : TerrainAccessor<TerrainPrefab, Terrain>
        {
            public static readonly SouthNeighborAccessor Instance = new SouthNeighborAccessor();
            public static readonly Terrain DefaultValue = null;
            public override Terrain DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.SouthNeighbor);
            public override Terrain GetPrefab(TerrainPrefab instance) { return instance.SouthNeighbor; }
            public override void SetPrefab(TerrainPrefab instance, Terrain value) { instance.SouthNeighbor = value; }
            public override Terrain GetUrho(Terrain instance) { return instance.SouthNeighbor; }
            public override void SetUrho(Terrain instance, Terrain value) { instance.SouthNeighbor = value; }
        }

        internal class WestNeighborAccessor : TerrainAccessor<TerrainPrefab, Terrain>
        {
            public static readonly WestNeighborAccessor Instance = new WestNeighborAccessor();
            public static readonly Terrain DefaultValue = null;
            public override Terrain DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.WestNeighbor);
            public override Terrain GetPrefab(TerrainPrefab instance) { return instance.WestNeighbor; }
            public override void SetPrefab(TerrainPrefab instance, Terrain value) { instance.WestNeighbor = value; }
            public override Terrain GetUrho(Terrain instance) { return instance.WestNeighbor; }
            public override void SetUrho(Terrain instance, Terrain value) { instance.WestNeighbor = value; }
        }

        internal class EastNeighborAccessor : TerrainAccessor<TerrainPrefab, Terrain>
        {
            public static readonly EastNeighborAccessor Instance = new EastNeighborAccessor();
            public static readonly Terrain DefaultValue = null;
            public override Terrain DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.EastNeighbor);
            public override Terrain GetPrefab(TerrainPrefab instance) { return instance.EastNeighbor; }
            public override void SetPrefab(TerrainPrefab instance, Terrain value) { instance.EastNeighbor = value; }
            public override Terrain GetUrho(Terrain instance) { return instance.EastNeighbor; }
            public override void SetUrho(Terrain instance, Terrain value) { instance.EastNeighbor = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<TerrainPrefab, Terrain>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.DrawDistance);
            public override float GetPrefab(TerrainPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(TerrainPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(Terrain instance) { return instance.DrawDistance; }
            public override void SetUrho(Terrain instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<TerrainPrefab, Terrain>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.ShadowDistance);
            public override float GetPrefab(TerrainPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(TerrainPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(Terrain instance) { return instance.ShadowDistance; }
            public override void SetUrho(Terrain instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<TerrainPrefab, Terrain>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.LodBias);
            public override float GetPrefab(TerrainPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(TerrainPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(Terrain instance) { return instance.LodBias; }
            public override void SetUrho(Terrain instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<TerrainPrefab, Terrain>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.ViewMask);
            public override uint GetPrefab(TerrainPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(TerrainPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(Terrain instance) { return instance.ViewMask; }
            public override void SetUrho(Terrain instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<TerrainPrefab, Terrain>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.LightMask);
            public override uint GetPrefab(TerrainPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(TerrainPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(Terrain instance) { return instance.LightMask; }
            public override void SetUrho(Terrain instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<TerrainPrefab, Terrain>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.ShadowMask);
            public override uint GetPrefab(TerrainPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(TerrainPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(Terrain instance) { return instance.ShadowMask; }
            public override void SetUrho(Terrain instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<TerrainPrefab, Terrain>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.ZoneMask);
            public override uint GetPrefab(TerrainPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(TerrainPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(Terrain instance) { return instance.ZoneMask; }
            public override void SetUrho(Terrain instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<TerrainPrefab, Terrain>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.MaxLights);
            public override uint GetPrefab(TerrainPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(TerrainPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(Terrain instance) { return instance.MaxLights; }
            public override void SetUrho(Terrain instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<TerrainPrefab, Terrain>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.CastShadows);
            public override bool GetPrefab(TerrainPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(TerrainPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(Terrain instance) { return instance.CastShadows; }
            public override void SetUrho(Terrain instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<TerrainPrefab, Terrain>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.Occluder);
            public override bool GetPrefab(TerrainPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(TerrainPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(Terrain instance) { return instance.Occluder; }
            public override void SetUrho(Terrain instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<TerrainPrefab, Terrain>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.Occludee);
            public override bool GetPrefab(TerrainPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(TerrainPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(Terrain instance) { return instance.Occludee; }
            public override void SetUrho(Terrain instance, bool value) { instance.Occludee = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<TerrainPrefab, Terrain>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.Enabled);
            public override bool GetPrefab(TerrainPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(TerrainPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Terrain instance) { return instance.Enabled; }
            public override void SetUrho(Terrain instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<TerrainPrefab, Terrain>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.AnimationEnabled);
            public override bool GetPrefab(TerrainPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(TerrainPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Terrain instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Terrain instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<TerrainPrefab, Terrain>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.Temporary);
            public override bool GetPrefab(TerrainPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(TerrainPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Terrain instance) { return instance.Temporary; }
            public override void SetUrho(Terrain instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<TerrainPrefab, Terrain>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Terrain.BlockEvents);
            public override bool GetPrefab(TerrainPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(TerrainPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Terrain instance) { return instance.BlockEvents; }
            public override void SetUrho(Terrain instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
