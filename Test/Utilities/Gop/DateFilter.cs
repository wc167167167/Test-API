using System;

namespace Test.Utilities.Gop
{
    /// <summary>
    ///     A filter of searching by date.
    /// </summary>
    public sealed class DateFilter : Filter
    {
        public DateFilter(DateTime value, bool isFromDate = true) : base(isFromDate ? "from-date" : "to-date")
        {
            Value = $"{value:yyyy-MM-dd}";
        }
        
    }
}