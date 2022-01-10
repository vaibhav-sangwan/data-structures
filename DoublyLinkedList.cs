using System;

namespace Data_Structures
{
    class DoublyLinkedList
    {
        //member variables
        int size = 0;
        Node head = null;
        Node tail = null;

        class Node
        {
            public int data = 0;
            public Node prev = null;
            public Node next = null;
        }

        //constructor
        public DoublyLinkedList()
        {
            head = new Node();
            tail = head;
        }

        public void AddFirst(int newNodeData)
        {
            if(size == 0)
            {
                head.data = newNodeData;
            }
            else
            {
                Node newNode = new Node();
                newNode.data = newNodeData;
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            size++;
        }

        public void AddLast(int newNodeData)
        {
            if(size == 0)
            {
                head.data = newNodeData;
            }
            else
            {
                Node newNode = new Node();
                newNode.data = newNodeData;
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            size++;
        }

        public void AddAfter(int existingNodeData, int newNodedata)
        {
            Node temp = getNode(existingNodeData);
            if(temp != null)
            {
                Node newNode = new Node();
                newNode.data = newNodedata;
                newNode.next = temp.next;
                newNode.prev = temp;
                temp.next.prev = newNode;
                temp.next = newNode;
                size++;
            }
            else
            {
                Console.WriteLine("Node " + existingNodeData + " doesn't exist");
            }          
        }

        public void Delete(int existingNodedata)
        {
            Node temp = getNode(existingNodedata);
            if(temp != null)
            {
                temp.prev.next = temp.next;
                temp.next.prev = temp.prev;
                temp = null;
            }
            else
            {
                Console.WriteLine("Node " + existingNodedata + " doesn't exist");
            }
        }
        
        public bool Contains(int existingNodeData)
        {
            Node temp = getNode(existingNodeData);
            if (temp != null)
                return true;
            else
                return false;
        }

        private Node getNode(int existingNodeData)
        {
            Node temp = head;
            while(temp.data != existingNodeData && temp.next != null)
            {
                temp = temp.next;
            }
            if (temp.data == existingNodeData)
                return temp;
            else
                return null;
        }

        

        public void print()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
