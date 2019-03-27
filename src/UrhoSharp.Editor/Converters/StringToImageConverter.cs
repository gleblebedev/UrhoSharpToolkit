using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace UrhoSharp.Editor.Converters
{
    public class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var imagename = value as string;
                var image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(imagename);
                image.EndInit();
                return image;
                //return new BitmapImage(new Uri(string.Format(@"..\..\Image\{0}", imagename), UriKind.Relative));
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}