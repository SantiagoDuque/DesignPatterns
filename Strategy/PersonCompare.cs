using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Person: ICompareStrategy<Person>
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public bool IsLess(Person other)
        {
            return Age < other.Age;
        }

        public override string ToString()
        {
            return $"Name:{Name} Age:{Age}";
        }
    }
}
