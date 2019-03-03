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
                        {
                            container.IsSelected = true;
                        }
                        else
                        {
                            container.IsExpanded = true;
                            FindAndOpenFolder(new ListTail<FileSystemItemViewModel>(breadcrumbs, 1), container);
                        }
                }
        }

        private void ImportAssets(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                var files = (string[]) e.Data.GetData(DataFormats.FileDrop);

                var vm = new ImportAssetsViewModel(files, ViewModel.SelectedFolder);
                var dialog = new ImportAssetsWindow {DataContext = vm};
                if (dialog.ShowDialog() == true) vm.ImportAssets();
            }
        }

        private void PreviewDragFiles(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                e.Effects = DragDropEffects.None;
                return;
            }

            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files == null || files.Length > 1)
            {
                e.Effects = DragDropEffects.None;
                return;
            }

            e.Effects = DragDropEffects.Copy;
            e.Handled = true;
        }

        private void UIElement_OnPreviewDragEnter(object sender, DragEventArgs e)
        {
        }

        private void UIElement_OnPreviewDragOver(object sender, DragEventArgs e)
        {
        }

        private void UIElement_OnPreviewDrop(object sender, DragEventArgs e)
        {
        }
    }
}