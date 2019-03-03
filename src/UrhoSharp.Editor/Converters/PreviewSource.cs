using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor.Converters
{
    public class PreviewSource : IValueConverter
    {
        private static readonly string DefaultIcon = "UrhoSharp.Editor.Icons.unknown.png";

        private static readonly Lazy<BitmapSource> _unknown =
            new Lazy<BitmapSource>(() => { return LoadEmbeddedResource(DefaultIcon); });

        private static readonly Lazy<BitmapSource> _folder =
            new Lazy<BitmapSource>(() => LoadEmbeddedResource("UrhoSharp.Editor.Icons.unknown.png"));

        private static readonly Lazy<BitmapSource> _font =
            new Lazy<BitmapSource>(() => LoadEmbeddedResource("UrhoSharp.Editor.Icons.font.png"));

        private static readonly Lazy<BitmapSource> _cs =
            new Lazy<BitmapSource>(() => LoadEmbeddedResource("UrhoSharp.Editor.Icons.cs.png"));

        private static readonly Lazy<BitmapSource> _xml =
            new Lazy<BitmapSource>(() => LoadEmbeddedResource("UrhoSharp.Editor.Icons.xml.png"));

        private static readonly Lazy<BitmapSource> _mesh =
            new Lazy<BitmapSource>(() => LoadEmbeddedResource("UrhoSharp.Editor.Icons.mesh.png"));

        private static readonly Lazy<BitmapSource> _animation =
            new Lazy<BitmapSource>(() => LoadEmbeddedResource("UrhoSharp.Editor.Icons.animation.png"));

        private readonly long MaxImageSize = 2 * 1024 * 1024;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fileViewModel = value as FileViewModel;
            if (fileViewModel != null) return ConvertFile(fileViewModel);
            var fdolderViewModel = value as FolderViewModel;
            if (fdolderViewModel != null) return _folder.Value;
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        private static BitmapSource LoadEmbeddedResource(string name)
        {
            var a = typeof(PreviewSource).Assembly;
            using (var s = a.GetManifestResourceStream(name))
            {
                if (s == null)
                {
                    if (name != DefaultIcon)
                        return _unknown.Value;
                    return null;
                }

                return BitmapFrame.Create(s);
            }
        }

        private object ConvertFile(FileViewModel viewModel)
        {
            if (IsImage(viewModel.Name) && viewModel.Size < MaxImageSize)
                return new BitmapImage(new Uri(viewModel.FullPath));
            return ConvertExtension(viewModel.Name);
        }

        private bool IsImage(string name)
        {
            var ex = Path.GetExtension(name);
            if (ex == ".png" || ex == ".jpg")
                return true;
            return false;
        }

        private object ConvertExtension(string name)
        {
            var ex = Path.GetExtension(name);
            switch (ex.ToLower())
            {
                case ".ttf":
                    return _font.Value;
                case ".cs":
                    return _cs.Value;
                case ".xml":
                    return _xml.Value;
                case ".mdl":
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

        private object ConvertImage(FileViewModel viewModel)
        {
            using (var s = viewModel.OpenFile())
            {
                var img = new BitmapImage();
                img.BeginInit();
                img.StreamSource = s;
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.EndInit();
                img.Freeze();
                return img;
            }
        }
    }
}