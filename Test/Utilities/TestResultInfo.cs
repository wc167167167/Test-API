using System;

namespace Test.Utilities
{
    public class TestResultInfo
    {
        /// <summary>
        ///     The name of the test case.
        /// </summary>
        public string TestCaseName { get; set; }

        /// <summary>
        ///     Passed or not.
        /// </summary>
        public bool IsPassed { get; set; }

        /// <summary>
        ///     The comments for this test.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        ///     Test start time.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        ///     Test end time.
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        ///     Test start memory usage.
        /// </summary>
        public double StartMemory { get; set; }

        /// <summary>
        ///     Test end memory usage.
        /// </summary>
        public double EndMemory { get; set; }

        /// <summary>
        ///     PlanningSpace restarted or not.
        /// </summary>
        public bool Restarted { get; set; }

        #region Performance Test Only

        /// <summary>
        ///     Performance test start time.
        /// </summary>
        public DateTime PerformanceStartTime { get; set; }

        /// <summary>
        ///     Performance test end time.
        /// </summary>
        public DateTime PerformanceEndTime { get; set; }

        /// <summary>
        ///     Performance start memory usage.
        /// </summary>
        public double PerformanceStartMemory { get; set; }

        /// <summary>
        ///     Performance end memory usage.
        /// </summary>
        public double PerformanceEndMemory { get; set; }

        #endregion
    }
}