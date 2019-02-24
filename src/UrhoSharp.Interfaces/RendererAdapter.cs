using System;
using Urho;
using Urho.Resources;
using Urho.Urho2D;

namespace UrhoSharp.Interfaces
{
    public class RendererAdapter : IRenderer
    {
        private readonly Renderer _impl;

        public RendererAdapter(Renderer impl)
        {
            _impl = impl;
        }

        public void SetViewport(uint index, Viewport viewport)
        {
            _impl.SetViewport(index, viewport);
        }

        public void SetDefaultRenderPath(XmlFile file)
        {
            _impl.SetDefaultRenderPath(file);
        }

        public void SetVSMShadowParameters(float minVariance, float lightBleedingReduction)
        {
            _impl.SetVSMShadowParameters(minVariance, lightBleedingReduction);
        }

        public void ReloadShaders()
        {
            _impl.ReloadShaders();
        }

        public void ApplyShadowMapFilter(View view, Texture2D shadowMap, float blurScale)
        {
            _impl.ApplyShadowMapFilter(view, shadowMap, blurScale);
        }

        public Viewport GetViewport(uint index)
        {
            return _impl.GetViewport(index);
        }

        public Viewport GetViewportForScene(Scene scene, uint index)
        {
            return _impl.GetViewportForScene(scene, index);
        }

        public uint GetNumGeometries(bool allViews = false)
        {
            return _impl.GetNumGeometries(allViews);
        }

        public uint GetNumLights(bool allViews = false)
        {
            return _impl.GetNumLights(allViews);
        }

        public uint GetNumShadowMaps(bool allViews = false)
        {
            return _impl.GetNumShadowMaps(allViews);
        }

        public uint GetNumOccluders(bool allViews = false)
        {
            return _impl.GetNumOccluders(allViews);
        }

        public void DrawDebugGeometry(bool depthTest)
        {
            _impl.DrawDebugGeometry(depthTest);
        }

        public void QueueRenderSurface(RenderSurface renderTarget)
        {
            _impl.QueueRenderSurface(renderTarget);
        }

        public void QueueViewport(RenderSurface renderTarget, Viewport viewport)
        {
            _impl.QueueViewport(renderTarget, viewport);
        }

        public Geometry GetLightGeometry(Light light)
        {
            return _impl.GetLightGeometry(light);
        }

        public Texture2D GetShadowMap(Light light, Camera camera, uint viewWidth, uint viewHeight)
        {
            return _impl.GetShadowMap(light, camera, viewWidth, viewHeight);
        }

        public Texture GetScreenBuffer(int width, int height, uint format, int multiSample, bool autoResolve,
            bool cubemap,
            bool filtered, bool srgb, uint persistentKey = 0)
        {
            return _impl.GetScreenBuffer(width, height, format, multiSample, autoResolve, cubemap, filtered, srgb,
                persistentKey);
        }

        public RenderSurface GetDepthStencil(int width, int height, int multiSample, bool autoResolve)
        {
            return _impl.GetDepthStencil(width, height, multiSample, autoResolve);
        }

        public OcclusionBuffer GetOcclusionBuffer(Camera camera)
        {
            return _impl.GetOcclusionBuffer(camera);
        }

        public void StorePreparedView(View view, Camera cullCamera)
        {
            _impl.StorePreparedView(view, cullCamera);
        }

        public View GetPreparedView(Camera cullCamera)
        {
            return _impl.GetPreparedView(cullCamera);
        }

        public void SetCullMode(CullMode mode, Camera camera)
        {
            _impl.SetCullMode(mode, camera);
        }

        public bool ResizeInstancingBuffer(uint numInstances)
        {
            return _impl.ResizeInstancingBuffer(numInstances);
        }

        public void OptimizeLightByScissor(Light light, Camera camera)
        {
            _impl.OptimizeLightByScissor(light, camera);
        }

        public void OptimizeLightByStencil(Light light, Camera camera)
        {
            _impl.OptimizeLightByStencil(light, camera);
        }

        public uint NumViewports
        {
            get => _impl.NumViewports;
            set => _impl.NumViewports = value;
        }

        public RenderPath DefaultRenderPath
        {
            get => _impl.DefaultRenderPath;
            set => _impl.DefaultRenderPath = value;
        }

        public Technique DefaultTechnique
        {
            get => _impl.DefaultTechnique;
            set => _impl.DefaultTechnique = value;
        }

        public bool HDRRendering
        {
            get => _impl.HDRRendering;
            set => _impl.HDRRendering = value;
        }

        public bool SpecularLighting
        {
            get => _impl.SpecularLighting;
            set => _impl.SpecularLighting = value;
        }

        public int TextureAnisotropy
        {
            get => _impl.TextureAnisotropy;
            set => _impl.TextureAnisotropy = value;
        }

        public TextureFilterMode TextureFilterMode
        {
            get => _impl.TextureFilterMode;
            set => _impl.TextureFilterMode = value;
        }

        public int TextureQuality
        {
            get => _impl.TextureQuality;
            set => _impl.TextureQuality = value;
        }

        public int MaterialQuality
        {
            get => _impl.MaterialQuality;
            set => _impl.MaterialQuality = value;
        }

        public bool DrawShadows
        {
            get => _impl.DrawShadows;
            set => _impl.DrawShadows = value;
        }

        public int ShadowMapSize
        {
            get => _impl.ShadowMapSize;
            set => _impl.ShadowMapSize = value;
        }

        public ShadowQuality ShadowQuality
        {
            get => _impl.ShadowQuality;
            set => _impl.ShadowQuality = value;
        }

        public float ShadowSoftness
        {
            get => _impl.ShadowSoftness;
            set => _impl.ShadowSoftness = value;
        }

        public int VSMMultiSample
        {
            get => _impl.VSMMultiSample;
            set => _impl.VSMMultiSample = value;
        }

        public bool ReuseShadowMaps
        {
            get => _impl.ReuseShadowMaps;
            set => _impl.ReuseShadowMaps = value;
        }

        public int MaxShadowMaps
        {
            get => _impl.MaxShadowMaps;
            set => _impl.MaxShadowMaps = value;
        }

        public bool DynamicInstancing
        {
            get => _impl.DynamicInstancing;
            set => _impl.DynamicInstancing = value;
        }

        public int NumExtraInstancingBufferElements
        {
            get => _impl.NumExtraInstancingBufferElements;
            set => _impl.NumExtraInstancingBufferElements = value;
        }

        public int MinInstances
        {
            get => _impl.MinInstances;
            set => _impl.MinInstances = value;
        }

        public int MaxSortedInstances
        {
            get => _impl.MaxSortedInstances;
            set => _impl.MaxSortedInstances = value;
        }

        public int MaxOccluderTriangles
        {
            get => _impl.MaxOccluderTriangles;
            set => _impl.MaxOccluderTriangles = value;
        }

        public int OcclusionBufferSize
        {
            get => _impl.OcclusionBufferSize;
            set => _impl.OcclusionBufferSize = value;
        }

        public float OccluderSizeThreshold
        {
            get => _impl.OccluderSizeThreshold;
            set => _impl.OccluderSizeThreshold = value;
        }

        public bool ThreadedOcclusion
        {
            get => _impl.ThreadedOcclusion;
            set => _impl.ThreadedOcclusion = value;
        }

        public float MobileShadowBiasMul
        {
            get => _impl.MobileShadowBiasMul;
            set => _impl.MobileShadowBiasMul = value;
        }

        public float MobileShadowBiasAdd
        {
            get => _impl.MobileShadowBiasAdd;
            set => _impl.MobileShadowBiasAdd = value;
        }

        public float MobileNormalOffsetMul
        {
            get => _impl.MobileNormalOffsetMul;
            set => _impl.MobileNormalOffsetMul = value;
        }

        public Vector2 VSMShadowParameters => _impl.VSMShadowParameters;

        public uint NumViews => _impl.NumViews;

        public uint NumPrimitives => _impl.NumPrimitives;

        public uint NumBatches => _impl.NumBatches;

        public Zone DefaultZone => _impl.DefaultZone;

        public Material DefaultMaterial => _impl.DefaultMaterial;

        public Texture2D DefaultLightRamp => _impl.DefaultLightRamp;

        public Texture2D DefaultLightSpot => _impl.DefaultLightSpot;

        public TextureCube FaceSelectCubeMap => _impl.FaceSelectCubeMap;

        public TextureCube IndirectionCubeMap => _impl.IndirectionCubeMap;

        public VertexBuffer InstancingBuffer => _impl.InstancingBuffer;

        public Geometry QuadGeometry => _impl.QuadGeometry;

        public Camera ShadowCamera => _impl.ShadowCamera;

        public event Action<RenderSurfaceUpdateEventArgs> RenderSurfaceUpdate
        {
            add => _impl.RenderSurfaceUpdate += value;
            remove => _impl.RenderSurfaceUpdate -= value;
        }

        public event Action<BeginViewRenderEventArgs> BeginViewRender
        {
            add => _impl.BeginViewRender += value;
            remove => _impl.BeginViewRender -= value;
        }

        public event Action<EndViewRenderEventArgs> EndViewRender
        {
            add => _impl.EndViewRender += value;
            remove => _impl.EndViewRender -= value;
        }
    }
}