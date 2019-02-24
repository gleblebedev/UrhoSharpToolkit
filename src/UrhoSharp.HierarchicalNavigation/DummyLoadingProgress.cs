using System.Diagnostics;

namespace UrhoSharp.HierarchicalNavigation
{
    public class DummyLoadingProgress : ILoadingProgress
    {
        public static ILoadingProgress Instance { get; } = new DummyLoadingProgress();

        public void ReportProgress(int index, int count, string message)
        {
            Trace.WriteLine("Loading: " + index + "/" + count + " " + message);
        }
    }
}