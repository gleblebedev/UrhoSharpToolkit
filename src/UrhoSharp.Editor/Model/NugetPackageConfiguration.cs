namespace UrhoSharp.Editor.Model
{
    public class NugetPackageConfiguration
    {
        public static readonly string ConfigurationFileName = ".nugetpackage";
        private string _version = "0.0.1";
        private string _licenseUrl = "https://creativecommons.org/publicdomain/zero/1.0/";
        private string _authors = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        private string _owners = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        private bool _requireLicenseAcceptance;
        private string _description = "Content for use with Urho3D or UrhoSharp game engines";
        private string _summary = "Content for use with Urho3D or UrhoSharp game engines";
        private string _projectUrl = "https://urho3d.github.io/";
        private string _iconUrl = "https://urho3d.github.io/assets/images/logo.png";
        private string _copyright = "";

        public string PackageName { get; set; }

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        public string LicenseUrl
        {
            get { return _licenseUrl; }
            set { _licenseUrl = value; }
        }

        public string Authors
        {
            get { return _authors; }
            set { _authors = value; }
        }

        public string Owners
        {
            get { return _owners; }
            set { _owners = value; }
        }

        public bool RequireLicenseAcceptance
        {
            get { return _requireLicenseAcceptance; }
            set { _requireLicenseAcceptance = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

        public string ProjectUrl
        {
            get { return _projectUrl; }
            set { _projectUrl = value; }
        }

        public string IconUrl
        {
            get { return _iconUrl; }
            set { _iconUrl = value; }
        }

        public string Copyright
        {
            get { return _copyright; }
            set { _copyright = value; }
        }

        public string[] ExcludeFiles { get; set; } = new string[0];
    }
}