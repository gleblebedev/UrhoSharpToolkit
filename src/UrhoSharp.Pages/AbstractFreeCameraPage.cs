namespace UrhoSharp.Pages
{
    public abstract class AbstractFreeCameraPage : AbstractSingleScenePage
    {
        public float YawAngle { get; set; }

        public float PitchAngle { get; set; }

        protected override void OnCameraChanged()
        {
            base.OnCameraChanged();
            if (Camera != null)
            {
                YawAngle = Camera.Node.Rotation.YawAngle;
                PitchAngle = Camera.Node.Rotation.PitchAngle;
            }
        }
    }
}