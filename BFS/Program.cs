using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breadth-First Search");
            Node root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);
            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);
            root.Right.Left = new Node(6);

            BFS(root);
        }

        static void BFS(Node root)
        {
            if (root == null) return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Node currentNode = queue.Peek();
                Console.WriteLine(currentNode.Data);

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if(currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }

                queue.Dequeue();
            }
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }
}
