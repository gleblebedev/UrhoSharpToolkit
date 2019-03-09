using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using RigidBody2D = Urho.Urho2D.RigidBody2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class RigidBody2DPrefab: AbstractComponentPrefab<RigidBody2D>, IPrefab
    {
        public override string TypeName { get { return RigidBody2D.TypeNameStatic; } }
        public BodyType2D BodyType { get; set; }
        public float Mass { get; set; }
        public float Inertia { get; set; }
        public bool UseFixtureMass { get; set; }
        public float LinearDamping { get; set; }
        public float AngularDamping { get; set; }
        public bool AllowSleep { get; set; }
        public bool FixedRotation { get; set; }
        public bool Bullet { get; set; }
        public float GravityScale { get; set; }
        public bool Awake { get; set; }
        public float AngularVelocity { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public RigidBody2DPrefab()
        {
            BodyType = BodyTypeAccessor.DefaultValue;
            Mass = MassAccessor.DefaultValue;
            Inertia = InertiaAccessor.DefaultValue;
            UseFixtureMass = UseFixtureMassAccessor.DefaultValue;
            LinearDamping = LinearDampingAccessor.DefaultValue;
            AngularDamping = AngularDampingAccessor.DefaultValue;
            AllowSleep = AllowSleepAccessor.DefaultValue;
            FixedRotation = FixedRotationAccessor.DefaultValue;
            Bullet = BulletAccessor.DefaultValue;
            GravityScale = GravityScaleAccessor.DefaultValue;
            Awake = AwakeAccessor.DefaultValue;
            AngularVelocity = AngularVelocityAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public RigidBody2DPrefab(RigidBody2D val)
        {
            ID = val.ID;
            BodyType = val.BodyType;
            Mass = val.Mass;
            Inertia = val.Inertia;
            UseFixtureMass = val.UseFixtureMass;
            LinearDamping = val.LinearDamping;
            AngularDamping = val.AngularDamping;
            AllowSleep = val.AllowSleep;
            FixedRotation = val.FixedRotation;
            Bullet = val.Bullet;
            GravityScale = val.GravityScale;
            Awake = val.Awake;
            AngularVelocity = val.AngularVelocity;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override RigidBody2D Create()
        {
            var result = new RigidBody2D();
            BodyTypeAccessor.Instance.ApplyIfChanged(this, result);
            MassAccessor.Instance.ApplyIfChanged(this, result);
            InertiaAccessor.Instance.ApplyIfChanged(this, result);
            UseFixtureMassAccessor.Instance.ApplyIfChanged(this, result);
            LinearDampingAccessor.Instance.ApplyIfChanged(this, result);
            AngularDampingAccessor.Instance.ApplyIfChanged(this, result);
            AllowSleepAccessor.Instance.ApplyIfChanged(this, result);
            FixedRotationAccessor.Instance.ApplyIfChanged(this, result);
            BulletAccessor.Instance.ApplyIfChanged(this, result);
            GravityScaleAccessor.Instance.ApplyIfChanged(this, result);
            AwakeAccessor.Instance.ApplyIfChanged(this, result);
            AngularVelocityAccessor.Instance.ApplyIfChanged(this, result);
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
                case "BodyType":
                    BodyTypeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Mass":
                    MassAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Inertia":
                    InertiaAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UseFixtureMass":
                    UseFixtureMassAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LinearDamping":
                    LinearDampingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AngularDamping":
                    AngularDampingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AllowSleep":
                    AllowSleepAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FixedRotation":
                    FixedRotationAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Bullet":
                    BulletAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "GravityScale":
                    GravityScaleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Awake":
                    AwakeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AngularVelocity":
                    AngularVelocityAccessor.Instance.ParseAndSet(value, this);
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
                yield return BodyTypeAccessor.Instance;
                yield return MassAccessor.Instance;
                yield return InertiaAccessor.Instance;
                yield return UseFixtureMassAccessor.Instance;
                yield return LinearDampingAccessor.Instance;
                yield return AngularDampingAccessor.Instance;
                yield return AllowSleepAccessor.Instance;
                yield return FixedRotationAccessor.Instance;
                yield return BulletAccessor.Instance;
                yield return GravityScaleAccessor.Instance;
                yield return AwakeAccessor.Instance;
                yield return AngularVelocityAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class BodyTypeAccessor : EnumAccessor<RigidBody2DPrefab, RigidBody2D, BodyType2D>
        {
            public static readonly BodyTypeAccessor Instance = new BodyTypeAccessor();
            public static readonly BodyType2D DefaultValue = BodyType2D.Static;
            public override BodyType2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.BodyType);
            public override BodyType2D GetPrefab(RigidBody2DPrefab instance) { return instance.BodyType; }
            public override void SetPrefab(RigidBody2DPrefab instance, BodyType2D value) { instance.BodyType = value; }
            public override BodyType2D GetUrho(RigidBody2D instance) { return instance.BodyType; }
            public override void SetUrho(RigidBody2D instance, BodyType2D value) { instance.BodyType = value; }
        }

        internal class MassAccessor : SingleAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly MassAccessor Instance = new MassAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.Mass);
            public override float GetPrefab(RigidBody2DPrefab instance) { return instance.Mass; }
            public override void SetPrefab(RigidBody2DPrefab instance, float value) { instance.Mass = value; }
            public override float GetUrho(RigidBody2D instance) { return instance.Mass; }
            public override void SetUrho(RigidBody2D instance, float value) { instance.Mass = value; }
        }

        internal class InertiaAccessor : SingleAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly InertiaAccessor Instance = new InertiaAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.Inertia);
            public override float GetPrefab(RigidBody2DPrefab instance) { return instance.Inertia; }
            public override void SetPrefab(RigidBody2DPrefab instance, float value) { instance.Inertia = value; }
            public override float GetUrho(RigidBody2D instance) { return instance.Inertia; }
            public override void SetUrho(RigidBody2D instance, float value) { instance.Inertia = value; }
        }

        internal class UseFixtureMassAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly UseFixtureMassAccessor Instance = new UseFixtureMassAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.UseFixtureMass);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.UseFixtureMass; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.UseFixtureMass = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.UseFixtureMass; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.UseFixtureMass = value; }
        }

        internal class LinearDampingAccessor : SingleAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly LinearDampingAccessor Instance = new LinearDampingAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.LinearDamping);
            public override float GetPrefab(RigidBody2DPrefab instance) { return instance.LinearDamping; }
            public override void SetPrefab(RigidBody2DPrefab instance, float value) { instance.LinearDamping = value; }
            public override float GetUrho(RigidBody2D instance) { return instance.LinearDamping; }
            public override void SetUrho(RigidBody2D instance, float value) { instance.LinearDamping = value; }
        }

        internal class AngularDampingAccessor : SingleAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly AngularDampingAccessor Instance = new AngularDampingAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.AngularDamping);
            public override float GetPrefab(RigidBody2DPrefab instance) { return instance.AngularDamping; }
            public override void SetPrefab(RigidBody2DPrefab instance, float value) { instance.AngularDamping = value; }
            public override float GetUrho(RigidBody2D instance) { return instance.AngularDamping; }
            public override void SetUrho(RigidBody2D instance, float value) { instance.AngularDamping = value; }
        }

        internal class AllowSleepAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly AllowSleepAccessor Instance = new AllowSleepAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.AllowSleep);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.AllowSleep; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.AllowSleep = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.AllowSleep; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.AllowSleep = value; }
        }

        internal class FixedRotationAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly FixedRotationAccessor Instance = new FixedRotationAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.FixedRotation);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.FixedRotation; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.FixedRotation = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.FixedRotation; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.FixedRotation = value; }
        }

        internal class BulletAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly BulletAccessor Instance = new BulletAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.Bullet);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.Bullet; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.Bullet = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.Bullet; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.Bullet = value; }
        }

        internal class GravityScaleAccessor : SingleAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly GravityScaleAccessor Instance = new GravityScaleAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.GravityScale);
            public override float GetPrefab(RigidBody2DPrefab instance) { return instance.GravityScale; }
            public override void SetPrefab(RigidBody2DPrefab instance, float value) { instance.GravityScale = value; }
            public override float GetUrho(RigidBody2D instance) { return instance.GravityScale; }
            public override void SetUrho(RigidBody2D instance, float value) { instance.GravityScale = value; }
        }

        internal class AwakeAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly AwakeAccessor Instance = new AwakeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.Awake);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.Awake; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.Awake = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.Awake; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.Awake = value; }
        }

        internal class AngularVelocityAccessor : SingleAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly AngularVelocityAccessor Instance = new AngularVelocityAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.AngularVelocity);
            public override float GetPrefab(RigidBody2DPrefab instance) { return instance.AngularVelocity; }
            public override void SetPrefab(RigidBody2DPrefab instance, float value) { instance.AngularVelocity = value; }
            public override float GetUrho(RigidBody2D instance) { return instance.AngularVelocity; }
            public override void SetUrho(RigidBody2D instance, float value) { instance.AngularVelocity = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.Enabled);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.Enabled; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.AnimationEnabled);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.Temporary);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.Temporary; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<RigidBody2DPrefab, RigidBody2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(RigidBody2D.BlockEvents);
            public override bool GetPrefab(RigidBody2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(RigidBody2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(RigidBody2D instance) { return instance.BlockEvents; }
            public override void SetUrho(RigidBody2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
