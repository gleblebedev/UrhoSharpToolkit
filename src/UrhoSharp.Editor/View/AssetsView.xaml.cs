using System.Collections.Generic;
using System.Linq;
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

        public void OpenFolder(FolderViewModel folder)
        {
            var breadcrumbs = folder.Breadcrumbs.ToList();
            FindAndOpenFolder(breadcrumbs, _treeView);
            //var tvi = _treeView.ItemContainerGenerator.ContainerFromItem(folder)
            //    as TreeViewItem;

            //if (tvi != null) tvi.IsSelected = true;
        }

        private void FindAndOpenFolder(IReadOnlyList<FileSystemItemViewModel> breadcrumbs, ItemsControl items)
        {
            foreach (FileSystemItemViewModel item in items.Items)
                if (item.Name == breadcrumbs[0].Name)
                {
                    var container = items.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem;
                    if (container != null)
                        if (breadcrumbs.Count == 1)
                            container.IsSelected = true;
                        else
                            FindAndOpenFolder(new ListTail<FileSystemItemViewModel>(breadcrumbs, 1), container);
                }
        }

        private void ImportAssets(object sender, DragEventArgs e)
        {
        }
    }
}