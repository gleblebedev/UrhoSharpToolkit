using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Xml.Linq;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class ExportPackageViewModel : ViewModelBase
    {
        private readonly IConfigurationContainer<NugetPackageConfiguration> _configuration;

        public ExportPackageViewModel(IConfigurationContainer<NugetPackageConfiguration> configuration,
            FolderViewModel rootFolder)
        {
            _configuration = configuration;
            IncVersionCommand = new ActionCommand(IncVersion);
            var conf = _configuration.Value;
            if (string.IsNullOrEmpty(conf.PackageName)) conf.PackageName = rootFolder.Name;

            var exclusionList = new HashSet<string>(conf.ExcludeFiles ?? new string[0]);

            Files = GetAllFiles(rootFolder, rootFolder.ResourcePath + "/").Select(_ =>
            {
                _.Include = !exclusionList.Contains(_.RelName);
                return _;
            }).OrderBy(_ => _.RelName).ToArray();
        }

        public ICommand IncVersionCommand { get; set; }
        public FileExportViewModel[] Files { get; set; }

        public string PackageName
        {
            get => _configuration.Value.PackageName;
            set => _configuration.Value.PackageName = value;
        }

        public string FileName => PackageName + "." + Version + ".nupkg";

        public string Version
        {
            get => _configuration.Value.Version;
            set
            {
                if (_configuration.Value.Version != value)
                {
                    _configuration.Value.Version = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Authors
        {
            get => _configuration.Value.Authors;
            set => _configuration.Value.Authors = value;
        }

        public string Owners
        {
            get => _configuration.Value.Owners;
            set => _configuration.Value.Owners = value;
        }

        public string LicenseUrl
        {
            get => _configuration.Value.LicenseUrl;
            set => _configuration.Value.LicenseUrl = value;
        }

        public bool RequireLicenseAcceptance
        {
            get => _configuration.Value.RequireLicenseAcceptance;
            set => _configuration.Value.RequireLicenseAcceptance = value;
        }

        public string Description
        {
            get => _configuration.Value.Description;
            set => _configuration.Value.Description = value;
        }

        public string Summary
        {
            get => _configuration.Value.Summary;
            set => _configuration.Value.Summary = value;
        }

        public string ProjectUrl
        {
            get => _configuration.Value.ProjectUrl;
            set => _configuration.Value.ProjectUrl = value;
        }

        public string IconUrl
        {
            get => _configuration.Value.IconUrl;
            set => _configuration.Value.IconUrl = value;
        }

        public string Copyright
        {
            get => _configuration.Value.Copyright;
            set => _configuration.Value.Copyright = value;
        }

        private void IncVersion()
        {
            Version v;
            if (System.Version.TryParse(Version, out v))
                if (v.Revision > 0)
                {
                    v = new Version(v.Major, v.Minor, v.Build, v.Revision + 1);
                    Version = v.ToString(4);
                }
                else if (v.Build > 0)
                {
                    v = new Version(v.Major, v.Minor, v.Build + 1);
                    Version = v.ToString(3);
                }
                else if (v.Minor > 0)
                {
                    v = new Version(v.Major, v.Minor + 1);
                    Version = v.ToString(2);
                }
                else
                {
                    v = new Version(v.Major + 1, 0);
                    Version = v.ToString(2);
                }
        }

        private IEnumerable<FileExportViewModel> GetAllFiles(FolderViewModel rootFolder, string rootPath)
        {
            if (rootFolder == null)
                yield break;
            foreach (var fileSystemItemViewModel in rootFolder.AllItems)
            {
                var file = fileSystemItemViewModel as FileViewModel;
                if (file != null && file.Name != NugetPackageConfiguration.ConfigurationFileName)
                {
                    yield return new FileExportViewModel(file, rootPath);
                }
                else
                {
                    var folderViewModel = fileSystemItemViewModel as FolderViewModel;
                    if (folderViewModel != null)
                    {
                        if (File.Exists(Path.Combine(folderViewModel.FullPath,
                            NugetPackageConfiguration.ConfigurationFileName))) yield break;
                        foreach (var fileExportViewModel in GetAllFiles(folderViewModel, rootPath))
                            yield return fileExportViewModel;
                    }
                }
            }
        }

        public void Export(string fileName)
        {
            if (!Validate())
                return;

            _configuration.Value.ExcludeFiles = Files.Where(_ => !_.Include).Select(_ => _.RelName).ToArray();
            _configuration.Save();

            using (var file = File.Open(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var arch = new ZipArchive(file, ZipArchiveMode.Create, false, new UTF8Encoding(false)))
                {
                    CreateNuspec(arch);
                    CreateContentTypes(arch);
                    CreateBuildTarget(arch);
                    foreach (var f in Files.Where(_ => _.Include)) CreateContentFile(arch, f);
                }
            }
        }

        private void CreateContentTypes(ZipArchive arch)
        {
            var extensions = new HashSet<string>(Files.Select(_ => Path.GetExtension(_.FullPath)));
            extensions.Add(".targets");
            var entry = arch.CreateEntry("[Content_Types].xml");
            using (var stream = entry.Open())
            {
                var ns = "http://schemas.openxmlformats.org/package/2006/content-types";
                var types = new XElement(XName.Get("Types", ns));
                types.Add(new XElement(XName.Get("Default", ns)
                    , new XAttribute("ContentType", "application/vnd.openxmlformats-package.relationships+xml")
                    , new XAttribute("Extension", "rels")));
                types.Add(new XElement(XName.Get("Default", ns)
                    , new XAttribute("ContentType", "application/vnd.openxmlformats-package.core-properties+xml")
                    , new XAttribute("Extension", "psmdcp")));
                foreach (var extension in extensions)
                    types.Add(new XElement(XName.Get("Default", ns)
                        , new XAttribute("ContentType", "application/octet")
                        , new XAttribute("Extension", extension.Substring(1))));
                var nuspec = new XDocument(new XDeclaration("1.0", null, null)
                    , types);
                nuspec.Save(stream);
            }
        }

        //private static string ContentFolder = "";
        private void CreateContentFile(ZipArchive arch, FileExportViewModel fileExportViewModel)
        {
            var entry = arch.CreateEntry("Content/Data/" + fileExportViewModel.ResourceName);
            using (var stream = entry.Open())
            {
                using (var file = File.Open(fileExportViewModel.FullPath, FileMode.Open, FileAccess.Read,
                    FileShare.ReadWrite))
                {
                    file.CopyTo(stream);
                }
            }
        }

        private void CreateBuildTarget(ZipArchive arch)
        {
            var entry = arch.CreateEntry("build/" + PackageName + ".targets");
            using (var stream = entry.Open())
            {
                var ns = "http://schemas.microsoft.com/developer/msbuild/2003";
                var group = new XElement(XName.Get("ItemGroup", ns));
                foreach (var file in Files.Where(_ => _.Include))
                    group.Add(new XElement(XName.Get("Content", ns)
                        , new XAttribute("Include",
                            "$(MSBuildThisFileDirectory)\\..\\Content\\Data\\" + file.ResourceName.Replace('/', '\\'))
                        , new XElement(XName.Get("Link", ns), "Data\\" + file.ResourceName.Replace('/', '\\'))
                        , new XElement(XName.Get("CopyToOutputDirectory", ns), "PreserveNewest")
                    ));
                var proj = new XElement(XName.Get("Project", ns), group);
                var target = new XDocument( //new XDeclaration("1.0", null, null), 
                    proj);
                target.Save(stream);
            }
        }

        private void CreateNuspec(ZipArchive arch)
        {
            var entry = arch.CreateEntry(PackageName + ".nuspec");
            using (var stream = entry.Open())
            {
                var nuspec = new XDocument(new XDeclaration("1.0", null, null), BuildNuspec());
                nuspec.Save(stream);
            }
        }

        private XElement BuildNuspec()
        {
            XNamespace schema = "http://www.w3.org/2001/XMLSchema";
            XNamespace schemaInstance = "http://www.w3.org/2001/XMLSchema-instance";
            //string ns = "http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd";
            var ns = "http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd";
            var contentFiles = new XElement(XName.Get("contentFiles", ns));
            contentFiles.Add(new XElement(XName.Get("files", ns)
                , new XAttribute("include", "**")
                , new XAttribute("buildAction", "Content")
                , new XAttribute("copyToOutput", "true")
            ));
            return new XElement(XName.Get("package", ns)
                //, new XAttribute(XNamespace.Xmlns+"xsd", schema)
                //, new XAttribute(XNamespace.Xmlns + "xsi", schemaInstance)
                , new XElement(XName.Get("metadata", ns)
                    , new XAttribute("minClientVersion", "3.3.0")
                    , new XElement(XName.Get("id", ns), PackageName)
                    , new XElement(XName.Get("version", ns), Version)
                    , new XElement(XName.Get("authors", ns), Authors)
                    , new XElement(XName.Get("owners", ns), Owners)
                    , new XElement(XName.Get("licenseUrl", ns), LicenseUrl)
                    , new XElement(XName.Get("projectUrl", ns), ProjectUrl)
                    , new XElement(XName.Get("iconUrl", ns), IconUrl)
                    , new XElement(XName.Get("requireLicenseAcceptance", ns),
                        RequireLicenseAcceptance.ToString().ToLower())
                    , new XElement(XName.Get("description", ns), Description)
                    , new XElement(XName.Get("summary", ns), Summary)
                    , new XElement(XName.Get("copyright", ns), Copyright)
                    , new XElement(XName.Get("tags", ns), "Urho3D UrhoSharp Urho3DAsset")
                    //, contentFiles
                )
            );
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(PackageName))
                return false;
            return true;
        }

        public class FileExportViewModel
        {
            private readonly FileViewModel _file;

            public FileExportViewModel(FileViewModel file, string rootFolder)
            {
                _file = file;
                RelName = file.ResourceName;
                if (RelName.StartsWith(rootFolder))
                    RelName = RelName.Substring(rootFolder.Length);
            }

            public string RelName { get; set; }

            public string ResourceName => _file.ResourceName;

            public string FullPath => _file.FullPath;

            public bool Include { get; set; } = true;
        }
    }
}