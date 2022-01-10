using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class DynamicArray<T>
    {
        public int Count = 0;
        private int capacity = 0;
        private int insertionIndex = 0;
        private T[] arr = null;

        //Indexer
        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        //Constructor
        public DynamicArray()
        {

            capacity = 1;
            arr = new T[capacity];
            insertionIndex = 0;
        }

        public void Add(T newData)
        {
            if(insertionIndex >= capacity)
            {
                T[] newArr = new T[capacity * 2]; // creates a new array with double the capacity of the current one
                for (int i = 0; i < Count; i++)
                    newArr[i] = arr[i];
                capacity *= 2;
                arr = newArr;
            }
            arr[insertionIndex] = newData;
            insertionIndex++;
            Count++;
        }

        public void Remove(T existingData)
        {
            int index = indexOf(existingData);
            if (index == -1)
                throw new Exception("Data not found in Array");
            RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            if (index >= capacity)
                throw new IndexOutOfRangeException();
            int j = 0;
            T[] newArr = new T[capacity];
            for (int i = 0; i < Count; i++)
            {
                if (i == index)
                    continue;
                newArr[j] = arr[i];
                j++;
            }
            arr = newArr;
            insertionIndex--;
            Count--;
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
                arr[i] = default(T);
        }

        public bool Contains(T existingData)
        {
            if (indexOf(existingData) == -1)
                return false;
            else
                return true;
        }

        private int indexOf(T existingData)
        {
            for(int i = 0; i < Count; i++)
            {
                if (arr[i].Equals(existingData))
                    return i;
            }
            return -1;
        }

        public void Print()
        {
            foreach (T t in arr)
                Console.WriteLine(t);
        }
    }
}
