using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using RibbonTrail = Urho.RibbonTrail;


namespace UrhoSharp.Prefabs
{
    public partial class RibbonTrailPrefab: AbstractComponentPrefab<RibbonTrail>, IPrefab
    {
        public override string TypeName { get { return RibbonTrail.TypeNameStatic; } }
        public Material Material { get; set; }
        public float VertexDistance { get; set; }
        public float Width { get; set; }
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }
        public float StartScale { get; set; }
        public float EndScale { get; set; }
        public TrailType TrailType { get; set; }
        public bool Sorted { get; set; }
        public float Lifetime { get; set; }
        public bool Emitting { get; set; }
        public bool UpdateInvisible { get; set; }
        public uint TailColumn { get; set; }
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
        public RibbonTrailPrefab()
        {
            Material = MaterialAccessor.DefaultValue;
            VertexDistance = VertexDistanceAccessor.DefaultValue;
            Width = WidthAccessor.DefaultValue;
            StartColor = StartColorAccessor.DefaultValue;
            EndColor = EndColorAccessor.DefaultValue;
            StartScale = StartScaleAccessor.DefaultValue;
            EndScale = EndScaleAccessor.DefaultValue;
            TrailType = TrailTypeAccessor.DefaultValue;
            Sorted = SortedAccessor.DefaultValue;
            Lifetime = LifetimeAccessor.DefaultValue;
            Emitting = EmittingAccessor.DefaultValue;
            UpdateInvisible = UpdateInvisibleAccessor.DefaultValue;
            TailColumn = TailColumnAccessor.DefaultValue;
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
        public RibbonTrailPrefab(RibbonTrail val)
        {
            ID = val.ID;
            Material = val.Material;
            VertexDistance = val.VertexDistance;
            Width = val.Width;
            StartColor = val.StartColor;
            EndColor = val.EndColor;
            StartScale = val.StartScale;
            EndScale = val.EndScale;
            TrailType = val.TrailType;
            Sorted = val.Sorted;
            Lifetime = val.Lifetime;
            Emitting = val.Emitting;
            UpdateInvisible = val.UpdateInvisible;
            TailColumn = val.TailColumn;
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
        public override RibbonTrail Create()
        {
            var result = new RibbonTrail();
            MaterialAccessor.Instance.ApplyIfChanged(this, result);
            VertexDistanceAccessor.Instance.ApplyIfChanged(this, result);
            WidthAccessor.Instance.ApplyIfChanged(this, result);
            StartColorAccessor.Instance.ApplyIfChanged(this, result);
            EndColorAccessor.Instance.ApplyIfChanged(this, result);
            StartScaleAccessor.Instance.ApplyIfChanged(this, result);
            EndScaleAccessor.Instance.ApplyIfChanged(this, result);
            TrailTypeAccessor.Instance.ApplyIfChanged(this, result);
            SortedAccessor.Instance.ApplyIfChanged(this, result);
            LifetimeAccessor.Instance.ApplyIfChanged(this, result);
            EmittingAccessor.Instance.ApplyIfChanged(this, result);
            UpdateInvisibleAccessor.Instance.ApplyIfChanged(this, result);
            TailColumnAccessor.Instance.ApplyIfChanged(this, result);
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
                case "VertexDistance":
                    VertexDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Width":
                    WidthAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "StartColor":
                    StartColorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EndColor":
                    EndColorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "StartScale":
                    StartScaleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EndScale":
                    EndScaleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "TrailType":
                    TrailTypeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Sorted":
                    SortedAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Lifetime":
                    LifetimeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Emitting":
                    EmittingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UpdateInvisible":
                    UpdateInvisibleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "TailColumn":
                    TailColumnAccessor.Instance.ParseAndSet(value, this);
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
                yield return VertexDistanceAccessor.Instance;
                yield return WidthAccessor.Instance;
                yield return StartColorAccessor.Instance;
                yield return EndColorAccessor.Instance;
                yield return StartScaleAccessor.Instance;
                yield return EndScaleAccessor.Instance;
                yield return TrailTypeAccessor.Instance;
                yield return SortedAccessor.Instance;
                yield return LifetimeAccessor.Instance;
                yield return EmittingAccessor.Instance;
                yield return UpdateInvisibleAccessor.Instance;
                yield return TailColumnAccessor.Instance;
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

        internal class MaterialAccessor : MaterialAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly MaterialAccessor Instance = new MaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Material);
            public override Material GetPrefab(RibbonTrailPrefab instance) { return instance.Material; }
            public override void SetPrefab(RibbonTrailPrefab instance, Material value) { instance.Material = value; }
            public override Material GetUrho(RibbonTrail instance) { return instance.Material; }
            public override void SetUrho(RibbonTrail instance, Material value) { instance.Material = value; }
        }

        internal class VertexDistanceAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly VertexDistanceAccessor Instance = new VertexDistanceAccessor();
            public static readonly float DefaultValue = 0.1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.VertexDistance);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.VertexDistance; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.VertexDistance = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.VertexDistance; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.VertexDistance = value; }
        }

        internal class WidthAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly WidthAccessor Instance = new WidthAccessor();
            public static readonly float DefaultValue = 0.2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Width);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.Width; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.Width = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.Width; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.Width = value; }
        }

        internal class StartColorAccessor : ColorAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly StartColorAccessor Instance = new StartColorAccessor();
            public static readonly Color DefaultValue = new Color(1f, 1f, 1f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.StartColor);
            public override Color GetPrefab(RibbonTrailPrefab instance) { return instance.StartColor; }
            public override void SetPrefab(RibbonTrailPrefab instance, Color value) { instance.StartColor = value; }
            public override Color GetUrho(RibbonTrail instance) { return instance.StartColor; }
            public override void SetUrho(RibbonTrail instance, Color value) { instance.StartColor = value; }
        }

        internal class EndColorAccessor : ColorAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly EndColorAccessor Instance = new EndColorAccessor();
            public static readonly Color DefaultValue = new Color(1f, 1f, 1f, 0f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.EndColor);
            public override Color GetPrefab(RibbonTrailPrefab instance) { return instance.EndColor; }
            public override void SetPrefab(RibbonTrailPrefab instance, Color value) { instance.EndColor = value; }
            public override Color GetUrho(RibbonTrail instance) { return instance.EndColor; }
            public override void SetUrho(RibbonTrail instance, Color value) { instance.EndColor = value; }
        }

        internal class StartScaleAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly StartScaleAccessor Instance = new StartScaleAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.StartScale);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.StartScale; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.StartScale = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.StartScale; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.StartScale = value; }
        }

        internal class EndScaleAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly EndScaleAccessor Instance = new EndScaleAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.EndScale);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.EndScale; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.EndScale = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.EndScale; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.EndScale = value; }
        }

        internal class TrailTypeAccessor : EnumAccessor<RibbonTrailPrefab, RibbonTrail, TrailType>
        {
            public static readonly TrailTypeAccessor Instance = new TrailTypeAccessor();
            public static readonly TrailType DefaultValue = TrailType.FaceCamera;
            public override TrailType DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.TrailType);
            public override TrailType GetPrefab(RibbonTrailPrefab instance) { return instance.TrailType; }
            public override void SetPrefab(RibbonTrailPrefab instance, TrailType value) { instance.TrailType = value; }
            public override TrailType GetUrho(RibbonTrail instance) { return instance.TrailType; }
            public override void SetUrho(RibbonTrail instance, TrailType value) { instance.TrailType = value; }
        }

        internal class SortedAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly SortedAccessor Instance = new SortedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Sorted);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.Sorted; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.Sorted = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.Sorted; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.Sorted = value; }
        }

        internal class LifetimeAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly LifetimeAccessor Instance = new LifetimeAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Lifetime);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.Lifetime; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.Lifetime = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.Lifetime; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.Lifetime = value; }
        }

        internal class EmittingAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly EmittingAccessor Instance = new EmittingAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Emitting);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.Emitting; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.Emitting = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.Emitting; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.Emitting = value; }
        }

        internal class UpdateInvisibleAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly UpdateInvisibleAccessor Instance = new UpdateInvisibleAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.UpdateInvisible);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.UpdateInvisible; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.UpdateInvisible = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.UpdateInvisible; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.UpdateInvisible = value; }
        }

        internal class TailColumnAccessor : UInt32Accessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly TailColumnAccessor Instance = new TailColumnAccessor();
            public static readonly uint DefaultValue = 1;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.TailColumn);
            public override uint GetPrefab(RibbonTrailPrefab instance) { return instance.TailColumn; }
            public override void SetPrefab(RibbonTrailPrefab instance, uint value) { instance.TailColumn = value; }
            public override uint GetUrho(RibbonTrail instance) { return instance.TailColumn; }
            public override void SetUrho(RibbonTrail instance, uint value) { instance.TailColumn = value; }
        }

        internal class AnimationLodBiasAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly AnimationLodBiasAccessor Instance = new AnimationLodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.AnimationLodBias);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.AnimationLodBias; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.AnimationLodBias = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.AnimationLodBias; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.AnimationLodBias = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.DrawDistance);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.DrawDistance; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.ShadowDistance);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.ShadowDistance; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.LodBias);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.LodBias; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.ViewMask);
            public override uint GetPrefab(RibbonTrailPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(RibbonTrailPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(RibbonTrail instance) { return instance.ViewMask; }
            public override void SetUrho(RibbonTrail instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.LightMask);
            public override uint GetPrefab(RibbonTrailPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(RibbonTrailPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(RibbonTrail instance) { return instance.LightMask; }
            public override void SetUrho(RibbonTrail instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.ShadowMask);
            public override uint GetPrefab(RibbonTrailPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(RibbonTrailPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(RibbonTrail instance) { return instance.ShadowMask; }
            public override void SetUrho(RibbonTrail instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.ZoneMask);
            public override uint GetPrefab(RibbonTrailPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(RibbonTrailPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(RibbonTrail instance) { return instance.ZoneMask; }
            public override void SetUrho(RibbonTrail instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.MaxLights);
            public override uint GetPrefab(RibbonTrailPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(RibbonTrailPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(RibbonTrail instance) { return instance.MaxLights; }
            public override void SetUrho(RibbonTrail instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.CastShadows);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.CastShadows; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Occluder);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.Occluder; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Occludee);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.Occludee; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.SortValue);
            public override float GetPrefab(RibbonTrailPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(RibbonTrailPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(RibbonTrail instance) { return instance.SortValue; }
            public override void SetUrho(RibbonTrail instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Enabled);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.Enabled; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.AnimationEnabled);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.AnimationEnabled; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.Temporary);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.Temporary; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<RibbonTrailPrefab, RibbonTrail>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RibbonTrail.BlockEvents);
            public override bool GetPrefab(RibbonTrailPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(RibbonTrailPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(RibbonTrail instance) { return instance.BlockEvents; }
            public override void SetUrho(RibbonTrail instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
