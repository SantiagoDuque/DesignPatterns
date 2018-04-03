using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IIterator<out T>
    {
        bool Next();
        T Actual();
    }
}
