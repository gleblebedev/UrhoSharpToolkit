using System;
using System.Xml.Linq;
using Urho;
using PhysicsWorld2D = Urho.Urho2D.PhysicsWorld2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class PhysicsWorld2DPrefab: AbstractComponentPrefab<PhysicsWorld2D>, IPrefab
    {
        private static  bool UpdateEnabledDefaultValue = true;
        private static  bool DrawShapeDefaultValue = true;
        private static  bool DrawJointDefaultValue = false;
        private static  bool DrawAabbDefaultValue = false;
        private static  bool DrawPairDefaultValue = false;
        private static  bool DrawCenterOfMassDefaultValue = false;
        private static  bool AllowSleepingDefaultValue = true;
        private static  bool WarmStartingDefaultValue = true;
        private static  bool ContinuousPhysicsDefaultValue = true;
        private static  bool SubSteppingDefaultValue = false;
        private static  Vector2 GravityDefaultValue = new Vector2(0f, -9.81f);
        private static  bool AutoClearForcesDefaultValue = true;
        private static  int VelocityIterationsDefaultValue = 8;
        private static  int PositionIterationsDefaultValue = 3;
        private static  bool ApplyingTransformsDefaultValue = false;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private bool _updateEnabled;
        private bool _drawShape;
        private bool _drawJoint;
        private bool _drawAabb;
        private bool _drawPair;
        private bool _drawCenterOfMass;
        private bool _allowSleeping;
        private bool _warmStarting;
        private bool _continuousPhysics;
        private bool _subStepping;
        private Vector2 _gravity;
        private bool _autoClearForces;
        private int _velocityIterations;
        private int _positionIterations;
        private bool _applyingTransforms;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public PhysicsWorld2DPrefab()
        {
            _updateEnabled = UpdateEnabledDefaultValue;
            _drawShape = DrawShapeDefaultValue;
            _drawJoint = DrawJointDefaultValue;
            _drawAabb = DrawAabbDefaultValue;
            _drawPair = DrawPairDefaultValue;
            _drawCenterOfMass = DrawCenterOfMassDefaultValue;
            _allowSleeping = AllowSleepingDefaultValue;
            _warmStarting = WarmStartingDefaultValue;
            _continuousPhysics = ContinuousPhysicsDefaultValue;
            _subStepping = SubSteppingDefaultValue;
            _gravity = GravityDefaultValue;
            _autoClearForces = AutoClearForcesDefaultValue;
            _velocityIterations = VelocityIterationsDefaultValue;
            _positionIterations = PositionIterationsDefaultValue;
            _applyingTransforms = ApplyingTransformsDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public PhysicsWorld2DPrefab(PhysicsWorld2D val)
        {
            _updateEnabled = val.UpdateEnabled;
            _drawShape = val.DrawShape;
            _drawJoint = val.DrawJoint;
            _drawAabb = val.DrawAabb;
            _drawPair = val.DrawPair;
            _drawCenterOfMass = val.DrawCenterOfMass;
            _allowSleeping = val.AllowSleeping;
            _warmStarting = val.WarmStarting;
            _continuousPhysics = val.ContinuousPhysics;
            _subStepping = val.SubStepping;
            _gravity = val.Gravity;
            _autoClearForces = val.AutoClearForces;
            _velocityIterations = val.VelocityIterations;
            _positionIterations = val.PositionIterations;
            _applyingTransforms = val.ApplyingTransforms;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public bool UpdateEnabled {get { return _updateEnabled;} set { _updateEnabled=value; } }
        public bool UpdateEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _updateEnabled, ref UpdateEnabledDefaultValue); } }
        public bool DrawShape {get { return _drawShape;} set { _drawShape=value; } }
        public bool DrawShapeHasValue {get { return !PrefabUtils.AreEqual(ref _drawShape, ref DrawShapeDefaultValue); } }
        public bool DrawJoint {get { return _drawJoint;} set { _drawJoint=value; } }
        public bool DrawJointHasValue {get { return !PrefabUtils.AreEqual(ref _drawJoint, ref DrawJointDefaultValue); } }
        public bool DrawAabb {get { return _drawAabb;} set { _drawAabb=value; } }
        public bool DrawAabbHasValue {get { return !PrefabUtils.AreEqual(ref _drawAabb, ref DrawAabbDefaultValue); } }
        public bool DrawPair {get { return _drawPair;} set { _drawPair=value; } }
        public bool DrawPairHasValue {get { return !PrefabUtils.AreEqual(ref _drawPair, ref DrawPairDefaultValue); } }
        public bool DrawCenterOfMass {get { return _drawCenterOfMass;} set { _drawCenterOfMass=value; } }
        public bool DrawCenterOfMassHasValue {get { return !PrefabUtils.AreEqual(ref _drawCenterOfMass, ref DrawCenterOfMassDefaultValue); } }
        public bool AllowSleeping {get { return _allowSleeping;} set { _allowSleeping=value; } }
        public bool AllowSleepingHasValue {get { return !PrefabUtils.AreEqual(ref _allowSleeping, ref AllowSleepingDefaultValue); } }
        public bool WarmStarting {get { return _warmStarting;} set { _warmStarting=value; } }
        public bool WarmStartingHasValue {get { return !PrefabUtils.AreEqual(ref _warmStarting, ref WarmStartingDefaultValue); } }
        public bool ContinuousPhysics {get { return _continuousPhysics;} set { _continuousPhysics=value; } }
        public bool ContinuousPhysicsHasValue {get { return !PrefabUtils.AreEqual(ref _continuousPhysics, ref ContinuousPhysicsDefaultValue); } }
        public bool SubStepping {get { return _subStepping;} set { _subStepping=value; } }
        public bool SubSteppingHasValue {get { return !PrefabUtils.AreEqual(ref _subStepping, ref SubSteppingDefaultValue); } }
        public Vector2 Gravity {get { return _gravity;} set { _gravity=value; } }
        public bool GravityHasValue {get { return !PrefabUtils.AreEqual(ref _gravity, ref GravityDefaultValue); } }
        public bool AutoClearForces {get { return _autoClearForces;} set { _autoClearForces=value; } }
        public bool AutoClearForcesHasValue {get { return !PrefabUtils.AreEqual(ref _autoClearForces, ref AutoClearForcesDefaultValue); } }
        public int VelocityIterations {get { return _velocityIterations;} set { _velocityIterations=value; } }
        public bool VelocityIterationsHasValue {get { return !PrefabUtils.AreEqual(ref _velocityIterations, ref VelocityIterationsDefaultValue); } }
        public int PositionIterations {get { return _positionIterations;} set { _positionIterations=value; } }
        public bool PositionIterationsHasValue {get { return !PrefabUtils.AreEqual(ref _positionIterations, ref PositionIterationsDefaultValue); } }
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
        public override PhysicsWorld2D Create()
        {
            var result = new PhysicsWorld2D();
            if(UpdateEnabledHasValue)
                result.UpdateEnabled = _updateEnabled;
            if(DrawShapeHasValue)
                result.DrawShape = _drawShape;
            if(DrawJointHasValue)
                result.DrawJoint = _drawJoint;
            if(DrawAabbHasValue)
                result.DrawAabb = _drawAabb;
            if(DrawPairHasValue)
                result.DrawPair = _drawPair;
            if(DrawCenterOfMassHasValue)
                result.DrawCenterOfMass = _drawCenterOfMass;
            if(AllowSleepingHasValue)
                result.AllowSleeping = _allowSleeping;
            if(WarmStartingHasValue)
                result.WarmStarting = _warmStarting;
            if(ContinuousPhysicsHasValue)
                result.ContinuousPhysics = _continuousPhysics;
            if(SubSteppingHasValue)
                result.SubStepping = _subStepping;
            if(GravityHasValue)
                result.Gravity = _gravity;
            if(AutoClearForcesHasValue)
                result.AutoClearForces = _autoClearForces;
            if(VelocityIterationsHasValue)
                result.VelocityIterations = _velocityIterations;
            if(PositionIterationsHasValue)
                result.PositionIterations = _positionIterations;
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
                case "UpdateEnabled":
                    break;
                case "DrawShape":
                    break;
                case "DrawJoint":
                    break;
                case "DrawAabb":
                    break;
                case "DrawPair":
                    break;
                case "DrawCenterOfMass":
                    break;
                case "AllowSleeping":
                    break;
                case "WarmStarting":
                    break;
                case "ContinuousPhysics":
                    break;
                case "SubStepping":
                    break;
                case "Gravity":
                    break;
                case "AutoClearForces":
                    break;
                case "VelocityIterations":
                    break;
                case "PositionIterations":
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
