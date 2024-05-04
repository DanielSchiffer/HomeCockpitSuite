
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DanielSchiffer.HCS.Logic.Settings
{
    public class SettingsManager
    {
        public Configuration configuration { get; private set; }

        public SettingsManager()
        {
            CreateFolder();
            configuration = GetConfiguration();
        }

        public Configuration GetConfiguration()
        {

            if (configuration == null)
            {
                Load();
            }
            return configuration is null ? CreateDefaultConfig() : configuration;
        }

        private void CreateFolder()
        {
            string pfad = GetConfigPath();
            if (!Directory.Exists(pfad))
            {
                Directory.CreateDirectory(pfad);
            }
        }

        public string GetConfigPath()
        {
            return Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HCS", "Configuration");
        }
        public void SaveConfig()
        {
            Save();
        }


        private string GetConfigFile()
        {
            return Path.Combine(GetConfigPath(), "config.json");
        }

        private void Save()
        {
            string file = GetConfigFile();
            string json = JsonConvert.SerializeObject(configuration, Formatting.Indented);
            File.WriteAllText(file, json);
        }

        private void Load()
        {
            string filePath = GetConfigFile();
            if (!File.Exists(filePath))
            {
                configuration = CreateDefaultConfig();
            }
            else
            {
                string json = File.ReadAllText(filePath);
                var config = JsonConvert.DeserializeObject<Configuration>(json);

                if (config == null)
                {
                    configuration = CreateDefaultConfig();
                }
                else
                {
                    configuration = config;
                }
            }
        }

        private Configuration CreateDefaultConfig()
        {
            Configuration config = new Configuration
            {
                EntwicklerModus = false,
                PilotsName = "Daniel Schiffer",
                SimBriefUser = "Boone0815"
            };
            return config;
        }
    }
}
