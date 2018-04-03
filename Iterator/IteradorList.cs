using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class IteradorList<T> : IIterator<T>
    {
        private int _index = 0;

        private readonly IAggregate<T> _aggregate;

        public IteradorList(IAggregate<T> aggregate)
        {
            _aggregate = aggregate;
        }
        public T Actual()
        {
            return _aggregate.GetElement(_index);
        }

        public bool Next()
        {
            _index++;
            return _index <= _aggregate.Count;
        }
    }
}
