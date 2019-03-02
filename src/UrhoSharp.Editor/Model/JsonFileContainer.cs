using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace UrhoSharp.Editor.Model
{
    public class JsonFileContainer<T> : IConfigurationContainer<T> where T : new()
    {
        private readonly string _fileName;
        private readonly Lazy<T> _value;

        public JsonFileContainer(string fileName)
        {
            _fileName = fileName;
            _value = new Lazy<T>(LoadOrCreateValue);
        }

        public T Value => _value.Value;

        public void Save()
        {
            if (_value.IsValueCreated) Save(_value.Value);
        }

        private T LoadOrCreateValue()
        {
            if (!File.Exists(_fileName)) return new T();

            try
            {
                using (var file = File.Open(_fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var reader = new StreamReader(file))
                    {
                        return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                Console.Error.WriteLine(ex);
                return new T();
            }
        }

        private void Save(T value)
        {
            using (var file = File.Open(_fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var writer = new StreamWriter(file, new UTF8Encoding(false)))
                {
                    writer.Write(JsonConvert.SerializeObject(value));
                }
            }
        }
    }
}