using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using NavArea = Urho.Navigation.NavArea;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public partial class NavAreaPrefab: AbstractComponentPrefab<NavArea>, IPrefab
    {
        public override string TypeName { get { return NavArea.TypeNameStatic; } }
        public uint AreaID { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public NavAreaPrefab()
        {
            AreaID = AreaIDAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public NavAreaPrefab(NavArea val)
        {
            ID = val.ID;
            AreaID = val.AreaID;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override NavArea Create()
        {
            var result = new NavArea();
            AreaIDAccessor.Instance.ApplyIfChanged(this, result);
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
                case "AreaID":
                    AreaIDAccessor.Instance.ParseAndSet(value, this);
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
                yield return AreaIDAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class AreaIDAccessor : UInt32Accessor<NavAreaPrefab, NavArea>
        {
            public static readonly AreaIDAccessor Instance = new AreaIDAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavArea.AreaID);
            public override uint GetPrefab(NavAreaPrefab instance) { return instance.AreaID; }
            public override void SetPrefab(NavAreaPrefab instance, uint value) { instance.AreaID = value; }
            public override uint GetUrho(NavArea instance) { return instance.AreaID; }
            public override void SetUrho(NavArea instance, uint value) { instance.AreaID = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<NavAreaPrefab, NavArea>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavArea.Enabled);
            public override bool GetPrefab(NavAreaPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(NavAreaPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(NavArea instance) { return instance.Enabled; }
            public override void SetUrho(NavArea instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<NavAreaPrefab, NavArea>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavArea.AnimationEnabled);
            public override bool GetPrefab(NavAreaPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(NavAreaPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(NavArea instance) { return instance.AnimationEnabled; }
            public override void SetUrho(NavArea instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<NavAreaPrefab, NavArea>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavArea.Temporary);
            public override bool GetPrefab(NavAreaPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(NavAreaPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(NavArea instance) { return instance.Temporary; }
            public override void SetUrho(NavArea instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<NavAreaPrefab, NavArea>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavArea.BlockEvents);
            public override bool GetPrefab(NavAreaPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(NavAreaPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(NavArea instance) { return instance.BlockEvents; }
            public override void SetUrho(NavArea instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
