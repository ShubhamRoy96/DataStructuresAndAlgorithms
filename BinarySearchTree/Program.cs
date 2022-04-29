using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Node
    {
        int _left;
        int _right;
        int _value;

        public Node (int left, int right, int value)
        {
            _left = left;
            _right = right;
            _value = value;
        }
    }
}
