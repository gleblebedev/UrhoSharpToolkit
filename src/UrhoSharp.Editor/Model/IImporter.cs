using System;
using System.IO;

namespace UrhoSharp.Editor.Model
{
    public interface IImporter : IDisposable
    {
        string Name { get; }
        void Import(string targetFolderFullPath);
        Stream Open(string path);
    }
}