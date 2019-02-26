using System;
using System.Collections.Generic;

namespace UrhoSharp.Input
{
    internal static class InternalExtensionMethods
    {
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
            Func<TKey, TValue> factory)
        {
            TValue res;
            if (dictionary.TryGetValue(key, out res))
                return res;
            dictionary.Add(key, res = factory(key));
            return res;
        }
    }
}