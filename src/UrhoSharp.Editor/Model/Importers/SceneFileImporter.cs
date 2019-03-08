using System.IO;
using Toe.ContentPipeline;
using Toe.ContentPipeline.Algorithms;
using Toe.ContentPipeline.Urho3d;

namespace UrhoSharp.Editor.Model.Importers
{
    public class SceneFileImporter : AbstractImporter
    {
        private readonly IFileFormat _fileFormat;

        public SceneFileImporter(IImporter parent, string name, IFileFormat fileFormat) : base(parent, name)
        {
            _fileFormat = fileFormat;
        }

        public float Scale { get; set; } = 1;
        public bool ZUp { get; set; } = false;
        public bool FlipFaces { get; set; } = false;
        public bool FlipNormals { get; set; } = false;

        public override void Import(string targetFolderFullPath)
        {
            targetFolderFullPath = System.IO.Path.Combine(targetFolderFullPath, Name);
            Directory.CreateDirectory(targetFolderFullPath);
            var reader = _fileFormat.CreateProactiveReader(new ReaderContext());
            var scene = reader.Read(Open());
            scene = new EnsureUniqueIds().Apply(scene);
            if (Scale != 1) scene = new Scale(Scale).Apply(scene);
            if (FlipFaces) scene = new FlipFaces().Apply(scene);
            if (FlipNormals) scene = new FlipNormals().Apply(scene);
            var urhoModel = new Urho3DMdlFileFormat();
            foreach (var sceneGeometry in scene.Geometries)
                using (var f = Create(System.IO.Path.Combine(targetFolderFullPath, sceneGeometry.Id)))
                {
                    var s = new Scene();
                    s.Geometries.Add(sceneGeometry);
                    s.Nodes.Add(new Node {Meshes = {new MeshReference(sceneGeometry)}});
                    urhoModel.Write(f, s);
                }
        }
    }
}