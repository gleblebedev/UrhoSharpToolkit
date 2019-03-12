using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class Vector2Accessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Vector2>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override string ToStringPrefab(Vector2 value)
        {
            return string.Format(InvariantCulture, "{0} {1}", value.X, value.Y);
        }

        public override bool TryParsePrefab(string text, out Vector2 value)
        {
            Vector2 res = Vector2.Zero;
            using (var e = SplitVector(text).GetEnumerator())
            {
                if (e.MoveNext())
                {
                    res.X = e.Current;
                    if (e.MoveNext())
                    {
                        res.Y = e.Current;
                    }
                }
            }

            value = res;
            return true;
        }
    }
}