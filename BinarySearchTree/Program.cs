using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(8);
            tree.insert(3);
            tree.insert(19);
            tree.insert(14);
            tree.insert(169);
            tree.insert(50);

            var BFSTree = tree.BreadthFirstSearch();
            var queue = new Queue();
            queue.Enqueue(tree.Root);
            var BFSTreeRecursive = tree.BreadthFirstSearchRecursive(queue, new List<int>());            
            foreach(var item in BFSTree)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n============================");
            foreach(var item in BFSTreeRecursive)
            {
                Console.Write($"{item} ");
            }

        }
    }

    class Node
    {
        public Node Left { get; set; }
        public Node Right{ get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            Left = null;
            Right = null;
            Value = value;
        }
    }

    class BinarySearchTree
    {
        public Node Root { get; private set; }
        public BinarySearchTree()
        {
            Root = null;
        }

        public void insert(int nodeValue)
        {
            var newNode = new Node(nodeValue);
            if (Root == null)
            {
                Root = newNode;
                Root = Root;
            }
            else
            {
                var currentNode = Root;
                while (true)
                {
                    if(nodeValue < currentNode.Value) //left
                    {
                        if(currentNode.Left == null)
                        {
                            currentNode.Left = newNode;
                            return;
                        }
                        currentNode = currentNode.Left;
                    }
                    else //right
                    {
                        if(currentNode.Right == null)
                        {
                            currentNode.Right = newNode;
                            return;
                        }
                        currentNode = currentNode.Right;
                    }
                }
            }
        }

        public List<int> BreadthFirstSearch()
        {
            var queue = new Queue();            
            var list = new List<int>();
            var currentNode = Root;
            queue.Enqueue(currentNode);
            while (queue.Count > 0)
            {
                currentNode = (Node)queue.Dequeue();
                list.Add(currentNode.Value);
                if(currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if(currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
            return list;
        }

        public List<int> BreadthFirstSearchRecursive(Queue queue, List<int> list)
        {
            if(queue.Count <= 0)
            {
                return list;
            }
            var currentNode = (Node)queue.Dequeue();
            list.Add(currentNode.Value);
            if(currentNode.Left != null)
            {
                queue.Enqueue(currentNode.Left);
            }
            if(currentNode.Right != null)
            {
                queue.Enqueue(currentNode.Right);
            }
            return BreadthFirstSearchRecursive(queue, list);
        }
    }
}
