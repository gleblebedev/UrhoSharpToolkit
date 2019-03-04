using System;
using System.Xml.Linq;
using Urho;
using DynamicNavigationMesh = Urho.Navigation.DynamicNavigationMesh;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public class DynamicNavigationMeshPrefab: AbstractComponentPrefab<DynamicNavigationMesh>, IPrefab
    {
        private static  uint MaxObstaclesDefaultValue = 1024;
        private static  uint MaxLayersDefaultValue = 16;
        private static  bool DrawObstaclesDefaultValue = false;
        private static  int TileSizeDefaultValue = 64;
        private static  float CellSizeDefaultValue = 0.3f;
        private static  float CellHeightDefaultValue = 0.2f;
        private static  float AgentHeightDefaultValue = 2f;
        private static  float AgentRadiusDefaultValue = 0.6f;
        private static  float AgentMaxClimbDefaultValue = 0.9f;
        private static  float AgentMaxSlopeDefaultValue = 45f;
        private static  float RegionMinSizeDefaultValue = 8f;
        private static  float RegionMergeSizeDefaultValue = 20f;
        private static  float EdgeMaxLengthDefaultValue = 12f;
        private static  float EdgeMaxErrorDefaultValue = 1.3f;
        private static  float DetailSampleDistanceDefaultValue = 6f;
        private static  float DetailSampleMaxErrorDefaultValue = 1f;
        private static  Vector3 PaddingDefaultValue = new Vector3(1f, 1f, 1f);
        private static  NavmeshPartitionType PartitionTypeDefaultValue = NavmeshPartitionType.Monotone;
        private static  bool DrawOffMeshConnectionsDefaultValue = false;
        private static  bool DrawNavAreasDefaultValue = false;
        private static  bool EnabledDefaultValue = true;
        private static  bool AnimationEnabledDefaultValue = true;
        private static  bool TemporaryDefaultValue = false;
        private static  bool BlockEventsDefaultValue = false;
        private uint _maxObstacles;
        private uint _maxLayers;
        private bool _drawObstacles;
        private int _tileSize;
        private float _cellSize;
        private float _cellHeight;
        private float _agentHeight;
        private float _agentRadius;
        private float _agentMaxClimb;
        private float _agentMaxSlope;
        private float _regionMinSize;
        private float _regionMergeSize;
        private float _edgeMaxLength;
        private float _edgeMaxError;
        private float _detailSampleDistance;
        private float _detailSampleMaxError;
        private Vector3 _padding;
        private NavmeshPartitionType _partitionType;
        private bool _drawOffMeshConnections;
        private bool _drawNavAreas;
        private bool _enabled;
        private bool _animationEnabled;
        private bool _temporary;
        private bool _blockEvents;
        public DynamicNavigationMeshPrefab()
        {
            _maxObstacles = MaxObstaclesDefaultValue;
            _maxLayers = MaxLayersDefaultValue;
            _drawObstacles = DrawObstaclesDefaultValue;
            _tileSize = TileSizeDefaultValue;
            _cellSize = CellSizeDefaultValue;
            _cellHeight = CellHeightDefaultValue;
            _agentHeight = AgentHeightDefaultValue;
            _agentRadius = AgentRadiusDefaultValue;
            _agentMaxClimb = AgentMaxClimbDefaultValue;
            _agentMaxSlope = AgentMaxSlopeDefaultValue;
            _regionMinSize = RegionMinSizeDefaultValue;
            _regionMergeSize = RegionMergeSizeDefaultValue;
            _edgeMaxLength = EdgeMaxLengthDefaultValue;
            _edgeMaxError = EdgeMaxErrorDefaultValue;
            _detailSampleDistance = DetailSampleDistanceDefaultValue;
            _detailSampleMaxError = DetailSampleMaxErrorDefaultValue;
            _padding = PaddingDefaultValue;
            _partitionType = PartitionTypeDefaultValue;
            _drawOffMeshConnections = DrawOffMeshConnectionsDefaultValue;
            _drawNavAreas = DrawNavAreasDefaultValue;
            _enabled = EnabledDefaultValue;
            _animationEnabled = AnimationEnabledDefaultValue;
            _temporary = TemporaryDefaultValue;
            _blockEvents = BlockEventsDefaultValue;
        }
        public DynamicNavigationMeshPrefab(DynamicNavigationMesh val)
        {
            _maxObstacles = val.MaxObstacles;
            _maxLayers = val.MaxLayers;
            _drawObstacles = val.DrawObstacles;
            _tileSize = val.TileSize;
            _cellSize = val.CellSize;
            _cellHeight = val.CellHeight;
            _agentHeight = val.AgentHeight;
            _agentRadius = val.AgentRadius;
            _agentMaxClimb = val.AgentMaxClimb;
            _agentMaxSlope = val.AgentMaxSlope;
            _regionMinSize = val.RegionMinSize;
            _regionMergeSize = val.RegionMergeSize;
            _edgeMaxLength = val.EdgeMaxLength;
            _edgeMaxError = val.EdgeMaxError;
            _detailSampleDistance = val.DetailSampleDistance;
            _detailSampleMaxError = val.DetailSampleMaxError;
            _padding = val.Padding;
            _partitionType = val.PartitionType;
            _drawOffMeshConnections = val.DrawOffMeshConnections;
            _drawNavAreas = val.DrawNavAreas;
            _enabled = val.Enabled;
            _animationEnabled = val.AnimationEnabled;
            _temporary = val.Temporary;
            _blockEvents = val.BlockEvents;
        }
        public uint MaxObstacles {get { return _maxObstacles;} set { _maxObstacles=value; } }
        public bool MaxObstaclesHasValue {get { return !PrefabUtils.AreEqual(ref _maxObstacles, ref MaxObstaclesDefaultValue); } }
        public uint MaxLayers {get { return _maxLayers;} set { _maxLayers=value; } }
        public bool MaxLayersHasValue {get { return !PrefabUtils.AreEqual(ref _maxLayers, ref MaxLayersDefaultValue); } }
        public bool DrawObstacles {get { return _drawObstacles;} set { _drawObstacles=value; } }
        public bool DrawObstaclesHasValue {get { return !PrefabUtils.AreEqual(ref _drawObstacles, ref DrawObstaclesDefaultValue); } }
        public int TileSize {get { return _tileSize;} set { _tileSize=value; } }
        public bool TileSizeHasValue {get { return !PrefabUtils.AreEqual(ref _tileSize, ref TileSizeDefaultValue); } }
        public float CellSize {get { return _cellSize;} set { _cellSize=value; } }
        public bool CellSizeHasValue {get { return !PrefabUtils.AreEqual(ref _cellSize, ref CellSizeDefaultValue); } }
        public float CellHeight {get { return _cellHeight;} set { _cellHeight=value; } }
        public bool CellHeightHasValue {get { return !PrefabUtils.AreEqual(ref _cellHeight, ref CellHeightDefaultValue); } }
        public float AgentHeight {get { return _agentHeight;} set { _agentHeight=value; } }
        public bool AgentHeightHasValue {get { return !PrefabUtils.AreEqual(ref _agentHeight, ref AgentHeightDefaultValue); } }
        public float AgentRadius {get { return _agentRadius;} set { _agentRadius=value; } }
        public bool AgentRadiusHasValue {get { return !PrefabUtils.AreEqual(ref _agentRadius, ref AgentRadiusDefaultValue); } }
        public float AgentMaxClimb {get { return _agentMaxClimb;} set { _agentMaxClimb=value; } }
        public bool AgentMaxClimbHasValue {get { return !PrefabUtils.AreEqual(ref _agentMaxClimb, ref AgentMaxClimbDefaultValue); } }
        public float AgentMaxSlope {get { return _agentMaxSlope;} set { _agentMaxSlope=value; } }
        public bool AgentMaxSlopeHasValue {get { return !PrefabUtils.AreEqual(ref _agentMaxSlope, ref AgentMaxSlopeDefaultValue); } }
        public float RegionMinSize {get { return _regionMinSize;} set { _regionMinSize=value; } }
        public bool RegionMinSizeHasValue {get { return !PrefabUtils.AreEqual(ref _regionMinSize, ref RegionMinSizeDefaultValue); } }
        public float RegionMergeSize {get { return _regionMergeSize;} set { _regionMergeSize=value; } }
        public bool RegionMergeSizeHasValue {get { return !PrefabUtils.AreEqual(ref _regionMergeSize, ref RegionMergeSizeDefaultValue); } }
        public float EdgeMaxLength {get { return _edgeMaxLength;} set { _edgeMaxLength=value; } }
        public bool EdgeMaxLengthHasValue {get { return !PrefabUtils.AreEqual(ref _edgeMaxLength, ref EdgeMaxLengthDefaultValue); } }
        public float EdgeMaxError {get { return _edgeMaxError;} set { _edgeMaxError=value; } }
        public bool EdgeMaxErrorHasValue {get { return !PrefabUtils.AreEqual(ref _edgeMaxError, ref EdgeMaxErrorDefaultValue); } }
        public float DetailSampleDistance {get { return _detailSampleDistance;} set { _detailSampleDistance=value; } }
        public bool DetailSampleDistanceHasValue {get { return !PrefabUtils.AreEqual(ref _detailSampleDistance, ref DetailSampleDistanceDefaultValue); } }
        public float DetailSampleMaxError {get { return _detailSampleMaxError;} set { _detailSampleMaxError=value; } }
        public bool DetailSampleMaxErrorHasValue {get { return !PrefabUtils.AreEqual(ref _detailSampleMaxError, ref DetailSampleMaxErrorDefaultValue); } }
        public Vector3 Padding {get { return _padding;} set { _padding=value; } }
        public bool PaddingHasValue {get { return !PrefabUtils.AreEqual(ref _padding, ref PaddingDefaultValue); } }
        public NavmeshPartitionType PartitionType {get { return _partitionType;} set { _partitionType=value; } }
        public bool PartitionTypeHasValue {get { return !PrefabUtils.AreEqual(ref _partitionType, ref PartitionTypeDefaultValue); } }
        public bool DrawOffMeshConnections {get { return _drawOffMeshConnections;} set { _drawOffMeshConnections=value; } }
        public bool DrawOffMeshConnectionsHasValue {get { return !PrefabUtils.AreEqual(ref _drawOffMeshConnections, ref DrawOffMeshConnectionsDefaultValue); } }
        public bool DrawNavAreas {get { return _drawNavAreas;} set { _drawNavAreas=value; } }
        public bool DrawNavAreasHasValue {get { return !PrefabUtils.AreEqual(ref _drawNavAreas, ref DrawNavAreasDefaultValue); } }
        public bool Enabled {get { return _enabled;} set { _enabled=value; } }
        public bool EnabledHasValue {get { return !PrefabUtils.AreEqual(ref _enabled, ref EnabledDefaultValue); } }
        public bool AnimationEnabled {get { return _animationEnabled;} set { _animationEnabled=value; } }
        public bool AnimationEnabledHasValue {get { return !PrefabUtils.AreEqual(ref _animationEnabled, ref AnimationEnabledDefaultValue); } }
        public bool Temporary {get { return _temporary;} set { _temporary=value; } }
        public bool TemporaryHasValue {get { return !PrefabUtils.AreEqual(ref _temporary, ref TemporaryDefaultValue); } }
        public bool BlockEvents {get { return _blockEvents;} set { _blockEvents=value; } }
        public bool BlockEventsHasValue {get { return !PrefabUtils.AreEqual(ref _blockEvents, ref BlockEventsDefaultValue); } }
        public override DynamicNavigationMesh Create()
        {
            var result = new DynamicNavigationMesh();
            if(MaxObstaclesHasValue)
                result.MaxObstacles = _maxObstacles;
            if(MaxLayersHasValue)
                result.MaxLayers = _maxLayers;
            if(DrawObstaclesHasValue)
                result.DrawObstacles = _drawObstacles;
            if(TileSizeHasValue)
                result.TileSize = _tileSize;
            if(CellSizeHasValue)
                result.CellSize = _cellSize;
            if(CellHeightHasValue)
                result.CellHeight = _cellHeight;
            if(AgentHeightHasValue)
                result.AgentHeight = _agentHeight;
            if(AgentRadiusHasValue)
                result.AgentRadius = _agentRadius;
            if(AgentMaxClimbHasValue)
                result.AgentMaxClimb = _agentMaxClimb;
            if(AgentMaxSlopeHasValue)
                result.AgentMaxSlope = _agentMaxSlope;
            if(RegionMinSizeHasValue)
                result.RegionMinSize = _regionMinSize;
            if(RegionMergeSizeHasValue)
                result.RegionMergeSize = _regionMergeSize;
            if(EdgeMaxLengthHasValue)
                result.EdgeMaxLength = _edgeMaxLength;
            if(EdgeMaxErrorHasValue)
                result.EdgeMaxError = _edgeMaxError;
            if(DetailSampleDistanceHasValue)
                result.DetailSampleDistance = _detailSampleDistance;
            if(DetailSampleMaxErrorHasValue)
                result.DetailSampleMaxError = _detailSampleMaxError;
            if(PaddingHasValue)
                result.Padding = _padding;
            if(PartitionTypeHasValue)
                result.PartitionType = _partitionType;
            if(DrawOffMeshConnectionsHasValue)
                result.DrawOffMeshConnections = _drawOffMeshConnections;
            if(DrawNavAreasHasValue)
                result.DrawNavAreas = _drawNavAreas;
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
                case "MaxObstacles":
                    break;
                case "MaxLayers":
                    break;
                case "DrawObstacles":
                    break;
                case "TileSize":
                    break;
                case "CellSize":
                    break;
                case "CellHeight":
                    break;
                case "AgentHeight":
                    break;
                case "AgentRadius":
                    break;
                case "AgentMaxClimb":
                    break;
                case "AgentMaxSlope":
                    break;
                case "RegionMinSize":
                    break;
                case "RegionMergeSize":
                    break;
                case "EdgeMaxLength":
                    break;
                case "EdgeMaxError":
                    break;
                case "DetailSampleDistance":
                    break;
                case "DetailSampleMaxError":
                    break;
                case "Padding":
                    break;
                case "PartitionType":
                    break;
                case "DrawOffMeshConnections":
                    break;
                case "DrawNavAreas":
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
