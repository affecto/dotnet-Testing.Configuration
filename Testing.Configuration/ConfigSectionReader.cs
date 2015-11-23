using System.Configuration;
using System.IO;

namespace Affecto.Testing.Configuration
{
    public class ConfigSectionReader
    {
        private readonly string directoryPath;

        public ConfigSectionReader(string directoryPath)
        {
            this.directoryPath = directoryPath;
        }

        public TSection GetConfigSection<TSection>(string configFileName, string sectionName) where TSection : ConfigurationSection
        {
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = Path.Combine(directoryPath, configFileName)
            };

            System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            return config.GetSection(sectionName) as TSection;
        }
    }
}