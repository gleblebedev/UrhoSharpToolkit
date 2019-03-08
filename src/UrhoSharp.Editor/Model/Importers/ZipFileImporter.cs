using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace UrhoSharp.Editor.Model.Importers
{
    public class ZipFileImporter : MultifileImporter
    {
        private readonly ZipArchive _archive;
        private readonly Dictionary<string, ZipArchiveEntry> _entries = new Dictionary<string, ZipArchiveEntry>();
        private readonly Stream _fileStream;

        public ZipFileImporter(IImporter parent, string name) : base(parent, name)
        {
            Name = System.IO.Path.GetFileNameWithoutExtension(name) ?? Name;
            try
            {
                _fileStream = Parent.Open(name);
                {
                    _archive = new ZipArchive(_fileStream);
                    foreach (var entry in _archive.Entries)
                    {
                        _entries[entry.FullName] = entry;
                        Files.Add(CreateImporter(entry.FullName));
                    }
                }
            }
            catch (Exception)
            {
                _fileStream?.Dispose();
                throw;
            }
        }

        public override Stream Open(string path)
        {
            return _entries[path].Open();
        }

        public override void Dispose()
        {
            base.Dispose();
            _fileStream.Dispose();
        }
    }
}