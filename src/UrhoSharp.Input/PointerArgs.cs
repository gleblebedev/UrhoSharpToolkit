using Urho;

namespace UrhoSharp.Input
{
    public class PointerArgs
    {
        public PointerArgs(Vector2 offset, Vector2 position)
        {
            Offset = offset;
            Position = position;
        }

        public Vector2 Offset { get; }

        public Vector2 Position { get; }

        public override string ToString()
        {
            return $"{Offset}@{Position}";
        }
    }
}