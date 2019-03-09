using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Zone = Urho.Zone;


namespace UrhoSharp.Prefabs
{
    public partial class ZonePrefab: AbstractComponentPrefab<Zone>, IPrefab
    {
        public override string TypeName { get { return Zone.TypeNameStatic; } }
        public Color AmbientColor { get; set; }
        public Color FogColor { get; set; }
        public float FogStart { get; set; }
        public float FogEnd { get; set; }
        public float FogHeight { get; set; }
        public float FogHeightScale { get; set; }
        public int Priority { get; set; }
        public bool HeightFog { get; set; }
        public bool Override { get; set; }
        public bool AmbientGradient { get; set; }
        public Texture ZoneTexture { get; set; }
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
        public ZonePrefab()
        {
            AmbientColor = AmbientColorAccessor.DefaultValue;
            FogColor = FogColorAccessor.DefaultValue;
            FogStart = FogStartAccessor.DefaultValue;
            FogEnd = FogEndAccessor.DefaultValue;
            FogHeight = FogHeightAccessor.DefaultValue;
            FogHeightScale = FogHeightScaleAccessor.DefaultValue;
            Priority = PriorityAccessor.DefaultValue;
            HeightFog = HeightFogAccessor.DefaultValue;
            Override = OverrideAccessor.DefaultValue;
            AmbientGradient = AmbientGradientAccessor.DefaultValue;
            ZoneTexture = ZoneTextureAccessor.DefaultValue;
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
        public ZonePrefab(Zone val)
        {
            ID = val.ID;
            AmbientColor = val.AmbientColor;
            FogColor = val.FogColor;
            FogStart = val.FogStart;
            FogEnd = val.FogEnd;
            FogHeight = val.FogHeight;
            FogHeightScale = val.FogHeightScale;
            Priority = val.Priority;
            HeightFog = val.HeightFog;
            Override = val.Override;
            AmbientGradient = val.AmbientGradient;
            ZoneTexture = val.ZoneTexture;
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
        public override Zone Create()
        {
            var result = new Zone();
            AmbientColorAccessor.Instance.ApplyIfChanged(this, result);
            FogColorAccessor.Instance.ApplyIfChanged(this, result);
            FogStartAccessor.Instance.ApplyIfChanged(this, result);
            FogEndAccessor.Instance.ApplyIfChanged(this, result);
            FogHeightAccessor.Instance.ApplyIfChanged(this, result);
            FogHeightScaleAccessor.Instance.ApplyIfChanged(this, result);
            PriorityAccessor.Instance.ApplyIfChanged(this, result);
            HeightFogAccessor.Instance.ApplyIfChanged(this, result);
            OverrideAccessor.Instance.ApplyIfChanged(this, result);
            AmbientGradientAccessor.Instance.ApplyIfChanged(this, result);
            ZoneTextureAccessor.Instance.ApplyIfChanged(this, result);
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
                case "AmbientColor":
                    AmbientColorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FogColor":
                    FogColorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FogStart":
                    FogStartAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FogEnd":
                    FogEndAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FogHeight":
                    FogHeightAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FogHeightScale":
                    FogHeightScaleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Priority":
                    PriorityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "HeightFog":
                    HeightFogAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Override":
                    OverrideAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AmbientGradient":
                    AmbientGradientAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ZoneTexture":
                    ZoneTextureAccessor.Instance.ParseAndSet(value, this);
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
                yield return AmbientColorAccessor.Instance;
                yield return FogColorAccessor.Instance;
                yield return FogStartAccessor.Instance;
                yield return FogEndAccessor.Instance;
                yield return FogHeightAccessor.Instance;
                yield return FogHeightScaleAccessor.Instance;
                yield return PriorityAccessor.Instance;
                yield return HeightFogAccessor.Instance;
                yield return OverrideAccessor.Instance;
                yield return AmbientGradientAccessor.Instance;
                yield return ZoneTextureAccessor.Instance;
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

        internal class AmbientColorAccessor : ColorAccessor<ZonePrefab, Zone>
        {
            public static readonly AmbientColorAccessor Instance = new AmbientColorAccessor();
            public static readonly Color DefaultValue = new Color(0.1f, 0.1f, 0.1f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.AmbientColor);
            public override Color GetPrefab(ZonePrefab instance) { return instance.AmbientColor; }
            public override void SetPrefab(ZonePrefab instance, Color value) { instance.AmbientColor = value; }
            public override Color GetUrho(Zone instance) { return instance.AmbientColor; }
            public override void SetUrho(Zone instance, Color value) { instance.AmbientColor = value; }
        }

        internal class FogColorAccessor : ColorAccessor<ZonePrefab, Zone>
        {
            public static readonly FogColorAccessor Instance = new FogColorAccessor();
            public static readonly Color DefaultValue = new Color(0f, 0f, 0f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.FogColor);
            public override Color GetPrefab(ZonePrefab instance) { return instance.FogColor; }
            public override void SetPrefab(ZonePrefab instance, Color value) { instance.FogColor = value; }
            public override Color GetUrho(Zone instance) { return instance.FogColor; }
            public override void SetUrho(Zone instance, Color value) { instance.FogColor = value; }
        }

        internal class FogStartAccessor : SingleAccessor<ZonePrefab, Zone>
        {
            public static readonly FogStartAccessor Instance = new FogStartAccessor();
            public static readonly float DefaultValue = 250f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.FogStart);
            public override float GetPrefab(ZonePrefab instance) { return instance.FogStart; }
            public override void SetPrefab(ZonePrefab instance, float value) { instance.FogStart = value; }
            public override float GetUrho(Zone instance) { return instance.FogStart; }
            public override void SetUrho(Zone instance, float value) { instance.FogStart = value; }
        }

        internal class FogEndAccessor : SingleAccessor<ZonePrefab, Zone>
        {
            public static readonly FogEndAccessor Instance = new FogEndAccessor();
            public static readonly float DefaultValue = 1000f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.FogEnd);
            public override float GetPrefab(ZonePrefab instance) { return instance.FogEnd; }
            public override void SetPrefab(ZonePrefab instance, float value) { instance.FogEnd = value; }
            public override float GetUrho(Zone instance) { return instance.FogEnd; }
            public override void SetUrho(Zone instance, float value) { instance.FogEnd = value; }
        }

        internal class FogHeightAccessor : SingleAccessor<ZonePrefab, Zone>
        {
            public static readonly FogHeightAccessor Instance = new FogHeightAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.FogHeight);
            public override float GetPrefab(ZonePrefab instance) { return instance.FogHeight; }
            public override void SetPrefab(ZonePrefab instance, float value) { instance.FogHeight = value; }
            public override float GetUrho(Zone instance) { return instance.FogHeight; }
            public override void SetUrho(Zone instance, float value) { instance.FogHeight = value; }
        }

        internal class FogHeightScaleAccessor : SingleAccessor<ZonePrefab, Zone>
        {
            public static readonly FogHeightScaleAccessor Instance = new FogHeightScaleAccessor();
            public static readonly float DefaultValue = 0.5f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.FogHeightScale);
            public override float GetPrefab(ZonePrefab instance) { return instance.FogHeightScale; }
            public override void SetPrefab(ZonePrefab instance, float value) { instance.FogHeightScale = value; }
            public override float GetUrho(Zone instance) { return instance.FogHeightScale; }
            public override void SetUrho(Zone instance, float value) { instance.FogHeightScale = value; }
        }

        internal class PriorityAccessor : Int32Accessor<ZonePrefab, Zone>
        {
            public static readonly PriorityAccessor Instance = new PriorityAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.Priority);
            public override int GetPrefab(ZonePrefab instance) { return instance.Priority; }
            public override void SetPrefab(ZonePrefab instance, int value) { instance.Priority = value; }
            public override int GetUrho(Zone instance) { return instance.Priority; }
            public override void SetUrho(Zone instance, int value) { instance.Priority = value; }
        }

        internal class HeightFogAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly HeightFogAccessor Instance = new HeightFogAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.HeightFog);
            public override bool GetPrefab(ZonePrefab instance) { return instance.HeightFog; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.HeightFog = value; }
            public override bool GetUrho(Zone instance) { return instance.HeightFog; }
            public override void SetUrho(Zone instance, bool value) { instance.HeightFog = value; }
        }

        internal class OverrideAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly OverrideAccessor Instance = new OverrideAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.Override);
            public override bool GetPrefab(ZonePrefab instance) { return instance.Override; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.Override = value; }
            public override bool GetUrho(Zone instance) { return instance.Override; }
            public override void SetUrho(Zone instance, bool value) { instance.Override = value; }
        }

        internal class AmbientGradientAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly AmbientGradientAccessor Instance = new AmbientGradientAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.AmbientGradient);
            public override bool GetPrefab(ZonePrefab instance) { return instance.AmbientGradient; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.AmbientGradient = value; }
            public override bool GetUrho(Zone instance) { return instance.AmbientGradient; }
            public override void SetUrho(Zone instance, bool value) { instance.AmbientGradient = value; }
        }

        internal class ZoneTextureAccessor : TextureAccessor<ZonePrefab, Zone>
        {
            public static readonly ZoneTextureAccessor Instance = new ZoneTextureAccessor();
            public static readonly Texture DefaultValue = null;
            public override Texture DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.ZoneTexture);
            public override Texture GetPrefab(ZonePrefab instance) { return instance.ZoneTexture; }
            public override void SetPrefab(ZonePrefab instance, Texture value) { instance.ZoneTexture = value; }
            public override Texture GetUrho(Zone instance) { return instance.ZoneTexture; }
            public override void SetUrho(Zone instance, Texture value) { instance.ZoneTexture = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<ZonePrefab, Zone>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.DrawDistance);
            public override float GetPrefab(ZonePrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(ZonePrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(Zone instance) { return instance.DrawDistance; }
            public override void SetUrho(Zone instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<ZonePrefab, Zone>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.ShadowDistance);
            public override float GetPrefab(ZonePrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(ZonePrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(Zone instance) { return instance.ShadowDistance; }
            public override void SetUrho(Zone instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<ZonePrefab, Zone>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.LodBias);
            public override float GetPrefab(ZonePrefab instance) { return instance.LodBias; }
            public override void SetPrefab(ZonePrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(Zone instance) { return instance.LodBias; }
            public override void SetUrho(Zone instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<ZonePrefab, Zone>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.ViewMask);
            public override uint GetPrefab(ZonePrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(ZonePrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(Zone instance) { return instance.ViewMask; }
            public override void SetUrho(Zone instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<ZonePrefab, Zone>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.LightMask);
            public override uint GetPrefab(ZonePrefab instance) { return instance.LightMask; }
            public override void SetPrefab(ZonePrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(Zone instance) { return instance.LightMask; }
            public override void SetUrho(Zone instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<ZonePrefab, Zone>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.ShadowMask);
            public override uint GetPrefab(ZonePrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(ZonePrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(Zone instance) { return instance.ShadowMask; }
            public override void SetUrho(Zone instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<ZonePrefab, Zone>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.ZoneMask);
            public override uint GetPrefab(ZonePrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(ZonePrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(Zone instance) { return instance.ZoneMask; }
            public override void SetUrho(Zone instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<ZonePrefab, Zone>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.MaxLights);
            public override uint GetPrefab(ZonePrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(ZonePrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(Zone instance) { return instance.MaxLights; }
            public override void SetUrho(Zone instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.CastShadows);
            public override bool GetPrefab(ZonePrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(Zone instance) { return instance.CastShadows; }
            public override void SetUrho(Zone instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.Occluder);
            public override bool GetPrefab(ZonePrefab instance) { return instance.Occluder; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(Zone instance) { return instance.Occluder; }
            public override void SetUrho(Zone instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.Occludee);
            public override bool GetPrefab(ZonePrefab instance) { return instance.Occludee; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(Zone instance) { return instance.Occludee; }
            public override void SetUrho(Zone instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<ZonePrefab, Zone>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.SortValue);
            public override float GetPrefab(ZonePrefab instance) { return instance.SortValue; }
            public override void SetPrefab(ZonePrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(Zone instance) { return instance.SortValue; }
            public override void SetUrho(Zone instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.Enabled);
            public override bool GetPrefab(ZonePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Zone instance) { return instance.Enabled; }
            public override void SetUrho(Zone instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.AnimationEnabled);
            public override bool GetPrefab(ZonePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Zone instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Zone instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.Temporary);
            public override bool GetPrefab(ZonePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Zone instance) { return instance.Temporary; }
            public override void SetUrho(Zone instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ZonePrefab, Zone>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Zone.BlockEvents);
            public override bool GetPrefab(ZonePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ZonePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Zone instance) { return instance.BlockEvents; }
            public override void SetUrho(Zone instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
