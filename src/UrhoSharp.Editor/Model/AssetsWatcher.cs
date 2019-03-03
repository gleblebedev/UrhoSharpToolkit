using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive.Subjects;

namespace UrhoSharp.Editor.Model
{
    public class AssetsWatcher : IObservable<AssetFileEventArgs>, IDisposable
    {
        private readonly IConfigurationContainer<ProjectConfiguration> _configuration;
        private readonly ProjectReference _project;
        public Subject<AssetFileEventArgs> _subject = new Subject<AssetFileEventArgs>();
        private readonly List<Proxy> _watchers = new List<Proxy>();

        public AssetsWatcher(ProjectReference project, IConfigurationContainer<ProjectConfiguration> configuration)
        {
            _project = project;
            _configuration = configuration;
            foreach (var folder in _configuration.Value.DataFolders)
            {
                var data = Path.GetFullPath(Path.Combine(_project.Path, folder));
                var watcher = new Proxy(new FileSystemWatcher(data), data, this);

                _watchers.Add(watcher);
            }
        }


        public void Dispose()
        {
            foreach (var fileSystemWatcher in _watchers) fileSystemWatcher.Dispose();
        }

        public IDisposable Subscribe(IObserver<AssetFileEventArgs> observer)
        {
            return _subject.Subscribe(observer);
        }

        public event EventHandler<AssetFileEventArgs> AssetChanged;
        public event EventHandler<ErrorEventArgs> Error;


        private void OnError(ErrorEventArgs e)
        {
            Error?.Invoke(this, e);
        }

        private class Proxy : IDisposable
        {
            private readonly AssetsWatcher _assets;
            private readonly string _folder;
            private readonly FileSystemWatcher _watcher;

            public Proxy(FileSystemWatcher watcher, string folder, AssetsWatcher assets)
            {
                _folder = folder;
                if (!_folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
                    _folder += Path.DirectorySeparatorChar;
                _assets = assets;
                _watcher = watcher;
                watcher.NotifyFilter = NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastWrite;
                watcher.Changed += OnFileChanged;
                watcher.Created += OnFileChanged;
                watcher.Deleted += OnFileChanged;
                watcher.Error += OnError;
                watcher.Renamed += OnFileRenamed;
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;
            }

            public void Dispose()
            {
                _watcher.EnableRaisingEvents = false;
                _watcher.Dispose();
            }


            private void OnFileChanged(object sender, FileSystemEventArgs e)
            {
                var fullPath = e.FullPath;
                var resourceName = GetResourceName(e.FullPath);

                switch (e.ChangeType)
                {
                    case WatcherChangeTypes.Deleted:
                        _assets._subject.OnNext(new AssetFileEventArgs(AssetFileEventArgs.ChangeTypes.Deleted, fullPath,
                            resourceName));
                        break;
                    case WatcherChangeTypes.Changed:
                        _assets._subject.OnNext(new AssetFileEventArgs(AssetFileEventArgs.ChangeTypes.Changed, fullPath,
                            resourceName));
                        break;
                    case WatcherChangeTypes.Created:
                        _assets._subject.OnNext(new AssetFileEventArgs(AssetFileEventArgs.ChangeTypes.Created, fullPath,
                            resourceName));
                        break;
                }
            }

            private string GetResourceName(string fullPath)
            {
                return new Uri(_folder).MakeRelativeUri(new Uri(fullPath)).ToString();
            }

            private void OnFileRenamed(object sender, RenamedEventArgs e)
            {
                var fullPath = e.OldFullPath;
                var resourceName = GetResourceName(e.OldFullPath);
                _assets._subject.OnNext(new AssetFileEventArgs(AssetFileEventArgs.ChangeTypes.Deleted, fullPath,
                    resourceName));
                fullPath = e.FullPath;
                resourceName = GetResourceName(e.FullPath);
                _assets._subject.OnNext(new AssetFileEventArgs(AssetFileEventArgs.ChangeTypes.Created, fullPath,
                    resourceName));
            }

            private void OnError(object sender, ErrorEventArgs e)
            {
                _assets.OnError(e);
            }
        }
    }
}