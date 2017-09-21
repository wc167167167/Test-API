using System;

namespace Test.Utilities
{
    /// <summary>
    ///     Base attribute of test classes.
    /// </summary>
    public class TestBaseAttribute : Attribute
    {
        protected TestBaseAttribute(string testType)
        {
            TestType = testType;
        }

        /// <summary>
        ///     The type of this test scenario.
        /// </summary>
        public string TestType { get; }

        /// <summary>
        ///     The ID of the test case.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     The name of the test scenario.
        /// </summary>
        public string ScenarioName { get; set; }

        /// <summary>
        ///     The full name of this test scenario.
        /// </summary>
        public string TestCaseName => TestType + "_" + Id + "_" + ScenarioName;

        /// <summary>
        ///     Indicates whether performance records will be recorded.
        /// </summary>
        public bool IsPerformanceRecorded { get; set; }
    }
}