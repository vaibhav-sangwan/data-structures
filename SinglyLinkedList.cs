using System;

namespace Data_Structures
{
    class SinglyLinkedList
    {
        Node head = null;
        Node tail = null;
        private int size = 0;

        public int Size
        {
            get { return size; }
        }
        class Node
        {
            public int data = 0;
            public Node next = null;
        }

        public SinglyLinkedList()
        {
        }

        public void AddFirst(int newNodeData)
        {
            Node newNode = new Node();
            newNode.data = newNodeData;
            newNode.next = head;
            head = newNode;
            if(size == 1)
            {
                tail = head;
            }
            size++;
        }

        public void AddLast(int newNodeData)
        {
            Node newNode = new Node();
            newNode.data = newNodeData;
            if(tail != null)
            {
                tail.next = newNode;
                tail = newNode;
            }
            else
            {
                tail = newNode;
                head = tail;
            }
            size++;
        }

        public int removeFirst()
        {
            Node temp = head;
            head = head.next;
            size--;
            return temp.data;
        }

        public int peekFirst()
        {
            return head.data;
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
