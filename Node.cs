namespace ds
{
    public class Node<T>
    {
        private readonly T _data;

        public T Data => _data;

        public Node<T> Next { get; set; }

        public Node(T data)
        {
            _data = data;
        }
    }
}