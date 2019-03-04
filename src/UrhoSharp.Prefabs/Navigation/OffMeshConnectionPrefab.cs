using System;
using System.Xml.Linq;
using Urho;
using OffMeshConnection = Urho.Navigation.OffMeshConnection;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public class OffMeshConnectionPrefab: AbstractComponentPrefab<OffMeshConnection>, IPrefab
    {
        private static  Node EndPointDefaultValue = null;
        private static  float RadiusDefaultValue = 1f;
        private static  bool BidirectionalDefaultValue = true;
        private static  uint MaskDefaultValue = 1;
        private static  uint AreaIDDefaultValue = 1;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Node _endPoint;
        private float _radius;
        private bool _bidirectional;
        private uint _mask;
        private uint _areaID;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public OffMeshConnectionPrefab()
        {
            _endPoint = EndPointDefaultValue;
            _radius = RadiusDefaultValue;
            _bidirectional = BidirectionalDefaultValue;
            _mask = MaskDefaultValue;
            _areaID = AreaIDDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public OffMeshConnectionPrefab(OffMeshConnection val)
        {
            _endPoint = val.EndPoint;
            _radius = val.Radius;
            _bidirectional = val.Bidirectional;
            _mask = val.Mask;
            _areaID = val.AreaID;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Node EndPoint {get { return _endPoint;} set { _endPoint=value; } }
        public bool EndPointHasValue {get { return !PrefabUtils.AreEqual(ref _endPoint, ref EndPointDefaultValue); } }
        public float Radius {get { return _radius;} set { _radius=value; } }
        public bool RadiusHasValue {get { return !PrefabUtils.AreEqual(ref _radius, ref RadiusDefaultValue); } }
        public bool Bidirectional {get { return _bidirectional;} set { _bidirectional=value; } }
        public bool BidirectionalHasValue {get { return !PrefabUtils.AreEqual(ref _bidirectional, ref BidirectionalDefaultValue); } }
        public uint Mask {get { return _mask;} set { _mask=value; } }
        public bool MaskHasValue {get { return !PrefabUtils.AreEqual(ref _mask, ref MaskDefaultValue); } }
        public uint AreaID {get { return _areaID;} set { _areaID=value; } }
        public bool AreaIDHasValue {get { return !PrefabUtils.AreEqual(ref _areaID, ref AreaIDDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override OffMeshConnection Create()
        {
            var result = new OffMeshConnection();
            if(EndPointHasValue)
                result.EndPoint = _endPoint;
            if(RadiusHasValue)
                result.Radius = _radius;
            if(BidirectionalHasValue)
                result.Bidirectional = _bidirectional;
            if(MaskHasValue)
                result.Mask = _mask;
            if(AreaIDHasValue)
                result.AreaID = _areaID;
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
                case "EndPoint":
                    break;
                case "Radius":
                    break;
                case "Bidirectional":
                    break;
                case "Mask":
                    break;
                case "AreaID":
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
