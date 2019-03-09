using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using TerrainPatch = Urho.TerrainPatch;


namespace UrhoSharp.Prefabs
{
    public partial class TerrainPatchPrefab: AbstractComponentPrefab<TerrainPatch>, IPrefab
    {
        public override string TypeName { get { return TerrainPatch.TypeNameStatic; } }
        public Terrain Owner { get; set; }
        public IntVector2 Coordinates { get; set; }
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
        public TerrainPatchPrefab()
        {
            Owner = OwnerAccessor.DefaultValue;
            Coordinates = CoordinatesAccessor.DefaultValue;
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
        public TerrainPatchPrefab(TerrainPatch val)
        {
            ID = val.ID;
            Owner = val.Owner;
            Coordinates = val.Coordinates;
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
        public override TerrainPatch Create()
        {
            var result = new TerrainPatch();
            OwnerAccessor.Instance.ApplyIfChanged(this, result);
            CoordinatesAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Owner":
                    OwnerAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Coordinates":
                    CoordinatesAccessor.Instance.ParseAndSet(value, this);
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
                yield return OwnerAccessor.Instance;
                yield return CoordinatesAccessor.Instance;
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

        internal class OwnerAccessor : TerrainAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly OwnerAccessor Instance = new OwnerAccessor();
            public static readonly Terrain DefaultValue = null;
            public override Terrain DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.Owner);
            public override Terrain GetPrefab(TerrainPatchPrefab instance) { return instance.Owner; }
            public override void SetPrefab(TerrainPatchPrefab instance, Terrain value) { instance.Owner = value; }
            public override Terrain GetUrho(TerrainPatch instance) { return instance.Owner; }
            public override void SetUrho(TerrainPatch instance, Terrain value) { instance.Owner = value; }
        }

        internal class CoordinatesAccessor : IntVector2Accessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly CoordinatesAccessor Instance = new CoordinatesAccessor();
            public static readonly IntVector2 DefaultValue = new IntVector2(0, 0);
            public override IntVector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.Coordinates);
            public override IntVector2 GetPrefab(TerrainPatchPrefab instance) { return instance.Coordinates; }
            public override void SetPrefab(TerrainPatchPrefab instance, IntVector2 value) { instance.Coordinates = value; }
            public override IntVector2 GetUrho(TerrainPatch instance) { return instance.Coordinates; }
            public override void SetUrho(TerrainPatch instance, IntVector2 value) { instance.Coordinates = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.DrawDistance);
            public override float GetPrefab(TerrainPatchPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(TerrainPatchPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(TerrainPatch instance) { return instance.DrawDistance; }
            public override void SetUrho(TerrainPatch instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.ShadowDistance);
            public override float GetPrefab(TerrainPatchPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(TerrainPatchPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(TerrainPatch instance) { return instance.ShadowDistance; }
            public override void SetUrho(TerrainPatch instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.LodBias);
            public override float GetPrefab(TerrainPatchPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(TerrainPatchPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(TerrainPatch instance) { return instance.LodBias; }
            public override void SetUrho(TerrainPatch instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.ViewMask);
            public override uint GetPrefab(TerrainPatchPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(TerrainPatchPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(TerrainPatch instance) { return instance.ViewMask; }
            public override void SetUrho(TerrainPatch instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.LightMask);
            public override uint GetPrefab(TerrainPatchPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(TerrainPatchPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(TerrainPatch instance) { return instance.LightMask; }
            public override void SetUrho(TerrainPatch instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.ShadowMask);
            public override uint GetPrefab(TerrainPatchPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(TerrainPatchPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(TerrainPatch instance) { return instance.ShadowMask; }
            public override void SetUrho(TerrainPatch instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.ZoneMask);
            public override uint GetPrefab(TerrainPatchPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(TerrainPatchPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(TerrainPatch instance) { return instance.ZoneMask; }
            public override void SetUrho(TerrainPatch instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.MaxLights);
            public override uint GetPrefab(TerrainPatchPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(TerrainPatchPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(TerrainPatch instance) { return instance.MaxLights; }
            public override void SetUrho(TerrainPatch instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.CastShadows);
            public override bool GetPrefab(TerrainPatchPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(TerrainPatchPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(TerrainPatch instance) { return instance.CastShadows; }
            public override void SetUrho(TerrainPatch instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.Occluder);
            public override bool GetPrefab(TerrainPatchPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(TerrainPatchPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(TerrainPatch instance) { return instance.Occluder; }
            public override void SetUrho(TerrainPatch instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.Occludee);
            public override bool GetPrefab(TerrainPatchPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(TerrainPatchPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(TerrainPatch instance) { return instance.Occludee; }
            public override void SetUrho(TerrainPatch instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.SortValue);
            public override float GetPrefab(TerrainPatchPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(TerrainPatchPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(TerrainPatch instance) { return instance.SortValue; }
            public override void SetUrho(TerrainPatch instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.Enabled);
            public override bool GetPrefab(TerrainPatchPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(TerrainPatchPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(TerrainPatch instance) { return instance.Enabled; }
            public override void SetUrho(TerrainPatch instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.AnimationEnabled);
            public override bool GetPrefab(TerrainPatchPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(TerrainPatchPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(TerrainPatch instance) { return instance.AnimationEnabled; }
            public override void SetUrho(TerrainPatch instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.Temporary);
            public override bool GetPrefab(TerrainPatchPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(TerrainPatchPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(TerrainPatch instance) { return instance.Temporary; }
            public override void SetUrho(TerrainPatch instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<TerrainPatchPrefab, TerrainPatch>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(TerrainPatch.BlockEvents);
            public override bool GetPrefab(TerrainPatchPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(TerrainPatchPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(TerrainPatch instance) { return instance.BlockEvents; }
            public override void SetUrho(TerrainPatch instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
