using System.Windows;
using System.Windows.Controls;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for AssetsView.xaml
    /// </summary>
    public partial class AssetsView : UserControl
    {
        public AssetsView()
        {
            InitializeComponent();
        }

        public AssetsViewModel ViewModel => DataContext as AssetsViewModel;

        private void UpdateSelectedItem(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            ViewModel.SelectedFolder = e.NewValue as FolderViewModel;
        }
    }
}