using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Utilities;
using Test.Utilities.Gop;

namespace Test.TestCases
{
    [CodedUITest]
    public class GopSearchBySectionTesting : TestMethodBase
    {
        [TestMethod]
        [FunctionalTest(Id = 5, ScenarioName = "Test Searching By Sections")]
        public void TestSearchBySection()
        {
            var response = GopApiHelper.Execute(
                "http://content.guardianapis.com/",
                "search",
                "30c5a1f2-3132-4f94-bba1-38b397fdec67",
                null,
                new SectionFilter("world"));
            Assert.AreEqual(response.response.status.Value, "ok");
        }

        [TestMethod]
        [FunctionalTest(Id = 6, ScenarioName = "Test Searching By Duplicated Sections")]
        public void TestSearchByDuplicatedSection()
        {
            var response = GopApiHelper.Execute(
                "http://content.guardianapis.com/",
                "search",
                "30c5a1f2-3132-4f94-bba1-38b397fdec67",
                null,
                new SectionFilter("world"),
                new SectionFilter("sport"));
            Assert.AreEqual(response.response.status.Value, "ok");
        }
    }
}