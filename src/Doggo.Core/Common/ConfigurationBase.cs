using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace Doggo
{
    public class ConfigurationBase
    {
        public static string Version { get; } =
            typeof(ConfigurationBase).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ??
            typeof(ConfigurationBase).GetTypeInfo().Assembly.GetName().Version.ToString(3) ??
            "Unknown";

        [JsonIgnore]
        public static string FileName { get; private set; } = "configuration.json";

        public ConfigurationBase() { }
        public ConfigurationBase(string fileName)
        {
            FileName = fileName;
        }

        public void SaveJson()
        {
            string file = Path.Combine(AppContext.BaseDirectory, FileName);
            File.WriteAllText(file, ToJson());
        }

        public static T Load<T>() where T : ConfigurationBase
        {
            string file = Path.Combine(AppContext.BaseDirectory, FileName);
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(file));
        }

        public string ToJson()
            => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
