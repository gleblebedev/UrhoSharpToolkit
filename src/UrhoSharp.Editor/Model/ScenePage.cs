using UrhoSharp.Pages;

namespace UrhoSharp.Editor.Model
{
    public class ScenePage : AbstractSingleScenePage
    {
        private readonly string _sceneName;

        public ScenePage(string sceneName)
        {
            _sceneName = sceneName;
            CreateSimpleScene();
        }
    }
}