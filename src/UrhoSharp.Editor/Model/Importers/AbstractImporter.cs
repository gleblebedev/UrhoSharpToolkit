using System.IO;

namespace UrhoSharp.Editor.Model.Importers
{
    public abstract class AbstractImporter : IImporter
    {
        protected AbstractImporter(IImporter parent, string path)
        {
            Parent = parent;
            Path = path;
            Name = System.IO.Path.GetFileName(Path);
        }

        public string Path { get; }

        public IImporter Parent { get; }

        public string Name { get; protected set; }

        public virtual void Import(string targetFolderFullPath)
        {
            using (var output = File.Open(System.IO.Path.Combine(targetFolderFullPath, Name), FileMode.Create,
                FileAccess.Write, FileShare.Read))
            {
                using (var source = Open())
                {
                    source.CopyTo(output);
                }
            }
        }

        public virtual Stream Open(string path)
        {
            return File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }

        public virtual void Dispose()
        {
        }

        public virtual Stream Open()
        {
            if (Parent != null) return Parent.Open(Path);
            return Open(Path);
        }

        public virtual Stream Create(string path)
        {
            return File.Open(path, FileMode.Create, FileAccess.Write, FileShare.Read);
        }
    }
}