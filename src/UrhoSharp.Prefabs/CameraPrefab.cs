using System;
using System.Xml.Linq;
using Urho;
using Camera = Urho.Camera;


namespace UrhoSharp.Prefabs
{
    public class CameraPrefab: AbstractComponentPrefab<Camera>, IPrefab
    {
        private static  float NearClipDefaultValue = 0.1f;
        private static  float FarClipDefaultValue = 1000f;
        private static  float FovDefaultValue = 45f;
        private static  float SkewDefaultValue = 0f;
        private static  float OrthoSizeDefaultValue = 20f;
        private static  float AspectRatioDefaultValue = 1f;
        private static  FillMode FillModeDefaultValue = FillMode.Solid;
        private static  float ZoomDefaultValue = 1f;
        private static  float LodBiasDefaultValue = 1f;
        private static  uint ViewMaskDefaultValue = 4294967295;
        private static  ViewOverrideFlags ViewOverrideFlagsDefaultValue = ViewOverrideFlags.None;
        private static  bool OrthographicDefaultValue = false;
        private static  bool AutoAspectRatioDefaultValue = true;
        private static  Vector2 ProjectionOffsetDefaultValue = new Vector2(0f, 0f);
        private static  bool UseReflectionDefaultValue = false;
        private static  Plane ReflectionPlaneDefaultValue = new Plane(new Vector4(0f, 1f, 0f, 0f));
        private static  bool UseClippingDefaultValue = false;
        private static  Plane ClipPlaneDefaultValue = new Plane(new Vector4(0f, 1f, 0f, 0f));
        private static  bool FlipVerticalDefaultValue = false;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private float _nearClip;
        private float _farClip;
        private float _fov;
        private float _skew;
        private float _orthoSize;
        private float _aspectRatio;
        private FillMode _fillMode;
        private float _zoom;
        private float _lodBias;
        private uint _viewMask;
        private ViewOverrideFlags _viewOverrideFlags;
        private bool _orthographic;
        private bool _autoAspectRatio;
        private Vector2 _projectionOffset;
        private bool _useReflection;
        private Plane _reflectionPlane;
        private bool _useClipping;
        private Plane _clipPlane;
        private bool _flipVertical;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public CameraPrefab()
        {
            _nearClip = NearClipDefaultValue;
            _farClip = FarClipDefaultValue;
            _fov = FovDefaultValue;
            _skew = SkewDefaultValue;
            _orthoSize = OrthoSizeDefaultValue;
            _aspectRatio = AspectRatioDefaultValue;
            _fillMode = FillModeDefaultValue;
            _zoom = ZoomDefaultValue;
            _lodBias = LodBiasDefaultValue;
            _viewMask = ViewMaskDefaultValue;
            _viewOverrideFlags = ViewOverrideFlagsDefaultValue;
            _orthographic = OrthographicDefaultValue;
            _autoAspectRatio = AutoAspectRatioDefaultValue;
            _projectionOffset = ProjectionOffsetDefaultValue;
            _useReflection = UseReflectionDefaultValue;
            _reflectionPlane = ReflectionPlaneDefaultValue;
            _useClipping = UseClippingDefaultValue;
            _clipPlane = ClipPlaneDefaultValue;
            _flipVertical = FlipVerticalDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public CameraPrefab(Camera val)
        {
            _nearClip = val.NearClip;
            _farClip = val.FarClip;
            _fov = val.Fov;
            _skew = val.Skew;
            _orthoSize = val.OrthoSize;
            _aspectRatio = val.AspectRatio;
            _fillMode = val.FillMode;
            _zoom = val.Zoom;
            _lodBias = val.LodBias;
            _viewMask = val.ViewMask;
            _viewOverrideFlags = val.ViewOverrideFlags;
            _orthographic = val.Orthographic;
            _autoAspectRatio = val.AutoAspectRatio;
            _projectionOffset = val.ProjectionOffset;
            _useReflection = val.UseReflection;
            _reflectionPlane = val.ReflectionPlane;
            _useClipping = val.UseClipping;
            _clipPlane = val.ClipPlane;
            _flipVertical = val.FlipVertical;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public float NearClip {get { return _nearClip;} set { _nearClip=value; } }
        public bool NearClipHasValue {get { return !PrefabUtils.AreEqual(ref _nearClip, ref NearClipDefaultValue); } }
        public float FarClip {get { return _farClip;} set { _farClip=value; } }
        public bool FarClipHasValue {get { return !PrefabUtils.AreEqual(ref _farClip, ref FarClipDefaultValue); } }
        public float Fov {get { return _fov;} set { _fov=value; } }
        public bool FovHasValue {get { return !PrefabUtils.AreEqual(ref _fov, ref FovDefaultValue); } }
        public float Skew {get { return _skew;} set { _skew=value; } }
        public bool SkewHasValue {get { return !PrefabUtils.AreEqual(ref _skew, ref SkewDefaultValue); } }
        public float OrthoSize {get { return _orthoSize;} set { _orthoSize=value; } }
        public bool OrthoSizeHasValue {get { return !PrefabUtils.AreEqual(ref _orthoSize, ref OrthoSizeDefaultValue); } }
        public float AspectRatio {get { return _aspectRatio;} set { _aspectRatio=value; } }
        public bool AspectRatioHasValue {get { return !PrefabUtils.AreEqual(ref _aspectRatio, ref AspectRatioDefaultValue); } }
        public FillMode FillMode {get { return _fillMode;} set { _fillMode=value; } }
        public bool FillModeHasValue {get { return !PrefabUtils.AreEqual(ref _fillMode, ref FillModeDefaultValue); } }
        public float Zoom {get { return _zoom;} set { _zoom=value; } }
        public bool ZoomHasValue {get { return !PrefabUtils.AreEqual(ref _zoom, ref ZoomDefaultValue); } }
        public float LodBias {get { return _lodBias;} set { _lodBias=value; } }
        public bool LodBiasHasValue {get { return !PrefabUtils.AreEqual(ref _lodBias, ref LodBiasDefaultValue); } }
        public uint ViewMask {get { return _viewMask;} set { _viewMask=value; } }
        public bool ViewMaskHasValue {get { return !PrefabUtils.AreEqual(ref _viewMask, ref ViewMaskDefaultValue); } }
        public ViewOverrideFlags ViewOverrideFlags {get { return _viewOverrideFlags;} set { _viewOverrideFlags=value; } }
        public bool ViewOverrideFlagsHasValue {get { return !PrefabUtils.AreEqual(ref _viewOverrideFlags, ref ViewOverrideFlagsDefaultValue); } }
        public bool Orthographic {get { return _orthographic;} set { _orthographic=value; } }
        public bool OrthographicHasValue {get { return !PrefabUtils.AreEqual(ref _orthographic, ref OrthographicDefaultValue); } }
        public bool AutoAspectRatio {get { return _autoAspectRatio;} set { _autoAspectRatio=value; } }
        public bool AutoAspectRatioHasValue {get { return !PrefabUtils.AreEqual(ref _autoAspectRatio, ref AutoAspectRatioDefaultValue); } }
        public Vector2 ProjectionOffset {get { return _projectionOffset;} set { _projectionOffset=value; } }
        public bool ProjectionOffsetHasValue {get { return !PrefabUtils.AreEqual(ref _projectionOffset, ref ProjectionOffsetDefaultValue); } }
        public bool UseReflection {get { return _useReflection;} set { _useReflection=value; } }
        public bool UseReflectionHasValue {get { return !PrefabUtils.AreEqual(ref _useReflection, ref UseReflectionDefaultValue); } }
        public Plane ReflectionPlane {get { return _reflectionPlane;} set { _reflectionPlane=value; } }
        public bool ReflectionPlaneHasValue {get { return !PrefabUtils.AreEqual(ref _reflectionPlane, ref ReflectionPlaneDefaultValue); } }
        public bool UseClipping {get { return _useClipping;} set { _useClipping=value; } }
        public bool UseClippingHasValue {get { return !PrefabUtils.AreEqual(ref _useClipping, ref UseClippingDefaultValue); } }
        public Plane ClipPlane {get { return _clipPlane;} set { _clipPlane=value; } }
        public bool ClipPlaneHasValue {get { return !PrefabUtils.AreEqual(ref _clipPlane, ref ClipPlaneDefaultValue); } }
        public bool FlipVertical {get { return _flipVertical;} set { _flipVertical=value; } }
        public bool FlipVerticalHasValue {get { return !PrefabUtils.AreEqual(ref _flipVertical, ref FlipVerticalDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override Camera Create()
        {
            var result = new Camera();
            if(NearClipHasValue)
                result.NearClip = _nearClip;
            if(FarClipHasValue)
                result.FarClip = _farClip;
            if(FovHasValue)
                result.Fov = _fov;
            if(SkewHasValue)
                result.Skew = _skew;
            if(OrthoSizeHasValue)
                result.OrthoSize = _orthoSize;
            if(AspectRatioHasValue)
                result.AspectRatio = _aspectRatio;
            if(FillModeHasValue)
                result.FillMode = _fillMode;
            if(ZoomHasValue)
                result.Zoom = _zoom;
            if(LodBiasHasValue)
                result.LodBias = _lodBias;
            if(ViewMaskHasValue)
                result.ViewMask = _viewMask;
            if(ViewOverrideFlagsHasValue)
                result.ViewOverrideFlags = _viewOverrideFlags;
            if(OrthographicHasValue)
                result.Orthographic = _orthographic;
            if(AutoAspectRatioHasValue)
                result.AutoAspectRatio = _autoAspectRatio;
            if(ProjectionOffsetHasValue)
                result.ProjectionOffset = _projectionOffset;
            if(UseReflectionHasValue)
                result.UseReflection = _useReflection;
            if(ReflectionPlaneHasValue)
                result.ReflectionPlane = _reflectionPlane;
            if(UseClippingHasValue)
                result.UseClipping = _useClipping;
            if(ClipPlaneHasValue)
                result.ClipPlane = _clipPlane;
            if(FlipVerticalHasValue)
                result.FlipVertical = _flipVertical;
            if(EnabledHasValue)
                result.Enabled = _enabled;
            if(AnimationEnabledHasValue)
                result.AnimationEnabled = _animationEnabled;
            if(TemporaryHasValue)
                result.Temporary = _temporary;
            if(BlockEventsHasValue)
                result.BlockEvents = _blockEvents;
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "NearClip":
                    break;
                case "FarClip":
                    break;
                case "Fov":
                    break;
                case "Skew":
                    break;
                case "OrthoSize":
                    break;
                case "AspectRatio":
                    break;
                case "FillMode":
                    break;
                case "Zoom":
                    break;
                case "LodBias":
                    break;
                case "ViewMask":
                    break;
                case "ViewOverrideFlags":
                    break;
                case "Orthographic":
                    break;
                case "AutoAspectRatio":
                    break;
                case "ProjectionOffset":
                    break;
                case "UseReflection":
                    break;
                case "ReflectionPlane":
                    break;
                case "UseClipping":
                    break;
                case "ClipPlane":
                    break;
                case "FlipVertical":
                    break;
                case "Enabled":
                    break;
                case "AnimationEnabled":
                    break;
                case "Temporary":
                    break;
                case "BlockEvents":
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
    }
}
