using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using PhysicsWorld2D = Urho.Urho2D.PhysicsWorld2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public partial class PhysicsWorld2DPrefab: AbstractComponentPrefab<PhysicsWorld2D>, IPrefab
    {
        public override string TypeName { get { return PhysicsWorld2D.TypeNameStatic; } }
        public bool UpdateEnabled { get; set; }
        public bool DrawShape { get; set; }
        public bool DrawJoint { get; set; }
        public bool DrawAabb { get; set; }
        public bool DrawPair { get; set; }
        public bool DrawCenterOfMass { get; set; }
        public bool AllowSleeping { get; set; }
        public bool WarmStarting { get; set; }
        public bool ContinuousPhysics { get; set; }
        public bool SubStepping { get; set; }
        public Vector2 Gravity { get; set; }
        public bool AutoClearForces { get; set; }
        public int VelocityIterations { get; set; }
        public int PositionIterations { get; set; }
        public bool ApplyingTransforms { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public PhysicsWorld2DPrefab()
        {
            UpdateEnabled = UpdateEnabledAccessor.DefaultValue;
            DrawShape = DrawShapeAccessor.DefaultValue;
            DrawJoint = DrawJointAccessor.DefaultValue;
            DrawAabb = DrawAabbAccessor.DefaultValue;
            DrawPair = DrawPairAccessor.DefaultValue;
            DrawCenterOfMass = DrawCenterOfMassAccessor.DefaultValue;
            AllowSleeping = AllowSleepingAccessor.DefaultValue;
            WarmStarting = WarmStartingAccessor.DefaultValue;
            ContinuousPhysics = ContinuousPhysicsAccessor.DefaultValue;
            SubStepping = SubSteppingAccessor.DefaultValue;
            Gravity = GravityAccessor.DefaultValue;
            AutoClearForces = AutoClearForcesAccessor.DefaultValue;
            VelocityIterations = VelocityIterationsAccessor.DefaultValue;
            PositionIterations = PositionIterationsAccessor.DefaultValue;
            ApplyingTransforms = ApplyingTransformsAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public PhysicsWorld2DPrefab(PhysicsWorld2D val)
        {
            ID = val.ID;
            UpdateEnabled = val.UpdateEnabled;
            DrawShape = val.DrawShape;
            DrawJoint = val.DrawJoint;
            DrawAabb = val.DrawAabb;
            DrawPair = val.DrawPair;
            DrawCenterOfMass = val.DrawCenterOfMass;
            AllowSleeping = val.AllowSleeping;
            WarmStarting = val.WarmStarting;
            ContinuousPhysics = val.ContinuousPhysics;
            SubStepping = val.SubStepping;
            Gravity = val.Gravity;
            AutoClearForces = val.AutoClearForces;
            VelocityIterations = val.VelocityIterations;
            PositionIterations = val.PositionIterations;
            ApplyingTransforms = val.ApplyingTransforms;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override PhysicsWorld2D Create()
        {
            var result = new PhysicsWorld2D();
            UpdateEnabledAccessor.Instance.ApplyIfChanged(this, result);
            DrawShapeAccessor.Instance.ApplyIfChanged(this, result);
            DrawJointAccessor.Instance.ApplyIfChanged(this, result);
            DrawAabbAccessor.Instance.ApplyIfChanged(this, result);
            DrawPairAccessor.Instance.ApplyIfChanged(this, result);
            DrawCenterOfMassAccessor.Instance.ApplyIfChanged(this, result);
            AllowSleepingAccessor.Instance.ApplyIfChanged(this, result);
            WarmStartingAccessor.Instance.ApplyIfChanged(this, result);
            ContinuousPhysicsAccessor.Instance.ApplyIfChanged(this, result);
            SubSteppingAccessor.Instance.ApplyIfChanged(this, result);
            GravityAccessor.Instance.ApplyIfChanged(this, result);
            AutoClearForcesAccessor.Instance.ApplyIfChanged(this, result);
            VelocityIterationsAccessor.Instance.ApplyIfChanged(this, result);
            PositionIterationsAccessor.Instance.ApplyIfChanged(this, result);
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
                case "UpdateEnabled":
                    UpdateEnabledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawShape":
                    DrawShapeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawJoint":
                    DrawJointAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawAabb":
                    DrawAabbAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawPair":
                    DrawPairAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawCenterOfMass":
                    DrawCenterOfMassAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AllowSleeping":
                    AllowSleepingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "WarmStarting":
                    WarmStartingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ContinuousPhysics":
                    ContinuousPhysicsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "SubStepping":
                    SubSteppingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Gravity":
                    GravityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AutoClearForces":
                    AutoClearForcesAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "VelocityIterations":
                    VelocityIterationsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "PositionIterations":
                    PositionIterationsAccessor.Instance.ParseAndSet(value, this);
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
                yield return UpdateEnabledAccessor.Instance;
                yield return DrawShapeAccessor.Instance;
                yield return DrawJointAccessor.Instance;
                yield return DrawAabbAccessor.Instance;
                yield return DrawPairAccessor.Instance;
                yield return DrawCenterOfMassAccessor.Instance;
                yield return AllowSleepingAccessor.Instance;
                yield return WarmStartingAccessor.Instance;
                yield return ContinuousPhysicsAccessor.Instance;
                yield return SubSteppingAccessor.Instance;
                yield return GravityAccessor.Instance;
                yield return AutoClearForcesAccessor.Instance;
                yield return VelocityIterationsAccessor.Instance;
                yield return PositionIterationsAccessor.Instance;
                yield return ApplyingTransformsAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class UpdateEnabledAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly UpdateEnabledAccessor Instance = new UpdateEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.UpdateEnabled);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.UpdateEnabled; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.UpdateEnabled = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.UpdateEnabled; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.UpdateEnabled = value; }
        }

        internal class DrawShapeAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly DrawShapeAccessor Instance = new DrawShapeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.DrawShape);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.DrawShape; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.DrawShape = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.DrawShape; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.DrawShape = value; }
        }

        internal class DrawJointAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly DrawJointAccessor Instance = new DrawJointAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.DrawJoint);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.DrawJoint; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.DrawJoint = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.DrawJoint; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.DrawJoint = value; }
        }

        internal class DrawAabbAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly DrawAabbAccessor Instance = new DrawAabbAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.DrawAabb);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.DrawAabb; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.DrawAabb = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.DrawAabb; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.DrawAabb = value; }
        }

        internal class DrawPairAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly DrawPairAccessor Instance = new DrawPairAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.DrawPair);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.DrawPair; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.DrawPair = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.DrawPair; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.DrawPair = value; }
        }

        internal class DrawCenterOfMassAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly DrawCenterOfMassAccessor Instance = new DrawCenterOfMassAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.DrawCenterOfMass);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.DrawCenterOfMass; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.DrawCenterOfMass = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.DrawCenterOfMass; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.DrawCenterOfMass = value; }
        }

        internal class AllowSleepingAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly AllowSleepingAccessor Instance = new AllowSleepingAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.AllowSleeping);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.AllowSleeping; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.AllowSleeping = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.AllowSleeping; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.AllowSleeping = value; }
        }

        internal class WarmStartingAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly WarmStartingAccessor Instance = new WarmStartingAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.WarmStarting);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.WarmStarting; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.WarmStarting = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.WarmStarting; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.WarmStarting = value; }
        }

        internal class ContinuousPhysicsAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly ContinuousPhysicsAccessor Instance = new ContinuousPhysicsAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.ContinuousPhysics);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.ContinuousPhysics; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.ContinuousPhysics = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.ContinuousPhysics; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.ContinuousPhysics = value; }
        }

        internal class SubSteppingAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly SubSteppingAccessor Instance = new SubSteppingAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.SubStepping);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.SubStepping; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.SubStepping = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.SubStepping; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.SubStepping = value; }
        }

        internal class GravityAccessor : Vector2Accessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly GravityAccessor Instance = new GravityAccessor();
            public static readonly Vector2 DefaultValue = new Vector2(0f, -9.81f);
            public override Vector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.Gravity);
            public override Vector2 GetPrefab(PhysicsWorld2DPrefab instance) { return instance.Gravity; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, Vector2 value) { instance.Gravity = value; }
            public override Vector2 GetUrho(PhysicsWorld2D instance) { return instance.Gravity; }
            public override void SetUrho(PhysicsWorld2D instance, Vector2 value) { instance.Gravity = value; }
        }

        internal class AutoClearForcesAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly AutoClearForcesAccessor Instance = new AutoClearForcesAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.AutoClearForces);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.AutoClearForces; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.AutoClearForces = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.AutoClearForces; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.AutoClearForces = value; }
        }

        internal class VelocityIterationsAccessor : Int32Accessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly VelocityIterationsAccessor Instance = new VelocityIterationsAccessor();
            public static readonly int DefaultValue = 8;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.VelocityIterations);
            public override int GetPrefab(PhysicsWorld2DPrefab instance) { return instance.VelocityIterations; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, int value) { instance.VelocityIterations = value; }
            public override int GetUrho(PhysicsWorld2D instance) { return instance.VelocityIterations; }
            public override void SetUrho(PhysicsWorld2D instance, int value) { instance.VelocityIterations = value; }
        }

        internal class PositionIterationsAccessor : Int32Accessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly PositionIterationsAccessor Instance = new PositionIterationsAccessor();
            public static readonly int DefaultValue = 3;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.PositionIterations);
            public override int GetPrefab(PhysicsWorld2DPrefab instance) { return instance.PositionIterations; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, int value) { instance.PositionIterations = value; }
            public override int GetUrho(PhysicsWorld2D instance) { return instance.PositionIterations; }
            public override void SetUrho(PhysicsWorld2D instance, int value) { instance.PositionIterations = value; }
        }

        internal class ApplyingTransformsAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly ApplyingTransformsAccessor Instance = new ApplyingTransformsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.ApplyingTransforms);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.ApplyingTransforms; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.ApplyingTransforms = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.ApplyingTransforms; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.ApplyingTransforms = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.Enabled);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.Enabled; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.AnimationEnabled);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.Temporary);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.Temporary; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<PhysicsWorld2DPrefab, PhysicsWorld2D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(PhysicsWorld2D.BlockEvents);
            public override bool GetPrefab(PhysicsWorld2DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(PhysicsWorld2DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(PhysicsWorld2D instance) { return instance.BlockEvents; }
            public override void SetUrho(PhysicsWorld2D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
