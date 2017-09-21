namespace Test.Utilities.Gop
{
    public class Filter
    {
        /// <summary>
        ///     The filter in GOP searching.
        /// </summary>
        /// <param name="name"></param>
        public Filter(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public string Value { get; set; }
    }
}