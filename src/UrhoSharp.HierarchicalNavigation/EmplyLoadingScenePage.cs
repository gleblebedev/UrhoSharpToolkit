namespace UrhoSharp.HierarchicalNavigation
{
    public class EmplyLoadingScenePage : AbstractSingleScenePage, ILoadingProgress
    {
        public EmplyLoadingScenePage()
        {
            CreateSimpleScene(100);
        }

        public void ReportProgress(int index, int count, string message)
        {
        }
    }
}