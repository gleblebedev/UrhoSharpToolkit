using System.Collections.Generic;
using System.Linq;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Prefabs
{
    public abstract class AbstractPrefab
    {
        public virtual void BackgroundLoadResource()
        {
            foreach (var property in Properties)
            {
                property.BackgroundLoadResource((IPrefab)this);
            }
        }

        public virtual IEnumerable<IAccessor> Properties
        {
            get { return Enumerable.Empty<IAccessor>(); }
        }
    }
}