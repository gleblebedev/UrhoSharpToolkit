using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using ConstraintDistance2D = Urho.Urho2D.ConstraintDistance2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class ConstraintDistance2DPrefab: AbstractComponentPrefab<ConstraintDistance2D>, IPrefab
    {
        public override string TypeName { get { return ConstraintDistance2D.TypeNameStatic; } }
        public Vector2 OwnerBodyAnchor { get; set; }
        public Vector2 OtherBodyAnchor { get; set; }
        public float FrequencyHz { get; set; }
        public float DampingRatio { get; set; }
        public float Length { get; set; }
        public RigidBody2D OtherBody { get; set; }
        public bool CollideConnected { get; set; }
        public Constraint2D AttachedConstraint { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public ConstraintDistance2DPrefab()
        {
            OwnerBodyAnchor = OwnerBodyAnchorAccessor.DefaultValue;
            OtherBodyAnchor = OtherBodyAnchorAccessor.DefaultValue;
            FrequencyHz = FrequencyHzAccessor.DefaultValue;
            DampingRatio = DampingRatioAccessor.DefaultValue;
            Length = LengthAccessor.DefaultValue;
            OtherBody = OtherBodyAccessor.DefaultValue;
            CollideConnected = CollideConnectedAccessor.DefaultValue;
            AttachedConstraint = AttachedConstraintAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public ConstraintDistance2DPrefab(ConstraintDistance2D val)
        {
            ID = val.ID;
            OwnerBodyAnchor = val.OwnerBodyAnchor;
            OtherBodyAnchor = val.OtherBodyAnchor;
            FrequencyHz = val.FrequencyHz;
            DampingRatio = val.DampingRatio;
            Length = val.Length;
            OtherBody = val.OtherBody;
            CollideConnected = val.CollideConnected;
            AttachedConstraint = val.AttachedConstraint;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override ConstraintDistance2D Create()
        {
            var result = new ConstraintDistance2D();
            OwnerBodyAnchorAccessor.Instance.ApplyIfChanged(this, result);
            OtherBodyAnchorAccessor.Instance.ApplyIfChanged(this, result);
            FrequencyHzAccessor.Instance.ApplyIfChanged(this, result);
            DampingRatioAccessor.Instance.ApplyIfChanged(this, result);
            LengthAccessor.Instance.ApplyIfChanged(this, result);
            OtherBodyAccessor.Instance.ApplyIfChanged(this, result);
            CollideConnectedAccessor.Instance.ApplyIfChanged(this, result);
            AttachedConstraintAccessor.Instance.ApplyIfChanged(this, result);
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
                case "OwnerBodyAnchor":
                    OwnerBodyAnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherBodyAnchor":
                    OtherBodyAnchorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FrequencyHz":
                    FrequencyHzAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DampingRatio":
                    DampingRatioAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Length":
                    LengthAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "OtherBody":
                    OtherBodyAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CollideConnected":
                    CollideConnectedAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AttachedConstraint":
                    AttachedConstraintAccessor.Instance.ParseAndSet(value, this);
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
                yield return OwnerBodyAnchorAccessor.Instance;
                yield return OtherBodyAnchorAccessor.Instance;
                yield return FrequencyHzAccessor.Instance;
                yield return DampingRatioAccessor.Instance;
                yield return LengthAccessor.Instance;
                yield return OtherBodyAccessor.Instance;
                yield return CollideConnectedAccessor.Instance;
                yield return AttachedConstraintAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class OwnerBodyAnchorAccessor : Vector2Accessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly OwnerBodyAnchorAccessor Instance = new OwnerBodyAnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.OwnerBodyAnchor);
            public override Vector2 GetPrefab(ConstraintDistance2DPrefab instance) { return instance.OwnerBodyAnchor; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, Vector2 value) { instance.OwnerBodyAnchor = value; }
            public override Vector2 GetUrho(ConstraintDistance2D instance) { return instance.OwnerBodyAnchor; }
            public override void SetUrho(ConstraintDistance2D instance, Vector2 value) { instance.OwnerBodyAnchor = value; }
        }

        internal class OtherBodyAnchorAccessor : Vector2Accessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly OtherBodyAnchorAccessor Instance = new OtherBodyAnchorAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.OtherBodyAnchor);
            public override Vector2 GetPrefab(ConstraintDistance2DPrefab instance) { return instance.OtherBodyAnchor; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, Vector2 value) { instance.OtherBodyAnchor = value; }
            public override Vector2 GetUrho(ConstraintDistance2D instance) { return instance.OtherBodyAnchor; }
            public override void SetUrho(ConstraintDistance2D instance, Vector2 value) { instance.OtherBodyAnchor = value; }
        }

        internal class FrequencyHzAccessor : SingleAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly FrequencyHzAccessor Instance = new FrequencyHzAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.FrequencyHz);
            public override float GetPrefab(ConstraintDistance2DPrefab instance) { return instance.FrequencyHz; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, float value) { instance.FrequencyHz = value; }
            public override float GetUrho(ConstraintDistance2D instance) { return instance.FrequencyHz; }
            public override void SetUrho(ConstraintDistance2D instance, float value) { instance.FrequencyHz = value; }
        }

        internal class DampingRatioAccessor : SingleAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly DampingRatioAccessor Instance = new DampingRatioAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.DampingRatio);
            public override float GetPrefab(ConstraintDistance2DPrefab instance) { return instance.DampingRatio; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, float value) { instance.DampingRatio = value; }
            public override float GetUrho(ConstraintDistance2D instance) { return instance.DampingRatio; }
            public override void SetUrho(ConstraintDistance2D instance, float value) { instance.DampingRatio = value; }
        }

        internal class LengthAccessor : SingleAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly LengthAccessor Instance = new LengthAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.Length);
            public override float GetPrefab(ConstraintDistance2DPrefab instance) { return instance.Length; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, float value) { instance.Length = value; }
            public override float GetUrho(ConstraintDistance2D instance) { return instance.Length; }
            public override void SetUrho(ConstraintDistance2D instance, float value) { instance.Length = value; }
        }

        internal class OtherBodyAccessor : RigidBody2DAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly OtherBodyAccessor Instance = new OtherBodyAccessor();
            public static readonly RigidBody2D DefaultValue = null;
            public override RigidBody2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.OtherBody);
            public override RigidBody2D GetPrefab(ConstraintDistance2DPrefab instance) { return instance.OtherBody; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, RigidBody2D value) { instance.OtherBody = value; }
            public override RigidBody2D GetUrho(ConstraintDistance2D instance) { return instance.OtherBody; }
            public override void SetUrho(ConstraintDistance2D instance, RigidBody2D value) { instance.OtherBody = value; }
        }

        internal class CollideConnectedAccessor : BooleanAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly CollideConnectedAccessor Instance = new CollideConnectedAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.CollideConnected);
            public override bool GetPrefab(ConstraintDistance2DPrefab instance) { return instance.CollideConnected; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, bool value) { instance.CollideConnected = value; }
            public override bool GetUrho(ConstraintDistance2D instance) { return instance.CollideConnected; }
            public override void SetUrho(ConstraintDistance2D instance, bool value) { instance.CollideConnected = value; }
        }

        internal class AttachedConstraintAccessor : Constraint2DAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly AttachedConstraintAccessor Instance = new AttachedConstraintAccessor();
            public static readonly Constraint2D DefaultValue = null;
            public override Constraint2D DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.AttachedConstraint);
            public override Constraint2D GetPrefab(ConstraintDistance2DPrefab instance) { return instance.AttachedConstraint; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, Constraint2D value) { instance.AttachedConstraint = value; }
            public override Constraint2D GetUrho(ConstraintDistance2D instance) { return instance.AttachedConstraint; }
            public override void SetUrho(ConstraintDistance2D instance, Constraint2D value) { instance.AttachedConstraint = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.Enabled);
            public override bool GetPrefab(ConstraintDistance2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(ConstraintDistance2D instance) { return instance.Enabled; }
            public override void SetUrho(ConstraintDistance2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.AnimationEnabled);
            public override bool GetPrefab(ConstraintDistance2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(ConstraintDistance2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(ConstraintDistance2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.Temporary);
            public override bool GetPrefab(ConstraintDistance2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(ConstraintDistance2D instance) { return instance.Temporary; }
            public override void SetUrho(ConstraintDistance2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<ConstraintDistance2DPrefab, ConstraintDistance2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(ConstraintDistance2D.BlockEvents);
            public override bool GetPrefab(ConstraintDistance2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(ConstraintDistance2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(ConstraintDistance2D instance) { return instance.BlockEvents; }
            public override void SetUrho(ConstraintDistance2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
