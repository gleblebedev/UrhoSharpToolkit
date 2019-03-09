using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using CollisionCircle2D = Urho.Urho2D.CollisionCircle2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class CollisionCircle2DPrefab: AbstractComponentPrefab<CollisionCircle2D>, IPrefab
    {
        public override string TypeName { get { return CollisionCircle2D.TypeNameStatic; } }
        public float Radius { get; set; }
        public Vector2 Center { get; set; }
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
        public CollisionCircle2DPrefab()
        {
            Radius = RadiusAccessor.DefaultValue;
            Center = CenterAccessor.DefaultValue;
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
        public CollisionCircle2DPrefab(CollisionCircle2D val)
        {
            ID = val.ID;
            Radius = val.Radius;
            Center = val.Center;
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
        public override CollisionCircle2D Create()
        {
            var result = new CollisionCircle2D();
            RadiusAccessor.Instance.ApplyIfChanged(this, result);
            CenterAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Radius":
                    RadiusAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Center":
                    CenterAccessor.Instance.ParseAndSet(value, this);
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
                yield return RadiusAccessor.Instance;
                yield return CenterAccessor.Instance;
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

        internal class RadiusAccessor : SingleAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly RadiusAccessor Instance = new RadiusAccessor();
            public static readonly float DefaultValue = 0.01f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.Radius);
            public override float GetPrefab(CollisionCircle2DPrefab instance) { return instance.Radius; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, float value) { instance.Radius = value; }
            public override float GetUrho(CollisionCircle2D instance) { return instance.Radius; }
            public override void SetUrho(CollisionCircle2D instance, float value) { instance.Radius = value; }
        }

        internal class CenterAccessor : Vector2Accessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly CenterAccessor Instance = new CenterAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.Center);
            public override Vector2 GetPrefab(CollisionCircle2DPrefab instance) { return instance.Center; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, Vector2 value) { instance.Center = value; }
            public override Vector2 GetUrho(CollisionCircle2D instance) { return instance.Center; }
            public override void SetUrho(CollisionCircle2D instance, Vector2 value) { instance.Center = value; }
        }

        internal class TriggerAccessor : BooleanAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly TriggerAccessor Instance = new TriggerAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.Trigger);
            public override bool GetPrefab(CollisionCircle2DPrefab instance) { return instance.Trigger; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, bool value) { instance.Trigger = value; }
            public override bool GetUrho(CollisionCircle2D instance) { return instance.Trigger; }
            public override void SetUrho(CollisionCircle2D instance, bool value) { instance.Trigger = value; }
        }

        internal class CategoryBitsAccessor : Int32Accessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly CategoryBitsAccessor Instance = new CategoryBitsAccessor();
            public static readonly int DefaultValue = 1;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.CategoryBits);
            public override int GetPrefab(CollisionCircle2DPrefab instance) { return instance.CategoryBits; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, int value) { instance.CategoryBits = value; }
            public override int GetUrho(CollisionCircle2D instance) { return instance.CategoryBits; }
            public override void SetUrho(CollisionCircle2D instance, int value) { instance.CategoryBits = value; }
        }

        internal class MaskBitsAccessor : Int32Accessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly MaskBitsAccessor Instance = new MaskBitsAccessor();
            public static readonly int DefaultValue = 65535;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.MaskBits);
            public override int GetPrefab(CollisionCircle2DPrefab instance) { return instance.MaskBits; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, int value) { instance.MaskBits = value; }
            public override int GetUrho(CollisionCircle2D instance) { return instance.MaskBits; }
            public override void SetUrho(CollisionCircle2D instance, int value) { instance.MaskBits = value; }
        }

        internal class GroupIndexAccessor : Int32Accessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly GroupIndexAccessor Instance = new GroupIndexAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.GroupIndex);
            public override int GetPrefab(CollisionCircle2DPrefab instance) { return instance.GroupIndex; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, int value) { instance.GroupIndex = value; }
            public override int GetUrho(CollisionCircle2D instance) { return instance.GroupIndex; }
            public override void SetUrho(CollisionCircle2D instance, int value) { instance.GroupIndex = value; }
        }

        internal class DensityAccessor : SingleAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly DensityAccessor Instance = new DensityAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.Density);
            public override float GetPrefab(CollisionCircle2DPrefab instance) { return instance.Density; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, float value) { instance.Density = value; }
            public override float GetUrho(CollisionCircle2D instance) { return instance.Density; }
            public override void SetUrho(CollisionCircle2D instance, float value) { instance.Density = value; }
        }

        internal class FrictionAccessor : SingleAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly FrictionAccessor Instance = new FrictionAccessor();
            public static readonly float DefaultValue = 0.2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.Friction);
            public override float GetPrefab(CollisionCircle2DPrefab instance) { return instance.Friction; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, float value) { instance.Friction = value; }
            public override float GetUrho(CollisionCircle2D instance) { return instance.Friction; }
            public override void SetUrho(CollisionCircle2D instance, float value) { instance.Friction = value; }
        }

        internal class RestitutionAccessor : SingleAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly RestitutionAccessor Instance = new RestitutionAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.Restitution);
            public override float GetPrefab(CollisionCircle2DPrefab instance) { return instance.Restitution; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, float value) { instance.Restitution = value; }
            public override float GetUrho(CollisionCircle2D instance) { return instance.Restitution; }
            public override void SetUrho(CollisionCircle2D instance, float value) { instance.Restitution = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.Enabled);
            public override bool GetPrefab(CollisionCircle2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(CollisionCircle2D instance) { return instance.Enabled; }
            public override void SetUrho(CollisionCircle2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.AnimationEnabled);
            public override bool GetPrefab(CollisionCircle2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(CollisionCircle2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(CollisionCircle2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.Temporary);
            public override bool GetPrefab(CollisionCircle2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(CollisionCircle2D instance) { return instance.Temporary; }
            public override void SetUrho(CollisionCircle2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<CollisionCircle2DPrefab, CollisionCircle2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionCircle2D.BlockEvents);
            public override bool GetPrefab(CollisionCircle2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(CollisionCircle2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(CollisionCircle2D instance) { return instance.BlockEvents; }
            public override void SetUrho(CollisionCircle2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
