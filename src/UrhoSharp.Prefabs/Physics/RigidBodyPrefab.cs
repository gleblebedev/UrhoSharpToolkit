using System;
using System.Xml.Linq;
using Urho;
using RigidBody = Urho.Physics.RigidBody;

using Urho.Physics;

namespace UrhoSharp.Prefabs
{
    public class RigidBodyPrefab: AbstractComponentPrefab<RigidBody>, IPrefab
    {
        private static  float MassDefaultValue = 0f;
        private static  float LinearRestThresholdDefaultValue = 0f;
        private static  float LinearDampingDefaultValue = 0f;
        private static  float AngularRestThresholdDefaultValue = 0f;
        private static  float AngularDampingDefaultValue = 0f;
        private static  float FrictionDefaultValue = 0f;
        private static  float RollingFrictionDefaultValue = 0f;
        private static  float RestitutionDefaultValue = 0f;
        private static  float ContactProcessingThresholdDefaultValue = 0f;
        private static  float CcdRadiusDefaultValue = 0f;
        private static  float CcdMotionThresholdDefaultValue = 0f;
        private static  bool UseGravityDefaultValue = true;
        private static  Vector3 GravityOverrideDefaultValue = new Vector3(0f, 0f, 0f);
        private static  bool KinematicDefaultValue = false;
        private static  bool TriggerDefaultValue = false;
        private static  uint CollisionLayerDefaultValue = 1;
        private static  uint CollisionMaskDefaultValue = 4294967295;
        private static  CollisionEventMode CollisionEventModeDefaultValue = CollisionEventMode.Active;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private float _mass;
        private float _linearRestThreshold;
        private float _linearDamping;
        private float _angularRestThreshold;
        private float _angularDamping;
        private float _friction;
        private float _rollingFriction;
        private float _restitution;
        private float _contactProcessingThreshold;
        private float _ccdRadius;
        private float _ccdMotionThreshold;
        private bool _useGravity;
        private Vector3 _gravityOverride;
        private bool _kinematic;
        private bool _trigger;
        private uint _collisionLayer;
        private uint _collisionMask;
        private CollisionEventMode _collisionEventMode;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public RigidBodyPrefab()
        {
            _mass = MassDefaultValue;
            _linearRestThreshold = LinearRestThresholdDefaultValue;
            _linearDamping = LinearDampingDefaultValue;
            _angularRestThreshold = AngularRestThresholdDefaultValue;
            _angularDamping = AngularDampingDefaultValue;
            _friction = FrictionDefaultValue;
            _rollingFriction = RollingFrictionDefaultValue;
            _restitution = RestitutionDefaultValue;
            _contactProcessingThreshold = ContactProcessingThresholdDefaultValue;
            _ccdRadius = CcdRadiusDefaultValue;
            _ccdMotionThreshold = CcdMotionThresholdDefaultValue;
            _useGravity = UseGravityDefaultValue;
            _gravityOverride = GravityOverrideDefaultValue;
            _kinematic = KinematicDefaultValue;
            _trigger = TriggerDefaultValue;
            _collisionLayer = CollisionLayerDefaultValue;
            _collisionMask = CollisionMaskDefaultValue;
            _collisionEventMode = CollisionEventModeDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public RigidBodyPrefab(RigidBody val)
        {
            _mass = val.Mass;
            _linearRestThreshold = val.LinearRestThreshold;
            _linearDamping = val.LinearDamping;
            _angularRestThreshold = val.AngularRestThreshold;
            _angularDamping = val.AngularDamping;
            _friction = val.Friction;
            _rollingFriction = val.RollingFriction;
            _restitution = val.Restitution;
            _contactProcessingThreshold = val.ContactProcessingThreshold;
            _ccdRadius = val.CcdRadius;
            _ccdMotionThreshold = val.CcdMotionThreshold;
            _useGravity = val.UseGravity;
            _gravityOverride = val.GravityOverride;
            _kinematic = val.Kinematic;
            _trigger = val.Trigger;
            _collisionLayer = val.CollisionLayer;
            _collisionMask = val.CollisionMask;
            _collisionEventMode = val.CollisionEventMode;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public float Mass {get { return _mass;} set { _mass=value; } }
        public bool MassHasValue {get { return !PrefabUtils.AreEqual(ref _mass, ref MassDefaultValue); } }
        public float LinearRestThreshold {get { return _linearRestThreshold;} set { _linearRestThreshold=value; } }
        public bool LinearRestThresholdHasValue {get { return !PrefabUtils.AreEqual(ref _linearRestThreshold, ref LinearRestThresholdDefaultValue); } }
        public float LinearDamping {get { return _linearDamping;} set { _linearDamping=value; } }
        public bool LinearDampingHasValue {get { return !PrefabUtils.AreEqual(ref _linearDamping, ref LinearDampingDefaultValue); } }
        public float AngularRestThreshold {get { return _angularRestThreshold;} set { _angularRestThreshold=value; } }
        public bool AngularRestThresholdHasValue {get { return !PrefabUtils.AreEqual(ref _angularRestThreshold, ref AngularRestThresholdDefaultValue); } }
        public float AngularDamping {get { return _angularDamping;} set { _angularDamping=value; } }
        public bool AngularDampingHasValue {get { return !PrefabUtils.AreEqual(ref _angularDamping, ref AngularDampingDefaultValue); } }
        public float Friction {get { return _friction;} set { _friction=value; } }
        public bool FrictionHasValue {get { return !PrefabUtils.AreEqual(ref _friction, ref FrictionDefaultValue); } }
        public float RollingFriction {get { return _rollingFriction;} set { _rollingFriction=value; } }
        public bool RollingFrictionHasValue {get { return !PrefabUtils.AreEqual(ref _rollingFriction, ref RollingFrictionDefaultValue); } }
        public float Restitution {get { return _restitution;} set { _restitution=value; } }
        public bool RestitutionHasValue {get { return !PrefabUtils.AreEqual(ref _restitution, ref RestitutionDefaultValue); } }
        public float ContactProcessingThreshold {get { return _contactProcessingThreshold;} set { _contactProcessingThreshold=value; } }
        public bool ContactProcessingThresholdHasValue {get { return !PrefabUtils.AreEqual(ref _contactProcessingThreshold, ref ContactProcessingThresholdDefaultValue); } }
        public float CcdRadius {get { return _ccdRadius;} set { _ccdRadius=value; } }
        public bool CcdRadiusHasValue {get { return !PrefabUtils.AreEqual(ref _ccdRadius, ref CcdRadiusDefaultValue); } }
        public float CcdMotionThreshold {get { return _ccdMotionThreshold;} set { _ccdMotionThreshold=value; } }
        public bool CcdMotionThresholdHasValue {get { return !PrefabUtils.AreEqual(ref _ccdMotionThreshold, ref CcdMotionThresholdDefaultValue); } }
        public bool UseGravity {get { return _useGravity;} set { _useGravity=value; } }
        public bool UseGravityHasValue {get { return !PrefabUtils.AreEqual(ref _useGravity, ref UseGravityDefaultValue); } }
        public Vector3 GravityOverride {get { return _gravityOverride;} set { _gravityOverride=value; } }
        public bool GravityOverrideHasValue {get { return !PrefabUtils.AreEqual(ref _gravityOverride, ref GravityOverrideDefaultValue); } }
        public bool Kinematic {get { return _kinematic;} set { _kinematic=value; } }
        public bool KinematicHasValue {get { return !PrefabUtils.AreEqual(ref _kinematic, ref KinematicDefaultValue); } }
        public bool Trigger {get { return _trigger;} set { _trigger=value; } }
        public bool TriggerHasValue {get { return !PrefabUtils.AreEqual(ref _trigger, ref TriggerDefaultValue); } }
        public uint CollisionLayer {get { return _collisionLayer;} set { _collisionLayer=value; } }
        public bool CollisionLayerHasValue {get { return !PrefabUtils.AreEqual(ref _collisionLayer, ref CollisionLayerDefaultValue); } }
        public uint CollisionMask {get { return _collisionMask;} set { _collisionMask=value; } }
        public bool CollisionMaskHasValue {get { return !PrefabUtils.AreEqual(ref _collisionMask, ref CollisionMaskDefaultValue); } }
        public CollisionEventMode CollisionEventMode {get { return _collisionEventMode;} set { _collisionEventMode=value; } }
        public bool CollisionEventModeHasValue {get { return !PrefabUtils.AreEqual(ref _collisionEventMode, ref CollisionEventModeDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override RigidBody Create()
        {
            var result = new RigidBody();
            if(MassHasValue)
                result.Mass = _mass;
            if(LinearRestThresholdHasValue)
                result.LinearRestThreshold = _linearRestThreshold;
            if(LinearDampingHasValue)
                result.LinearDamping = _linearDamping;
            if(AngularRestThresholdHasValue)
                result.AngularRestThreshold = _angularRestThreshold;
            if(AngularDampingHasValue)
                result.AngularDamping = _angularDamping;
            if(FrictionHasValue)
                result.Friction = _friction;
            if(RollingFrictionHasValue)
                result.RollingFriction = _rollingFriction;
            if(RestitutionHasValue)
                result.Restitution = _restitution;
            if(ContactProcessingThresholdHasValue)
                result.ContactProcessingThreshold = _contactProcessingThreshold;
            if(CcdRadiusHasValue)
                result.CcdRadius = _ccdRadius;
            if(CcdMotionThresholdHasValue)
                result.CcdMotionThreshold = _ccdMotionThreshold;
            if(UseGravityHasValue)
                result.UseGravity = _useGravity;
            if(GravityOverrideHasValue)
                result.GravityOverride = _gravityOverride;
            if(KinematicHasValue)
                result.Kinematic = _kinematic;
            if(TriggerHasValue)
                result.Trigger = _trigger;
            if(CollisionLayerHasValue)
                result.CollisionLayer = _collisionLayer;
            if(CollisionMaskHasValue)
                result.CollisionMask = _collisionMask;
            if(CollisionEventModeHasValue)
                result.CollisionEventMode = _collisionEventMode;
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
                case "Mass":
                    break;
                case "LinearRestThreshold":
                    break;
                case "LinearDamping":
                    break;
                case "AngularRestThreshold":
                    break;
                case "AngularDamping":
                    break;
                case "Friction":
                    break;
                case "RollingFriction":
                    break;
                case "Restitution":
                    break;
                case "ContactProcessingThreshold":
                    break;
                case "CcdRadius":
                    break;
                case "CcdMotionThreshold":
                    break;
                case "UseGravity":
                    break;
                case "GravityOverride":
                    break;
                case "Kinematic":
                    break;
                case "Trigger":
                    break;
                case "CollisionLayer":
                    break;
                case "CollisionMask":
                    break;
                case "CollisionEventMode":
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
