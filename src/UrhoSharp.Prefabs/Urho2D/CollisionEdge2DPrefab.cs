using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using CollisionEdge2D = Urho.Urho2D.CollisionEdge2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class CollisionEdge2DPrefab: AbstractComponentPrefab<CollisionEdge2D>, IPrefab
    {
        public override string TypeName { get { return CollisionEdge2D.TypeNameStatic; } }
        public Vector2 Vertex1 { get; set; }
        public Vector2 Vertex2 { get; set; }
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
        public CollisionEdge2DPrefab()
        {
            Vertex1 = Vertex1Accessor.DefaultValue;
            Vertex2 = Vertex2Accessor.DefaultValue;
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
        public CollisionEdge2DPrefab(CollisionEdge2D val)
        {
            ID = val.ID;
            Vertex1 = val.Vertex1;
            Vertex2 = val.Vertex2;
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
        public override CollisionEdge2D Create()
        {
            var result = new CollisionEdge2D();
            Vertex1Accessor.Instance.ApplyIfChanged(this, result);
            Vertex2Accessor.Instance.ApplyIfChanged(this, result);
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
                case "Vertex1":
                    Vertex1Accessor.Instance.ParseAndSet(value, this);
                    break;
                case "Vertex2":
                    Vertex2Accessor.Instance.ParseAndSet(value, this);
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
                yield return Vertex1Accessor.Instance;
                yield return Vertex2Accessor.Instance;
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

        internal class Vertex1Accessor : Vector2Accessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly Vertex1Accessor Instance = new Vertex1Accessor();
            public static readonly Vector2 DefaultValue = new Vector2(-0.01f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.Vertex1);
            public override Vector2 GetPrefab(CollisionEdge2DPrefab instance) { return instance.Vertex1; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, Vector2 value) { instance.Vertex1 = value; }
            public override Vector2 GetUrho(CollisionEdge2D instance) { return instance.Vertex1; }
            public override void SetUrho(CollisionEdge2D instance, Vector2 value) { instance.Vertex1 = value; }
        }

        internal class Vertex2Accessor : Vector2Accessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly Vertex2Accessor Instance = new Vertex2Accessor();
            public static readonly Vector2 DefaultValue = new Vector2(0.01f, 0f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.Vertex2);
            public override Vector2 GetPrefab(CollisionEdge2DPrefab instance) { return instance.Vertex2; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, Vector2 value) { instance.Vertex2 = value; }
            public override Vector2 GetUrho(CollisionEdge2D instance) { return instance.Vertex2; }
            public override void SetUrho(CollisionEdge2D instance, Vector2 value) { instance.Vertex2 = value; }
        }

        internal class TriggerAccessor : BooleanAccessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly TriggerAccessor Instance = new TriggerAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.Trigger);
            public override bool GetPrefab(CollisionEdge2DPrefab instance) { return instance.Trigger; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, bool value) { instance.Trigger = value; }
            public override bool GetUrho(CollisionEdge2D instance) { return instance.Trigger; }
            public override void SetUrho(CollisionEdge2D instance, bool value) { instance.Trigger = value; }
        }

        internal class CategoryBitsAccessor : Int32Accessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly CategoryBitsAccessor Instance = new CategoryBitsAccessor();
            public static readonly int DefaultValue = 1;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.CategoryBits);
            public override int GetPrefab(CollisionEdge2DPrefab instance) { return instance.CategoryBits; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, int value) { instance.CategoryBits = value; }
            public override int GetUrho(CollisionEdge2D instance) { return instance.CategoryBits; }
            public override void SetUrho(CollisionEdge2D instance, int value) { instance.CategoryBits = value; }
        }

        internal class MaskBitsAccessor : Int32Accessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly MaskBitsAccessor Instance = new MaskBitsAccessor();
            public static readonly int DefaultValue = 65535;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.MaskBits);
            public override int GetPrefab(CollisionEdge2DPrefab instance) { return instance.MaskBits; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, int value) { instance.MaskBits = value; }
            public override int GetUrho(CollisionEdge2D instance) { return instance.MaskBits; }
            public override void SetUrho(CollisionEdge2D instance, int value) { instance.MaskBits = value; }
        }

        internal class GroupIndexAccessor : Int32Accessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly GroupIndexAccessor Instance = new GroupIndexAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.GroupIndex);
            public override int GetPrefab(CollisionEdge2DPrefab instance) { return instance.GroupIndex; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, int value) { instance.GroupIndex = value; }
            public override int GetUrho(CollisionEdge2D instance) { return instance.GroupIndex; }
            public override void SetUrho(CollisionEdge2D instance, int value) { instance.GroupIndex = value; }
        }

        internal class DensityAccessor : SingleAccessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly DensityAccessor Instance = new DensityAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.Density);
            public override float GetPrefab(CollisionEdge2DPrefab instance) { return instance.Density; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, float value) { instance.Density = value; }
            public override float GetUrho(CollisionEdge2D instance) { return instance.Density; }
            public override void SetUrho(CollisionEdge2D instance, float value) { instance.Density = value; }
        }

        internal class FrictionAccessor : SingleAccessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly FrictionAccessor Instance = new FrictionAccessor();
            public static readonly float DefaultValue = 0.2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.Friction);
            public override float GetPrefab(CollisionEdge2DPrefab instance) { return instance.Friction; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, float value) { instance.Friction = value; }
            public override float GetUrho(CollisionEdge2D instance) { return instance.Friction; }
            public override void SetUrho(CollisionEdge2D instance, float value) { instance.Friction = value; }
        }

        internal class RestitutionAccessor : SingleAccessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly RestitutionAccessor Instance = new RestitutionAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.Restitution);
            public override float GetPrefab(CollisionEdge2DPrefab instance) { return instance.Restitution; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, float value) { instance.Restitution = value; }
            public override float GetUrho(CollisionEdge2D instance) { return instance.Restitution; }
            public override void SetUrho(CollisionEdge2D instance, float value) { instance.Restitution = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.Enabled);
            public override bool GetPrefab(CollisionEdge2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(CollisionEdge2D instance) { return instance.Enabled; }
            public override void SetUrho(CollisionEdge2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.AnimationEnabled);
            public override bool GetPrefab(CollisionEdge2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(CollisionEdge2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(CollisionEdge2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.Temporary);
            public override bool GetPrefab(CollisionEdge2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(CollisionEdge2D instance) { return instance.Temporary; }
            public override void SetUrho(CollisionEdge2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<CollisionEdge2DPrefab, CollisionEdge2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(CollisionEdge2D.BlockEvents);
            public override bool GetPrefab(CollisionEdge2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(CollisionEdge2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(CollisionEdge2D instance) { return instance.BlockEvents; }
            public override void SetUrho(CollisionEdge2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
