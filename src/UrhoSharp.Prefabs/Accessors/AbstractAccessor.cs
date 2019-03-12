using System;
using System.Collections.Generic;
using System.Globalization;
using Urho;

namespace UrhoSharp.Prefabs.Accessors
{
    public abstract class
        AbstractAccessor<TPrefab, TUrho, TProperty> : AbstractAccessor<TPrefab, TProperty, TUrho, TProperty>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        public override TProperty PrefabToUrho(TProperty value)
        {
            return value; 
        }

        public override TProperty UrhoToPrefab(TProperty value)
        {
            return value;
        }
    }
    public abstract class AbstractAccessor<TPrefab,TPrefabProperty,TUrho,TUrhoProperty>: IAccessor<TPrefab, TPrefabProperty, TUrho, TUrhoProperty>
        where TPrefab : IPrefab
        where TUrho : RefCounted
    {
        private Type _propertyType;
        private Type _prefabPropertyType;

        public abstract string Name { get; }

        object IAccessor.DefaultPrefabValue
        {
            get { return DefaultPrefabValue; }
        }

        public abstract TPrefabProperty DefaultPrefabValue { get; }
        public virtual bool TryParseAndSet(string value, TPrefab instance)
        {
            TPrefabProperty val;
            if (!TryParsePrefab(value, out val))
                return false;
            SetPrefab(instance, val);
            return true;
        }
        public virtual void ParseAndSet(string value, TPrefab instance)
        {
            if (!TryParseAndSet(value, instance))
                throw new FormatException($"Can\'t parse {Name} value \"{value}\"");
        }

        protected IEnumerable<float> SplitVector(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                yield break;
            var parts =  text.Split(whitespaceChars, StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                float v;
                if (!TryParseFloat(part, out v))
                    yield return 0.0f;
                else
                    yield return v;
            }
        }

        protected static readonly char[] whitespaceChars = new char[]
        {
            (char)32,
            (char)9,
            (char)10,
            (char)11,
            (char)12,
            (char)13,
            (char)160,
            (char)133,
        };
        protected bool TryParseFloat(string text, out float v)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                v = 0.0f;
                return true;
            }
            return float.TryParse(text, NumberStyles.Any, InvariantCulture, out v);
        }

        public virtual bool PrefabHasValue(TPrefab instance)
        {
            return !EqualityComparer<TPrefabProperty>.Default.Equals(GetPrefab(instance), DefaultPrefabValue);
        }
        public virtual void Apply(TPrefab source, TUrho target)
        {
            SetUrho(target, PrefabToUrho(GetPrefab(source)));
        }
        public virtual void ApplyIfChanged(TPrefab source, TUrho target)
        {
            if (PrefabHasValue(source))
                SetUrho(target, PrefabToUrho(GetPrefab(source)));
        }
        public virtual void Get(TUrho source, TPrefab target)
        {
            SetPrefab(target, UrhoToPrefab(GetUrho(source)));
        }

        public abstract TUrhoProperty PrefabToUrho(TPrefabProperty value);

        public abstract TPrefabProperty UrhoToPrefab(TUrhoProperty value);

        public Type UrhoPropertyType
        {
            get => typeof(TUrhoProperty);
        }

        public Type PrefabPropertyType
        {
            get => typeof(TPrefabProperty);
        }

        object IAccessor.GetUrho(RefCounted instance)
        {
            return GetUrho((TUrho)instance);
        }
        bool IAccessor.PrefabHasValue(IPrefab instance)
        {
            return PrefabHasValue((TPrefab)instance);
        }
        void IAccessor.SetUrho(RefCounted instance, object value)
        {
            SetUrho((TUrho)instance, (TUrhoProperty)value);
        }

        object IAccessor.GetPrefab(IPrefab instance)
        {
            return GetPrefab((TPrefab) instance);
        }

        void IAccessor.SetPrefab(IPrefab instance, object value)
        {
            SetPrefab((TPrefab)instance, (TPrefabProperty)value);
        }

        bool IAccessor.TryParsePrefab(string text, out object value)
        {
            TPrefabProperty p;
            if (TryParsePrefab(text, out p))
            {
                value = p;
                return true;
            }

            value = null;
            return false;
        }

        string IAccessor.ToStringPrefab(object value)
        {
            return ToStringPrefab((TPrefabProperty)value);
        }

        public abstract TPrefabProperty GetPrefab(TPrefab instance);

        public abstract void SetPrefab(TPrefab instance, TPrefabProperty value);

        public abstract TUrhoProperty GetUrho(TUrho instance);

        public abstract void SetUrho(TUrho instance, TUrhoProperty value);

        public abstract bool TryParsePrefab(string text, out TPrefabProperty value);

        public virtual string ToStringPrefab(TPrefabProperty value)
        {
            return string.Format("{0}", value, InvariantCulture);
        }

        public static readonly CultureInfo InvariantCulture = CultureInfo.InvariantCulture;
        public virtual void BackgroundLoadResource(IPrefab prefab)
        {
        }
    }
}