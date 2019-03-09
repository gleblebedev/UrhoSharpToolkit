using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using DynamicNavigationMesh = Urho.Navigation.DynamicNavigationMesh;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public partial class DynamicNavigationMeshPrefab: AbstractComponentPrefab<DynamicNavigationMesh>, IPrefab
    {
        public override string TypeName { get { return DynamicNavigationMesh.TypeNameStatic; } }
        public uint MaxObstacles { get; set; }
        public uint MaxLayers { get; set; }
        public bool DrawObstacles { get; set; }
        public int TileSize { get; set; }
        public float CellSize { get; set; }
        public float CellHeight { get; set; }
        public float AgentHeight { get; set; }
        public float AgentRadius { get; set; }
        public float AgentMaxClimb { get; set; }
        public float AgentMaxSlope { get; set; }
        public float RegionMinSize { get; set; }
        public float RegionMergeSize { get; set; }
        public float EdgeMaxLength { get; set; }
        public float EdgeMaxError { get; set; }
        public float DetailSampleDistance { get; set; }
        public float DetailSampleMaxError { get; set; }
        public Vector3 Padding { get; set; }
        public NavmeshPartitionType PartitionType { get; set; }
        public bool DrawOffMeshConnections { get; set; }
        public bool DrawNavAreas { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public DynamicNavigationMeshPrefab()
        {
            MaxObstacles = MaxObstaclesAccessor.DefaultValue;
            MaxLayers = MaxLayersAccessor.DefaultValue;
            DrawObstacles = DrawObstaclesAccessor.DefaultValue;
            TileSize = TileSizeAccessor.DefaultValue;
            CellSize = CellSizeAccessor.DefaultValue;
            CellHeight = CellHeightAccessor.DefaultValue;
            AgentHeight = AgentHeightAccessor.DefaultValue;
            AgentRadius = AgentRadiusAccessor.DefaultValue;
            AgentMaxClimb = AgentMaxClimbAccessor.DefaultValue;
            AgentMaxSlope = AgentMaxSlopeAccessor.DefaultValue;
            RegionMinSize = RegionMinSizeAccessor.DefaultValue;
            RegionMergeSize = RegionMergeSizeAccessor.DefaultValue;
            EdgeMaxLength = EdgeMaxLengthAccessor.DefaultValue;
            EdgeMaxError = EdgeMaxErrorAccessor.DefaultValue;
            DetailSampleDistance = DetailSampleDistanceAccessor.DefaultValue;
            DetailSampleMaxError = DetailSampleMaxErrorAccessor.DefaultValue;
            Padding = PaddingAccessor.DefaultValue;
            PartitionType = PartitionTypeAccessor.DefaultValue;
            DrawOffMeshConnections = DrawOffMeshConnectionsAccessor.DefaultValue;
            DrawNavAreas = DrawNavAreasAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public DynamicNavigationMeshPrefab(DynamicNavigationMesh val)
        {
            ID = val.ID;
            MaxObstacles = val.MaxObstacles;
            MaxLayers = val.MaxLayers;
            DrawObstacles = val.DrawObstacles;
            TileSize = val.TileSize;
            CellSize = val.CellSize;
            CellHeight = val.CellHeight;
            AgentHeight = val.AgentHeight;
            AgentRadius = val.AgentRadius;
            AgentMaxClimb = val.AgentMaxClimb;
            AgentMaxSlope = val.AgentMaxSlope;
            RegionMinSize = val.RegionMinSize;
            RegionMergeSize = val.RegionMergeSize;
            EdgeMaxLength = val.EdgeMaxLength;
            EdgeMaxError = val.EdgeMaxError;
            DetailSampleDistance = val.DetailSampleDistance;
            DetailSampleMaxError = val.DetailSampleMaxError;
            Padding = val.Padding;
            PartitionType = val.PartitionType;
            DrawOffMeshConnections = val.DrawOffMeshConnections;
            DrawNavAreas = val.DrawNavAreas;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override DynamicNavigationMesh Create()
        {
            var result = new DynamicNavigationMesh();
            MaxObstaclesAccessor.Instance.ApplyIfChanged(this, result);
            MaxLayersAccessor.Instance.ApplyIfChanged(this, result);
            DrawObstaclesAccessor.Instance.ApplyIfChanged(this, result);
            TileSizeAccessor.Instance.ApplyIfChanged(this, result);
            CellSizeAccessor.Instance.ApplyIfChanged(this, result);
            CellHeightAccessor.Instance.ApplyIfChanged(this, result);
            AgentHeightAccessor.Instance.ApplyIfChanged(this, result);
            AgentRadiusAccessor.Instance.ApplyIfChanged(this, result);
            AgentMaxClimbAccessor.Instance.ApplyIfChanged(this, result);
            AgentMaxSlopeAccessor.Instance.ApplyIfChanged(this, result);
            RegionMinSizeAccessor.Instance.ApplyIfChanged(this, result);
            RegionMergeSizeAccessor.Instance.ApplyIfChanged(this, result);
            EdgeMaxLengthAccessor.Instance.ApplyIfChanged(this, result);
            EdgeMaxErrorAccessor.Instance.ApplyIfChanged(this, result);
            DetailSampleDistanceAccessor.Instance.ApplyIfChanged(this, result);
            DetailSampleMaxErrorAccessor.Instance.ApplyIfChanged(this, result);
            PaddingAccessor.Instance.ApplyIfChanged(this, result);
            PartitionTypeAccessor.Instance.ApplyIfChanged(this, result);
            DrawOffMeshConnectionsAccessor.Instance.ApplyIfChanged(this, result);
            DrawNavAreasAccessor.Instance.ApplyIfChanged(this, result);
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
                case "MaxObstacles":
                    MaxObstaclesAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxLayers":
                    MaxLayersAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawObstacles":
                    DrawObstaclesAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "TileSize":
                    TileSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CellSize":
                    CellSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CellHeight":
                    CellHeightAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AgentHeight":
                    AgentHeightAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AgentRadius":
                    AgentRadiusAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AgentMaxClimb":
                    AgentMaxClimbAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AgentMaxSlope":
                    AgentMaxSlopeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "RegionMinSize":
                    RegionMinSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "RegionMergeSize":
                    RegionMergeSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EdgeMaxLength":
                    EdgeMaxLengthAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EdgeMaxError":
                    EdgeMaxErrorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DetailSampleDistance":
                    DetailSampleDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DetailSampleMaxError":
                    DetailSampleMaxErrorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Padding":
                    PaddingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "PartitionType":
                    PartitionTypeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawOffMeshConnections":
                    DrawOffMeshConnectionsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawNavAreas":
                    DrawNavAreasAccessor.Instance.ParseAndSet(value, this);
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
                yield return MaxObstaclesAccessor.Instance;
                yield return MaxLayersAccessor.Instance;
                yield return DrawObstaclesAccessor.Instance;
                yield return TileSizeAccessor.Instance;
                yield return CellSizeAccessor.Instance;
                yield return CellHeightAccessor.Instance;
                yield return AgentHeightAccessor.Instance;
                yield return AgentRadiusAccessor.Instance;
                yield return AgentMaxClimbAccessor.Instance;
                yield return AgentMaxSlopeAccessor.Instance;
                yield return RegionMinSizeAccessor.Instance;
                yield return RegionMergeSizeAccessor.Instance;
                yield return EdgeMaxLengthAccessor.Instance;
                yield return EdgeMaxErrorAccessor.Instance;
                yield return DetailSampleDistanceAccessor.Instance;
                yield return DetailSampleMaxErrorAccessor.Instance;
                yield return PaddingAccessor.Instance;
                yield return PartitionTypeAccessor.Instance;
                yield return DrawOffMeshConnectionsAccessor.Instance;
                yield return DrawNavAreasAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class MaxObstaclesAccessor : UInt32Accessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly MaxObstaclesAccessor Instance = new MaxObstaclesAccessor();
            public static readonly uint DefaultValue = 1024;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.MaxObstacles);
            public override uint GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.MaxObstacles; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, uint value) { instance.MaxObstacles = value; }
            public override uint GetUrho(DynamicNavigationMesh instance) { return instance.MaxObstacles; }
            public override void SetUrho(DynamicNavigationMesh instance, uint value) { instance.MaxObstacles = value; }
        }

        internal class MaxLayersAccessor : UInt32Accessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly MaxLayersAccessor Instance = new MaxLayersAccessor();
            public static readonly uint DefaultValue = 16;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.MaxLayers);
            public override uint GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.MaxLayers; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, uint value) { instance.MaxLayers = value; }
            public override uint GetUrho(DynamicNavigationMesh instance) { return instance.MaxLayers; }
            public override void SetUrho(DynamicNavigationMesh instance, uint value) { instance.MaxLayers = value; }
        }

        internal class DrawObstaclesAccessor : BooleanAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly DrawObstaclesAccessor Instance = new DrawObstaclesAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.DrawObstacles);
            public override bool GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.DrawObstacles; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, bool value) { instance.DrawObstacles = value; }
            public override bool GetUrho(DynamicNavigationMesh instance) { return instance.DrawObstacles; }
            public override void SetUrho(DynamicNavigationMesh instance, bool value) { instance.DrawObstacles = value; }
        }

        internal class TileSizeAccessor : Int32Accessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly TileSizeAccessor Instance = new TileSizeAccessor();
            public static readonly int DefaultValue = 64;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.TileSize);
            public override int GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.TileSize; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, int value) { instance.TileSize = value; }
            public override int GetUrho(DynamicNavigationMesh instance) { return instance.TileSize; }
            public override void SetUrho(DynamicNavigationMesh instance, int value) { instance.TileSize = value; }
        }

        internal class CellSizeAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly CellSizeAccessor Instance = new CellSizeAccessor();
            public static readonly float DefaultValue = 0.3f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.CellSize);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.CellSize; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.CellSize = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.CellSize; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.CellSize = value; }
        }

        internal class CellHeightAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly CellHeightAccessor Instance = new CellHeightAccessor();
            public static readonly float DefaultValue = 0.2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.CellHeight);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.CellHeight; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.CellHeight = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.CellHeight; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.CellHeight = value; }
        }

        internal class AgentHeightAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly AgentHeightAccessor Instance = new AgentHeightAccessor();
            public static readonly float DefaultValue = 2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.AgentHeight);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.AgentHeight; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.AgentHeight = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.AgentHeight; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.AgentHeight = value; }
        }

        internal class AgentRadiusAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly AgentRadiusAccessor Instance = new AgentRadiusAccessor();
            public static readonly float DefaultValue = 0.6f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.AgentRadius);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.AgentRadius; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.AgentRadius = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.AgentRadius; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.AgentRadius = value; }
        }

        internal class AgentMaxClimbAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly AgentMaxClimbAccessor Instance = new AgentMaxClimbAccessor();
            public static readonly float DefaultValue = 0.9f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.AgentMaxClimb);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.AgentMaxClimb; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.AgentMaxClimb = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.AgentMaxClimb; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.AgentMaxClimb = value; }
        }

        internal class AgentMaxSlopeAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly AgentMaxSlopeAccessor Instance = new AgentMaxSlopeAccessor();
            public static readonly float DefaultValue = 45f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.AgentMaxSlope);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.AgentMaxSlope; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.AgentMaxSlope = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.AgentMaxSlope; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.AgentMaxSlope = value; }
        }

        internal class RegionMinSizeAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly RegionMinSizeAccessor Instance = new RegionMinSizeAccessor();
            public static readonly float DefaultValue = 8f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.RegionMinSize);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.RegionMinSize; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.RegionMinSize = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.RegionMinSize; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.RegionMinSize = value; }
        }

        internal class RegionMergeSizeAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly RegionMergeSizeAccessor Instance = new RegionMergeSizeAccessor();
            public static readonly float DefaultValue = 20f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.RegionMergeSize);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.RegionMergeSize; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.RegionMergeSize = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.RegionMergeSize; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.RegionMergeSize = value; }
        }

        internal class EdgeMaxLengthAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly EdgeMaxLengthAccessor Instance = new EdgeMaxLengthAccessor();
            public static readonly float DefaultValue = 12f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.EdgeMaxLength);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.EdgeMaxLength; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.EdgeMaxLength = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.EdgeMaxLength; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.EdgeMaxLength = value; }
        }

        internal class EdgeMaxErrorAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly EdgeMaxErrorAccessor Instance = new EdgeMaxErrorAccessor();
            public static readonly float DefaultValue = 1.3f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.EdgeMaxError);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.EdgeMaxError; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.EdgeMaxError = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.EdgeMaxError; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.EdgeMaxError = value; }
        }

        internal class DetailSampleDistanceAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly DetailSampleDistanceAccessor Instance = new DetailSampleDistanceAccessor();
            public static readonly float DefaultValue = 6f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.DetailSampleDistance);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.DetailSampleDistance; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.DetailSampleDistance = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.DetailSampleDistance; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.DetailSampleDistance = value; }
        }

        internal class DetailSampleMaxErrorAccessor : SingleAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly DetailSampleMaxErrorAccessor Instance = new DetailSampleMaxErrorAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.DetailSampleMaxError);
            public override float GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.DetailSampleMaxError; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, float value) { instance.DetailSampleMaxError = value; }
            public override float GetUrho(DynamicNavigationMesh instance) { return instance.DetailSampleMaxError; }
            public override void SetUrho(DynamicNavigationMesh instance, float value) { instance.DetailSampleMaxError = value; }
        }

        internal class PaddingAccessor : Vector3Accessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly PaddingAccessor Instance = new PaddingAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(1f, 1f, 1f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.Padding);
            public override Vector3 GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.Padding; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, Vector3 value) { instance.Padding = value; }
            public override Vector3 GetUrho(DynamicNavigationMesh instance) { return instance.Padding; }
            public override void SetUrho(DynamicNavigationMesh instance, Vector3 value) { instance.Padding = value; }
        }

        internal class PartitionTypeAccessor : EnumAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh, NavmeshPartitionType>
        {
            public static readonly PartitionTypeAccessor Instance = new PartitionTypeAccessor();
            public static readonly NavmeshPartitionType DefaultValue = NavmeshPartitionType.Monotone;
            public override NavmeshPartitionType DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.PartitionType);
            public override NavmeshPartitionType GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.PartitionType; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, NavmeshPartitionType value) { instance.PartitionType = value; }
            public override NavmeshPartitionType GetUrho(DynamicNavigationMesh instance) { return instance.PartitionType; }
            public override void SetUrho(DynamicNavigationMesh instance, NavmeshPartitionType value) { instance.PartitionType = value; }
        }

        internal class DrawOffMeshConnectionsAccessor : BooleanAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly DrawOffMeshConnectionsAccessor Instance = new DrawOffMeshConnectionsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.DrawOffMeshConnections);
            public override bool GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.DrawOffMeshConnections; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, bool value) { instance.DrawOffMeshConnections = value; }
            public override bool GetUrho(DynamicNavigationMesh instance) { return instance.DrawOffMeshConnections; }
            public override void SetUrho(DynamicNavigationMesh instance, bool value) { instance.DrawOffMeshConnections = value; }
        }

        internal class DrawNavAreasAccessor : BooleanAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly DrawNavAreasAccessor Instance = new DrawNavAreasAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.DrawNavAreas);
            public override bool GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.DrawNavAreas; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, bool value) { instance.DrawNavAreas = value; }
            public override bool GetUrho(DynamicNavigationMesh instance) { return instance.DrawNavAreas; }
            public override void SetUrho(DynamicNavigationMesh instance, bool value) { instance.DrawNavAreas = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.Enabled);
            public override bool GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(DynamicNavigationMesh instance) { return instance.Enabled; }
            public override void SetUrho(DynamicNavigationMesh instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.AnimationEnabled);
            public override bool GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(DynamicNavigationMesh instance) { return instance.AnimationEnabled; }
            public override void SetUrho(DynamicNavigationMesh instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.Temporary);
            public override bool GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(DynamicNavigationMesh instance) { return instance.Temporary; }
            public override void SetUrho(DynamicNavigationMesh instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<DynamicNavigationMeshPrefab, DynamicNavigationMesh>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(DynamicNavigationMesh.BlockEvents);
            public override bool GetPrefab(DynamicNavigationMeshPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(DynamicNavigationMeshPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(DynamicNavigationMesh instance) { return instance.BlockEvents; }
            public override void SetUrho(DynamicNavigationMesh instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
