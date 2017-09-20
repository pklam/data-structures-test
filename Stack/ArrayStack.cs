using System;

namespace ds.Stack
{
    public class ArrayStack : IStack<int>
    {
        private int _size = 0;
        private readonly int[] _items;

        public bool IsEmpty => _size == 0;

        public int Size => _size;

        public ArrayStack(int size)
        {
            _items = new int[size];
        }

        public int Peek()
        {
            if (_size == 0)
                throw new Exception("Empty stack duh C#");

            return _items[_size - 1];
        }

        public int Pop()
        {
            var result = Peek();
            _size -= 1;

            return result;
        }

        public void Push(int item)
        {
            if (_size == _items.Length)
                throw new Exception("Stack is full");

            _items[_size] = item;
            _size += 1;
        }
    }
}