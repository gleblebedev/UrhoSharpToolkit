using System.Security.Principal;

namespace UrhoSharp.Editor.Model
{
    public class NugetPackageConfiguration
    {
        public static readonly string ConfigurationFileName = ".nugetpackage";

        public string PackageName { get; set; }

        public string Version { get; set; } = "0.0.1";

        public string LicenseUrl { get; set; } = "https://creativecommons.org/publicdomain/zero/1.0/";

        public string Authors { get; set; } = WindowsIdentity.GetCurrent().Name;

        public string Owners { get; set; } = WindowsIdentity.GetCurrent().Name;

        public bool RequireLicenseAcceptance { get; set; }

        public string Description { get; set; } = "Content for use with Urho3D or UrhoSharp game engines";

        public string Summary { get; set; } = "Content for use with Urho3D or UrhoSharp game engines";

        public string ProjectUrl { get; set; } = "https://urho3d.github.io/";

        public string IconUrl { get; set; } = "https://urho3d.github.io/assets/images/logo.png";

        public string Copyright { get; set; } = "";

        public string[] ExcludeFiles { get; set; } = new string[0];
    }
}