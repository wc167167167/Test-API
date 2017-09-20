using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Utilities
{
    /// <summary>
    ///     The base class of test cases. By extending this would provide basic suppor, e.g. reporting result.
    /// </summary>
    [TestClass]
    public abstract class TestMethodBase
    {
        /// <summary>
        ///     The test context object.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        ///     The start time of a test.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        ///     The end time of a test.
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        ///     The initiate memory usage.
        /// </summary>
        public double StartMemory { get; set; }

        /// <summary>
        ///     The final memory usage
        /// </summary>
        public double EndMemory { get; set; }

        /// <summary>
        ///     Whether this test is a performance test case. Note that this is used for report uses. A test with performance
        ///     detail recorded is not
        ///     neccessary to be a performance test case.
        /// </summary>
        public bool IsPerformanceTest { get; set; }

        /// <summary>
        ///     Initialize a test method, with common enhancements and functionalities.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            var testMethodName = TestContext.TestName;
            var type = GetType();
            var methodInfo = type.GetMethod(testMethodName);
            IsPerformanceTest = methodInfo.GetCustomAttributes(typeof (PerformanceTestAttribute), false).Any();
            StartTime = DateTime.Now;
        }

        /// <summary>
        ///     Cleanup processes after a test method finishes.s
        /// </summary>
        [TestCleanup]
        public void TestCleanUp()
        {
            //---------------------------------------------------
            //  Record the end time first for a better accuracy.
            //---------------------------------------------------
            var testResultInfo = new TestResultInfo
            {
                EndTime = DateTime.Now,
                IsPassed = TestContext.CurrentTestOutcome.Equals(UnitTestOutcome.Passed),
                StartTime = StartTime
            };

            //---------------------------------------------------
            //  Record the end time first for a better accuracy.
            //---------------------------------------------------
            var testMethodName = TestContext.TestName;
            var type = GetType();
            var methodInfo = type.GetMethod(testMethodName);
            var attribute = (TestBaseAttribute) methodInfo
                .GetCustomAttributes(typeof (TestBaseAttribute), true).FirstOrDefault();
            if (attribute == null)
            {
            }
            else
            {
                testResultInfo.TestCaseName = attribute.TestCaseName;
                var funcAttribute = attribute as FunctionalTestAttribute;
                if (funcAttribute != null) return;
                var performanceAttribute = attribute as PerformanceTestAttribute;
                if (performanceAttribute == null)
                {
                }
            }
        }
    }
}