using System;
using System.Text;
using ds;

namespace ds.List
{
    public class SinglyLinkedList<T> : IList<Node<T>>
    {
        private Node<T> _head;
        private int _size;

        public bool IsEmpty => _size == 0;

        public Node<T> Head => _head;

        public Node<T> Tail
        {
            get
            {
                if (IsEmpty)
                    return default(Node<T>);

                var current = Head;

                while (current.Next != null)
                    current = current.Next;

                return current;
            }
        }

        public void Append(Node<T> item)
        {
            if (IsEmpty)
                _head = item;
            else
            {
                Tail.Next = item;
            }
            _size++;
        }

        public void Prepend(Node<T> item)
        {
            if (IsEmpty)
                _head = item;
            else
            {
                item.Next = Head;
                _head = item;
            }
            _size++;
        }

        public Node<T> RemoveAtBeginning()
        {
            if (IsEmpty)
                throw new Exception("List is empty");

            var tmp = Head;

            _head = _head.Next;
            _size--;

            return tmp;
        }

        public Node<T> RemoveAtEnd()
        {
            if (IsEmpty)
                throw new Exception("List is empty");

            Node<T> result = default(Node<T>);
            var current = Head;

            while (current.Next.Next != null)
                current = current.Next;

            result = current.Next;
            current.Next = default(Node<T>);
            _size--;

            return result;
        }

        public override string ToString()
        {
            var current = Head;
            var sb = new StringBuilder();

            while (current != null)
            {
                sb.Append($"{current.Data} -> ");
                current = current.Next;
            }

            return sb.ToString() + "nil";
        }
    }
}