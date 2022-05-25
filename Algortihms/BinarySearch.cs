using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Algortihms
{
    class BinarySearch
    {
        private static int binarySearch(int[] arr, int start, int end, int target)
        {
            if(start <= end)
            {
                int mid = start + (end - start) / 2;
                Console.WriteLine(arr[mid]);
                if (arr[mid] == target)
                    return mid;
                if (arr[mid] > target)
                    return binarySearch(arr, start, mid - 1, target);
                else
                    return binarySearch(arr, mid + 1, end, target);
            }
            return -1;
        }

        public int findIndex(int[] arr, int target)
        {
            return binarySearch(arr, 0, arr.Length - 1, target);
        }
    }
}
