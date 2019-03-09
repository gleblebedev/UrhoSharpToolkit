using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using RigidBody = Urho.Physics.RigidBody;

using Urho.Physics;

namespace UrhoSharp.Prefabs
{
    public partial class RigidBodyPrefab: AbstractComponentPrefab<RigidBody>, IPrefab
    {
        public override string TypeName { get { return RigidBody.TypeNameStatic; } }
        public float Mass { get; set; }
        public float LinearRestThreshold { get; set; }
        public float LinearDamping { get; set; }
        public float AngularRestThreshold { get; set; }
        public float AngularDamping { get; set; }
        public float Friction { get; set; }
        public float RollingFriction { get; set; }
        public float Restitution { get; set; }
        public float ContactProcessingThreshold { get; set; }
        public float CcdRadius { get; set; }
        public float CcdMotionThreshold { get; set; }
        public bool UseGravity { get; set; }
        public Vector3 GravityOverride { get; set; }
        public bool Kinematic { get; set; }
        public bool Trigger { get; set; }
        public uint CollisionLayer { get; set; }
        public uint CollisionMask { get; set; }
        public CollisionEventMode CollisionEventMode { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public RigidBodyPrefab()
        {
            Mass = MassAccessor.DefaultValue;
            LinearRestThreshold = LinearRestThresholdAccessor.DefaultValue;
            LinearDamping = LinearDampingAccessor.DefaultValue;
            AngularRestThreshold = AngularRestThresholdAccessor.DefaultValue;
            AngularDamping = AngularDampingAccessor.DefaultValue;
            Friction = FrictionAccessor.DefaultValue;
            RollingFriction = RollingFrictionAccessor.DefaultValue;
            Restitution = RestitutionAccessor.DefaultValue;
            ContactProcessingThreshold = ContactProcessingThresholdAccessor.DefaultValue;
            CcdRadius = CcdRadiusAccessor.DefaultValue;
            CcdMotionThreshold = CcdMotionThresholdAccessor.DefaultValue;
            UseGravity = UseGravityAccessor.DefaultValue;
            GravityOverride = GravityOverrideAccessor.DefaultValue;
            Kinematic = KinematicAccessor.DefaultValue;
            Trigger = TriggerAccessor.DefaultValue;
            CollisionLayer = CollisionLayerAccessor.DefaultValue;
            CollisionMask = CollisionMaskAccessor.DefaultValue;
            CollisionEventMode = CollisionEventModeAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public RigidBodyPrefab(RigidBody val)
        {
            ID = val.ID;
            Mass = val.Mass;
            LinearRestThreshold = val.LinearRestThreshold;
            LinearDamping = val.LinearDamping;
            AngularRestThreshold = val.AngularRestThreshold;
            AngularDamping = val.AngularDamping;
            Friction = val.Friction;
            RollingFriction = val.RollingFriction;
            Restitution = val.Restitution;
            ContactProcessingThreshold = val.ContactProcessingThreshold;
            CcdRadius = val.CcdRadius;
            CcdMotionThreshold = val.CcdMotionThreshold;
            UseGravity = val.UseGravity;
            GravityOverride = val.GravityOverride;
            Kinematic = val.Kinematic;
            Trigger = val.Trigger;
            CollisionLayer = val.CollisionLayer;
            CollisionMask = val.CollisionMask;
            CollisionEventMode = val.CollisionEventMode;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override RigidBody Create()
        {
            var result = new RigidBody();
            MassAccessor.Instance.ApplyIfChanged(this, result);
            LinearRestThresholdAccessor.Instance.ApplyIfChanged(this, result);
            LinearDampingAccessor.Instance.ApplyIfChanged(this, result);
            AngularRestThresholdAccessor.Instance.ApplyIfChanged(this, result);
            AngularDampingAccessor.Instance.ApplyIfChanged(this, result);
            FrictionAccessor.Instance.ApplyIfChanged(this, result);
            RollingFrictionAccessor.Instance.ApplyIfChanged(this, result);
            RestitutionAccessor.Instance.ApplyIfChanged(this, result);
            ContactProcessingThresholdAccessor.Instance.ApplyIfChanged(this, result);
            CcdRadiusAccessor.Instance.ApplyIfChanged(this, result);
            CcdMotionThresholdAccessor.Instance.ApplyIfChanged(this, result);
            UseGravityAccessor.Instance.ApplyIfChanged(this, result);
            GravityOverrideAccessor.Instance.ApplyIfChanged(this, result);
            KinematicAccessor.Instance.ApplyIfChanged(this, result);
            TriggerAccessor.Instance.ApplyIfChanged(this, result);
            CollisionLayerAccessor.Instance.ApplyIfChanged(this, result);
            CollisionMaskAccessor.Instance.ApplyIfChanged(this, result);
            CollisionEventModeAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Mass":
                    MassAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LinearRestThreshold":
                    LinearRestThresholdAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LinearDamping":
                    LinearDampingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AngularRestThreshold":
                    AngularRestThresholdAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AngularDamping":
                    AngularDampingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Friction":
                    FrictionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "RollingFriction":
                    RollingFrictionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Restitution":
                    RestitutionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ContactProcessingThreshold":
                    ContactProcessingThresholdAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CcdRadius":
                    CcdRadiusAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CcdMotionThreshold":
                    CcdMotionThresholdAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UseGravity":
                    UseGravityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "GravityOverride":
                    GravityOverrideAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Kinematic":
                    KinematicAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Trigger":
                    TriggerAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CollisionLayer":
                    CollisionLayerAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CollisionMask":
                    CollisionMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CollisionEventMode":
                    CollisionEventModeAccessor.Instance.ParseAndSet(value, this);
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
                yield return MassAccessor.Instance;
                yield return LinearRestThresholdAccessor.Instance;
                yield return LinearDampingAccessor.Instance;
                yield return AngularRestThresholdAccessor.Instance;
                yield return AngularDampingAccessor.Instance;
                yield return FrictionAccessor.Instance;
                yield return RollingFrictionAccessor.Instance;
                yield return RestitutionAccessor.Instance;
                yield return ContactProcessingThresholdAccessor.Instance;
                yield return CcdRadiusAccessor.Instance;
                yield return CcdMotionThresholdAccessor.Instance;
                yield return UseGravityAccessor.Instance;
                yield return GravityOverrideAccessor.Instance;
                yield return KinematicAccessor.Instance;
                yield return TriggerAccessor.Instance;
                yield return CollisionLayerAccessor.Instance;
                yield return CollisionMaskAccessor.Instance;
                yield return CollisionEventModeAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class MassAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly MassAccessor Instance = new MassAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.Mass);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.Mass; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.Mass = value; }
            public override float GetUrho(RigidBody instance) { return instance.Mass; }
            public override void SetUrho(RigidBody instance, float value) { instance.Mass = value; }
        }

        internal class LinearRestThresholdAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly LinearRestThresholdAccessor Instance = new LinearRestThresholdAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.LinearRestThreshold);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.LinearRestThreshold; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.LinearRestThreshold = value; }
            public override float GetUrho(RigidBody instance) { return instance.LinearRestThreshold; }
            public override void SetUrho(RigidBody instance, float value) { instance.LinearRestThreshold = value; }
        }

        internal class LinearDampingAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly LinearDampingAccessor Instance = new LinearDampingAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.LinearDamping);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.LinearDamping; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.LinearDamping = value; }
            public override float GetUrho(RigidBody instance) { return instance.LinearDamping; }
            public override void SetUrho(RigidBody instance, float value) { instance.LinearDamping = value; }
        }

        internal class AngularRestThresholdAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly AngularRestThresholdAccessor Instance = new AngularRestThresholdAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.AngularRestThreshold);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.AngularRestThreshold; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.AngularRestThreshold = value; }
            public override float GetUrho(RigidBody instance) { return instance.AngularRestThreshold; }
            public override void SetUrho(RigidBody instance, float value) { instance.AngularRestThreshold = value; }
        }

        internal class AngularDampingAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly AngularDampingAccessor Instance = new AngularDampingAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.AngularDamping);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.AngularDamping; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.AngularDamping = value; }
            public override float GetUrho(RigidBody instance) { return instance.AngularDamping; }
            public override void SetUrho(RigidBody instance, float value) { instance.AngularDamping = value; }
        }

        internal class FrictionAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly FrictionAccessor Instance = new FrictionAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.Friction);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.Friction; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.Friction = value; }
            public override float GetUrho(RigidBody instance) { return instance.Friction; }
            public override void SetUrho(RigidBody instance, float value) { instance.Friction = value; }
        }

        internal class RollingFrictionAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly RollingFrictionAccessor Instance = new RollingFrictionAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.RollingFriction);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.RollingFriction; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.RollingFriction = value; }
            public override float GetUrho(RigidBody instance) { return instance.RollingFriction; }
            public override void SetUrho(RigidBody instance, float value) { instance.RollingFriction = value; }
        }

        internal class RestitutionAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly RestitutionAccessor Instance = new RestitutionAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.Restitution);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.Restitution; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.Restitution = value; }
            public override float GetUrho(RigidBody instance) { return instance.Restitution; }
            public override void SetUrho(RigidBody instance, float value) { instance.Restitution = value; }
        }

        internal class ContactProcessingThresholdAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly ContactProcessingThresholdAccessor Instance = new ContactProcessingThresholdAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.ContactProcessingThreshold);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.ContactProcessingThreshold; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.ContactProcessingThreshold = value; }
            public override float GetUrho(RigidBody instance) { return instance.ContactProcessingThreshold; }
            public override void SetUrho(RigidBody instance, float value) { instance.ContactProcessingThreshold = value; }
        }

        internal class CcdRadiusAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly CcdRadiusAccessor Instance = new CcdRadiusAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.CcdRadius);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.CcdRadius; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.CcdRadius = value; }
            public override float GetUrho(RigidBody instance) { return instance.CcdRadius; }
            public override void SetUrho(RigidBody instance, float value) { instance.CcdRadius = value; }
        }

        internal class CcdMotionThresholdAccessor : SingleAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly CcdMotionThresholdAccessor Instance = new CcdMotionThresholdAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.CcdMotionThreshold);
            public override float GetPrefab(RigidBodyPrefab instance) { return instance.CcdMotionThreshold; }
            public override void SetPrefab(RigidBodyPrefab instance, float value) { instance.CcdMotionThreshold = value; }
            public override float GetUrho(RigidBody instance) { return instance.CcdMotionThreshold; }
            public override void SetUrho(RigidBody instance, float value) { instance.CcdMotionThreshold = value; }
        }

        internal class UseGravityAccessor : BooleanAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly UseGravityAccessor Instance = new UseGravityAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.UseGravity);
            public override bool GetPrefab(RigidBodyPrefab instance) { return instance.UseGravity; }
            public override void SetPrefab(RigidBodyPrefab instance, bool value) { instance.UseGravity = value; }
            public override bool GetUrho(RigidBody instance) { return instance.UseGravity; }
            public override void SetUrho(RigidBody instance, bool value) { instance.UseGravity = value; }
        }

        internal class GravityOverrideAccessor : Vector3Accessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly GravityOverrideAccessor Instance = new GravityOverrideAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(0f, 0f, 0f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.GravityOverride);
            public override Vector3 GetPrefab(RigidBodyPrefab instance) { return instance.GravityOverride; }
            public override void SetPrefab(RigidBodyPrefab instance, Vector3 value) { instance.GravityOverride = value; }
            public override Vector3 GetUrho(RigidBody instance) { return instance.GravityOverride; }
            public override void SetUrho(RigidBody instance, Vector3 value) { instance.GravityOverride = value; }
        }

        internal class KinematicAccessor : BooleanAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly KinematicAccessor Instance = new KinematicAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.Kinematic);
            public override bool GetPrefab(RigidBodyPrefab instance) { return instance.Kinematic; }
            public override void SetPrefab(RigidBodyPrefab instance, bool value) { instance.Kinematic = value; }
            public override bool GetUrho(RigidBody instance) { return instance.Kinematic; }
            public override void SetUrho(RigidBody instance, bool value) { instance.Kinematic = value; }
        }

        internal class TriggerAccessor : BooleanAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly TriggerAccessor Instance = new TriggerAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.Trigger);
            public override bool GetPrefab(RigidBodyPrefab instance) { return instance.Trigger; }
            public override void SetPrefab(RigidBodyPrefab instance, bool value) { instance.Trigger = value; }
            public override bool GetUrho(RigidBody instance) { return instance.Trigger; }
            public override void SetUrho(RigidBody instance, bool value) { instance.Trigger = value; }
        }

        internal class CollisionLayerAccessor : UInt32Accessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly CollisionLayerAccessor Instance = new CollisionLayerAccessor();
            public static readonly uint DefaultValue = 1;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.CollisionLayer);
            public override uint GetPrefab(RigidBodyPrefab instance) { return instance.CollisionLayer; }
            public override void SetPrefab(RigidBodyPrefab instance, uint value) { instance.CollisionLayer = value; }
            public override uint GetUrho(RigidBody instance) { return instance.CollisionLayer; }
            public override void SetUrho(RigidBody instance, uint value) { instance.CollisionLayer = value; }
        }

        internal class CollisionMaskAccessor : UInt32Accessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly CollisionMaskAccessor Instance = new CollisionMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.CollisionMask);
            public override uint GetPrefab(RigidBodyPrefab instance) { return instance.CollisionMask; }
            public override void SetPrefab(RigidBodyPrefab instance, uint value) { instance.CollisionMask = value; }
            public override uint GetUrho(RigidBody instance) { return instance.CollisionMask; }
            public override void SetUrho(RigidBody instance, uint value) { instance.CollisionMask = value; }
        }

        internal class CollisionEventModeAccessor : EnumAccessor<RigidBodyPrefab, RigidBody, CollisionEventMode>
        {
            public static readonly CollisionEventModeAccessor Instance = new CollisionEventModeAccessor();
            public static readonly CollisionEventMode DefaultValue = CollisionEventMode.Active;
            public override CollisionEventMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.CollisionEventMode);
            public override CollisionEventMode GetPrefab(RigidBodyPrefab instance) { return instance.CollisionEventMode; }
            public override void SetPrefab(RigidBodyPrefab instance, CollisionEventMode value) { instance.CollisionEventMode = value; }
            public override CollisionEventMode GetUrho(RigidBody instance) { return instance.CollisionEventMode; }
            public override void SetUrho(RigidBody instance, CollisionEventMode value) { instance.CollisionEventMode = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.Enabled);
            public override bool GetPrefab(RigidBodyPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(RigidBodyPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(RigidBody instance) { return instance.Enabled; }
            public override void SetUrho(RigidBody instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.AnimationEnabled);
            public override bool GetPrefab(RigidBodyPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(RigidBodyPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(RigidBody instance) { return instance.AnimationEnabled; }
            public override void SetUrho(RigidBody instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.Temporary);
            public override bool GetPrefab(RigidBodyPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(RigidBodyPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(RigidBody instance) { return instance.Temporary; }
            public override void SetUrho(RigidBody instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<RigidBodyPrefab, RigidBody>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody.BlockEvents);
            public override bool GetPrefab(RigidBodyPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(RigidBodyPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(RigidBody instance) { return instance.BlockEvents; }
            public override void SetUrho(RigidBody instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
