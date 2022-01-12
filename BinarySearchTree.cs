using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class BinarySearchTree
    {
        private Node rootNode = null;
        private class Node
        {
            internal int data = 0;
            internal Node leftChild = null;
            internal Node rightChild = null;
            internal Node parentNode = null;
        }

        public void Insert(int newNodedata)
        {
            Insert(newNodedata, rootNode);
        }

        private void Insert(int newNodeData, Node node)
        {
            if(node == null)
            {
                Node newNode = new Node();
                newNode.data = newNodeData;
                rootNode = newNode;
            }
            else if(newNodeData < node.data)
            {
                if(node.leftChild != null)
                    Insert(newNodeData, node.leftChild);
                else
                {
                    Node newNode = new Node();
                    newNode.data = newNodeData;
                    newNode.parentNode = node;
                    node.leftChild = newNode;
                }
            }
            else if(newNodeData > node.data)
            {
                if (node.rightChild != null)
                    Insert(newNodeData, node.rightChild);
                else
                {
                    Node newNode = new Node();
                    newNode.data = newNodeData;
                    newNode.parentNode = node;
                    node.rightChild = newNode;
                }
            }
            else if(newNodeData == node.data)
            {
                //do nothing
            }
        }

        private Node Find(int nodeData, Node node)
        {
            if (node == null)
                return null;
            else if (nodeData == node.data)
                return node;
            else if (nodeData < node.data)
                return Find(nodeData, node.leftChild);
            else if (nodeData > node.data)
                return Find(nodeData, node.rightChild);

            return node;
        }

        public bool Contains(int nodeData)
        {
            if (Find(nodeData, rootNode) == null)
                return false;
            else return true;
        }

        public void Remove(int nodeData)
        {
            Node node = Find(nodeData, rootNode);
            if(node == null)
            {
                throw new Exception("The Node you are trying to delete doesn't exist.");
            }
            else
            {
                if (node.leftChild == null && node.rightChild == null)
                {
                    if (node == node.parentNode.leftChild)
                        node.parentNode.leftChild = null;
                    else
                        node.parentNode.rightChild = null;

                    node.parentNode = null;    
                }

                else if(node.leftChild != null && node.rightChild == null)
                {
                    if(node == node.parentNode.leftChild)
                    {
                        node.parentNode.leftChild = node.leftChild;
                    }
                    else
                    {
                        node.parentNode.rightChild = node.leftChild;
                    }
                }

                else if (node.leftChild == null && node.rightChild != null)
                {
                    if (node == node.parentNode.leftChild)
                    {
                        node.parentNode.leftChild = node.rightChild;
                    }
                    else
                    {
                        node.parentNode.rightChild = node.rightChild;
                    }
                }
                else
                {
                    Node successor = largest(node.leftChild);
                    Remove(successor.data);
                    node.data = successor.data;
                    Console.WriteLine(successor.data);
                }


            }
        }

        private Node largest(Node node)
        {
            if (node.rightChild == null)
                return node;
            else
                return largest(node.rightChild);
        }

        public void Traversal()
        {
            Traversal(rootNode);
        }
        private void Traversal(Node node) //inorder traversal
        {
            if(node == null)
            {

            }
            else
            {
                Traversal(node.leftChild);
                Console.Write(node.data + " ");
                Traversal(node.rightChild);
            }
        }

        public void LevelOrderTraversal()
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(rootNode);
            while (q.Count != 0)
            {
                if(q.Peek() != null)
                {
                    Console.Write(q.Peek().data + " ");
                    q.Enqueue(q.Peek().leftChild);
                    q.Enqueue(q.Peek().rightChild);
                }
                q.Dequeue();
            }

        }
    }
}
