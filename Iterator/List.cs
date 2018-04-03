using System;

namespace Iterator
{
    public class List<T> : IAggregate<T>, IList<T>
    {
        private const int _capacityDefault = 4;
        public int Count { get; private set; } = 0;
        public int Capacity { get; private set; } = _capacityDefault;

        private T[] _items = new T[_capacityDefault];
        public void Add(T item)
        {
            if(Count + 1 == Capacity)
            {
                Capacity = DoubleArray();
            }

            _items[++Count] = item;
        }

        private int DoubleArray()
        {
            var newCapacity = Capacity * 2;
            var copyArray = new T[newCapacity];
            Array.Copy(_items, copyArray, Capacity);

            _items = new T[newCapacity];

            Array.Copy(copyArray, _items, Capacity);
            return newCapacity;
        }

        public IIterator<T> CreateIterator()
        {
            return new IteradorList<T>(this);
        }

        public T GetElement(int index)
        {
            return _items[index];
        }
    }
}
