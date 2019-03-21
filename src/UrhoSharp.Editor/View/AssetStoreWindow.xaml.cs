using System.Windows;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for AssetStoreWindow.xaml
    /// </summary>
    public partial class AssetStoreWindow : Window
    {
        public AssetStoreWindow(AssetStoreViewModel viewModel):this()
        {
            DataContext = viewModel;
        }

        public AssetStoreViewModel viewModel
        {
            get { return DataContext as AssetStoreViewModel; }
        }

        public AssetStoreWindow()
        {
            InitializeComponent();
        }

        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}