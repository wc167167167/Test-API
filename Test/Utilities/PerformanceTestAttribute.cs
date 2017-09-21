namespace Test.Utilities
{
    /// <summary>
    ///     An attribute of performance testing.
    /// </summary>
    internal class PerformanceTestAttribute : TestBaseAttribute
    {
        public PerformanceTestAttribute() : base("Performance")
        {
            IsPerformanceRecorded = true;
        }
    }
}