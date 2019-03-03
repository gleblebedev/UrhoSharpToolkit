using System;
using System.Collections.Generic;

namespace UrhoSharp.Editor.Model
{
    internal static class ExtensionMethods
    {
        public static bool RemoveIf<T>(this IList<T> list, Func<T, bool> predicate)
        {
            var res = false;
            for (var index = list.Count - 1; index >= 0; --index)
                if (predicate(list[index]))
                    list.RemoveAt(index);

            return res;
        }
    }
}