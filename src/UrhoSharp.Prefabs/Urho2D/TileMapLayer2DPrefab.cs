using System;
using System.Xml.Linq;
using Urho;
using TileMapLayer2D = Urho.Urho2D.TileMapLayer2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class TileMapLayer2DPrefab: AbstractComponentPrefab<TileMapLayer2D>, IPrefab
    {
        private static  int DrawOrderDefaultValue = 0;
        private static  bool VisibleDefaultValue = true;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private int _drawOrder;
        private bool _visible;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public TileMapLayer2DPrefab()
        {
            _drawOrder = DrawOrderDefaultValue;
            _visible = VisibleDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public TileMapLayer2DPrefab(TileMapLayer2D val)
        {
            _drawOrder = val.DrawOrder;
            _visible = val.Visible;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public int DrawOrder {get { return _drawOrder;} set { _drawOrder=value; } }
        public bool DrawOrderHasValue {get { return !PrefabUtils.AreEqual(ref _drawOrder, ref DrawOrderDefaultValue); } }
        public bool Visible {get { return _visible;} set { _visible=value; } }
        public bool VisibleHasValue {get { return !PrefabUtils.AreEqual(ref _visible, ref VisibleDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override TileMapLayer2D Create()
        {
            var result = new TileMapLayer2D();
            if(DrawOrderHasValue)
                result.DrawOrder = _drawOrder;
            if(VisibleHasValue)
                result.Visible = _visible;
            if(EnabledHasValue)
                result.Enabled = _enabled;
            if(AnimationEnabledHasValue)
                result.AnimationEnabled = _animationEnabled;
            if(TemporaryHasValue)
                result.Temporary = _temporary;
            if(BlockEventsHasValue)
                result.BlockEvents = _blockEvents;
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "DrawOrder":
                    break;
                case "Visible":
                    break;
                case "Enabled":
                    break;
                case "AnimationEnabled":
                    break;
                case "Temporary":
                    break;
                case "BlockEvents":
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
    }
}
