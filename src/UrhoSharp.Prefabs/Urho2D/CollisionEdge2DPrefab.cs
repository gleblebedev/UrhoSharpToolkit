using System;
using System.Xml.Linq;
using Urho;
using CollisionEdge2D = Urho.Urho2D.CollisionEdge2D;

using Urho.Urho2D;

namespace UrhoSharp.Prefabs
{
    public class CollisionEdge2DPrefab: AbstractComponentPrefab<CollisionEdge2D>, IPrefab
    {
        private static  Vector2 Vertex1DefaultValue = new Vector2(-0.01f, 0f);
        private static  Vector2 Vertex2DefaultValue = new Vector2(0.01f, 0f);
        private static  bool TriggerDefaultValue = false;
        private static  int CategoryBitsDefaultValue = 1;
        private static  int MaskBitsDefaultValue = 65535;
        private static  int GroupIndexDefaultValue = 0;
        private static  float DensityDefaultValue = 0f;
        private static  float FrictionDefaultValue = 0.2f;
        private static  float RestitutionDefaultValue = 0f;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private Vector2 _vertex1;
        private Vector2 _vertex2;
        private bool _trigger;
        private int _categoryBits;
        private int _maskBits;
        private int _groupIndex;
        private float _density;
        private float _friction;
        private float _restitution;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public CollisionEdge2DPrefab()
        {
            _vertex1 = Vertex1DefaultValue;
            _vertex2 = Vertex2DefaultValue;
            _trigger = TriggerDefaultValue;
            _categoryBits = CategoryBitsDefaultValue;
            _maskBits = MaskBitsDefaultValue;
            _groupIndex = GroupIndexDefaultValue;
            _density = DensityDefaultValue;
            _friction = FrictionDefaultValue;
            _restitution = RestitutionDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public CollisionEdge2DPrefab(CollisionEdge2D val)
        {
            _vertex1 = val.Vertex1;
            _vertex2 = val.Vertex2;
            _trigger = val.Trigger;
            _categoryBits = val.CategoryBits;
            _maskBits = val.MaskBits;
            _groupIndex = val.GroupIndex;
            _density = val.Density;
            _friction = val.Friction;
            _restitution = val.Restitution;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public Vector2 Vertex1 {get { return _vertex1;} set { _vertex1=value; } }
        public bool Vertex1HasValue {get { return !PrefabUtils.AreEqual(ref _vertex1, ref Vertex1DefaultValue); } }
        public Vector2 Vertex2 {get { return _vertex2;} set { _vertex2=value; } }
        public bool Vertex2HasValue {get { return !PrefabUtils.AreEqual(ref _vertex2, ref Vertex2DefaultValue); } }
        public bool Trigger {get { return _trigger;} set { _trigger=value; } }
        public bool TriggerHasValue {get { return !PrefabUtils.AreEqual(ref _trigger, ref TriggerDefaultValue); } }
        public int CategoryBits {get { return _categoryBits;} set { _categoryBits=value; } }
        public bool CategoryBitsHasValue {get { return !PrefabUtils.AreEqual(ref _categoryBits, ref CategoryBitsDefaultValue); } }
        public int MaskBits {get { return _maskBits;} set { _maskBits=value; } }
        public bool MaskBitsHasValue {get { return !PrefabUtils.AreEqual(ref _maskBits, ref MaskBitsDefaultValue); } }
        public int GroupIndex {get { return _groupIndex;} set { _groupIndex=value; } }
        public bool GroupIndexHasValue {get { return !PrefabUtils.AreEqual(ref _groupIndex, ref GroupIndexDefaultValue); } }
        public float Density {get { return _density;} set { _density=value; } }
        public bool DensityHasValue {get { return !PrefabUtils.AreEqual(ref _density, ref DensityDefaultValue); } }
        public float Friction {get { return _friction;} set { _friction=value; } }
        public bool FrictionHasValue {get { return !PrefabUtils.AreEqual(ref _friction, ref FrictionDefaultValue); } }
        public float Restitution {get { return _restitution;} set { _restitution=value; } }
        public bool RestitutionHasValue {get { return !PrefabUtils.AreEqual(ref _restitution, ref RestitutionDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override CollisionEdge2D Create()
        {
            var result = new CollisionEdge2D();
            if(Vertex1HasValue)
                result.Vertex1 = _vertex1;
            if(Vertex2HasValue)
                result.Vertex2 = _vertex2;
            if(TriggerHasValue)
                result.Trigger = _trigger;
            if(CategoryBitsHasValue)
                result.CategoryBits = _categoryBits;
            if(MaskBitsHasValue)
                result.MaskBits = _maskBits;
            if(GroupIndexHasValue)
                result.GroupIndex = _groupIndex;
            if(DensityHasValue)
                result.Density = _density;
            if(FrictionHasValue)
                result.Friction = _friction;
            if(RestitutionHasValue)
                result.Restitution = _restitution;
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
                case "Vertex1":
                    break;
                case "Vertex2":
                    break;
                case "Trigger":
                    break;
                case "CategoryBits":
                    break;
                case "MaskBits":
                    break;
                case "GroupIndex":
                    break;
                case "Density":
                    break;
                case "Friction":
                    break;
                case "Restitution":
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
