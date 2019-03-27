using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using Urho;
using Urho.Urho2D;
using UrhoSharp.Editor.Model.PreviewScenes;

namespace UrhoSharp.Editor.Model
{
    public class PreviewFactory
    {
        private const int _previewSize = 128;

        private static readonly string DefaultIcon = "UrhoSharp.Editor.Icons.unknown.png";

        private static readonly Lazy<ImageSourceContainer> _unknown =
            new Lazy<ImageSourceContainer>(() => new ImageSourceContainer(LoadEmbeddedResource(DefaultIcon)));

        private static readonly Lazy<ImageSourceContainer> _folder =
            new Lazy<ImageSourceContainer>(() =>
                new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.unknown.png")));

        private static readonly Lazy<ImageSourceContainer> _font =
            new Lazy<ImageSourceContainer>(() =>
                new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.font.png")));

        private static readonly Lazy<ImageSourceContainer> _cs =
            new Lazy<ImageSourceContainer>(() =>
                new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.cs.png")));

        private static readonly Lazy<ImageSourceContainer> _xml =
            new Lazy<ImageSourceContainer>(() =>
                new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.xml.png")));

        private static readonly Lazy<ImageSourceContainer> _mesh =
            new Lazy<ImageSourceContainer>(() =>
                new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.mesh.png")));

        private static readonly Lazy<ImageSourceContainer> _animation =
            new Lazy<ImageSourceContainer>(() =>
                new ImageSourceContainer(LoadEmbeddedResource("UrhoSharp.Editor.Icons.animation.png")));

        private readonly IHashFunction _hashFunction;
        private readonly long MaxImageSize = 2 * 1024 * 1024;

        private PreviewRequest _current;

        private readonly Lazy<MaterialPreviewScene> _materialPreview =
            new Lazy<MaterialPreviewScene>(() => new MaterialPreviewScene());

        private readonly Lazy<ModelPreviewScene> _modelPreview =
            new Lazy<ModelPreviewScene>(() => new ModelPreviewScene());

        private readonly Lazy<PrefabPreviewScene> _prefabPreview =
            new Lazy<PrefabPreviewScene>(() => new PrefabPreviewScene());

        private readonly string _previewFolder;
        private readonly ConcurrentQueue<PreviewRequest> _queue = new ConcurrentQueue<PreviewRequest>();
        private Texture2D _renderTexture;

        private readonly Lazy<TexturePreviewScene> _texturePreview =
            new Lazy<TexturePreviewScene>(() => new TexturePreviewScene());

        public PreviewFactory(ProjectReference project, IConfigurationContainer<ProjectConfiguration> config,
            IHashFunction hashFunction)
        {
            _hashFunction = hashFunction;
            _previewFolder = Path.Combine(project.Path, config.Value.MetaInfoFolder, "previews");
            Directory.CreateDirectory(_previewFolder);
            Application.Started += StartPreviewFactory;
        }

        private void StartPreviewFactory()
        {
            Application.Current.Update += Tick;
            _renderTexture = new Texture2D();
            _renderTexture.SetSize(_previewSize, _previewSize, Graphics.RGBFormat, TextureUsage.Rendertarget);
            _renderTexture.FilterMode = TextureFilterMode.Bilinear;
        }

        private void Tick(UpdateEventArgs obj)
        {
            if (_current == null)
            {
                if (!_queue.TryDequeue(out _current))
                    return;
                if (_current.ResourceType.Code != 0)
                    Application.Current.ResourceCache.BackgroundLoadResource(_current.ResourceType,
                        _current.ResourceName, false);
            }

            if (!_current.Ready)
            {
                if (Application.Current.ResourceCache.NumBackgroundLoadResources == 0)
                {
                    if (File.Exists(_current.ImagePath))
                    {
                        _current.Container.ImageSource = BitmapFrame.Create(new Uri(_current.ImagePath));
                        _current = null;
                    }

                    _current.Ready = true;
                    var scene = _current.PreviewScene.Value;
                    _renderTexture.RenderSurface.SetViewport(0,
                        new Viewport(Application.CurrentContext, scene.Scene, scene.Camera));
                    _renderTexture.RenderSurface.UpdateMode = RenderSurfaceUpdateMode.Updatealways;
                }

                return;
            }

            if (_current.TimeoutCounter > 0)
            {
                --_current.TimeoutCounter;
                return;
            }

            var size = _renderTexture.GetDataSize(_previewSize, _previewSize);
            if (size != 0)
            {
                var buf = new byte[size];
                var pinnedArray = GCHandle.Alloc(buf, GCHandleType.Pinned);
                var pointer = pinnedArray.AddrOfPinnedObject();
                _renderTexture.GetData(0, pointer);
                pinnedArray.Free();
                var image = BitmapSource.Create(
                    _previewSize,
                    _previewSize,
                    96,
                    96,
                    PixelFormats.Rgb24, BitmapPalettes.Halftone256, buf, _previewSize * 3);
                using (var stream = new FileStream(_current.ImagePath, FileMode.Create))
                {
                    var encoder = new PngBitmapEncoder();
                    encoder.Interlace = PngInterlaceOption.On;
                    encoder.Frames.Add(BitmapFrame.Create(image));
                    encoder.Save(stream);
                }

                _current.Container.ImageSource = BitmapFrame.Create(new Uri(_current.ImagePath));
            }

            _current = null;
        }

        public ImageSourceContainer CreateFolderPreview(string resourcePath, string fullPath)
        {
            return _folder.Value;
        }

        public ImageSourceContainer CreateFilePreview(string resourceName, string fullPath, long size)
        {
            //if (IsImage(resourceName) && size  < MaxImageSize)
            //    return new ImageSourceContainer(new BitmapImage(new Uri(fullPath)));
            return ConvertExtension(resourceName, fullPath);
        }

        private ImageSourceContainer ConvertExtension(string resourceName, string fullPath)
        {
            var previewImage = Path.Combine(_previewFolder, _hashFunction.GetHash(resourceName) + ".png");
            if (File.Exists(previewImage))
                return new ImageSourceContainer(BitmapFrame.Create(new Uri(previewImage)));

            var ex = Path.GetExtension(resourceName);
            switch (ex.ToLower())
            {
                case ".ttf":
                    return _font.Value;
                case ".cs":
                    return _cs.Value;
                case ".xml":
                    return CreateXmlPreview(resourceName, fullPath);
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
                case ".dds":
                case ".png":
                case ".tga":
                case ".jpg":
                    return CreateTexturePreview(resourceName, fullPath);
            }

            return _unknown.Value;
        }

        private ImageSourceContainer CreateXmlPreview(string resourceName, string fullPath)
        {
            try
            {
                var doc = XDocument.Load(fullPath);
                switch (doc.Root.Name.LocalName)
                {
                    case "material":
                        return CreateMaterialPreview(resourceName, fullPath);
                    case "node":
                        return CreatePrefabPreview(resourceName, fullPath);
                    default:
                        return _xml.Value;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                return _xml.Value;
            }
        }

        private ImageSourceContainer CreatePrefabPreview(string resourceName, string fullPath)
        {
            Func<AbstractPreviewScene> valueFactory = () =>
            {
                var previewScene = _prefabPreview.Value;
                previewScene.SetPrefab(resourceName);
                return previewScene;
            };
            var resourceType = new StringHash(0);

            return CreatePreviewScene(resourceName, fullPath, resourceType, valueFactory);
        }

        private ImageSourceContainer CreateMaterialPreview(string resourceName, string fullPath)
        {
            Func<AbstractPreviewScene> valueFactory = () =>
            {
                var previewScene = _materialPreview.Value;
                previewScene.SetMaterial(Application.Current.ResourceCache.GetMaterial(resourceName));
                return previewScene;
            };
            var resourceType = Material.TypeStatic;

            return CreatePreviewScene(resourceName, fullPath, resourceType, valueFactory);
        }

        private ImageSourceContainer CreateModelPreview(string resourceName, string fullPath)
        {
            Func<AbstractPreviewScene> valueFactory = () =>
            {
                var previewScene = _modelPreview.Value;
                previewScene.SetModel(Application.Current.ResourceCache.GetModel(resourceName));
                return previewScene;
            };
            var resourceType = Urho.Model.TypeStatic;

            return CreatePreviewScene(resourceName, fullPath, resourceType, valueFactory);
        }

        private ImageSourceContainer CreatePreviewScene(string resourceName, string fullPath, StringHash resourceType,
            Func<AbstractPreviewScene> valueFactory)
        {
            var previewImage = Path.Combine(_previewFolder, _hashFunction.GetHash(resourceName) + ".png");
            if (File.Exists(previewImage))
                return new ImageSourceContainer(BitmapFrame.Create(new Uri(previewImage)));
            var imageSourceContainer = new ImageSourceContainer(_mesh.Value.ImageSource);
            _queue.Enqueue(new PreviewRequest
            {
                ResourceType = resourceType,
                ImagePath = previewImage,
                ResourceName = resourceName,
                FullPath = fullPath,
                Container = imageSourceContainer,
                PreviewScene = new Lazy<AbstractPreviewScene>(valueFactory)
            });
            return imageSourceContainer;
        }

        private ImageSourceContainer CreateTexturePreview(string resourceName, string fullPath)
        {
            Func<AbstractPreviewScene> valueFactory = () =>
            {
                var previewScene = _texturePreview.Value;
                previewScene.SetTexture(Application.Current.ResourceCache.GetTexture2D(resourceName, true));
                return previewScene;
            };
            var resourceType = Texture2D.TypeStatic;

            return CreatePreviewScene(resourceName, fullPath, resourceType, valueFactory);
        }

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


        private class PreviewRequest
        {
            public int TimeoutCounter { get; set; } = 4;

            public string ImagePath { get; set; }

            public Lazy<AbstractPreviewScene> PreviewScene { get; set; }

            public string ResourceName { get; set; }

            public string FullPath { get; set; }

            public ImageSourceContainer Container { get; set; }

            public StringHash ResourceType { get; set; }

            public bool Ready { get; set; }
        }
    }
}