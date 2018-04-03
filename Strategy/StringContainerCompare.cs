using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StringContainer : ICompareStrategy<StringContainer>
    {
        public String String { get; set; }

        public bool IsLess(StringContainer other)
        {
            return String.CompareTo(other.String) < 0;
        }
    }

}
