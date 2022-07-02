using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class SegmentTree
    { 
        public int Size = 0;
        internal class Node
        {
            public int val;
            public Node left;
            public Node right;

            public Node()
            {
                this.left = null;
                this.right = null;
                val = 0;
            }
        }
        public void Create(int[] arr)
        {
            Node newNode = Create(arr, 0, arr.Length - 1);
            Print(newNode);
        }

        public void Print(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while(q.Count != 0)
            {
                if(q.Peek() != null)
                {
                    q.Enqueue(q.Peek().left);
                    q.Enqueue(q.Peek().right);
                }


                if (q.Peek() == null)
                    Console.Write("null ");
                else
                    Console.Write(q.Peek().val + " ");
                q.Dequeue();
            }
        }

        private Node Create(int[] arr, int start, int end)
        {
            if (end < start)
                return null;
            Node newNode = new Node();
            Size++;
            if (start == end)
            {
                newNode.val = arr[start];
            }
            else
            {
                int mid = start + (end - start) / 2;
                newNode.left = Create(arr, start, mid);
                newNode.right = Create(arr, (mid) + 1, end);
                newNode.val = newNode.left.val + newNode.right.val;
            }
            Console.WriteLine("adding " + newNode.val + " to the st.");

            return newNode;
        }
    }
}
