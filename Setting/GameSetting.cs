using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace tarkov_settings.Setting
{
    class GameSetting
    {
        private readonly string settingPath;
        private TarkovSetting setting;

        public GameSetting()
        {
            settingPath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Documents\Escape from Tarkov\local.ini");

            using (StreamReader file = File.OpenText(settingPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                setting = (TarkovSetting)serializer.Deserialize(file, typeof(TarkovSetting));
            }
            Console.WriteLine(setting);
        }

    }
}
