using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class PQ
    {
        class Node
        {
            public int data = 0;
        }

        DynamicArray<Node> Heap = new DynamicArray<Node>();

        public void Add(int newNodeData)
        {
            Node newNode = new Node();
            newNode.data = newNodeData;
            Heap.Add(newNode);
            swim(Heap.Count - 1);
        }

        public int Poll()
        {
            int temp = Heap[0].data;
            swap(0, Heap.Count - 1);
            Heap.RemoveAt(Heap.Count - 1);
            sink(0);
            return temp;
        }

        public int Peek()
        {
            return Heap[0].data;
        }

        public void Remove(int existingNodeData)
        {
            for(int i = 0; i < Heap.Count; i++)
            {
                if(existingNodeData == Heap[i].data)
                {
                    swap(i, Heap.Count - 1);
                    Heap.RemoveAt(Heap.Count - 1);
                    sink(i);    //try to sink i
                    swim(i);    //if the element can't sink, try swimming it up
                    break;
                }
            }

        }
        public void heapDraw()
        {
            int j = 0;
            int k = 0;
            for(int i = 0; i < Heap.Count; i++)
            {
                Console.Write(Heap[i].data + " ");
                j++;
                if(j >= MathF.Pow(2, k))
                {
                    Console.WriteLine();
                    k++;
                    j = 0;
                }
            }
        }

        private void swim(int nodeIndex)
        {
            int parentIndex = (nodeIndex - 1) / 2;
            if(Heap[nodeIndex].data < Heap[parentIndex].data && nodeIndex > 0)
            {
                swap(nodeIndex, parentIndex);
                swim(parentIndex);
            }
        }

        private void sink(int nodeIndex)
        {
            int left = (nodeIndex * 2) + 1, right = (nodeIndex * 2) + 2;
            int smallest = left;
            if(right < Heap.Count)
            {
                if (Heap[right].data < Heap[left].data)
                    smallest = right;
            }
            if(smallest < Heap.Count)
            {
                if (Heap[nodeIndex].data > Heap[smallest].data)
                {
                    swap(nodeIndex, smallest);
                    sink(smallest);
                }
            }
        }

        private void swap(int index1, int index2)
        {
            int temp = Heap[index1].data;
            Heap[index1].data = Heap[index2].data;
            Heap[index2].data = temp;
        }



    }
}
