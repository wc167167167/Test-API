namespace Test.Utilities.Gop
{
    /// <summary>
    ///     Filter by section.
    /// </summary>
    public sealed class SectionFilter : Filter
    {
        public SectionFilter(string value) : base("section")
        {
            Value = value;
        }
        
    }
}