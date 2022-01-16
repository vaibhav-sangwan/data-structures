using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class BinarySearchTree
    {
        internal class Node
        {
            internal int data = 0;
            internal Node left = null;
            internal Node right = null;
        }

        internal Node root = null;

        public void Insert(int newNodeData)
        {
            InsertIn(ref root, newNodeData);
        }

        private void InsertIn(ref Node node, int newNodeData) // node is passed by reference to initialise the original node passed to this function
        {
            if(node == null)
            {
                node = new Node();
                node.data = newNodeData;
            }
            else if(newNodeData < node.data)
            {
                InsertIn(ref node.left, newNodeData);
            }
            else if(newNodeData > node.data)
            {
                InsertIn(ref node.right, newNodeData);
            }
            else if(newNodeData == node.data)
            {
                // do nothing
            }
        }

        public bool Contains(int nodeData)
        {
            return (Find(nodeData, root) != null);
        }

        private Node Find(int nodeData, Node node)
        {
            if (node == null)
                return null;
            else if (nodeData == node.data)
                return node;
            else if(nodeData < node.data)
                return Find(nodeData, node.left);
            else if(nodeData > node.data)
                return Find(nodeData, node.right);
            else
                return node;
        }

        public void Remove(int nodeData)
        {
            if (Contains(nodeData))
                root = Remove(nodeData, root);
        }

        private Node Remove(int nodeData, Node node)
        {
            if(nodeData < node.data)
                node.left = Remove(nodeData, node.left);
            else if(nodeData > node.data)
                node.right = Remove(nodeData, node.right);
            if(node.data == nodeData)
            {
                if (node.left == null && node.right == null)
                    return null;

                else if (node.left == null)
                    return node.right;
                else if (node.right == null)
                    return node.left;
                else
                {
                    Node temp = greatest(node.left);
                    node.data = temp.data;
                    node.left = Remove(temp.data, node.left);
                }
            }
            return node;
        }

        private Node greatest(Node node)
        {
            Node temp = node;
            while (temp.right != null)
                temp = temp.right;
            return temp;
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }

        private void InOrderTraversal(Node node) // print appears in between traversals
        {
            if(node != null)
            {
                InOrderTraversal(node.left);
                Console.Write(node.data + " ");
                InOrderTraversal(node.right);
            }
        }

        public void LevelOrderTraversal()
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while(q.Count != 0)
            {
                if(q.Peek() != null)
                {
                    q.Enqueue(q.Peek().left);
                    q.Enqueue(q.Peek().right);
                    Console.Write(q.Peek().data + " ");
                }
                q.Dequeue();
            }
        }

    }
}
