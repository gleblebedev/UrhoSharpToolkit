using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using PhysicsWorld = Urho.Physics.PhysicsWorld;

using Urho.Physics;

namespace UrhoSharp.Prefabs
{
    public partial class PhysicsWorldPrefab: AbstractComponentPrefab<PhysicsWorld>, IPrefab
    {
        public override string TypeName { get { return PhysicsWorld.TypeNameStatic; } }
        public int Fps { get; set; }
        public int MaxSubSteps { get; set; }
        public int NumIterations { get; set; }
        public bool UpdateEnabled { get; set; }
        public bool Interpolation { get; set; }
        public bool InternalEdge { get; set; }
        public bool SplitImpulse { get; set; }
        public float MaxNetworkAngularVelocity { get; set; }
        public bool ApplyingTransforms { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public PhysicsWorldPrefab()
        {
            Fps = FpsAccessor.DefaultValue;
            MaxSubSteps = MaxSubStepsAccessor.DefaultValue;
            NumIterations = NumIterationsAccessor.DefaultValue;
            UpdateEnabled = UpdateEnabledAccessor.DefaultValue;
            Interpolation = InterpolationAccessor.DefaultValue;
            InternalEdge = InternalEdgeAccessor.DefaultValue;
            SplitImpulse = SplitImpulseAccessor.DefaultValue;
            MaxNetworkAngularVelocity = MaxNetworkAngularVelocityAccessor.DefaultValue;
            ApplyingTransforms = ApplyingTransformsAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public PhysicsWorldPrefab(PhysicsWorld val)
        {
            ID = val.ID;
            Fps = val.Fps;
            MaxSubSteps = val.MaxSubSteps;
            NumIterations = val.NumIterations;
            UpdateEnabled = val.UpdateEnabled;
            Interpolation = val.Interpolation;
            InternalEdge = val.InternalEdge;
            SplitImpulse = val.SplitImpulse;
            MaxNetworkAngularVelocity = val.MaxNetworkAngularVelocity;
            ApplyingTransforms = val.ApplyingTransforms;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override PhysicsWorld Create()
        {
            var result = new PhysicsWorld();
            FpsAccessor.Instance.ApplyIfChanged(this, result);
            MaxSubStepsAccessor.Instance.ApplyIfChanged(this, result);
            NumIterationsAccessor.Instance.ApplyIfChanged(this, result);
            UpdateEnabledAccessor.Instance.ApplyIfChanged(this, result);
            InterpolationAccessor.Instance.ApplyIfChanged(this, result);
            InternalEdgeAccessor.Instance.ApplyIfChanged(this, result);
            SplitImpulseAccessor.Instance.ApplyIfChanged(this, result);
            MaxNetworkAngularVelocityAccessor.Instance.ApplyIfChanged(this, result);
            ApplyingTransformsAccessor.Instance.ApplyIfChanged(this, result);
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
                case "Fps":
                    FpsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxSubSteps":
                    MaxSubStepsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "NumIterations":
                    NumIterationsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "UpdateEnabled":
                    UpdateEnabledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Interpolation":
                    InterpolationAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "InternalEdge":
                    InternalEdgeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "SplitImpulse":
                    SplitImpulseAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxNetworkAngularVelocity":
                    MaxNetworkAngularVelocityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ApplyingTransforms":
                    ApplyingTransformsAccessor.Instance.ParseAndSet(value, this);
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
                yield return FpsAccessor.Instance;
                yield return MaxSubStepsAccessor.Instance;
                yield return NumIterationsAccessor.Instance;
                yield return UpdateEnabledAccessor.Instance;
                yield return InterpolationAccessor.Instance;
                yield return InternalEdgeAccessor.Instance;
                yield return SplitImpulseAccessor.Instance;
                yield return MaxNetworkAngularVelocityAccessor.Instance;
                yield return ApplyingTransformsAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class FpsAccessor : Int32Accessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly FpsAccessor Instance = new FpsAccessor();
            public static readonly int DefaultValue = 60;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.Fps);
            public override int GetPrefab(PhysicsWorldPrefab instance) { return instance.Fps; }
            public override void SetPrefab(PhysicsWorldPrefab instance, int value) { instance.Fps = value; }
            public override int GetUrho(PhysicsWorld instance) { return instance.Fps; }
            public override void SetUrho(PhysicsWorld instance, int value) { instance.Fps = value; }
        }

        internal class MaxSubStepsAccessor : Int32Accessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly MaxSubStepsAccessor Instance = new MaxSubStepsAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.MaxSubSteps);
            public override int GetPrefab(PhysicsWorldPrefab instance) { return instance.MaxSubSteps; }
            public override void SetPrefab(PhysicsWorldPrefab instance, int value) { instance.MaxSubSteps = value; }
            public override int GetUrho(PhysicsWorld instance) { return instance.MaxSubSteps; }
            public override void SetUrho(PhysicsWorld instance, int value) { instance.MaxSubSteps = value; }
        }

        internal class NumIterationsAccessor : Int32Accessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly NumIterationsAccessor Instance = new NumIterationsAccessor();
            public static readonly int DefaultValue = 10;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.NumIterations);
            public override int GetPrefab(PhysicsWorldPrefab instance) { return instance.NumIterations; }
            public override void SetPrefab(PhysicsWorldPrefab instance, int value) { instance.NumIterations = value; }
            public override int GetUrho(PhysicsWorld instance) { return instance.NumIterations; }
            public override void SetUrho(PhysicsWorld instance, int value) { instance.NumIterations = value; }
        }

        internal class UpdateEnabledAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly UpdateEnabledAccessor Instance = new UpdateEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.UpdateEnabled);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.UpdateEnabled; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.UpdateEnabled = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.UpdateEnabled; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.UpdateEnabled = value; }
        }

        internal class InterpolationAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly InterpolationAccessor Instance = new InterpolationAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.Interpolation);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.Interpolation; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.Interpolation = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.Interpolation; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.Interpolation = value; }
        }

        internal class InternalEdgeAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly InternalEdgeAccessor Instance = new InternalEdgeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.InternalEdge);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.InternalEdge; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.InternalEdge = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.InternalEdge; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.InternalEdge = value; }
        }

        internal class SplitImpulseAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly SplitImpulseAccessor Instance = new SplitImpulseAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.SplitImpulse);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.SplitImpulse; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.SplitImpulse = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.SplitImpulse; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.SplitImpulse = value; }
        }

        internal class MaxNetworkAngularVelocityAccessor : SingleAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly MaxNetworkAngularVelocityAccessor Instance = new MaxNetworkAngularVelocityAccessor();
            public static readonly float DefaultValue = 100f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.MaxNetworkAngularVelocity);
            public override float GetPrefab(PhysicsWorldPrefab instance) { return instance.MaxNetworkAngularVelocity; }
            public override void SetPrefab(PhysicsWorldPrefab instance, float value) { instance.MaxNetworkAngularVelocity = value; }
            public override float GetUrho(PhysicsWorld instance) { return instance.MaxNetworkAngularVelocity; }
            public override void SetUrho(PhysicsWorld instance, float value) { instance.MaxNetworkAngularVelocity = value; }
        }

        internal class ApplyingTransformsAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly ApplyingTransformsAccessor Instance = new ApplyingTransformsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.ApplyingTransforms);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.ApplyingTransforms; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.ApplyingTransforms = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.ApplyingTransforms; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.ApplyingTransforms = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.Enabled);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.Enabled; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.AnimationEnabled);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.AnimationEnabled; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.Temporary);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.Temporary; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<PhysicsWorldPrefab, PhysicsWorld>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld.BlockEvents);
            public override bool GetPrefab(PhysicsWorldPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(PhysicsWorldPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(PhysicsWorld instance) { return instance.BlockEvents; }
            public override void SetUrho(PhysicsWorld instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
