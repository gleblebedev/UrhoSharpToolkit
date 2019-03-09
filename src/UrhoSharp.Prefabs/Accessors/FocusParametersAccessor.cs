using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class FocusParametersAccessor<TPrefab, TUrho> : AbstractAccessor<TPrefab, TUrho, FocusParameters>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override bool TryParsePrefab(string text, out FocusParameters value)
        {
            throw new System.NotImplementedException();
        }
    }
}