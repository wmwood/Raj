using System;
using System.IO;

namespace wmwood.Raj
{
    public class LoadConfigurationUseCase
    {
        public Configuration Load(string configurationFilePath)
        {
            //var fileContents = File.ReadAllText(configurationFilePath);

            //if(string.IsNullOrWhiteSpace(fileContents))
            //    throw new InvalidOperationException("Configuration file is empty.");

            return new Configuration(null, null);
        }
    }

    public class Configuration
    {
        public Configuration(GlobalSettings globalSettings, dynamic themeSettings)
        {
            GlobalSettings = globalSettings;
            ThemeSettings = themeSettings;
        }

        public GlobalSettings GlobalSettings { get; private set; }
        public dynamic ThemeSettings { get; private set; }
    }

    public class GlobalSettings
    {
        public string SiteTitle { get; set; }
    }
}