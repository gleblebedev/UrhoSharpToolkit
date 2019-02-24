using System;
using Urho;
using Urho.Resources;
using Urho.Urho2D;

namespace UrhoSharp.Interfaces
{
    public interface IRenderer
    {
        uint NumViewports { get; set; }
        RenderPath DefaultRenderPath { get; set; }
        Technique DefaultTechnique { get; set; }
        bool HDRRendering { get; set; }
        bool SpecularLighting { get; set; }
        int TextureAnisotropy { get; set; }
        TextureFilterMode TextureFilterMode { get; set; }
        int TextureQuality { get; set; }
        int MaterialQuality { get; set; }
        bool DrawShadows { get; set; }
        int ShadowMapSize { get; set; }
        ShadowQuality ShadowQuality { get; set; }
        float ShadowSoftness { get; set; }
        int VSMMultiSample { get; set; }
        bool ReuseShadowMaps { get; set; }
        int MaxShadowMaps { get; set; }
        bool DynamicInstancing { get; set; }
        int NumExtraInstancingBufferElements { get; set; }
        int MinInstances { get; set; }
        int MaxSortedInstances { get; set; }
        int MaxOccluderTriangles { get; set; }
        int OcclusionBufferSize { get; set; }
        float OccluderSizeThreshold { get; set; }
        bool ThreadedOcclusion { get; set; }
        float MobileShadowBiasMul { get; set; }
        float MobileShadowBiasAdd { get; set; }
        float MobileNormalOffsetMul { get; set; }
        Vector2 VSMShadowParameters { get; }
        uint NumViews { get; }
        uint NumPrimitives { get; }
        uint NumBatches { get; }
        Zone DefaultZone { get; }
        Material DefaultMaterial { get; }
        Texture2D DefaultLightRamp { get; }
        Texture2D DefaultLightSpot { get; }
        TextureCube FaceSelectCubeMap { get; }
        TextureCube IndirectionCubeMap { get; }
        VertexBuffer InstancingBuffer { get; }
        Geometry QuadGeometry { get; }
        Camera ShadowCamera { get; }
        void SetViewport(uint index, Viewport viewport);
        void SetDefaultRenderPath(XmlFile file);
        void SetVSMShadowParameters(float minVariance, float lightBleedingReduction);
        void ReloadShaders();
        void ApplyShadowMapFilter(View view, Texture2D shadowMap, float blurScale);
        Viewport GetViewport(uint index);
        Viewport GetViewportForScene(Scene scene, uint index);
        uint GetNumGeometries(bool allViews = false);
        uint GetNumLights(bool allViews = false);
        uint GetNumShadowMaps(bool allViews = false);
        uint GetNumOccluders(bool allViews = false);
        void DrawDebugGeometry(bool depthTest);
        void QueueRenderSurface(RenderSurface renderTarget);
        void QueueViewport(RenderSurface renderTarget, Viewport viewport);
        Geometry GetLightGeometry(Light light);
        Texture2D GetShadowMap(Light light, Camera camera, uint viewWidth, uint viewHeight);

        Texture GetScreenBuffer(int width, int height, uint format, int multiSample, bool autoResolve, bool cubemap,
            bool filtered, bool srgb, uint persistentKey = 0);

        RenderSurface GetDepthStencil(int width, int height, int multiSample, bool autoResolve);
        OcclusionBuffer GetOcclusionBuffer(Camera camera);
        void StorePreparedView(View view, Camera cullCamera);
        View GetPreparedView(Camera cullCamera);
        void SetCullMode(CullMode mode, Camera camera);
        bool ResizeInstancingBuffer(uint numInstances);
        void OptimizeLightByScissor(Light light, Camera camera);
        void OptimizeLightByStencil(Light light, Camera camera);
        event Action<RenderSurfaceUpdateEventArgs> RenderSurfaceUpdate;
        event Action<BeginViewRenderEventArgs> BeginViewRender;
        event Action<EndViewRenderEventArgs> EndViewRender;
    }
}