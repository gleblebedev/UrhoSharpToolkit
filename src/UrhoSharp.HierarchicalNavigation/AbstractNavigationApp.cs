using System;
using Urho;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.HierarchicalNavigation
{
    public class AbstractNavigationApp : Application
    {
        private bool _hasInputFocus = true;
        private bool _isMinimized;
        private bool _isPagePaused;
        private bool _isPaused;
        private UrhoManualScheduler _scheduler;

        public AbstractNavigationApp(ApplicationOptions options) : base(options)
        {
        }

        public AbstractNavigationApp(IntPtr handle) : base(handle)
        {
        }

        protected AbstractNavigationApp(UrhoObjectFlag emptyFlag) : base(emptyFlag)
        {
        }

        public CurrentPageContainer CurrentPageContainer { get; private set; }
        public NavigationStack Navigation { get; private set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void Start()
        {
            _scheduler = new UrhoManualScheduler();
            Paused += OnPaused;
            Resumed += OnResumed;
            Input.InputFocus += OnInputFocusChanged;
            base.Start();
            InitNavigation();
        }

        private void OnInputFocusChanged(InputFocusEventArgs args)
        {
            _hasInputFocus = args.Focus;
            _isMinimized = args.Minimized;
            UpdatePageState();
        }

        private void UpdatePageState()
        {
            var isPagePaused = _isMinimized;
            if (isPagePaused != _isPagePaused)
                if (isPagePaused)
                    Pause();
                else
                    Resume();
        }

        private void OnResumed()
        {
            _isPaused = false;
            UpdatePageState();
        }

        private void OnPaused()
        {
            _isPaused = true;
            UpdatePageState();
        }

        protected virtual void Pause()
        {
            _isPagePaused = true;
            CurrentPageContainer.Pause();
        }

        protected virtual void Resume()
        {
            _isPagePaused = false;
            CurrentPageContainer.Resume();
        }


        private void InitNavigation()
        {
            CurrentPageContainer =
                new CurrentPageContainer(new InputAdapter(Input), new RendererAdapter(Renderer), _scheduler);
            CurrentPageContainer.Resize(Graphics.Size);
            Navigation = new NavigationStack(CurrentPageContainer);
        }

        private IntVector2 _prevGraphicsSize;

        protected override void OnUpdate(float timeStep)
        {
            base.OnUpdate(timeStep);
            if (_prevGraphicsSize != Graphics.Size)
            {
                _prevGraphicsSize = Graphics.Size;
                CurrentPageContainer.Resize(_prevGraphicsSize);
            }
            _scheduler.Update(timeStep);
            CurrentPageContainer.OnUpdate(timeStep);
        }
    }
}