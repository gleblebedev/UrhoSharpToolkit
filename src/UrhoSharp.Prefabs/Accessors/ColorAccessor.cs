using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class ColorAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, Color>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override string ToStringPrefab(Color value)
        {
            return string.Format(InvariantCulture, "{0} {1} {2} {3}", value.R, value.G, value.B, value.A);
        }

        public override bool TryParsePrefab(string text, out Color value)
        {
            Color res = Color.Black;
            using (var e = SplitVector(text).GetEnumerator())
            {
                if (e.MoveNext())
                {
                    res.R = e.Current;
                    if (e.MoveNext())
                    {
                        res.G = e.Current;
                        if (e.MoveNext())
                        {
                            res.B = e.Current;
                            if (e.MoveNext())
                            {
                                res.A = e.Current;
                            }
                        }
                    }
                }
            }

            value = res;
            return true;
        }
    }
}