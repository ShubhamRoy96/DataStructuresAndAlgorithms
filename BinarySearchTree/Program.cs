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
        Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void insert(int nodeValue)
        {
            var newNode = new Node(nodeValue);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                var currentNode = root;
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

        public List<Node> BreadthFirstSearch()
        {
            var queue = new Queue();            
            var list = new List<Node>();
            var currentNode = root;
            queue.Enqueue(currentNode);
            while (queue.Count > 0)
            {
                currentNode = (Node)queue.Dequeue();
                list.Add(currentNode);
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
    }
}
