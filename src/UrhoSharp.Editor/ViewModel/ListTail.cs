using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UrhoSharp.Editor.ViewModel
{
    internal class ListTail<T> : IReadOnlyList<T>
    {
        private readonly IReadOnlyList<T> _list;
        private readonly int _offset;

        public ListTail(IReadOnlyList<T> list, int offset)
        {
            _list = list;
            _offset = offset;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.Skip(_offset).GetEnumerator();
        }

        public int Count => _list.Count - _offset;

        public T this[int index] => _list[index + _offset];

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}