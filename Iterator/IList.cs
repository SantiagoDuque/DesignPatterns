namespace Iterator
{
    public interface IList<in T>
    {
        void Add(T item);
    }
}