using System.Configuration;

namespace Affecto.Testing.Configuration.Tests
{
    internal class TestConfigurationSection : ConfigurationSection
    {
        private static readonly TestConfigurationSection SettingsInstance = ConfigurationManager.GetSection("testConfigurationSection") as TestConfigurationSection;

        public static TestConfigurationSection Settings
        {
            get { return SettingsInstance; }
        }

        [ConfigurationProperty("requiredStringProperty", IsRequired = true)]
        public string RequiredStringProperty
        {
            get
            {
                return (string)this["requiredStringProperty"];
            }
            set { this["requiredStringProperty"] = value; }
        }
    }
}