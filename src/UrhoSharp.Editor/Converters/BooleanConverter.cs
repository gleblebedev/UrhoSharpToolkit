using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace UrhoSharp.Editor.Converters
{
    public class BooleanConverter<T>: IValueConverter
    {
        public T IfTrue { get; set; }
        public T IfFalse { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToBoolean(value)?IfTrue:IfFalse;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (EqualityComparer<T>.Default.Equals((T) value, IfTrue))
                return true;
            return false;
        }
    }

    public class VisibilityConverter:BooleanConverter<Visibility>
    { }

    public class CollapsedIconConverter : BooleanConverter<string>
    {
        public CollapsedIconConverter()
        {
            IfTrue = "\u25B7";
            IfFalse = "\u25E2";
        }
    }
}
