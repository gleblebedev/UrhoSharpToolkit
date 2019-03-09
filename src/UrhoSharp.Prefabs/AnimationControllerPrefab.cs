using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using AnimationController = Urho.AnimationController;


namespace UrhoSharp.Prefabs
{
    public partial class AnimationControllerPrefab: AbstractComponentPrefab<AnimationController>, IPrefab
    {
        public override string TypeName { get { return AnimationController.TypeNameStatic; } }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public AnimationControllerPrefab()
        {
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public AnimationControllerPrefab(AnimationController val)
        {
            ID = val.ID;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override AnimationController Create()
        {
            var result = new AnimationController();
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
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class EnabledAccessor : BooleanAccessor<AnimationControllerPrefab, AnimationController>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimationController.Enabled);
            public override bool GetPrefab(AnimationControllerPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(AnimationControllerPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(AnimationController instance) { return instance.Enabled; }
            public override void SetUrho(AnimationController instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<AnimationControllerPrefab, AnimationController>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimationController.AnimationEnabled);
            public override bool GetPrefab(AnimationControllerPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(AnimationControllerPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(AnimationController instance) { return instance.AnimationEnabled; }
            public override void SetUrho(AnimationController instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<AnimationControllerPrefab, AnimationController>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimationController.Temporary);
            public override bool GetPrefab(AnimationControllerPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(AnimationControllerPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(AnimationController instance) { return instance.Temporary; }
            public override void SetUrho(AnimationController instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<AnimationControllerPrefab, AnimationController>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(AnimationController.BlockEvents);
            public override bool GetPrefab(AnimationControllerPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(AnimationControllerPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(AnimationController instance) { return instance.BlockEvents; }
            public override void SetUrho(AnimationController instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
