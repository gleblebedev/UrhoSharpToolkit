using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Camera = Urho.Camera;


namespace UrhoSharp.Prefabs
{
    public partial class CameraPrefab: AbstractComponentPrefab<Camera>, IPrefab
    {
        public override string TypeName { get { return Camera.TypeNameStatic; } }
        public float NearClip { get; set; }
        public float FarClip { get; set; }
        public float Fov { get; set; }
        public float Skew { get; set; }
        public float OrthoSize { get; set; }
        public float AspectRatio { get; set; }
        public FillMode FillMode { get; set; }
        public float Zoom { get; set; }
        public float LodBias { get; set; }
        public uint ViewMask { get; set; }
        public ViewOverrideFlags ViewOverrideFlags { get; set; }
        public bool Orthographic { get; set; }
        public bool AutoAspectRatio { get; set; }
        public Vector2 ProjectionOffset { get; set; }
        public bool UseReflection { get; set; }
        public Plane ReflectionPlane { get; set; }
        public bool UseClipping { get; set; }
        public Plane ClipPlane { get; set; }
        public bool FlipVertical { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public CameraPrefab()
        {
            NearClip = NearClipAccessor.DefaultValue;
            FarClip = FarClipAccessor.DefaultValue;
            Fov = FovAccessor.DefaultValue;
            Skew = SkewAccessor.DefaultValue;
            OrthoSize = OrthoSizeAccessor.DefaultValue;
            AspectRatio = AspectRatioAccessor.DefaultValue;
            FillMode = FillModeAccessor.DefaultValue;
            Zoom = ZoomAccessor.DefaultValue;
            LodBias = LodBiasAccessor.DefaultValue;
            ViewMask = ViewMaskAccessor.DefaultValue;
            ViewOverrideFlags = ViewOverrideFlagsAccessor.DefaultValue;
            Orthographic = OrthographicAccessor.DefaultValue;
            AutoAspectRatio = AutoAspectRatioAccessor.DefaultValue;
            ProjectionOffset = ProjectionOffsetAccessor.DefaultValue;
            UseReflection = UseReflectionAccessor.DefaultValue;
            ReflectionPlane = ReflectionPlaneAccessor.DefaultValue;
            UseClipping = UseClippingAccessor.DefaultValue;
            ClipPlane = ClipPlaneAccessor.DefaultValue;
            FlipVertical = FlipVerticalAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public CameraPrefab(Camera val)
        {
            ID = val.ID;
            NearClip = val.NearClip;
            FarClip = val.FarClip;
            Fov = val.Fov;
            Skew = val.Skew;
            OrthoSize = val.OrthoSize;
            AspectRatio = val.AspectRatio;
            FillMode = val.FillMode;
            Zoom = val.Zoom;
            LodBias = val.LodBias;
            ViewMask = val.ViewMask;
            ViewOverrideFlags = val.ViewOverrideFlags;
            Orthographic = val.Orthographic;
            AutoAspectRatio = val.AutoAspectRatio;
            ProjectionOffset = val.ProjectionOffset;
            UseReflection = val.UseReflection;
            ReflectionPlane = val.ReflectionPlane;
            UseClipping = val.UseClipping;
            ClipPlane = val.ClipPlane;
            FlipVertical = val.FlipVertical;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Camera Create()
        {
            var result = new Camera();
            NearClipAccessor.Instance.ApplyIfChanged(this, result);
            FarClipAccessor.Instance.ApplyIfChanged(this, result);
            FovAccessor.Instance.ApplyIfChanged(this, result);
            SkewAccessor.Instance.ApplyIfChanged(this, result);
            OrthoSizeAccessor.Instance.ApplyIfChanged(this, result);
            AspectRatioAccessor.Instance.ApplyIfChanged(this, result);
            FillModeAccessor.Instance.ApplyIfChanged(this, result);
            ZoomAccessor.Instance.ApplyIfChanged(this, result);
            LodBiasAccessor.Instance.ApplyIfChanged(this, result);
            ViewMaskAccessor.Instance.ApplyIfChanged(this, result);
            ViewOverrideFlagsAccessor.Instance.ApplyIfChanged(this, result);
            OrthographicAccessor.Instance.ApplyIfChanged(this, result);
            AutoAspectRatioAccessor.Instance.ApplyIfChanged(this, result);
            ProjectionOffsetAccessor.Instance.ApplyIfChanged(this, result);
            UseReflectionAccessor.Instance.ApplyIfChanged(this, result);
            ReflectionPlaneAccessor.Instance.ApplyIfChanged(this, result);
            UseClippingAccessor.Instance.ApplyIfChanged(this, result);
            ClipPlaneAccessor.Instance.ApplyIfChanged(this, result);
            FlipVerticalAccessor.Instance.ApplyIfChanged(this, result);
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
                case "NearClip":
                    NearClipAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FarClip":
                    FarClipAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Fov":
                    FovAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Skew":
                    SkewAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OrthoSize":
                    OrthoSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AspectRatio":
                    AspectRatioAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FillMode":
                    FillModeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Zoom":
                    ZoomAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LodBias":
                    LodBiasAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ViewMask":
                    ViewMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ViewOverrideFlags":
                    ViewOverrideFlagsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Orthographic":
                    OrthographicAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AutoAspectRatio":
                    AutoAspectRatioAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ProjectionOffset":
                    ProjectionOffsetAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UseReflection":
                    UseReflectionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ReflectionPlane":
                    ReflectionPlaneAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UseClipping":
                    UseClippingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ClipPlane":
                    ClipPlaneAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FlipVertical":
                    FlipVerticalAccessor.Instance.ParseAndSet(value, this);
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
                yield return NearClipAccessor.Instance;
                yield return FarClipAccessor.Instance;
                yield return FovAccessor.Instance;
                yield return SkewAccessor.Instance;
                yield return OrthoSizeAccessor.Instance;
                yield return AspectRatioAccessor.Instance;
                yield return FillModeAccessor.Instance;
                yield return ZoomAccessor.Instance;
                yield return LodBiasAccessor.Instance;
                yield return ViewMaskAccessor.Instance;
                yield return ViewOverrideFlagsAccessor.Instance;
                yield return OrthographicAccessor.Instance;
                yield return AutoAspectRatioAccessor.Instance;
                yield return ProjectionOffsetAccessor.Instance;
                yield return UseReflectionAccessor.Instance;
                yield return ReflectionPlaneAccessor.Instance;
                yield return UseClippingAccessor.Instance;
                yield return ClipPlaneAccessor.Instance;
                yield return FlipVerticalAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class NearClipAccessor : SingleAccessor<CameraPrefab, Camera>
        {
            public static readonly NearClipAccessor Instance = new NearClipAccessor();
            public static readonly float DefaultValue = 0.1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.NearClip);
            public override float GetPrefab(CameraPrefab instance) { return instance.NearClip; }
            public override void SetPrefab(CameraPrefab instance, float value) { instance.NearClip = value; }
            public override float GetUrho(Camera instance) { return instance.NearClip; }
            public override void SetUrho(Camera instance, float value) { instance.NearClip = value; }
        }

        internal class FarClipAccessor : SingleAccessor<CameraPrefab, Camera>
        {
            public static readonly FarClipAccessor Instance = new FarClipAccessor();
            public static readonly float DefaultValue = 1000f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.FarClip);
            public override float GetPrefab(CameraPrefab instance) { return instance.FarClip; }
            public override void SetPrefab(CameraPrefab instance, float value) { instance.FarClip = value; }
            public override float GetUrho(Camera instance) { return instance.FarClip; }
            public override void SetUrho(Camera instance, float value) { instance.FarClip = value; }
        }

        internal class FovAccessor : SingleAccessor<CameraPrefab, Camera>
        {
            public static readonly FovAccessor Instance = new FovAccessor();
            public static readonly float DefaultValue = 45f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.Fov);
            public override float GetPrefab(CameraPrefab instance) { return instance.Fov; }
            public override void SetPrefab(CameraPrefab instance, float value) { instance.Fov = value; }
            public override float GetUrho(Camera instance) { return instance.Fov; }
            public override void SetUrho(Camera instance, float value) { instance.Fov = value; }
        }

        internal class SkewAccessor : SingleAccessor<CameraPrefab, Camera>
        {
            public static readonly SkewAccessor Instance = new SkewAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.Skew);
            public override float GetPrefab(CameraPrefab instance) { return instance.Skew; }
            public override void SetPrefab(CameraPrefab instance, float value) { instance.Skew = value; }
            public override float GetUrho(Camera instance) { return instance.Skew; }
            public override void SetUrho(Camera instance, float value) { instance.Skew = value; }
        }

        internal class OrthoSizeAccessor : SingleAccessor<CameraPrefab, Camera>
        {
            public static readonly OrthoSizeAccessor Instance = new OrthoSizeAccessor();
            public static readonly float DefaultValue = 20f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.OrthoSize);
            public override float GetPrefab(CameraPrefab instance) { return instance.OrthoSize; }
            public override void SetPrefab(CameraPrefab instance, float value) { instance.OrthoSize = value; }
            public override float GetUrho(Camera instance) { return instance.OrthoSize; }
            public override void SetUrho(Camera instance, float value) { instance.OrthoSize = value; }
        }

        internal class AspectRatioAccessor : SingleAccessor<CameraPrefab, Camera>
        {
            public static readonly AspectRatioAccessor Instance = new AspectRatioAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.AspectRatio);
            public override float GetPrefab(CameraPrefab instance) { return instance.AspectRatio; }
            public override void SetPrefab(CameraPrefab instance, float value) { instance.AspectRatio = value; }
            public override float GetUrho(Camera instance) { return instance.AspectRatio; }
            public override void SetUrho(Camera instance, float value) { instance.AspectRatio = value; }
        }

        internal class FillModeAccessor : EnumAccessor<CameraPrefab, Camera, FillMode>
        {
            public static readonly FillModeAccessor Instance = new FillModeAccessor();
            public static readonly FillMode DefaultValue = FillMode.Solid;
            public override FillMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.FillMode);
            public override FillMode GetPrefab(CameraPrefab instance) { return instance.FillMode; }
            public override void SetPrefab(CameraPrefab instance, FillMode value) { instance.FillMode = value; }
            public override FillMode GetUrho(Camera instance) { return instance.FillMode; }
            public override void SetUrho(Camera instance, FillMode value) { instance.FillMode = value; }
        }

        internal class ZoomAccessor : SingleAccessor<CameraPrefab, Camera>
        {
            public static readonly ZoomAccessor Instance = new ZoomAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.Zoom);
            public override float GetPrefab(CameraPrefab instance) { return instance.Zoom; }
            public override void SetPrefab(CameraPrefab instance, float value) { instance.Zoom = value; }
            public override float GetUrho(Camera instance) { return instance.Zoom; }
            public override void SetUrho(Camera instance, float value) { instance.Zoom = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<CameraPrefab, Camera>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.LodBias);
            public override float GetPrefab(CameraPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(CameraPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(Camera instance) { return instance.LodBias; }
            public override void SetUrho(Camera instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<CameraPrefab, Camera>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.ViewMask);
            public override uint GetPrefab(CameraPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(CameraPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(Camera instance) { return instance.ViewMask; }
            public override void SetUrho(Camera instance, uint value) { instance.ViewMask = value; }
        }

        internal class ViewOverrideFlagsAccessor : EnumAccessor<CameraPrefab, Camera, ViewOverrideFlags>
        {
            public static readonly ViewOverrideFlagsAccessor Instance = new ViewOverrideFlagsAccessor();
            public static readonly ViewOverrideFlags DefaultValue = ViewOverrideFlags.None;
            public override ViewOverrideFlags DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.ViewOverrideFlags);
            public override ViewOverrideFlags GetPrefab(CameraPrefab instance) { return instance.ViewOverrideFlags; }
            public override void SetPrefab(CameraPrefab instance, ViewOverrideFlags value) { instance.ViewOverrideFlags = value; }
            public override ViewOverrideFlags GetUrho(Camera instance) { return instance.ViewOverrideFlags; }
            public override void SetUrho(Camera instance, ViewOverrideFlags value) { instance.ViewOverrideFlags = value; }
        }

        internal class OrthographicAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly OrthographicAccessor Instance = new OrthographicAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.Orthographic);
            public override bool GetPrefab(CameraPrefab instance) { return instance.Orthographic; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.Orthographic = value; }
            public override bool GetUrho(Camera instance) { return instance.Orthographic; }
            public override void SetUrho(Camera instance, bool value) { instance.Orthographic = value; }
        }

        internal class AutoAspectRatioAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly AutoAspectRatioAccessor Instance = new AutoAspectRatioAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.AutoAspectRatio);
            public override bool GetPrefab(CameraPrefab instance) { return instance.AutoAspectRatio; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.AutoAspectRatio = value; }
            public override bool GetUrho(Camera instance) { return instance.AutoAspectRatio; }
            public override void SetUrho(Camera instance, bool value) { instance.AutoAspectRatio = value; }
        }

        internal class ProjectionOffsetAccessor : Vector2Accessor<CameraPrefab, Camera>
        {
            public static readonly ProjectionOffsetAccessor Instance = new ProjectionOffsetAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.ProjectionOffset);
            public override Vector2 GetPrefab(CameraPrefab instance) { return instance.ProjectionOffset; }
            public override void SetPrefab(CameraPrefab instance, Vector2 value) { instance.ProjectionOffset = value; }
            public override Vector2 GetUrho(Camera instance) { return instance.ProjectionOffset; }
            public override void SetUrho(Camera instance, Vector2 value) { instance.ProjectionOffset = value; }
        }

        internal class UseReflectionAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly UseReflectionAccessor Instance = new UseReflectionAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.UseReflection);
            public override bool GetPrefab(CameraPrefab instance) { return instance.UseReflection; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.UseReflection = value; }
            public override bool GetUrho(Camera instance) { return instance.UseReflection; }
            public override void SetUrho(Camera instance, bool value) { instance.UseReflection = value; }
        }

        internal class ReflectionPlaneAccessor : PlaneAccessor<CameraPrefab, Camera>
        {
            public static readonly ReflectionPlaneAccessor Instance = new ReflectionPlaneAccessor();
            public static readonly Plane DefaultValue = new Plane(new Vector4(0f, 1f, 0f, 0f));
            public override Plane DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.ReflectionPlane);
            public override Plane GetPrefab(CameraPrefab instance) { return instance.ReflectionPlane; }
            public override void SetPrefab(CameraPrefab instance, Plane value) { instance.ReflectionPlane = value; }
            public override Plane GetUrho(Camera instance) { return instance.ReflectionPlane; }
            public override void SetUrho(Camera instance, Plane value) { instance.ReflectionPlane = value; }
        }

        internal class UseClippingAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly UseClippingAccessor Instance = new UseClippingAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.UseClipping);
            public override bool GetPrefab(CameraPrefab instance) { return instance.UseClipping; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.UseClipping = value; }
            public override bool GetUrho(Camera instance) { return instance.UseClipping; }
            public override void SetUrho(Camera instance, bool value) { instance.UseClipping = value; }
        }

        internal class ClipPlaneAccessor : PlaneAccessor<CameraPrefab, Camera>
        {
            public static readonly ClipPlaneAccessor Instance = new ClipPlaneAccessor();
            public static readonly Plane DefaultValue = new Plane(new Vector4(0f, 1f, 0f, 0f));
            public override Plane DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.ClipPlane);
            public override Plane GetPrefab(CameraPrefab instance) { return instance.ClipPlane; }
            public override void SetPrefab(CameraPrefab instance, Plane value) { instance.ClipPlane = value; }
            public override Plane GetUrho(Camera instance) { return instance.ClipPlane; }
            public override void SetUrho(Camera instance, Plane value) { instance.ClipPlane = value; }
        }

        internal class FlipVerticalAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly FlipVerticalAccessor Instance = new FlipVerticalAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.FlipVertical);
            public override bool GetPrefab(CameraPrefab instance) { return instance.FlipVertical; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.FlipVertical = value; }
            public override bool GetUrho(Camera instance) { return instance.FlipVertical; }
            public override void SetUrho(Camera instance, bool value) { instance.FlipVertical = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.Enabled);
            public override bool GetPrefab(CameraPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Camera instance) { return instance.Enabled; }
            public override void SetUrho(Camera instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.AnimationEnabled);
            public override bool GetPrefab(CameraPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Camera instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Camera instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.Temporary);
            public override bool GetPrefab(CameraPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Camera instance) { return instance.Temporary; }
            public override void SetUrho(Camera instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<CameraPrefab, Camera>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Camera.BlockEvents);
            public override bool GetPrefab(CameraPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(CameraPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Camera instance) { return instance.BlockEvents; }
            public override void SetUrho(Camera instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
