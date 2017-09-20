namespace Test.Utilities
{
    /// <summary>
    ///     An attribute of functional testing.
    /// </summary>
    internal class FunctionalTestAttribute : TestBaseAttribute
    {
        public FunctionalTestAttribute() : base("Functional")
        {
        }
    }
}