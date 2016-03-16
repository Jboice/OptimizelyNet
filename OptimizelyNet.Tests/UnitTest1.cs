using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimizelyNet;
using OptimizelyNet.DTO;

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
            var result = optimizely.ExecuteAsync<List<Project>>("experiment/v1/projects/").GetAwaiter().GetResult();

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count > 0);
        }
    }
}
