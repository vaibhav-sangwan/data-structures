using System;

namespace Data_Structures
{
    class Stack
    {
        Node head = null;
        class Node
        {
            public int data = 0;
            public Node next = null;
        }

        public Stack()
        {
        }

        public void push(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = head;
            head = newNode;
        }

        public int pop()
        {
            if (isempty())
                throw new ArgumentNullException();
            int temp = head.data;
            head = head.next;
            return temp;
        }
        public int peek()
        {
            if (isempty())
                throw new ArgumentNullException();
            return head.data;
        }

        bool isempty()
        {
            if (head == null)
                return true;
            else
                return false;
        }

    }
}
