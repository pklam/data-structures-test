public interface IStack<T>
{
    bool IsEmpty { get; }
    int Size { get; }

    void Push(T item);

    T Pop();

    T Peek();
}