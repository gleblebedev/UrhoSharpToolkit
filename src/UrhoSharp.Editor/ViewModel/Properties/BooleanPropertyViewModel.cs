using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrhoSharp.Prefabs;
using UrhoSharp.Prefabs.Accessors;

namespace UrhoSharp.Editor.ViewModel.Properties
{
    public class BooleanPropertyViewModel: PropertyViewModel
    {
        public BooleanPropertyViewModel(IPrefab prefab, IAccessor accessor, int index) : base(prefab, accessor, index)
        {
        }
    }
}
