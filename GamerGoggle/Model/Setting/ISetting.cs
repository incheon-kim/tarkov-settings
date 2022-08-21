using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;
using Serilog;
using System.CodeDom;

namespace GamerGoggle.Model.Setting
{
    public abstract class ISetting<T> where T : new()
    {
        private const string DEFAULT_FILENAME = "settings.json";

        /**
         * Save methods use object type as template because System.Text.Json.JsonSerializer
         * use template of this as ISetting<T>.
         * 
         * This prevents serialization for implementation of ISetting<T>. (ex. AppSetting)
         */
        public void Save(string fileName = DEFAULT_FILENAME)
        {
            using var fs = new FileStream(fileName, FileMode.OpenOrCreate);
            JsonSerializer.Serialize<object>(fs, this, new JsonSerializerOptions() { WriteIndented = true });
        }

        public async Task SaveAsync(string fileName = DEFAULT_FILENAME)
        {
            using var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite, 0x10000, true);
            await JsonSerializer.SerializeAsync<object>(fs, this, new JsonSerializerOptions() { WriteIndented = true });
        }

        public static T Load(string fileName = DEFAULT_FILENAME)
        {
            T t = new();

            try
            {
                using var fs = new FileStream(fileName, FileMode.Open);
                #pragma warning disable CS8600
                t = JsonSerializer.Deserialize<T>(fs) ?? new T();
                #pragma warning restore CS8600
            }
            catch 
            { 
                Log.Logger.Error("Setting File Not Found or Invalid");
            }

            return t;
        }

        public static async Task<T> LoadAsync(string fileName = DEFAULT_FILENAME)
        {
            T t = new();

            try
            {
                using var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, 0x10000, true);
#pragma warning disable CS8600
                t = await JsonSerializer.DeserializeAsync<T>(fs) ?? new T();
#pragma warning restore CS8600
            }
            catch
            {
                Log.Logger.Error("Setting File Not Found or Invalid");
            }

            return t;
        }
    }
}
