using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.HierarchicalNavigation.InputDeviceAdapters;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.HierarchicalNavigation
{
    public class CurrentPageContainer : ICurrentPageContainer, IDisposable
    {
        private readonly object _gate = new object();
        private readonly IInput _input;
        private readonly KeyboardAdapter _keyboard;
        private readonly MouseAdapter _mouse;
        private readonly IRenderer _renderer;
        private readonly IUrhoScheduler _scheduler;

        private bool _isPaused;

        private IScenePage _loading = new EmplyLoadingScenePage();

        public CurrentPageContainer(IInput input, IRenderer renderer, IUrhoScheduler scheduler)
        {
            _input = input;
            _renderer = renderer;
            _scheduler = scheduler;
            _keyboard = new KeyboardAdapter(input);
            _mouse = new MouseAdapter(input);
        }


        public async Task SetCurrentPageAsync(IScenePage page)
        {
            if (CurrentPage != page)
            {
                await _scheduler.RunAsync(() => ReleaseCurrentPage());
                CurrentPage = _loading;
                await _scheduler.RunAsync(() => ActivateCurrentPage());
                await page.LoadPageAsync(_scheduler, LoadingProgress);
                await _scheduler.RunAsync(() =>
                {
                    ReleaseCurrentPage();
                    CurrentPage = page;
                    ActivateCurrentPage();
                });
            }
        }

        protected ILoadingProgress LoadingProgress
        {
            get { return (_loading as ILoadingProgress) ?? DummyLoadingProgress.Instance; }
        }

        public IScenePage CurrentPage { get; private set; }

        public void OnUpdate(float timeStep)
        {
            lock (_gate)
            {
                foreach (var adapter in GetInputDeviceAdapters()) adapter.OnUpdate(timeStep);
            }

            if (_isCurrentPageActive)
            {
                CurrentPage?.Update(timeStep);
            }
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
            foreach (var adapter in GetInputDeviceAdapters()) adapter.Dispose();
        }

        private IEnumerable<IInputDeviceAdapter> GetInputDeviceAdapters()
        {
            yield return _keyboard;
            yield return _mouse;
        }

        private bool _isCurrentPageActive;
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
                foreach (var adapter in GetInputDeviceAdapters()) adapter.AssignPage(page);
                _isCurrentPageActive = true;
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
                foreach (var adapter in GetInputDeviceAdapters()) adapter.ReleasePage(page);
                page.Deactivate();
                _isCurrentPageActive = false;
            }
        }

        public async Task SetLoadingPageAsync(IScenePage loadingScenePage)
        {
            _loading = loadingScenePage;
            await _loading.LoadPageAsync(_scheduler, DummyLoadingProgress.Instance);
        }

        private IntVector2 _graphicsSize;
        public void Resize(IntVector2 graphicsSize)
        {
            if (_graphicsSize == graphicsSize)
                return;
            _graphicsSize = graphicsSize;
            CurrentPage?.Resize(_graphicsSize);
        }
    }
}