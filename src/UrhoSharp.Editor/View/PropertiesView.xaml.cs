using System.Windows;
using System.Windows.Controls;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for PropertiesView.xaml
    /// </summary>
    public partial class PropertiesView : UserControl
    {
        public static readonly DependencyProperty NumRowsProperty = DependencyProperty.RegisterAttached(
            "NumRows",
            typeof(int),
            typeof(Grid),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender)
        );
        public static void SetNumRows(UIElement element, int value)
        {
            element.SetValue(NumRowsProperty, value);
        }
        public static int GetNumRows(UIElement element)
        {
            return (int)element.GetValue(NumRowsProperty);
        }

        public PropertiesView()
        {
            InitializeComponent();
        }
    }
}