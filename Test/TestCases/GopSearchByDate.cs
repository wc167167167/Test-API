using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Utilities;
using Test.Utilities.Gop;

namespace Test.TestCases
{
    [CodedUITest]
    public class GopSearchByDate : TestMethodBase
    {
        [TestMethod]
        [FunctionalTest(Id = 7, ScenarioName = "Test Searching By Date")]
        public void TestSearchByDate()
        {
            var response = GopApiHelper.Execute(
                "http://content.guardianapis.com/",
                "search",
                "30c5a1f2-3132-4f94-bba1-38b397fdec67",
                null,
                new DateFilter(new DateTime(2017, 9, 17)));
            Assert.AreEqual(response.response.status.Value, "ok");
        }

        [TestMethod]
        [FunctionalTest(Id = 8, ScenarioName = "Test Searching By Invalid Date2")]
        public void TestSearchByInvalidDate()
        {
            var response = GopApiHelper.Execute(
                "http://content.guardianapis.com/",
                "search",
                "30c5a1f2-3132-4f94-bba1-38b397fdec67",
                null,
                new Filter("to-date") {Value = "null"});
            Assert.AreEqual(response.response.status.Value, "error");
        }
    }
}