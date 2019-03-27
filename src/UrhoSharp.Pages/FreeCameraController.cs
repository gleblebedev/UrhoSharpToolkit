using Urho;
using UrhoSharp.Input;
using UrhoSharp.Interfaces;

namespace UrhoSharp.Pages
{
    public class FreeCameraController : InputMapping
    {
        private readonly Node _cameraNode;
        private readonly AxisAction _backward = new AxisAction();
        private readonly Camera _camera;

        private readonly AxisAction _forward = new AxisAction();
        private readonly AxisAction _left = new AxisAction();
        private readonly AxisAction _lookLeft = new AxisAction();
        private readonly AxisAction _lookRight = new AxisAction();

        private readonly AggregatingPointerAction _mouseMove = new AggregatingPointerAction();
        private readonly AxisAction _right = new AxisAction();
        private readonly TriggerAction _rightMouseButton = new TriggerAction();
        protected float CamreraSpeed = 10.0f;

        public FreeCameraController(Node cameraNode)
        {
            _cameraNode = cameraNode;
            _camera = cameraNode.GetComponent<Camera>();
            MapKey(Key.W, _forward);
            MapKey(Key.Up, _forward);
            MapKey(Key.S, _backward);
            MapKey(Key.Down, _forward);
            MapJoystickAxis(1, new SplitAxisAction(_backward, _forward));
            MapKey(Key.A, _left);
            MapKey(Key.Left, _left);
            MapKey(Key.D, _right);
            MapKey(Key.Right, _right);
            MapMouseButton(MouseButton.Right, _rightMouseButton);
            MapJoystickAxis(0, new SplitAxisAction(_right, _left));

            MapJoystickAxis(2, new SplitAxisAction(_lookRight, _lookLeft));

            MapPointer(_mouseMove);
        }

        public bool MouseLocked { get; set; }

        public MouseMode MouseMode { get; set; }

        public override void OnMouseModeChanged(object sender, MouseModeChangedEventArguments args)
        {
            base.OnMouseModeChanged(sender, args);

            MouseMode = args.Mode;
            MouseLocked = args.MouseLocked;
        }

        public override void Update(float timeStep)
        {
            base.Update(timeStep);
            if (_camera?.Node == null)
                return;

            const float mouseSensitivity = .1f;
            const float joystickSensitivity = 96.0f;

            //if (UI.FocusElement != null)
            //    return;

            var cameraRotation = _cameraNode.Rotation;
            var yaw = cameraRotation.YawAngle;
            var pitch = cameraRotation.PitchAngle;
            var roll = cameraRotation.RollAngle;

            var mouseOffset = MouseMode == MouseMode.Absolute || MouseLocked || _rightMouseButton.Value
                ? _mouseMove.Offset
                : Vector2.Zero;
            _mouseMove.Cancel();

            yaw += mouseSensitivity * mouseOffset.X +
                   (_lookRight.Value - _lookLeft.Value) * joystickSensitivity * timeStep;
            pitch += mouseSensitivity * mouseOffset.Y;
            pitch = MathHelper.Clamp(pitch, -90, 90);

            _cameraNode.Rotation = new Quaternion(pitch, yaw, roll);

            var translation =
                (
                    Vector3.UnitZ * (_forward.Value - _backward.Value)
                    + Vector3.UnitX * (_right.Value - _left.Value)
                    //+ Vector3.UnitY * (_moveUpKeyboard - _moveDownKeyboard)
                )
                * CamreraSpeed * timeStep;
            _cameraNode.Translate(translation);
        }
    }
}