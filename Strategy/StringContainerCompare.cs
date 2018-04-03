using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StringContainerCompare<T> : ICompareStrategy<T> where T : StringContainer
    {
        public bool IsLess(T left, T right)
        {
            return left.String.CompareTo(right.String) < 0;
        }
    }

    public class StringContainer
    {
        public String String { get; set; }

    }

}
