namespace UrhoSharp.Pages
{
    public interface ILoadingProgress
    {
        void ReportProgress(int index, int count, string message);
    }
}