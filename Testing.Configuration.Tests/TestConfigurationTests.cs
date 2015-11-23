using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Affecto.Testing.Configuration.Tests
{
    [TestClass]
    [DeploymentItem("ConfigFiles")]
    public class TestConfigurationTests
    {
        private readonly ConfigSectionReader sut = new ConfigSectionReader(Environment.CurrentDirectory);
        private TestConfigurationSection configurationSection;

        [TestMethod]
        public void ReadFromValidConfig()
        {

            configurationSection = sut.GetConfigSection<TestConfigurationSection>("Valid.config", "testConfigurationSection");
            Assert.AreEqual("value", configurationSection.RequiredStringProperty);
        }
    }
}