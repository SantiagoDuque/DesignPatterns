using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    interface ICompareStrategy<in T>
    {
        bool IsLess(T left, T right);
    }
}
