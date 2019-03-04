using System;
using System.Xml.Linq;
using Urho;
using Obstacle = Urho.Navigation.Obstacle;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public class ObstaclePrefab: AbstractComponentPrefab<Obstacle>, IPrefab
    {
        private static  float HeightDefaultValue = 5f;
        private static  float RadiusDefaultValue = 5f;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private float _height;
        private float _radius;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public ObstaclePrefab()
        {
            _height = HeightDefaultValue;
            _radius = RadiusDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public ObstaclePrefab(Obstacle val)
        {
            _height = val.Height;
            _radius = val.Radius;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public float Height {get { return _height;} set { _height=value; } }
        public bool HeightHasValue {get { return !PrefabUtils.AreEqual(ref _height, ref HeightDefaultValue); } }
        public float Radius {get { return _radius;} set { _radius=value; } }
        public bool RadiusHasValue {get { return !PrefabUtils.AreEqual(ref _radius, ref RadiusDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override Obstacle Create()
        {
            var result = new Obstacle();
            if(HeightHasValue)
                result.Height = _height;
            if(RadiusHasValue)
                result.Radius = _radius;
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
                case "Height":
                    break;
                case "Radius":
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
