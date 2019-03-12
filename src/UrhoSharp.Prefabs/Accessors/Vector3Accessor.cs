using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class Vector3Accessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Vector3>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override string ToStringPrefab(Vector3 value)
        {
            return string.Format(InvariantCulture, "{0} {1} {2}", value.X, value.Y, value.Z);
        }

        public override bool TryParsePrefab(string text, out Vector3 value)
        {
            Vector3 res = Vector3.Zero;
            using (var e = SplitVector(text).GetEnumerator())
            {
                if (e.MoveNext())
                {
                    res.X = e.Current;
                    if (e.MoveNext())
                    {
                        res.Y = e.Current;
                        if (e.MoveNext())
                        {
                            res.Z = e.Current;
                        }
                    }
                }
            }

            value = res;
            return true;
        }
    }
}