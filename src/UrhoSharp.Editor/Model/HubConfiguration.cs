using System.Collections.Generic;

namespace UrhoSharp.Editor.Model
{
    public class HubConfiguration
    {
        public List<ProjectReference> Projects { get; } = new List<ProjectReference>();
    }
}