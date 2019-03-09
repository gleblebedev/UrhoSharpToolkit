using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using SmoothedTransform = Urho.SmoothedTransform;


namespace UrhoSharp.Prefabs
{
    public partial class SmoothedTransformPrefab: AbstractComponentPrefab<SmoothedTransform>, IPrefab
    {
        public override string TypeName { get { return SmoothedTransform.TypeNameStatic; } }
        public Vector3 TargetPosition { get; set; }
        public Quaternion TargetRotation { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public SmoothedTransformPrefab()
        {
            TargetPosition = TargetPositionAccessor.DefaultValue;
            TargetRotation = TargetRotationAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public SmoothedTransformPrefab(SmoothedTransform val)
        {
            ID = val.ID;
            TargetPosition = val.TargetPosition;
            TargetRotation = val.TargetRotation;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override SmoothedTransform Create()
        {
            var result = new SmoothedTransform();
            TargetPositionAccessor.Instance.ApplyIfChanged(this, result);
            TargetRotationAccessor.Instance.ApplyIfChanged(this, result);
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
                case "TargetPosition":
                    TargetPositionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "TargetRotation":
                    TargetRotationAccessor.Instance.ParseAndSet(value, this);
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
                yield return TargetPositionAccessor.Instance;
                yield return TargetRotationAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class TargetPositionAccessor : Vector3Accessor<SmoothedTransformPrefab, SmoothedTransform>
        {
            public static readonly TargetPositionAccessor Instance = new TargetPositionAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(0f, 0f, 0f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SmoothedTransform.TargetPosition);
            public override Vector3 GetPrefab(SmoothedTransformPrefab instance) { return instance.TargetPosition; }
            public override void SetPrefab(SmoothedTransformPrefab instance, Vector3 value) { instance.TargetPosition = value; }
            public override Vector3 GetUrho(SmoothedTransform instance) { return instance.TargetPosition; }
            public override void SetUrho(SmoothedTransform instance, Vector3 value) { instance.TargetPosition = value; }
        }

        internal class TargetRotationAccessor : QuaternionAccessor<SmoothedTransformPrefab, SmoothedTransform>
        {
            public static readonly TargetRotationAccessor Instance = new TargetRotationAccessor();
            public static readonly Quaternion DefaultValue = new Quaternion(0f, 0f, 0f, 1f);
            public override Quaternion DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SmoothedTransform.TargetRotation);
            public override Quaternion GetPrefab(SmoothedTransformPrefab instance) { return instance.TargetRotation; }
            public override void SetPrefab(SmoothedTransformPrefab instance, Quaternion value) { instance.TargetRotation = value; }
            public override Quaternion GetUrho(SmoothedTransform instance) { return instance.TargetRotation; }
            public override void SetUrho(SmoothedTransform instance, Quaternion value) { instance.TargetRotation = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<SmoothedTransformPrefab, SmoothedTransform>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SmoothedTransform.Enabled);
            public override bool GetPrefab(SmoothedTransformPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(SmoothedTransformPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(SmoothedTransform instance) { return instance.Enabled; }
            public override void SetUrho(SmoothedTransform instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<SmoothedTransformPrefab, SmoothedTransform>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SmoothedTransform.AnimationEnabled);
            public override bool GetPrefab(SmoothedTransformPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(SmoothedTransformPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(SmoothedTransform instance) { return instance.AnimationEnabled; }
            public override void SetUrho(SmoothedTransform instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<SmoothedTransformPrefab, SmoothedTransform>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SmoothedTransform.Temporary);
            public override bool GetPrefab(SmoothedTransformPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(SmoothedTransformPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(SmoothedTransform instance) { return instance.Temporary; }
            public override void SetUrho(SmoothedTransform instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<SmoothedTransformPrefab, SmoothedTransform>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(SmoothedTransform.BlockEvents);
            public override bool GetPrefab(SmoothedTransformPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(SmoothedTransformPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(SmoothedTransform instance) { return instance.BlockEvents; }
            public override void SetUrho(SmoothedTransform instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
