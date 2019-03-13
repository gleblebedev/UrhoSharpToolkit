using System;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Urho;
using Urho.Urho2D;
using UrhoSharp.Editor.Converters;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Editor.Model
{
    public class PreviewFactory
    {
        private readonly IHashFunction _hashFunction;
        private Texture2D _renderTexture;

        public PreviewFactory(ProjectReference project, IHashFunction hashFunction)
        {
            _hashFunction = hashFunction;
            _previewFolder = Path.Combine(project.Path, ".meta\\previews");
            Directory.CreateDirectory(_previewFolder);
            Urho.Application.Started += StartPreviewFactory;
        }

        private void StartPreviewFactory()
        {
            Urho.Application.Current.Update += Tick;
            _renderTexture = new Texture2D();
            _renderTexture.SetSize(_previewSize, _previewSize, Graphics.RGBFormat, TextureUsage.Rendertarget);
            _renderTexture.FilterMode = TextureFilterMode.Bilinear;
        }

        private const int _previewSize = 128;
        ConcurrentQueue<PreviewRequest> _queue = new ConcurrentQueue<PreviewRequest>();

        private PreviewRequest _current;

        private void Tick(UpdateEventArgs obj)
        {
            if (_current == null)
            {
                if (!_queue.TryDequeue(out _current))
                    return;
                Urho.Application.Current.ResourceCache.BackgroundLoadResource(_current.ResourceType,
                    _current.ResourceName, false);
            }

            if (!_current.Ready)
            {
                if (Urho.Application.Current.ResourceCache.NumBackgroundLoadResources == 0)
                {
                    if (File.Exists(_current.ImagePath))
                    {
                        _current.Container.ImageSource = BitmapFrame.Create(new Uri(_current.ImagePath));
                        _current = null;
                    }

                    _current.Ready = true;
                    var scene = _current.CreateSceneAndCamera();
                    _renderTexture.RenderSurface.SetViewport(0, new Viewport(Urho.Application.CurrentContext, scene.Scene, scene.Camera));
                    _renderTexture.RenderSurface.UpdateMode = RenderSurfaceUpdateMode.Updatealways;
                }
                return;
            }

            var size = _renderTexture.GetDataSize(_previewSize, _previewSize);
            if (size != 0)
            {
                var buf = new byte[size];
                unsafe
                {
                    GCHandle pinnedArray = GCHandle.Alloc(buf, GCHandleType.Pinned);
                    IntPtr pointer = pinnedArray.AddrOfPinnedObject();
                    _renderTexture.GetData(0, pointer);
                    pinnedArray.Free();
                }
                BitmapSource image = BitmapSource.Create(
                    _previewSize,
                    _previewSize,
                    96,
                    96,
                    PixelFormats.Rgb24, BitmapPalettes.Halftone256,buf, _previewSize*3);
                using (FileStream stream = new FileStream(_current.ImagePath, FileMode.Create))
                {
                    PngBitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Interlace = PngInterlaceOption.On;
                    encoder.Frames.Add(BitmapFrame.Create(image));
                    encoder.Save(stream);
                }
                _current.Container.ImageSource = BitmapFrame.Create(new Uri(_current.ImagePath));
            }

            _current = null;
        }

        class SceneAndCamera
        {
            public Scene Scene;
            public Camera Camera;
        }
        class PreviewRequest
        {
            private string _imagePath;
            private string _resourceName;
            private string _fullPath;
            private ImageSourceContainer _container;
            private StringHash _resourceType;
            private bool _ready;

            public string ImagePath
            {
                get { return _imagePath; }
                set { _imagePath = value; }
            }

            public Func<SceneAndCamera> CreateSceneAndCamera { get; set; }

            public string ResourceName
            {
                get { return _resourceName; }
                set { _resourceName = value; }
            }

            public string FullPath
            {
                get { return _fullPath; }
                set { _fullPath = value; }
            }

            public ImageSourceContainer Container
            {
                get { return _container; }
                set { _container = value; }
            }

            public StringHash ResourceType
            {
                get { return _resourceType; }
                set { _resourceType = value; }
            }

            public bool Ready
            {
                get { return _ready; }
                set { _ready = value; }
            }
        }

        public ImageSourceContainer CreateFolderPreview(string resourcePath, string fullPath)
        {
            return _folder.Value;
        }
        private readonly long MaxImageSize = 2 * 1024 * 1024;
        public ImageSourceContainer CreateFilePreview(string resourceName, string fullPath, long size)
        {
            if (IsImage(resourceName) && size  < MaxImageSize)
                return new ImageSourceContainer(new BitmapImage(new Uri(fullPath)));
            return ConvertExtension(resourceName, fullPath);
        }
        private ImageSourceContainer ConvertExtension(string resourceName, string fullPath)
        {
            var ex = Path.GetExtension(resourceName);
            switch (ex.ToLower())
            {
                case ".ttf":
                    return _font.Value;
                case ".cs":
                    return _cs.Value;
                case ".xml":
                    return _xml.Value;
                case ".mdl":
                    return CreateModelPreview(resourceName, fullPath);
                case ".dae":
                case ".3ds":
                case ".max":
                case ".ma":
                case ".smd":
                case ".bsp":
                case ".fbx":
                    return _mesh.Value;
                case ".ani":
                    return _animation.Value;
            }

            return _unknown.Value;
        }

        private ImageSourceContainer CreateModelPreview(string resourceName, string fullPath)
        {
            var previewImage = Path.Combine(_previewFolder, _hashFunction.GetHash(resourceName)+".png");
            if (File.Exists(previewImage))
                return new ImageSourceContainer(BitmapFrame.Create(new Uri(previewImage)));
            var imageSourceContainer = new ImageSourceContainer(_mesh.Value.ImageSource);
            _queue.Enqueue(new PreviewRequest()
            {
                ResourceType = Urho.Model.TypeStatic,
                ImagePath = previewImage,
                ResourceName = resourceName,
                FullPath = fullPath,
                Container = imageSourceContainer,
                CreateSceneAndCamera = ()=>CreateModelScene(resourceName)
            });
            return imageSourceContainer;
        }

        private SceneAndCamera CreateModelScene(string resourceName)
        {
            ResetScene();
            var node = Scene.CreateChild();
            var mdl = node.CreateComponent<StaticModel>();
            mdl.Model = Urho.Application.Current.ResourceCache.GetModel(resourceName);
            CameraNode.Position = mdl.Model.BoundingBox.Size;
            CameraNode.LookAt(Vector3.Zero, Vector3.Up);
            return new SceneAndCamera() {Scene = _scene.Value, Camera = _camera.Value.GetComponent<Camera>()};
        }

        private void ResetScene()
        {
            if (!_scene.HasValue)
            {
                var sceneValue = new Scene();
                sceneValue.CreateComponent<Octree>();
                var z = sceneValue.CreateComponent<Zone>();
                z.AmbientColor = new Urho.Color(1,1,1,1);
                _scene.Value = sceneValue;
            }
            else
            {
                Scene.RemoveAllChildren();
            }

            if (!_camera.HasValue)
            {
                _camera.Value = new Node() {Name = "MainCamera"};
                CameraNode.CreateComponent<Camera>();
            }

            Scene.AddChild(CameraNode);
        }
        private Scene Scene
        {
            get { return _scene.Value; }
        }
        private Node CameraNode
        {
            get { return _camera.Value; }
        }
        private UrhoRef<Scene> _scene = new UrhoRef<Scene>();
        private UrhoRef<Node> _camera = new UrhoRef<Node>();

    private bool IsImage(string name)
        {
            var ex = Path.GetExtension(name);
            if (ex == ".png" || ex == ".jpg")
                return true;
            return false;
        }
        private static readonly string DefaultIcon = "UrhoSharp.Editor.Icons.unknown.png";

        private static readonly Lazy<ImageSourceContainer> _unknown =
            new Lazy<ImageSourceContainer>(() => new ImageSourceContainer(LoadEmbeddedResource(DefaultIcon)));

        private static readonly Lazy<ImageSourceContainer> _folder =
            new Lazy<ImageSourceContainer>(() => new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.unknown.png")));

        private static readonly Lazy<ImageSourceContainer> _font =
            new Lazy<ImageSourceContainer>(() => new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.font.png")));

        private static readonly Lazy<ImageSourceContainer> _cs =
            new Lazy<ImageSourceContainer>(() => new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.cs.png")));

        private static readonly Lazy<ImageSourceContainer> _xml =
            new Lazy<ImageSourceContainer>(() => new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.xml.png")));

        private static readonly Lazy<ImageSourceContainer> _mesh =
            new Lazy<ImageSourceContainer>(() => new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.mesh.png")));

        private static readonly Lazy<ImageSourceContainer> _animation =
            new Lazy<ImageSourceContainer>(() => new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.animation.png")));

        private string _previewFolder;

        private static ImageSource LoadEmbeddedResource(string name)
        {
            var a = typeof(PreviewFactory).Assembly;
            using (var s = a.GetManifestResourceStream(name))
            {
                if (s == null)
                {
                    if (name != DefaultIcon)
                        return _unknown.Value.ImageSource;
                    return null;
                }

                return BitmapFrame.Create(s);
            }
        }
    }
}