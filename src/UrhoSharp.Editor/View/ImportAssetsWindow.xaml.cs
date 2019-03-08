using System.Windows;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for ImportAssetsWindow.xaml
    /// </summary>
    public partial class ImportAssetsWindow : Window
    {
        public ImportAssetsWindow()
        {
            InitializeComponent();
        }

        private void Ok(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}