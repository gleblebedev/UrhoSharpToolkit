using Urho;
using Urho.Audio;
using Urho.Gui;
using Urho.Navigation;
using Urho.Network;
using Urho.Physics;
using Urho.Portable;
using Urho.Shapes;
using Urho.Urho2D;
using Plane = Urho.Plane;

namespace UrhoSharp.Prefabs
{
    public class ComponentFactory
    {
        public IComponentPrefab CreateComponent(Component component)
        {
            switch (component.Type.Code)
            {
                case 1364112997: return new CameraPrefab((Camera)component);
                case -1136515728: return new RibbonTrailPrefab((RibbonTrail)component);
                case 121334427: return new StaticModelPrefab((StaticModel)component);
                //case 121334427: return new BoxPrefab((Box)component);
                //case 121334427: return new ConePrefab((Cone)component);
                //case 121334427: return new CylinderPrefab((Cylinder)component);
                //case 121334427: return new PlanePrefab((Plane)component);
                //case 121334427: return new PyramidPrefab((Pyramid)component);
                //case 121334427: return new SpherePrefab((Sphere)component);
                //case 121334427: return new TorusPrefab((Torus)component);
                case 181454470: return new AnimatedModelPrefab((AnimatedModel)component);
                case -884169025: return new LogicComponentPrefab((LogicComponent)component);
                case -555236963: return new ComponentPrefab((Component)component);
                //case -555236963: return new WirePlanePrefab((WirePlane)component);
                //case -555236963: return new ScriptInstancePrefab((ScriptInstance)component);
                case 1305921859: return new BillboardSetPrefab((BillboardSet)component);
                case -1554111520: return new AnimationControllerPrefab((AnimationController)component);
                case 564774307: return new CustomGeometryPrefab((CustomGeometry)component);
                case 327000022: return new DebugRendererPrefab((DebugRenderer)component);
                case 1534673685: return new DecalSetPrefab((DecalSet)component);
                case -266073674: return new LightPrefab((Light)component);
                case -227627531: return new TerrainPrefab((Terrain)component);
                case -1996169729: return new SmoothedTransformPrefab((SmoothedTransform)component);
                case 793083634: return new OctreePrefab((Octree)component);
                case -411558968: return new ParticleEmitterPrefab((ParticleEmitter)component);
                case -2010834390: return new SkyboxPrefab((Skybox)component);
                case -2032810218: return new SplinePathPrefab((SplinePath)component);
                case 854129604: return new StaticModelGroupPrefab((StaticModelGroup)component);
                case 524512339: return new TerrainPatchPrefab((TerrainPatch)component);
                case 0: return new UnknownComponentPrefab((UnknownComponent)component);
                case 1666600812: return new ZonePrefab((Zone)component);
                case 2136168809: return new UIComponentPrefab((UIComponent)component);
                case 687004888: return new CrowdAgentPrefab((CrowdAgent)component);
                case 353363072: return new CrowdManagerPrefab((CrowdManager)component);
                case -1682223136: return new DynamicNavigationMeshPrefab((DynamicNavigationMesh)component);
                case -1781254192: return new NavAreaPrefab((NavArea)component);
                case 1956588603: return new NavigablePrefab((Navigable)component);
                case -1296913343: return new NavigationMeshPrefab((NavigationMesh)component);
                case 1080511791: return new ObstaclePrefab((Obstacle)component);
                case 2110062362: return new OffMeshConnectionPrefab((OffMeshConnection)component);
                case -522094370: return new Text3DPrefab((Text3D)component);
                case -2026052814: return new NetworkPriorityPrefab((NetworkPriority)component);
                case 938043215: return new CollisionShapePrefab((CollisionShape)component);
                case -2077232227: return new ConstraintPrefab((Constraint)component);
                case -1285203093: return new PhysicsWorldPrefab((PhysicsWorld)component);
                case -1238354931: return new RigidBodyPrefab((RigidBody)component);
                case 253947139: return new SoundListenerPrefab((SoundListener)component);
                case 368456554: return new SoundSourcePrefab((SoundSource)component);
                case -864933029: return new SoundSource3DPrefab((SoundSource3D)component);
                case 1175295226: return new AnimatedSprite2DPrefab((AnimatedSprite2D)component);
                case 100410059: return new CollisionBox2DPrefab((CollisionBox2D)component);
                case 248425153: return new CollisionChain2DPrefab((CollisionChain2D)component);
                case -1022519180: return new CollisionCircle2DPrefab((CollisionCircle2D)component);
                case -181678911: return new CollisionEdge2DPrefab((CollisionEdge2D)component);
                case -1588331462: return new CollisionPolygon2DPrefab((CollisionPolygon2D)component);
                case 1390936527: return new Constraint2DPrefab((Constraint2D)component);
                case 599967012: return new ConstraintDistance2DPrefab((ConstraintDistance2D)component);
                case -549789495: return new ConstraintFriction2DPrefab((ConstraintFriction2D)component);
                case -135372706: return new ConstraintGear2DPrefab((ConstraintGear2D)component);
                case -452097590: return new ConstraintMotor2DPrefab((ConstraintMotor2D)component);
                case -592551366: return new ConstraintMouse2DPrefab((ConstraintMouse2D)component);
                case -105605117: return new ConstraintPrismatic2DPrefab((ConstraintPrismatic2D)component);
                case 521737512: return new ConstraintPulley2DPrefab((ConstraintPulley2D)component);
                case 717978805: return new ConstraintRevolute2DPrefab((ConstraintRevolute2D)component);
                case 1183954369: return new ConstraintRope2DPrefab((ConstraintRope2D)component);
                case 1402639221: return new ConstraintWeld2DPrefab((ConstraintWeld2D)component);
                case -663610224: return new ConstraintWheel2DPrefab((ConstraintWheel2D)component);
                case 1430938269: return new PhysicsWorld2DPrefab((PhysicsWorld2D)component);
                case 1506329722: return new ParticleEmitter2DPrefab((ParticleEmitter2D)component);
                case -1905001291: return new Renderer2DPrefab((Renderer2D)component);
                case 1072630335: return new RigidBody2DPrefab((RigidBody2D)component);
                case -403894107: return new StaticSprite2DPrefab((StaticSprite2D)component);
                case 1738366208: return new TileMap2DPrefab((TileMap2D)component);
                case 225050485: return new TileMapLayer2DPrefab((TileMapLayer2D)component);
                default:
                    return null;
            }
        }
    }
}