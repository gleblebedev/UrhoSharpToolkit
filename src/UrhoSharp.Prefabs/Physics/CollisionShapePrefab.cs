using System;
using System.Xml.Linq;
using Urho;
using CollisionShape = Urho.Physics.CollisionShape;

using Urho.Physics;

namespace UrhoSharp.Prefabs
{
    public class CollisionShapePrefab: AbstractComponentPrefab<CollisionShape>, IPrefab
    {
        private static  ShapeType ShapeTypeDefaultValue = ShapeType.Box;
        private static  Vector3 SizeDefaultValue = new Vector3(1f, 1f, 1f);
        private static  Vector3 PositionDefaultValue = new Vector3(0f, 0f, 0f);
        private static  Quaternion RotationDefaultValue = new Quaternion(0f, 0f, 0f, 1f);
        private static  float MarginDefaultValue = 0.04f;
        private static  Model ModelDefaultValue = null;
        private static  uint LodLevelDefaultValue = 0;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private ShapeType _shapeType;
        private Vector3 _size;
        private Vector3 _position;
        private Quaternion _rotation;
        private float _margin;
        private Model _model;
        private uint _lodLevel;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public CollisionShapePrefab()
        {
            _shapeType = ShapeTypeDefaultValue;
            _size = SizeDefaultValue;
            _position = PositionDefaultValue;
            _rotation = RotationDefaultValue;
            _margin = MarginDefaultValue;
            _model = ModelDefaultValue;
            _lodLevel = LodLevelDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public CollisionShapePrefab(CollisionShape val)
        {
            _shapeType = val.ShapeType;
            _size = val.Size;
            _position = val.Position;
            _rotation = val.Rotation;
            _margin = val.Margin;
            _model = val.Model;
            _lodLevel = val.LodLevel;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public ShapeType ShapeType {get { return _shapeType;} set { _shapeType=value; } }
        public bool ShapeTypeHasValue {get { return !PrefabUtils.AreEqual(ref _shapeType, ref ShapeTypeDefaultValue); } }
        public Vector3 Size {get { return _size;} set { _size=value; } }
        public bool SizeHasValue {get { return !PrefabUtils.AreEqual(ref _size, ref SizeDefaultValue); } }
        public Vector3 Position {get { return _position;} set { _position=value; } }
        public bool PositionHasValue {get { return !PrefabUtils.AreEqual(ref _position, ref PositionDefaultValue); } }
        public Quaternion Rotation {get { return _rotation;} set { _rotation=value; } }
        public bool RotationHasValue {get { return !PrefabUtils.AreEqual(ref _rotation, ref RotationDefaultValue); } }
        public float Margin {get { return _margin;} set { _margin=value; } }
        public bool MarginHasValue {get { return !PrefabUtils.AreEqual(ref _margin, ref MarginDefaultValue); } }
        public Model Model {get { return _model;} set { _model=value; } }
        public bool ModelHasValue {get { return !PrefabUtils.AreEqual(ref _model, ref ModelDefaultValue); } }
        public uint LodLevel {get { return _lodLevel;} set { _lodLevel=value; } }
        public bool LodLevelHasValue {get { return !PrefabUtils.AreEqual(ref _lodLevel, ref LodLevelDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override CollisionShape Create()
        {
            var result = new CollisionShape();
            if(ShapeTypeHasValue)
                result.ShapeType = _shapeType;
            if(SizeHasValue)
                result.Size = _size;
            if(PositionHasValue)
                result.Position = _position;
            if(RotationHasValue)
                result.Rotation = _rotation;
            if(MarginHasValue)
                result.Margin = _margin;
            if(ModelHasValue)
                result.Model = _model;
            if(LodLevelHasValue)
                result.LodLevel = _lodLevel;
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
                case "ShapeType":
                    break;
                case "Size":
                    break;
                case "Position":
                    break;
                case "Rotation":
                    break;
                case "Margin":
                    break;
                case "Model":
                    break;
                case "LodLevel":
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
