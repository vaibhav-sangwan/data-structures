using System;
using System.Collections.Generic;

namespace Data_Structures
{
    class Queue
    {

        SinglyLinkedList list = new SinglyLinkedList();
        public Queue()
        {

        }

        public void Enqueue(int newNodeData)
        {
            list.AddLast(newNodeData);
        }

        public int Dequeue()
        {
            if (isEmpty())
                throw new Exception("Queue is empty");
            return list.removeFirst();
        }

        public int Peek()
        {
            if (isEmpty())
                throw new Exception("Queue is empty");
            return list.peekFirst();
        }

        public bool isEmpty()
        {
            return (list.Size == 0);
        }

        public void print()
        {
            list.print();
        }

    }
}
