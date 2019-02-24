using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urho;
using Urho.Gui;
using UrhoSharp.Interfaces;
using UrhoSharp.Rx;

namespace UrhoSharp.HierarchicalNavigation
{
    public abstract class AbstractScenePage : IScenePage
    {
        private Viewport[] _activeViewports;

        private bool _invalidViewports = true;

        private Task _prepareTask;

        public IRenderer Renderer { get; private set; }

        public virtual MouseMode MouseMode => MouseMode.Free;

        public virtual bool MouseGrabbed => false;

        public virtual bool MouseVisible => true;

        public Task LoadPageAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            return _prepareTask ?? (_prepareTask = PrepareAsync(scheduler, progress));
        }

        public virtual void Activate(IRenderer renderer)
        {
            Renderer = renderer;
            AddViewports();
            Application.Current.UI.Root.AddChild(UI);
        }
        public virtual void Resize(IntVector2 size)
        {
            UI.SetSize(size.X, size.Y);
        }
        public virtual void Resume()
        {
            Application.Current.Input.SetMouseMode(MouseMode);
            Application.Current.Input.SetMouseGrabbed(MouseGrabbed);
            Application.Current.Input.SetMouseVisible(MouseVisible);
        }

        private UrhoRef<UIElement> _ui =new UrhoRef < UIElement > (new UIElement());
        public UIElement UI
        {
            get { return _ui.Value; }
        }

        public virtual void Pause()
        {
        }

        public virtual void Deactivate()
        {
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

        #region IInputSubscriber

        public virtual void OnKeyCancel(object sender, KeyCancelEventArguments args)
        {
        }

        public virtual void OnKeyDown(object sender, KeyDownEventArguments args)
        {
        }

        public virtual void OnKeyUp(object sender, KeyUpEventArguments args)
        {
        }

        public virtual void OnMouseButtonCancel(object sender, MouseButtonCancelEventArguments args)
        {
        }

        public virtual void OnMouseButtonDown(object sender, MouseButtonDownEventArguments args)
        {
        }

        public virtual void OnMouseButtonUp(object sender, MouseButtonUpEventArguments args)
        {
        }

        public virtual void OnMouseMoved(object sender, MouseMovedEventArguments args)
        {
        }

        public virtual void OnMouseWheel(object sender, MouseWheelEventArguments args)
        {
        }

        public virtual void OnMouseVisibleChanged(object sender, MouseVisibleChangedEventArguments args)
        {
        }

        public virtual void OnMouseModeChanged(object sender, MouseModeChangedEventArguments args)
        {
        }

        public virtual void OnTextInput(object sender, TextInputEventArguments args)
        {
        }

        public virtual void OnJoystickConnected(object sender, JoystickConnectedEventArguments args)
        {
        }

        public virtual void OnJoystickDisconnected(object sender, JoystickDisconnectedEventArguments args)
        {
        }

        public virtual void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
        }

        public virtual void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
        }

        public virtual void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
        }

        public virtual void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
        }

        public virtual void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
        }

        public virtual void OnTouchEnd(object sender, TouchEndEventArguments args)
        {
        }

        public virtual void OnTouchMove(object sender, TouchMoveEventArguments args)
        {
        }

        public virtual void OnGestureRecorded(object sender, GestureRecordedEventArguments args)
        {
        }

        public virtual void OnGestureInput(object sender, GestureInputEventArguments args)
        {
        }

        public virtual void OnMultiGesture(object sender, MultiGestureEventArguments args)
        {
        }

        public virtual void OnDropFile(object sender, DropFileEventArguments args)
        {
        }

        public virtual void OnInputFocus(object sender, InputFocusEventArguments args)
        {
        }

        public virtual void OnExitRequested(object sender, ExitRequestedEventArguments args)
        {
        }

        #endregion
    }
}