using System.Windows;
using System.Windows.Controls;
using UrhoSharp.Editor.ViewModel;

namespace UrhoSharp.Editor.View
{
    /// <summary>
    ///     Interaction logic for HierarchyView.xaml
    /// </summary>
    public partial class HierarchyView : UserControl
    {
        public HierarchyView()
        {
            InitializeComponent();
        }

        private HierarchyViewModel ViewModel => DataContext as HierarchyViewModel;

        private void UpdateSelectedItem(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            ViewModel.SelectedNode = _tree.SelectedItem as NodeViewModel;
        }
    }
}