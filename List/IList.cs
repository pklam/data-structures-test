namespace ds.List
{
    public interface IList<T>
    {
        bool IsEmpty { get; }

        T Head { get; }

        T Tail { get; }

        void Prepend(T item);

        void Append(T item);

        T RemoveAtEnd();

        T RemoveAtBeginning();
    }
}