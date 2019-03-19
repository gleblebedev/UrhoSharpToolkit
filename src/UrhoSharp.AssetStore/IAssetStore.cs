using System.Collections.Generic;
using System.Threading.Tasks;

namespace UrhoSharp.AssetStore
{
    public interface IAssetStore
    {
        Task<IList<IAssetPackage>> Query(AssetStoreQueryArgs text);
    }
}