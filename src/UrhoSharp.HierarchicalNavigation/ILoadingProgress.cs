namespace UrhoSharp.HierarchicalNavigation
{
    public interface ILoadingProgress
    {
        void ReportProgress(int index, int count, string message);
    }
}