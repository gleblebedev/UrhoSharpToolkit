using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using NavigationMesh = Urho.Navigation.NavigationMesh;

using Urho.Navigation;

namespace UrhoSharp.Prefabs
{
    public partial class NavigationMeshPrefab: AbstractComponentPrefab<NavigationMesh>, IPrefab
    {
        public override string TypeName { get { return NavigationMesh.TypeNameStatic; } }
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
        public NavigationMeshPrefab()
        {
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
        public NavigationMeshPrefab(NavigationMesh val)
        {
            ID = val.ID;
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
        public override NavigationMesh Create()
        {
            var result = new NavigationMesh();
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

        internal class TileSizeAccessor : Int32Accessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly TileSizeAccessor Instance = new TileSizeAccessor();
            public static readonly int DefaultValue = 128;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.TileSize);
            public override int GetPrefab(NavigationMeshPrefab instance) { return instance.TileSize; }
            public override void SetPrefab(NavigationMeshPrefab instance, int value) { instance.TileSize = value; }
            public override int GetUrho(NavigationMesh instance) { return instance.TileSize; }
            public override void SetUrho(NavigationMesh instance, int value) { instance.TileSize = value; }
        }

        internal class CellSizeAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly CellSizeAccessor Instance = new CellSizeAccessor();
            public static readonly float DefaultValue = 0.3f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.CellSize);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.CellSize; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.CellSize = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.CellSize; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.CellSize = value; }
        }

        internal class CellHeightAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly CellHeightAccessor Instance = new CellHeightAccessor();
            public static readonly float DefaultValue = 0.2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.CellHeight);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.CellHeight; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.CellHeight = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.CellHeight; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.CellHeight = value; }
        }

        internal class AgentHeightAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly AgentHeightAccessor Instance = new AgentHeightAccessor();
            public static readonly float DefaultValue = 2f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.AgentHeight);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.AgentHeight; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.AgentHeight = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.AgentHeight; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.AgentHeight = value; }
        }

        internal class AgentRadiusAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly AgentRadiusAccessor Instance = new AgentRadiusAccessor();
            public static readonly float DefaultValue = 0.6f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.AgentRadius);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.AgentRadius; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.AgentRadius = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.AgentRadius; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.AgentRadius = value; }
        }

        internal class AgentMaxClimbAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly AgentMaxClimbAccessor Instance = new AgentMaxClimbAccessor();
            public static readonly float DefaultValue = 0.9f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.AgentMaxClimb);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.AgentMaxClimb; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.AgentMaxClimb = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.AgentMaxClimb; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.AgentMaxClimb = value; }
        }

        internal class AgentMaxSlopeAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly AgentMaxSlopeAccessor Instance = new AgentMaxSlopeAccessor();
            public static readonly float DefaultValue = 45f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.AgentMaxSlope);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.AgentMaxSlope; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.AgentMaxSlope = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.AgentMaxSlope; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.AgentMaxSlope = value; }
        }

        internal class RegionMinSizeAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly RegionMinSizeAccessor Instance = new RegionMinSizeAccessor();
            public static readonly float DefaultValue = 8f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.RegionMinSize);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.RegionMinSize; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.RegionMinSize = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.RegionMinSize; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.RegionMinSize = value; }
        }

        internal class RegionMergeSizeAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly RegionMergeSizeAccessor Instance = new RegionMergeSizeAccessor();
            public static readonly float DefaultValue = 20f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.RegionMergeSize);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.RegionMergeSize; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.RegionMergeSize = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.RegionMergeSize; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.RegionMergeSize = value; }
        }

        internal class EdgeMaxLengthAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly EdgeMaxLengthAccessor Instance = new EdgeMaxLengthAccessor();
            public static readonly float DefaultValue = 12f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.EdgeMaxLength);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.EdgeMaxLength; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.EdgeMaxLength = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.EdgeMaxLength; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.EdgeMaxLength = value; }
        }

        internal class EdgeMaxErrorAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly EdgeMaxErrorAccessor Instance = new EdgeMaxErrorAccessor();
            public static readonly float DefaultValue = 1.3f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.EdgeMaxError);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.EdgeMaxError; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.EdgeMaxError = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.EdgeMaxError; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.EdgeMaxError = value; }
        }

        internal class DetailSampleDistanceAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly DetailSampleDistanceAccessor Instance = new DetailSampleDistanceAccessor();
            public static readonly float DefaultValue = 6f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.DetailSampleDistance);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.DetailSampleDistance; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.DetailSampleDistance = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.DetailSampleDistance; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.DetailSampleDistance = value; }
        }

        internal class DetailSampleMaxErrorAccessor : SingleAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly DetailSampleMaxErrorAccessor Instance = new DetailSampleMaxErrorAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.DetailSampleMaxError);
            public override float GetPrefab(NavigationMeshPrefab instance) { return instance.DetailSampleMaxError; }
            public override void SetPrefab(NavigationMeshPrefab instance, float value) { instance.DetailSampleMaxError = value; }
            public override float GetUrho(NavigationMesh instance) { return instance.DetailSampleMaxError; }
            public override void SetUrho(NavigationMesh instance, float value) { instance.DetailSampleMaxError = value; }
        }

        internal class PaddingAccessor : Vector3Accessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly PaddingAccessor Instance = new PaddingAccessor();
            public static readonly Vector3 DefaultValue = new Vector3(1f, 1f, 1f);
            public override Vector3 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.Padding);
            public override Vector3 GetPrefab(NavigationMeshPrefab instance) { return instance.Padding; }
            public override void SetPrefab(NavigationMeshPrefab instance, Vector3 value) { instance.Padding = value; }
            public override Vector3 GetUrho(NavigationMesh instance) { return instance.Padding; }
            public override void SetUrho(NavigationMesh instance, Vector3 value) { instance.Padding = value; }
        }

        internal class PartitionTypeAccessor : EnumAccessor<NavigationMeshPrefab, NavigationMesh, NavmeshPartitionType>
        {
            public static readonly PartitionTypeAccessor Instance = new PartitionTypeAccessor();
            public static readonly NavmeshPartitionType DefaultValue = NavmeshPartitionType.Watershed;
            public override NavmeshPartitionType DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.PartitionType);
            public override NavmeshPartitionType GetPrefab(NavigationMeshPrefab instance) { return instance.PartitionType; }
            public override void SetPrefab(NavigationMeshPrefab instance, NavmeshPartitionType value) { instance.PartitionType = value; }
            public override NavmeshPartitionType GetUrho(NavigationMesh instance) { return instance.PartitionType; }
            public override void SetUrho(NavigationMesh instance, NavmeshPartitionType value) { instance.PartitionType = value; }
        }

        internal class DrawOffMeshConnectionsAccessor : BooleanAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly DrawOffMeshConnectionsAccessor Instance = new DrawOffMeshConnectionsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.DrawOffMeshConnections);
            public override bool GetPrefab(NavigationMeshPrefab instance) { return instance.DrawOffMeshConnections; }
            public override void SetPrefab(NavigationMeshPrefab instance, bool value) { instance.DrawOffMeshConnections = value; }
            public override bool GetUrho(NavigationMesh instance) { return instance.DrawOffMeshConnections; }
            public override void SetUrho(NavigationMesh instance, bool value) { instance.DrawOffMeshConnections = value; }
        }

        internal class DrawNavAreasAccessor : BooleanAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly DrawNavAreasAccessor Instance = new DrawNavAreasAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.DrawNavAreas);
            public override bool GetPrefab(NavigationMeshPrefab instance) { return instance.DrawNavAreas; }
            public override void SetPrefab(NavigationMeshPrefab instance, bool value) { instance.DrawNavAreas = value; }
            public override bool GetUrho(NavigationMesh instance) { return instance.DrawNavAreas; }
            public override void SetUrho(NavigationMesh instance, bool value) { instance.DrawNavAreas = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.Enabled);
            public override bool GetPrefab(NavigationMeshPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(NavigationMeshPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(NavigationMesh instance) { return instance.Enabled; }
            public override void SetUrho(NavigationMesh instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.AnimationEnabled);
            public override bool GetPrefab(NavigationMeshPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(NavigationMeshPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(NavigationMesh instance) { return instance.AnimationEnabled; }
            public override void SetUrho(NavigationMesh instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.Temporary);
            public override bool GetPrefab(NavigationMeshPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(NavigationMeshPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(NavigationMesh instance) { return instance.Temporary; }
            public override void SetUrho(NavigationMesh instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<NavigationMeshPrefab, NavigationMesh>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(NavigationMesh.BlockEvents);
            public override bool GetPrefab(NavigationMeshPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(NavigationMeshPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(NavigationMesh instance) { return instance.BlockEvents; }
            public override void SetUrho(NavigationMesh instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
