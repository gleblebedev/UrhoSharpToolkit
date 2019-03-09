using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using CollisionShape = Urho.Physics.CollisionShape;

using Urho.Physics;

namespace UrhoSharp.Prefabs
{
    public partial class CollisionShapePrefab: AbstractComponentPrefab<CollisionShape>, IPrefab
    {
        public override string TypeName { get { return CollisionShape.TypeNameStatic; } }
        public ShapeType ShapeType { get; set; }
        public Vector3 Size { get; set; }
        public Vector3 Position { get; set; }
        public Quaternion Rotation { get; set; }
        public float Margin { get; set; }
        public Model Model { get; set; }
        public uint LodLevel { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public CollisionShapePrefab()
        {
            ShapeType = ShapeTypeAccessor.DefaultValue;
            Size = SizeAccessor.DefaultValue;
            Position = PositionAccessor.DefaultValue;
            Rotation = RotationAccessor.DefaultValue;
            Margin = MarginAccessor.DefaultValue;
            Model = ModelAccessor.DefaultValue;
            LodLevel = LodLevelAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public CollisionShapePrefab(CollisionShape val)
        {
            ID = val.ID;
            ShapeType = val.ShapeType;
            Size = val.Size;
            Position = val.Position;
            Rotation = val.Rotation;
            Margin = val.Margin;
            Model = val.Model;
            LodLevel = val.LodLevel;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override CollisionShape Create()
        {
            var result = new CollisionShape();
            ShapeTypeAccessor.Instance.ApplyIfChanged(this, result);
            SizeAccessor.Instance.ApplyIfChanged(this, result);
            PositionAccessor.Instance.ApplyIfChanged(this, result);
            RotationAccessor.Instance.ApplyIfChanged(this, result);
            MarginAccessor.Instance.ApplyIfChanged(this, result);
            ModelAccessor.Instance.ApplyIfChanged(this, result);
            LodLevelAccessor.Instance.ApplyIfChanged(this, result);
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
                case "ShapeType":
                    ShapeTypeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Size":
                    SizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Position":
                    PositionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Rotation":
                    RotationAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Margin":
                    MarginAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Model":
                    ModelAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LodLevel":
                    LodLevelAccessor.Instance.ParseAndSet(value, this);
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
                yield return ShapeTypeAccessor.Instance;
                yield return SizeAccessor.Instance;
                yield return PositionAccessor.Instance;
                yield return RotationAccessor.Instance;
                yield return MarginAccessor.Instance;
                yield return ModelAccessor.Instance;
                yield return LodLevelAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class ShapeTypeAccessor : EnumAccessor<CollisionShapePrefab, CollisionShape, ShapeType>
        {
            public static readonly ShapeTypeAccessor Instance = new ShapeTypeAccessor();
            public static readonly ShapeType DefaultValue = ShapeType.Box;
            public override ShapeType DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.ShapeType);
            public override ShapeType GetPrefab(CollisionShapePrefab instance) { return instance.ShapeType; }
            public override void SetPrefab(CollisionShapePrefab instance, ShapeType value) { instance.ShapeType = value; }
            public override ShapeType GetUrho(CollisionShape instance) { return instance.ShapeType; }
            public override void SetUrho(CollisionShape instance, ShapeType value) { instance.ShapeType = value; }
        }

        internal class SizeAccessor : Vector3Accessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly SizeAccessor Instance = new SizeAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(1f, 1f, 1f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.Size);
            public override Vector3 GetPrefab(CollisionShapePrefab instance) { return instance.Size; }
            public override void SetPrefab(CollisionShapePrefab instance, Vector3 value) { instance.Size = value; }
            public override Vector3 GetUrho(CollisionShape instance) { return instance.Size; }
            public override void SetUrho(CollisionShape instance, Vector3 value) { instance.Size = value; }
        }

        internal class PositionAccessor : Vector3Accessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly PositionAccessor Instance = new PositionAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(0f, 0f, 0f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.Position);
            public override Vector3 GetPrefab(CollisionShapePrefab instance) { return instance.Position; }
            public override void SetPrefab(CollisionShapePrefab instance, Vector3 value) { instance.Position = value; }
            public override Vector3 GetUrho(CollisionShape instance) { return instance.Position; }
            public override void SetUrho(CollisionShape instance, Vector3 value) { instance.Position = value; }
        }

        internal class RotationAccessor : QuaternionAccessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly RotationAccessor Instance = new RotationAccessor();
            public static readonly Quaternion DefaultValue = new Quaternion(0f, 0f, 0f, 1f);
            public override Quaternion DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.Rotation);
            public override Quaternion GetPrefab(CollisionShapePrefab instance) { return instance.Rotation; }
            public override void SetPrefab(CollisionShapePrefab instance, Quaternion value) { instance.Rotation = value; }
            public override Quaternion GetUrho(CollisionShape instance) { return instance.Rotation; }
            public override void SetUrho(CollisionShape instance, Quaternion value) { instance.Rotation = value; }
        }

        internal class MarginAccessor : SingleAccessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly MarginAccessor Instance = new MarginAccessor();
            public static readonly float DefaultValue = 0.04f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.Margin);
            public override float GetPrefab(CollisionShapePrefab instance) { return instance.Margin; }
            public override void SetPrefab(CollisionShapePrefab instance, float value) { instance.Margin = value; }
            public override float GetUrho(CollisionShape instance) { return instance.Margin; }
            public override void SetUrho(CollisionShape instance, float value) { instance.Margin = value; }
        }

        internal class ModelAccessor : ModelAccessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly ModelAccessor Instance = new ModelAccessor();
            public static readonly Model DefaultValue = null;
            public override Model DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.Model);
            public override Model GetPrefab(CollisionShapePrefab instance) { return instance.Model; }
            public override void SetPrefab(CollisionShapePrefab instance, Model value) { instance.Model = value; }
            public override Model GetUrho(CollisionShape instance) { return instance.Model; }
            public override void SetUrho(CollisionShape instance, Model value) { instance.Model = value; }
        }

        internal class LodLevelAccessor : UInt32Accessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly LodLevelAccessor Instance = new LodLevelAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.LodLevel);
            public override uint GetPrefab(CollisionShapePrefab instance) { return instance.LodLevel; }
            public override void SetPrefab(CollisionShapePrefab instance, uint value) { instance.LodLevel = value; }
            public override uint GetUrho(CollisionShape instance) { return instance.LodLevel; }
            public override void SetUrho(CollisionShape instance, uint value) { instance.LodLevel = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.Enabled);
            public override bool GetPrefab(CollisionShapePrefab instance) { return instance.Enabled; }
            public override void SetPrefab(CollisionShapePrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(CollisionShape instance) { return instance.Enabled; }
            public override void SetUrho(CollisionShape instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.AnimationEnabled);
            public override bool GetPrefab(CollisionShapePrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(CollisionShapePrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(CollisionShape instance) { return instance.AnimationEnabled; }
            public override void SetUrho(CollisionShape instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.Temporary);
            public override bool GetPrefab(CollisionShapePrefab instance) { return instance.Temporary; }
            public override void SetPrefab(CollisionShapePrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(CollisionShape instance) { return instance.Temporary; }
            public override void SetUrho(CollisionShape instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<CollisionShapePrefab, CollisionShape>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionShape.BlockEvents);
            public override bool GetPrefab(CollisionShapePrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(CollisionShapePrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(CollisionShape instance) { return instance.BlockEvents; }
            public override void SetUrho(CollisionShape instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
