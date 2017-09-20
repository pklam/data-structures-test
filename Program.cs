using System;
using ds.Stack;
using ds.List;

namespace ds
{
    class Program
    {
        static readonly Random _rng = new Random();

        static readonly SinglyLinkedList<int> _list = new SinglyLinkedList<int>();

        static Node<int> RandomNode => new Node<int>(_rng.Next(1, 10));

        static Node<int> Node(int i) => new Node<int>(i);

        static void Main(string[] args)
        {
            _list.Append(Node(5));
            _list.Prepend(Node(1));
            _list.Append(Node(3));
            _list.Append(Node(4));



            Console.WriteLine(_list.ToString());

            _list.RemoveAtBeginning();
            Console.WriteLine(_list.ToString());

            _list.RemoveAtEnd();
            Console.WriteLine(_list.ToString());
        }
    }
}
