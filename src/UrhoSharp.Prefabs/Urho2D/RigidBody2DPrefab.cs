using System;
using System.Xml.Linq;
using Urho;
using RigidBody2D = Urho.Urho2D.RigidBody2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class RigidBody2DPrefab: AbstractComponentPrefab<RigidBody2D>, IPrefab
    {
        private static  BodyType2D BodyTypeDefaultValue = BodyType2D.Static;
        private static  float MassDefaultValue = 0f;
        private static  float InertiaDefaultValue = 0f;
        private static  bool UseFixtureMassDefaultValue = true;
        private static  float LinearDampingDefaultValue = 0f;
        private static  float AngularDampingDefaultValue = 0f;
        private static  bool AllowSleepDefaultValue = true;
        private static  bool FixedRotationDefaultValue = false;
        private static  bool BulletDefaultValue = false;
        private static  float GravityScaleDefaultValue = 1f;
        private static  bool AwakeDefaultValue = true;
        private static  float AngularVelocityDefaultValue = 0f;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private BodyType2D _bodyType;
        private float _mass;
        private float _inertia;
        private bool _useFixtureMass;
        private float _linearDamping;
        private float _angularDamping;
        private bool _allowSleep;
        private bool _fixedRotation;
        private bool _bullet;
        private float _gravityScale;
        private bool _awake;
        private float _angularVelocity;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public RigidBody2DPrefab()
        {
            _bodyType = BodyTypeDefaultValue;
            _mass = MassDefaultValue;
            _inertia = InertiaDefaultValue;
            _useFixtureMass = UseFixtureMassDefaultValue;
            _linearDamping = LinearDampingDefaultValue;
            _angularDamping = AngularDampingDefaultValue;
            _allowSleep = AllowSleepDefaultValue;
            _fixedRotation = FixedRotationDefaultValue;
            _bullet = BulletDefaultValue;
            _gravityScale = GravityScaleDefaultValue;
            _awake = AwakeDefaultValue;
            _angularVelocity = AngularVelocityDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public RigidBody2DPrefab(RigidBody2D val)
        {
            _bodyType = val.BodyType;
            _mass = val.Mass;
            _inertia = val.Inertia;
            _useFixtureMass = val.UseFixtureMass;
            _linearDamping = val.LinearDamping;
            _angularDamping = val.AngularDamping;
            _allowSleep = val.AllowSleep;
            _fixedRotation = val.FixedRotation;
            _bullet = val.Bullet;
            _gravityScale = val.GravityScale;
            _awake = val.Awake;
            _angularVelocity = val.AngularVelocity;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public BodyType2D BodyType {get { return _bodyType;} set { _bodyType=value; } }
        public bool BodyTypeHasValue {get { return !PrefabUtils.AreEqual(ref _bodyType, ref BodyTypeDefaultValue); } }
        public float Mass {get { return _mass;} set { _mass=value; } }
        public bool MassHasValue {get { return !PrefabUtils.AreEqual(ref _mass, ref MassDefaultValue); } }
        public float Inertia {get { return _inertia;} set { _inertia=value; } }
        public bool InertiaHasValue {get { return !PrefabUtils.AreEqual(ref _inertia, ref InertiaDefaultValue); } }
        public bool UseFixtureMass {get { return _useFixtureMass;} set { _useFixtureMass=value; } }
        public bool UseFixtureMassHasValue {get { return !PrefabUtils.AreEqual(ref _useFixtureMass, ref UseFixtureMassDefaultValue); } }
        public float LinearDamping {get { return _linearDamping;} set { _linearDamping=value; } }
        public bool LinearDampingHasValue {get { return !PrefabUtils.AreEqual(ref _linearDamping, ref LinearDampingDefaultValue); } }
        public float AngularDamping {get { return _angularDamping;} set { _angularDamping=value; } }
        public bool AngularDampingHasValue {get { return !PrefabUtils.AreEqual(ref _angularDamping, ref AngularDampingDefaultValue); } }
        public bool AllowSleep {get { return _allowSleep;} set { _allowSleep=value; } }
        public bool AllowSleepHasValue {get { return !PrefabUtils.AreEqual(ref _allowSleep, ref AllowSleepDefaultValue); } }
        public bool FixedRotation {get { return _fixedRotation;} set { _fixedRotation=value; } }
        public bool FixedRotationHasValue {get { return !PrefabUtils.AreEqual(ref _fixedRotation, ref FixedRotationDefaultValue); } }
        public bool Bullet {get { return _bullet;} set { _bullet=value; } }
        public bool BulletHasValue {get { return !PrefabUtils.AreEqual(ref _bullet, ref BulletDefaultValue); } }
        public float GravityScale {get { return _gravityScale;} set { _gravityScale=value; } }
        public bool GravityScaleHasValue {get { return !PrefabUtils.AreEqual(ref _gravityScale, ref GravityScaleDefaultValue); } }
        public bool Awake {get { return _awake;} set { _awake=value; } }
        public bool AwakeHasValue {get { return !PrefabUtils.AreEqual(ref _awake, ref AwakeDefaultValue); } }
        public float AngularVelocity {get { return _angularVelocity;} set { _angularVelocity=value; } }
        public bool AngularVelocityHasValue {get { return !PrefabUtils.AreEqual(ref _angularVelocity, ref AngularVelocityDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override RigidBody2D Create()
        {
            var result = new RigidBody2D();
            if(BodyTypeHasValue)
                result.BodyType = _bodyType;
            if(MassHasValue)
                result.Mass = _mass;
            if(InertiaHasValue)
                result.Inertia = _inertia;
            if(UseFixtureMassHasValue)
                result.UseFixtureMass = _useFixtureMass;
            if(LinearDampingHasValue)
                result.LinearDamping = _linearDamping;
            if(AngularDampingHasValue)
                result.AngularDamping = _angularDamping;
            if(AllowSleepHasValue)
                result.AllowSleep = _allowSleep;
            if(FixedRotationHasValue)
                result.FixedRotation = _fixedRotation;
            if(BulletHasValue)
                result.Bullet = _bullet;
            if(GravityScaleHasValue)
                result.GravityScale = _gravityScale;
            if(AwakeHasValue)
                result.Awake = _awake;
            if(AngularVelocityHasValue)
                result.AngularVelocity = _angularVelocity;
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
                case "BodyType":
                    break;
                case "Mass":
                    break;
                case "Inertia":
                    break;
                case "UseFixtureMass":
                    break;
                case "LinearDamping":
                    break;
                case "AngularDamping":
                    break;
                case "AllowSleep":
                    break;
                case "FixedRotation":
                    break;
                case "Bullet":
                    break;
                case "GravityScale":
                    break;
                case "Awake":
                    break;
                case "AngularVelocity":
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
