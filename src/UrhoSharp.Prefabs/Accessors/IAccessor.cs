using System;
using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public interface IAccessor
    {
        string Name { get; }
        Type UrhoPropertyType { get; }
        Type PrefabPropertyType { get; }
        object DefaultPrefabValue { get; }
        object GetUrho(RefCounted instance);
        void SetUrho(RefCounted instance, object value);
        object GetPrefab(IPrefab instance);
        void SetPrefab(IPrefab instance, object value);
        bool TryParsePrefab(string text, out object value);
        string ToStringPrefab(object value);
        void BackgroundLoadResource(IPrefab prefab);
        bool PrefabHasValue(IPrefab instance);
    }

    public interface IPrefabAccessor<TPrefab, TPrefabProperty> : IAccessor
        where TPrefab : IPrefab
    {
        TPrefabProperty GetPrefab(TPrefab instance);
        void SetPrefab(TPrefab instance, TPrefabProperty value);
        bool TryParsePrefab(string text, out TPrefabProperty value);
        string ToStringPrefab(TPrefabProperty value);
        bool PrefabHasValue(TPrefab instance);
        TPrefabProperty DefaultPrefabValue { get; }
    }
    public interface IUrhoAccessor<TUrho, TUrhoProperty> : IAccessor
        where TUrho : RefCounted
    {
        TUrhoProperty GetUrho(TUrho instance);
        void SetUrho(TUrho instance, TUrhoProperty value);
    }
    public interface IAccessor<TPrefab, TPrefabProperty, TUrho, TUrhoProperty> : 
        IPrefabAccessor<TPrefab, TPrefabProperty>, 
        IUrhoAccessor<TUrho, TUrhoProperty>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        void Apply(TPrefab source, TUrho target);
        void Get(TUrho source, TPrefab target);

        TUrhoProperty PrefabToUrho(TPrefabProperty value);

        TPrefabProperty UrhoToPrefab(TUrhoProperty value);
    }
}
