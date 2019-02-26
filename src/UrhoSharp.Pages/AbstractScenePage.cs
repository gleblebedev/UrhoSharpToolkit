using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urho;
using Urho.Gui;
using Urho.Resources;
using UrhoSharp.Input;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.Pages
{
    public abstract class AbstractScenePage : InputMapping, IScenePage
    {
        private readonly UrhoRef<UIElement> _ui = new UrhoRef<UIElement>(new UIElement());
        private Viewport[] _activeViewports;

        private bool _invalidViewports = true;

        private Task _prepareTask;

        protected IUrhoScheduler _scheduler;

        public ScenePageState State { get; private set; } = ScenePageState.NotActive;

        public ResourceCache ResourceCache => Application.Current.ResourceCache;

        public IRenderer Renderer { get; private set; }

        public virtual MouseMode MouseMode => MouseMode.Free;

        public virtual bool MouseGrabbed => false;

        public virtual bool MouseVisible => true;

        public UIElement UI => _ui.Value;

        public Task LoadPageAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            _scheduler = scheduler;
            State = ScenePageState.Preparing;
            return _prepareTask ?? (_prepareTask = PrepareAsync(scheduler, progress));
        }

        public void Activate(IRenderer renderer)
        {
            State = ScenePageState.Paused;
            Renderer = renderer;
            AddViewports();
            Application.Current.UI.Root.AddChild(UI);
            OnActivated();
        }


        public virtual void Resize(IntVector2 size)
        {
            UI.SetSize(size.X, size.Y);
        }

        public void Resume()
        {
            State = ScenePageState.Active;
            Application.Current.Input.SetMouseMode(MouseMode);
            Application.Current.Input.SetMouseGrabbed(MouseGrabbed);
            Application.Current.Input.SetMouseVisible(MouseVisible);
            OnResumed();
        }

        public void Pause()
        {
            State = ScenePageState.Paused;
            OnPaused();
        }

        public void Deactivate()
        {
            OnDeactivated();
            State = ScenePageState.NotActive;
            RemoveViewports();
            Renderer = null;
            Application.Current.UI.Root.RemoveChild(UI);
        }

        public virtual void Update(float timeStep)
        {
            if (_invalidViewports)
            {
                ResetViewports();
                _invalidViewports = false;
            }
        }

        public virtual void OnActivated()
        {
        }

        public virtual void OnResumed()
        {
        }

        public virtual void OnPaused()
        {
        }

        public virtual void OnDeactivated()
        {
        }

        protected virtual Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            return Task.CompletedTask;
        }

        private void AddViewports()
        {
            _activeViewports = GetViewports().ToArray();
            for (var index = 0; index < _activeViewports.Length; index++)
                Renderer.SetViewport((uint) index, _activeViewports[index]);
            _invalidViewports = false;
        }

        private void RemoveViewports()
        {
            if (_activeViewports == null)
                return;
            for (var index = 0; index < _activeViewports.Length; index++) Renderer.SetViewport((uint) index, null);

            _activeViewports = null;
        }

        private void ResetViewports()
        {
            RemoveViewports();
            AddViewports();
        }

        public void InvalidateViewports()
        {
            _invalidViewports = true;
        }

        public virtual IList<Viewport> GetViewports()
        {
            return new Viewport[0];
        }
    }
}