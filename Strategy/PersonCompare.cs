using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
    }

    public class PersonCompare<T> : ICompareStrategy<T> where T:Person
    {
        public bool IsLess(T left, T right)
        {
            return left.Age < right.Age;
        }
    }
}
