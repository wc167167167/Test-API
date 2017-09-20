using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Utilities;
using Test.Utilities.Gop;

namespace Test.TestCases
{
    [CodedUITest]
    public class GopApiGeneralTesting : TestMethodBase
    {
        [TestMethod]
        [FunctionalTest(Id = 1, ScenarioName = "Test Basic Access to the API")]
        public void TestApiAvailability()
        {
            var response = GopApiHelper.Execute(
                "http://content.guardianapis.com/",
                "search",
                "30c5a1f2-3132-4f94-bba1-38b397fdec67",
                null,
                null);
            Assert.AreEqual(response.response.status.Value, "ok");
        }

        [TestMethod]
        [FunctionalTest(Id = 2, ScenarioName = "Test Using Invalid Key with Filter")]
        public void TestInvalidApiKey()
        {
            var response = GopApiHelper.Execute(
                "http://content.guardianapis.com/",
                "search",
                "InvalidKey",
                null,
                new SectionFilter("sport"));
            Assert.AreEqual(response.message.Value, "Invalid authentication credentials");
        }

        [TestMethod]
        [FunctionalTest(Id = 3, ScenarioName = "Test Using Invalid Key with No Filter")]
        public void TestInvalidApiKeyWithoutFilter()
        {
            var response = GopApiHelper.Execute(
                "http://content.guardianapis.com/",
                "search",
                "InvalidKey",
                null,
                null);
            Assert.AreEqual(response.message.Value, "Invalid authentication credentials");
        }

        [TestMethod]
        [FunctionalTest(Id = 4, ScenarioName = "Test Searching without Passing Any API Keys")]
        public void TestApiNoKeyGiven()
        {
            var response = GopApiHelper.Execute(
                "http://content.guardianapis.com/",
                "search",
                null,
                null,
                null);
            Assert.AreEqual(response.message.Value, "No API key found in headers or querystring");
        }
    }
}