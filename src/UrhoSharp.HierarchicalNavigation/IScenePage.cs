using System.Threading.Tasks;
using Urho;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.HierarchicalNavigation
{
    public interface IScenePage : IInputSubscriber
    {
        Task LoadPageAsync(IUrhoScheduler scheduler, ILoadingProgress progress);

        void Activate(IRenderer renderer);

        void Resume();

        void Pause();

        void Deactivate();

        void Update(float timeStep);
        void Resize(IntVector2 graphicsSize);
    }
}