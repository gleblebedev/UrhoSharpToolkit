using System;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.Input;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.Pages
{
    public class CurrentPageContainer : ICurrentPageContainer, IDisposable
    {
        private readonly object _gate = new object();
        private readonly InputDispatcher _input;
        private readonly InputProxy _inputProxy;
        private readonly IRenderer _renderer;
        private readonly IUrhoScheduler _scheduler;

        private IntVector2 _graphicsSize;

        private bool _isCurrentPageActive;

        private bool _isPaused;

        private IScenePage _loading = new EmplyLoadingScenePage();

        public CurrentPageContainer(IInput input, IRenderer renderer, IUrhoScheduler scheduler)
        {
            _input = new InputDispatcher();
            _inputProxy = new InputProxy(input, _input);
            _renderer = renderer;
            _scheduler = scheduler;
        }

        protected ILoadingProgress LoadingProgress => _loading as ILoadingProgress ?? DummyLoadingProgress.Instance;


        public async Task SetCurrentPageAsync(IScenePage page)
        {
            if (CurrentPage != page)
                if (page == null)
                {
                    await _scheduler.RunAsync(() => { ReleaseCurrentPage(); });
                }
                else
                {
                    await _scheduler.RunAsync(() =>
                    {
                        ReleaseCurrentPage();
                        CurrentPage = _loading;
                        ActivateCurrentPage();
                    });
                    await page.LoadPageAsync(_scheduler, LoadingProgress);
                    await _scheduler.RunAsync(() =>
                    {
                        ReleaseCurrentPage();
                        CurrentPage = page;
                        ActivateCurrentPage();
                    });
                }
        }

        public IScenePage CurrentPage { get; private set; }

        public void OnUpdate(float timeStep)
        {
            if (_isCurrentPageActive) CurrentPage?.Update(timeStep);
        }

        public void Pause()
        {
            _isPaused = true;
            CurrentPage?.Pause();
        }

        public void Resume()
        {
            _isPaused = false;
            CurrentPage?.Resume();
        }

        public void Dispose()
        {
            _inputProxy.Dispose();
        }


        private void ActivateCurrentPage()
        {
            lock (_gate)
            {
                if (CurrentPage == null)
                    return;
                var page = CurrentPage;
                page.Activate(_renderer);
                page.Resize(_graphicsSize);
                if (!_isPaused)
                    page.Resume();
                _input.Subscriber = page;
                _isCurrentPageActive = true;
                PageActivated?.Invoke(this, new PageEventArgs(page));
            }
        }

        private void ReleaseCurrentPage()
        {
            lock (_gate)
            {
                var page = CurrentPage;
                CurrentPage = null;
                if (page == null)
                    return;
                if (!_isPaused)
                    page.Pause();
                _input.Subscriber = null;
                page.Deactivate();
                _isCurrentPageActive = false;
                PageDeactivated?.Invoke(this, new PageEventArgs(page));
            }
        }

        public event EventHandler<PageEventArgs> PageActivated;
        public event EventHandler<PageEventArgs> PageDeactivated;

        public async Task SetLoadingPageAsync(IScenePage loadingScenePage)
        {
            _loading = loadingScenePage;
            await _loading.LoadPageAsync(_scheduler, DummyLoadingProgress.Instance);
        }

        public void Resize(IntVector2 graphicsSize)
        {
            if (_graphicsSize == graphicsSize)
                return;
            _graphicsSize = graphicsSize;
            CurrentPage?.Resize(_graphicsSize);
        }
    }
}