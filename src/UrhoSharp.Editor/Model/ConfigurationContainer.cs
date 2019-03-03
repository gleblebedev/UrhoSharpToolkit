using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace UrhoSharp.Editor.Model
{
    public class ConfigurationContainer<T> : IConfigurationContainer<T> where T : new()
    {
        private readonly Lazy<T> _value = new Lazy<T>(LoadOrCreateValue);

        public T Value => _value.Value;

        public void Save()
        {
            if (_value.IsValueCreated) Save(_value.Value);
        }

        private static T LoadOrCreateValue()
        {
            var fileName = GetFileName();
            if (!File.Exists(fileName)) return new T();

            try
            {
                using (var file = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
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

        private static string GetFileName()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "UrhoSharp.Editor",
                typeof(T).Name + ".json");
        }

        private void Save(T value)
        {
            var fileName = GetFileName();
            Directory.CreateDirectory(Path.GetDirectoryName(fileName));
            using (var file = File.Open(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var writer = new StreamWriter(file, new UTF8Encoding(false)))
                {
                    writer.Write(JsonConvert.SerializeObject(value, Formatting.Indented));
                }
            }
        }
    }
}