using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IAggregate<out T>
    {
        int Count { get; }
        IIterator<T> CreateIterator();
        T GetElement(int index);
    }
}
