using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Constraint = Urho.Physics.Constraint;

using Urho.Physics;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintPrefab: AbstractComponentPrefab<Constraint>, IPrefab
    {
        public override string TypeName { get { return Constraint.TypeNameStatic; } }
        public ConstraintType ConstraintType { get; set; }
        public RigidBody OtherBody { get; set; }
        public Vector3 Position { get; set; }
        public Quaternion Rotation { get; set; }
        public Vector3 OtherPosition { get; set; }
        public Quaternion OtherRotation { get; set; }
        public Vector2 HighLimit { get; set; }
        public Vector2 LowLimit { get; set; }
        public float ERP { get; set; }
        public float CFM { get; set; }
        public bool DisableCollision { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintPrefab()
        {
            ConstraintType = ConstraintTypeAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            Position = PositionAccessor.DefaultValue;
            Rotation = RotationAccessor.DefaultValue;
            OtherPosition = OtherPositionAccessor.DefaultValue;
            OtherRotation = OtherRotationAccessor.DefaultValue;
            HighLimit = HighLimitAccessor.DefaultValue;
            LowLimit = LowLimitAccessor.DefaultValue;
            ERP = ERPAccessor.DefaultValue;
            CFM = CFMAccessor.DefaultValue;
            DisableCollision = DisableCollisionAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintPrefab(Constraint val)
        {
            ID = val.ID;
            ConstraintType = val.ConstraintType;
            OtherBody = val.OtherBody;
            Position = val.Position;
            Rotation = val.Rotation;
            OtherPosition = val.OtherPosition;
            OtherRotation = val.OtherRotation;
            HighLimit = val.HighLimit;
            LowLimit = val.LowLimit;
            ERP = val.ERP;
            CFM = val.CFM;
            DisableCollision = val.DisableCollision;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Constraint Create()
        {
            var result = new Constraint();
            ConstraintTypeAccessor.Instance.ApplyIfChanged(this, result);
            OtherBodyAccessor.Instance.ApplyIfChanged(this, result);
            PositionAccessor.Instance.ApplyIfChanged(this, result);
            RotationAccessor.Instance.ApplyIfChanged(this, result);
            OtherPositionAccessor.Instance.ApplyIfChanged(this, result);
            OtherRotationAccessor.Instance.ApplyIfChanged(this, result);
            HighLimitAccessor.Instance.ApplyIfChanged(this, result);
            LowLimitAccessor.Instance.ApplyIfChanged(this, result);
            ERPAccessor.Instance.ApplyIfChanged(this, result);
            CFMAccessor.Instance.ApplyIfChanged(this, result);
            DisableCollisionAccessor.Instance.ApplyIfChanged(this, result);
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
                case "ConstraintType":
                    ConstraintTypeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherBody":
                    OtherBodyAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Position":
                    PositionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Rotation":
                    RotationAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherPosition":
                    OtherPositionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherRotation":
                    OtherRotationAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "HighLimit":
                    HighLimitAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LowLimit":
                    LowLimitAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ERP":
                    ERPAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CFM":
                    CFMAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DisableCollision":
                    DisableCollisionAccessor.Instance.ParseAndSet(value, this);
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
                yield return ConstraintTypeAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return PositionAccessor.Instance;
                yield return RotationAccessor.Instance;
                yield return OtherPositionAccessor.Instance;
                yield return OtherRotationAccessor.Instance;
                yield return HighLimitAccessor.Instance;
                yield return LowLimitAccessor.Instance;
                yield return ERPAccessor.Instance;
                yield return CFMAccessor.Instance;
                yield return DisableCollisionAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class ConstraintTypeAccessor : EnumAccessor<ConstraintPrefab, Constraint, ConstraintType>
        {
            public static readonly ConstraintTypeAccessor Instance = new ConstraintTypeAccessor();
            public static readonly ConstraintType DefaultValue = ConstraintType.Point;
            public override ConstraintType DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.ConstraintType);
            public override ConstraintType GetPrefab(ConstraintPrefab instance) { return instance.ConstraintType; }
            public override void SetPrefab(ConstraintPrefab instance, ConstraintType value) { instance.ConstraintType = value; }
            public override ConstraintType GetUrho(Constraint instance) { return instance.ConstraintType; }
            public override void SetUrho(Constraint instance, ConstraintType value) { instance.ConstraintType = value; }
        }

        internal class OtherBodyAccessor : RigidBodyAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody DefaultValue = null;
            public override RigidBody DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.OtherBody);
            public override RigidBody GetPrefab(ConstraintPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintPrefab instance, RigidBody value) { instance.OtherBody = value; }
            public override RigidBody GetUrho(Constraint instance) { return instance.OtherBody; }
            public override void SetUrho(Constraint instance, RigidBody value) { instance.OtherBody = value; }
        }

        internal class PositionAccessor : Vector3Accessor<ConstraintPrefab, Constraint>
        {
            public static readonly PositionAccessor Instance = new PositionAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(0f, 0f, 0f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.Position);
            public override Vector3 GetPrefab(ConstraintPrefab instance) { return instance.Position; }
            public override void SetPrefab(ConstraintPrefab instance, Vector3 value) { instance.Position = value; }
            public override Vector3 GetUrho(Constraint instance) { return instance.Position; }
            public override void SetUrho(Constraint instance, Vector3 value) { instance.Position = value; }
        }

        internal class RotationAccessor : QuaternionAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly RotationAccessor Instance = new RotationAccessor();
            public static readonly Quaternion DefaultValue = new Quaternion(0f, 0f, 0f, 1f);
            public override Quaternion DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.Rotation);
            public override Quaternion GetPrefab(ConstraintPrefab instance) { return instance.Rotation; }
            public override void SetPrefab(ConstraintPrefab instance, Quaternion value) { instance.Rotation = value; }
            public override Quaternion GetUrho(Constraint instance) { return instance.Rotation; }
            public override void SetUrho(Constraint instance, Quaternion value) { instance.Rotation = value; }
        }

        internal class OtherPositionAccessor : Vector3Accessor<ConstraintPrefab, Constraint>
        {
            public static readonly OtherPositionAccessor Instance = new OtherPositionAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(0f, 0f, 0f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.OtherPosition);
            public override Vector3 GetPrefab(ConstraintPrefab instance) { return instance.OtherPosition; }
            public override void SetPrefab(ConstraintPrefab instance, Vector3 value) { instance.OtherPosition = value; }
            public override Vector3 GetUrho(Constraint instance) { return instance.OtherPosition; }
            public override void SetUrho(Constraint instance, Vector3 value) { instance.OtherPosition = value; }
        }

        internal class OtherRotationAccessor : QuaternionAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly OtherRotationAccessor Instance = new OtherRotationAccessor();
            public static readonly Quaternion DefaultValue = new Quaternion(0f, 0f, 0f, 1f);
            public override Quaternion DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.OtherRotation);
            public override Quaternion GetPrefab(ConstraintPrefab instance) { return instance.OtherRotation; }
            public override void SetPrefab(ConstraintPrefab instance, Quaternion value) { instance.OtherRotation = value; }
            public override Quaternion GetUrho(Constraint instance) { return instance.OtherRotation; }
            public override void SetUrho(Constraint instance, Quaternion value) { instance.OtherRotation = value; }
        }

        internal class HighLimitAccessor : Vector2Accessor<ConstraintPrefab, Constraint>
        {
            public static readonly HighLimitAccessor Instance = new HighLimitAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.HighLimit);
            public override Vector2 GetPrefab(ConstraintPrefab instance) { return instance.HighLimit; }
            public override void SetPrefab(ConstraintPrefab instance, Vector2 value) { instance.HighLimit = value; }
            public override Vector2 GetUrho(Constraint instance) { return instance.HighLimit; }
            public override void SetUrho(Constraint instance, Vector2 value) { instance.HighLimit = value; }
        }

        internal class LowLimitAccessor : Vector2Accessor<ConstraintPrefab, Constraint>
        {
            public static readonly LowLimitAccessor Instance = new LowLimitAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.LowLimit);
            public override Vector2 GetPrefab(ConstraintPrefab instance) { return instance.LowLimit; }
            public override void SetPrefab(ConstraintPrefab instance, Vector2 value) { instance.LowLimit = value; }
            public override Vector2 GetUrho(Constraint instance) { return instance.LowLimit; }
            public override void SetUrho(Constraint instance, Vector2 value) { instance.LowLimit = value; }
        }

        internal class ERPAccessor : SingleAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly ERPAccessor Instance = new ERPAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.ERP);
            public override float GetPrefab(ConstraintPrefab instance) { return instance.ERP; }
            public override void SetPrefab(ConstraintPrefab instance, float value) { instance.ERP = value; }
            public override float GetUrho(Constraint instance) { return instance.ERP; }
            public override void SetUrho(Constraint instance, float value) { instance.ERP = value; }
        }

        internal class CFMAccessor : SingleAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly CFMAccessor Instance = new CFMAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.CFM);
            public override float GetPrefab(ConstraintPrefab instance) { return instance.CFM; }
            public override void SetPrefab(ConstraintPrefab instance, float value) { instance.CFM = value; }
            public override float GetUrho(Constraint instance) { return instance.CFM; }
            public override void SetUrho(Constraint instance, float value) { instance.CFM = value; }
        }

        internal class DisableCollisionAccessor : BooleanAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly DisableCollisionAccessor Instance = new DisableCollisionAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.DisableCollision);
            public override bool GetPrefab(ConstraintPrefab instance) { return instance.DisableCollision; }
            public override void SetPrefab(ConstraintPrefab instance, bool value) { instance.DisableCollision = value; }
            public override bool GetUrho(Constraint instance) { return instance.DisableCollision; }
            public override void SetUrho(Constraint instance, bool value) { instance.DisableCollision = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.Enabled);
            public override bool GetPrefab(ConstraintPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Constraint instance) { return instance.Enabled; }
            public override void SetUrho(Constraint instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.AnimationEnabled);
            public override bool GetPrefab(ConstraintPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Constraint instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Constraint instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.Temporary);
            public override bool GetPrefab(ConstraintPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Constraint instance) { return instance.Temporary; }
            public override void SetUrho(Constraint instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintPrefab, Constraint>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Constraint.BlockEvents);
            public override bool GetPrefab(ConstraintPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Constraint instance) { return instance.BlockEvents; }
            public override void SetUrho(Constraint instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
