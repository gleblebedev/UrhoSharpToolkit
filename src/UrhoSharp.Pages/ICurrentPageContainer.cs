using System.Threading.Tasks;

namespace UrhoSharp.Pages
{
    public interface ICurrentPageContainer
    {
        /// <summary>
        ///     Get current active page.
        /// </summary>
        IScenePage CurrentPage { get; }

        /// <summary>
        ///     Step current page.
        /// </summary>
        /// <param name="timeStep">time step in seconds.</param>
        void OnUpdate(float timeStep);

        /// <summary>
        ///     Pause the page.
        /// </summary>
        void Pause();

        /// <summary>
        ///     Resume the page.
        /// </summary>
        void Resume();

        /// <summary>
        ///     Set current active page.
        /// </summary>
        /// <param name="page">page to set as current active page.</param>
        /// <returns>Awaitable task</returns>
        Task SetCurrentPageAsync(IScenePage page);
    }
}