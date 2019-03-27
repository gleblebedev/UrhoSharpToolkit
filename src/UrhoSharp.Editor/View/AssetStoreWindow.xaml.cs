using System.Windows;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for AssetStoreWindow.xaml
    /// </summary>
    public partial class AssetStoreWindow : Window
    {
        public AssetStoreWindow(AssetStoreViewModel viewModel) : this()
        {
            DataContext = viewModel;
        }

        public AssetStoreWindow()
        {
            InitializeComponent();
        }

        public AssetStoreViewModel viewModel => DataContext as AssetStoreViewModel;

        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}