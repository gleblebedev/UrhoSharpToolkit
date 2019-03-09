using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using CollisionBox2D = Urho.Urho2D.CollisionBox2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class CollisionBox2DPrefab: AbstractComponentPrefab<CollisionBox2D>, IPrefab
    {
        public override string TypeName { get { return CollisionBox2D.TypeNameStatic; } }
        public Vector2 Size { get; set; }
        public Vector2 Center { get; set; }
        public float Angle { get; set; }
        public bool Trigger { get; set; }
        public int CategoryBits { get; set; }
        public int MaskBits { get; set; }
        public int GroupIndex { get; set; }
        public float Density { get; set; }
        public float Friction { get; set; }
        public float Restitution { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public CollisionBox2DPrefab()
        {
            Size = SizeAccessor.DefaultValue;
            Center = CenterAccessor.DefaultValue;
            Angle = AngleAccessor.DefaultValue;
            Trigger = TriggerAccessor.DefaultValue;
            CategoryBits = CategoryBitsAccessor.DefaultValue;
            MaskBits = MaskBitsAccessor.DefaultValue;
            GroupIndex = GroupIndexAccessor.DefaultValue;
            Density = DensityAccessor.DefaultValue;
            Friction = FrictionAccessor.DefaultValue;
            Restitution = RestitutionAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public CollisionBox2DPrefab(CollisionBox2D val)
        {
            ID = val.ID;
            Size = val.Size;
            Center = val.Center;
            Angle = val.Angle;
            Trigger = val.Trigger;
            CategoryBits = val.CategoryBits;
            MaskBits = val.MaskBits;
            GroupIndex = val.GroupIndex;
            Density = val.Density;
            Friction = val.Friction;
            Restitution = val.Restitution;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override CollisionBox2D Create()
        {
            var result = new CollisionBox2D();
            SizeAccessor.Instance.ApplyIfChanged(this, result);
            CenterAccessor.Instance.ApplyIfChanged(this, result);
            AngleAccessor.Instance.ApplyIfChanged(this, result);
            TriggerAccessor.Instance.ApplyIfChanged(this, result);
            CategoryBitsAccessor.Instance.ApplyIfChanged(this, result);
            MaskBitsAccessor.Instance.ApplyIfChanged(this, result);
            GroupIndexAccessor.Instance.ApplyIfChanged(this, result);
            DensityAccessor.Instance.ApplyIfChanged(this, result);
            FrictionAccessor.Instance.ApplyIfChanged(this, result);
            RestitutionAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Size":
                    SizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Center":
                    CenterAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Angle":
                    AngleAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Trigger":
                    TriggerAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CategoryBits":
                    CategoryBitsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaskBits":
                    MaskBitsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "GroupIndex":
                    GroupIndexAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Density":
                    DensityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Friction":
                    FrictionAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Restitution":
                    RestitutionAccessor.Instance.ParseAndSet(value, this);
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
                yield return SizeAccessor.Instance;
                yield return CenterAccessor.Instance;
                yield return AngleAccessor.Instance;
                yield return TriggerAccessor.Instance;
                yield return CategoryBitsAccessor.Instance;
                yield return MaskBitsAccessor.Instance;
                yield return GroupIndexAccessor.Instance;
                yield return DensityAccessor.Instance;
                yield return FrictionAccessor.Instance;
                yield return RestitutionAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class SizeAccessor : Vector2Accessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly SizeAccessor Instance = new SizeAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0.01f, 0.01f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Size);
            public override Vector2 GetPrefab(CollisionBox2DPrefab instance) { return instance.Size; }
            public override void SetPrefab(CollisionBox2DPrefab instance, Vector2 value) { instance.Size = value; }
            public override Vector2 GetUrho(CollisionBox2D instance) { return instance.Size; }
            public override void SetUrho(CollisionBox2D instance, Vector2 value) { instance.Size = value; }
        }

        internal class CenterAccessor : Vector2Accessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly CenterAccessor Instance = new CenterAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Center);
            public override Vector2 GetPrefab(CollisionBox2DPrefab instance) { return instance.Center; }
            public override void SetPrefab(CollisionBox2DPrefab instance, Vector2 value) { instance.Center = value; }
            public override Vector2 GetUrho(CollisionBox2D instance) { return instance.Center; }
            public override void SetUrho(CollisionBox2D instance, Vector2 value) { instance.Center = value; }
        }

        internal class AngleAccessor : SingleAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly AngleAccessor Instance = new AngleAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Angle);
            public override float GetPrefab(CollisionBox2DPrefab instance) { return instance.Angle; }
            public override void SetPrefab(CollisionBox2DPrefab instance, float value) { instance.Angle = value; }
            public override float GetUrho(CollisionBox2D instance) { return instance.Angle; }
            public override void SetUrho(CollisionBox2D instance, float value) { instance.Angle = value; }
        }

        internal class TriggerAccessor : BooleanAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly TriggerAccessor Instance = new TriggerAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Trigger);
            public override bool GetPrefab(CollisionBox2DPrefab instance) { return instance.Trigger; }
            public override void SetPrefab(CollisionBox2DPrefab instance, bool value) { instance.Trigger = value; }
            public override bool GetUrho(CollisionBox2D instance) { return instance.Trigger; }
            public override void SetUrho(CollisionBox2D instance, bool value) { instance.Trigger = value; }
        }

        internal class CategoryBitsAccessor : Int32Accessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly CategoryBitsAccessor Instance = new CategoryBitsAccessor();
            public static readonly int DefaultValue = 1;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.CategoryBits);
            public override int GetPrefab(CollisionBox2DPrefab instance) { return instance.CategoryBits; }
            public override void SetPrefab(CollisionBox2DPrefab instance, int value) { instance.CategoryBits = value; }
            public override int GetUrho(CollisionBox2D instance) { return instance.CategoryBits; }
            public override void SetUrho(CollisionBox2D instance, int value) { instance.CategoryBits = value; }
        }

        internal class MaskBitsAccessor : Int32Accessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly MaskBitsAccessor Instance = new MaskBitsAccessor();
            public static readonly int DefaultValue = 65535;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.MaskBits);
            public override int GetPrefab(CollisionBox2DPrefab instance) { return instance.MaskBits; }
            public override void SetPrefab(CollisionBox2DPrefab instance, int value) { instance.MaskBits = value; }
            public override int GetUrho(CollisionBox2D instance) { return instance.MaskBits; }
            public override void SetUrho(CollisionBox2D instance, int value) { instance.MaskBits = value; }
        }

        internal class GroupIndexAccessor : Int32Accessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly GroupIndexAccessor Instance = new GroupIndexAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.GroupIndex);
            public override int GetPrefab(CollisionBox2DPrefab instance) { return instance.GroupIndex; }
            public override void SetPrefab(CollisionBox2DPrefab instance, int value) { instance.GroupIndex = value; }
            public override int GetUrho(CollisionBox2D instance) { return instance.GroupIndex; }
            public override void SetUrho(CollisionBox2D instance, int value) { instance.GroupIndex = value; }
        }

        internal class DensityAccessor : SingleAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly DensityAccessor Instance = new DensityAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Density);
            public override float GetPrefab(CollisionBox2DPrefab instance) { return instance.Density; }
            public override void SetPrefab(CollisionBox2DPrefab instance, float value) { instance.Density = value; }
            public override float GetUrho(CollisionBox2D instance) { return instance.Density; }
            public override void SetUrho(CollisionBox2D instance, float value) { instance.Density = value; }
        }

        internal class FrictionAccessor : SingleAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly FrictionAccessor Instance = new FrictionAccessor();
            public static readonly float DefaultValue = 0.2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Friction);
            public override float GetPrefab(CollisionBox2DPrefab instance) { return instance.Friction; }
            public override void SetPrefab(CollisionBox2DPrefab instance, float value) { instance.Friction = value; }
            public override float GetUrho(CollisionBox2D instance) { return instance.Friction; }
            public override void SetUrho(CollisionBox2D instance, float value) { instance.Friction = value; }
        }

        internal class RestitutionAccessor : SingleAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly RestitutionAccessor Instance = new RestitutionAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Restitution);
            public override float GetPrefab(CollisionBox2DPrefab instance) { return instance.Restitution; }
            public override void SetPrefab(CollisionBox2DPrefab instance, float value) { instance.Restitution = value; }
            public override float GetUrho(CollisionBox2D instance) { return instance.Restitution; }
            public override void SetUrho(CollisionBox2D instance, float value) { instance.Restitution = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Enabled);
            public override bool GetPrefab(CollisionBox2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(CollisionBox2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(CollisionBox2D instance) { return instance.Enabled; }
            public override void SetUrho(CollisionBox2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.AnimationEnabled);
            public override bool GetPrefab(CollisionBox2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(CollisionBox2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(CollisionBox2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(CollisionBox2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.Temporary);
            public override bool GetPrefab(CollisionBox2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(CollisionBox2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(CollisionBox2D instance) { return instance.Temporary; }
            public override void SetUrho(CollisionBox2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<CollisionBox2DPrefab, CollisionBox2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionBox2D.BlockEvents);
            public override bool GetPrefab(CollisionBox2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(CollisionBox2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(CollisionBox2D instance) { return instance.BlockEvents; }
            public override void SetUrho(CollisionBox2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
