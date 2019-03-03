using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public abstract class FileSystemItemViewModel
    {
        protected readonly AssetsViewModel _assets;
        private readonly FileSystemItemViewModel _parent;
        protected readonly string _rootPath;
        private ObservableCollection<FileSystemItemViewModel> _allItems;
        private ObservableCollection<FolderViewModel> _folders;
        private ICommand _viewInExplorerCommand;

        public FileSystemItemViewModel(string fullPath, string rootPath, FileSystemItemViewModel parent,
            AssetsViewModel assets)
        {
            FullPath = fullPath;
            _rootPath = rootPath;
            _parent = parent;
            _assets = assets;
            Name = FullPath == rootPath
                ? Path.GetFileName(Path.GetDirectoryName(fullPath))
                : Path.GetFileName(FullPath);
        }

        public ICommand ViewInExplorerCommand =>
            _viewInExplorerCommand ?? (_viewInExplorerCommand = new ActionCommand(ViewInExplorer));

        public IReadOnlyCollection<FileSystemItemViewModel> Breadcrumbs
        {
            get
            {
                var a = new List<FileSystemItemViewModel>();
                var current = this;
                while (current != null)
                {
                    a.Add(current);
                    current = current._parent;
                }

                a.Reverse();
                return a;
            }
        }


        public IList<FolderViewModel> Folders => _folders ?? (_folders = GetFolders());

        public IList<FileSystemItemViewModel> AllItems => _allItems ?? (_allItems = GetAllItems());

        public string Name { get; }

        public string FullPath { get; }

        protected abstract void ViewInExplorer();

        public override string ToString()
        {
            return Name ?? base.ToString();
        }

        private ObservableCollection<FolderViewModel> GetFolders()
        {
            return new ObservableCollection<FolderViewModel>(
                EvalFolders()
                    .OrderBy(_ => _, Comparer.Instance));
        }

        private IEnumerable<FolderViewModel> EvalFolders()
        {
            if (_allItems != null)
                return _allItems.Select(_ => _ as FolderViewModel).Where(_ => _ != null);
            return Directory.GetDirectories(FullPath)
                .Select(_ => new FolderViewModel(_, _rootPath, this, _assets));
        }

        private ObservableCollection<FileSystemItemViewModel> GetAllItems()
        {
            return new ObservableCollection<FileSystemItemViewModel>(
                EvalAllItems()
                    .OrderBy(_ => _, Comparer.Instance)
            );
        }

        private IEnumerable<FileSystemItemViewModel> EvalAllItems()
        {
            var folders = _folders ?? Directory.GetDirectories(FullPath)
                              .Select(_ => (FileSystemItemViewModel) new FolderViewModel(_, _rootPath, this, _assets));
            return folders
                .Concat(
                    Directory.GetFiles(FullPath)
                        .Select(_ => (FileSystemItemViewModel) new FileViewModel(_, _rootPath, this, _assets))
                );
        }

        public void OnAssetChanged(IReadOnlyList<string> path, AssetFileEventArgs args)
        {
            if (path.Count == 0)
                return;

            //var folderIndex = -1;
            //if (_folders != null)
            //    folderIndex = _folders.Select((a, i) => new { Name = a.Name, Index = i }).FirstOrDefault(_ => _.Name == path[0])?.Index ?? -1;
            //var itemIndex = -1;
            //if (_allItems != null)
            //    itemIndex = _allItems.Select((a, i) => new { Name = a.Name, Index = i }).FirstOrDefault(_ => _.Name == path[0])?.Index ?? -1;

            if (path.Count > 1)
            {
                if (_folders != null)
                    _folders.FirstOrDefault(_ => _.Name == path[0])
                        ?.OnAssetChanged(new ListTail<string>(path, 1), args);
                if (_allItems != null)
                    _allItems.FirstOrDefault(_ => _.Name == path[0])
                        ?.OnAssetChanged(new ListTail<string>(path, 1), args);
            }
            else
            {
                switch (args.ChangeType)
                {
                    case AssetFileEventArgs.ChangeTypes.Created:
                        var info = new FileInfo(args.FullPath);
                        if (info.Exists)
                        {
                            AddFile(args.FullPath, path[0]);
                        }
                        else
                        {
                            var folderInfo = new DirectoryInfo(args.FullPath);
                            if (folderInfo.Exists) AddFolder(args.FullPath, path[0]);
                        }

                        break;
                    case AssetFileEventArgs.ChangeTypes.Changed:
                        break;
                    case AssetFileEventArgs.ChangeTypes.Deleted:
                        _folders?.RemoveIf(_ => _.Name == path[0]);
                        _allItems?.RemoveIf(_ => _.Name == path[0]);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void AddFile(string argsFullPath, string s)
        {
            if (_allItems == null)
                return;
            var vm = new FileViewModel(argsFullPath, _rootPath, this as FolderViewModel, _assets);
            Insert(_allItems, vm);
        }

        private void Insert<T>(IList<T> collection, T vm) where T : FileSystemItemViewModel
        {
            if (collection == null)
                return;
            for (var index = 0; index < collection.Count; index++)
                if (Comparer.Instance.Compare(vm, collection[index]) < 0)
                {
                    collection.Insert(index, vm);
                    return;
                }

            collection.Add(vm);
        }

        private void AddFolder(string argsFullPath, string s)
        {
            if (_folders == null && _allItems == null)
                return;
            var vm = new FolderViewModel(argsFullPath, _rootPath, this as FolderViewModel, _assets);
            Insert(_folders, vm);
            Insert(_allItems, vm);
        }

        public class Comparer : IComparer<FileSystemItemViewModel>
        {
            public static readonly Comparer Instance = new Comparer();
            private static readonly IComparer<string> NameComparer = StringComparer.InvariantCultureIgnoreCase;

            public int Compare(FileSystemItemViewModel x, FileSystemItemViewModel y)
            {
                var xIsDir = x is FolderViewModel;
                var yIsDir = y is FolderViewModel;
                if (xIsDir != yIsDir)
                {
                    if (xIsDir)
                        return -1;
                    return 1;
                }

                return NameComparer.Compare(x.Name, y.Name);
            }
        }
    }
}