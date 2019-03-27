using Urho;

namespace UrhoSharp.Input
{
    public class AggregatingPointerAction : IPointerAction
    {
        public Vector2 Offset { get; private set; }

        public Vector2 Position { get; private set; }

        public void StartOrUpdate(PointerArgs value)
        {
            Offset += value.Offset;
            Position = value.Position;
        }

        public void Cancel()
        {
            Offset = Vector2.Zero;
        }
    }
}