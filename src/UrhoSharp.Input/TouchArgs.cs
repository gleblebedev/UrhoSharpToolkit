using System.Collections.Generic;

namespace UrhoSharp.Input
{
    public class TouchArgs
    {
        private readonly bool _isNew;
        private readonly IList<PointerArgs> _toches;

        public TouchArgs(IList<PointerArgs> toches, bool isNew)
        {
            _toches = toches;
            _isNew = isNew;
        }

        public override string ToString()
        {
            return string.Join(", ", _toches);
        }
    }
}