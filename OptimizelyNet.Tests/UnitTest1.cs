using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimizelyNet;

namespace OptimizelyNet.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string ApiToken;
        public UnitTest1()
        {
            ApiToken = ConfigurationManager.AppSettings.Get("ApiToken");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var optimizely = new OptimizelyNet(ApiToken);
            var projects = optimizely.GetProjects();

            Assert.IsNotNull(projects);
        }
    }
}
