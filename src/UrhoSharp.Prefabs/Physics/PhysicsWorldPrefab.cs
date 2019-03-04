using System;
using System.Xml.Linq;
using Urho;
using PhysicsWorld = Urho.Physics.PhysicsWorld;

using Urho.Physics;

namespace UrhoSharp.Prefabs
{
    public class PhysicsWorldPrefab: AbstractComponentPrefab<PhysicsWorld>, IPrefab
    {
        private static  int FpsDefaultValue = 60;
        private static  int MaxSubStepsDefaultValue = 0;
        private static  int NumIterationsDefaultValue = 10;
        private static  bool UpdateEnabledDefaultValue = true;
        private static  bool InterpolationDefaultValue = true;
        private static  bool InternalEdgeDefaultValue = true;
        private static  bool SplitImpulseDefaultValue = false;
        private static  float MaxNetworkAngularVelocityDefaultValue = 100f;
        private static  bool ApplyingTransformsDefaultValue = false;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private int _fps;
        private int _maxSubSteps;
        private int _numIterations;
        private bool _updateEnabled;
        private bool _interpolation;
        private bool _internalEdge;
        private bool _splitImpulse;
        private float _maxNetworkAngularVelocity;
        private bool _applyingTransforms;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public PhysicsWorldPrefab()
        {
            _fps = FpsDefaultValue;
            _maxSubSteps = MaxSubStepsDefaultValue;
            _numIterations = NumIterationsDefaultValue;
            _updateEnabled = UpdateEnabledDefaultValue;
            _interpolation = InterpolationDefaultValue;
            _internalEdge = InternalEdgeDefaultValue;
            _splitImpulse = SplitImpulseDefaultValue;
            _maxNetworkAngularVelocity = MaxNetworkAngularVelocityDefaultValue;
            _applyingTransforms = ApplyingTransformsDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public PhysicsWorldPrefab(PhysicsWorld val)
        {
            _fps = val.Fps;
            _maxSubSteps = val.MaxSubSteps;
            _numIterations = val.NumIterations;
            _updateEnabled = val.UpdateEnabled;
            _interpolation = val.Interpolation;
            _internalEdge = val.InternalEdge;
            _splitImpulse = val.SplitImpulse;
            _maxNetworkAngularVelocity = val.MaxNetworkAngularVelocity;
            _applyingTransforms = val.ApplyingTransforms;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public int Fps {get { return _fps;} set { _fps=value; } }
        public bool FpsHasValue {get { return !PrefabUtils.AreEqual(ref _fps, ref FpsDefaultValue); } }
        public int MaxSubSteps {get { return _maxSubSteps;} set { _maxSubSteps=value; } }
        public bool MaxSubStepsHasValue {get { return !PrefabUtils.AreEqual(ref _maxSubSteps, ref MaxSubStepsDefaultValue); } }
        public int NumIterations {get { return _numIterations;} set { _numIterations=value; } }
        public bool NumIterationsHasValue {get { return !PrefabUtils.AreEqual(ref _numIterations, ref NumIterationsDefaultValue); } }
        public bool UpdateEnabled {get { return _updateEnabled;} set { _updateEnabled=value; } }
        public bool UpdateEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _updateEnabled, ref UpdateEnabledDefaultValue); } }
        public bool Interpolation {get { return _interpolation;} set { _interpolation=value; } }
        public bool InterpolationHasValue {get { return !PrefabUtils.AreEqual(ref _interpolation, ref InterpolationDefaultValue); } }
        public bool InternalEdge {get { return _internalEdge;} set { _internalEdge=value; } }
        public bool InternalEdgeHasValue {get { return !PrefabUtils.AreEqual(ref _internalEdge, ref InternalEdgeDefaultValue); } }
        public bool SplitImpulse {get { return _splitImpulse;} set { _splitImpulse=value; } }
        public bool SplitImpulseHasValue {get { return !PrefabUtils.AreEqual(ref _splitImpulse, ref SplitImpulseDefaultValue); } }
        public float MaxNetworkAngularVelocity {get { return _maxNetworkAngularVelocity;} set { _maxNetworkAngularVelocity=value; } }
        public bool MaxNetworkAngularVelocityHasValue {get { return !PrefabUtils.AreEqual(ref _maxNetworkAngularVelocity, ref MaxNetworkAngularVelocityDefaultValue); } }
        public bool ApplyingTransforms {get { return _applyingTransforms;} set { _applyingTransforms=value; } }
        public bool ApplyingTransformsHasValue {get { return !PrefabUtils.AreEqual(ref _applyingTransforms, ref ApplyingTransformsDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override PhysicsWorld Create()
        {
            var result = new PhysicsWorld();
            if(FpsHasValue)
                result.Fps = _fps;
            if(MaxSubStepsHasValue)
                result.MaxSubSteps = _maxSubSteps;
            if(NumIterationsHasValue)
                result.NumIterations = _numIterations;
            if(UpdateEnabledHasValue)
                result.UpdateEnabled = _updateEnabled;
            if(InterpolationHasValue)
                result.Interpolation = _interpolation;
            if(InternalEdgeHasValue)
                result.InternalEdge = _internalEdge;
            if(SplitImpulseHasValue)
                result.SplitImpulse = _splitImpulse;
            if(MaxNetworkAngularVelocityHasValue)
                result.MaxNetworkAngularVelocity = _maxNetworkAngularVelocity;
            if(ApplyingTransformsHasValue)
                result.ApplyingTransforms = _applyingTransforms;
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
                case "Fps":
                    break;
                case "MaxSubSteps":
                    break;
                case "NumIterations":
                    break;
                case "UpdateEnabled":
                    break;
                case "Interpolation":
                    break;
                case "InternalEdge":
                    break;
                case "SplitImpulse":
                    break;
                case "MaxNetworkAngularVelocity":
                    break;
                case "ApplyingTransforms":
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
