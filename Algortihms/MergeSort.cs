using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.MergeSort
{
    class MergeSort
    {
        static void merge(int[] arr, int start, int mid, int end)
        {
            int[] temp1 = new int[mid + 1 - start];
            int[] temp2 = new int[end - mid];
            int i = 0, j = 0;

            for (i = 0; i < temp1.Length; i++)
                temp1[i] = arr[start + i];
            for (j = 0; j < temp2.Length; j++)
                temp2[j] = arr[mid + 1 + j];
            i = 0;
            j = 0;
            int k = start;

            while (i < temp1.Length && j < temp2.Length)
            {
                if (temp1[i] <= temp2[j])
                {
                    arr[k] = temp1[i];
                    i++;
                    k++;
                }
                else
                {
                    arr[k] = temp2[j];
                    j++;
                    k++;
                }
            }

            while (i < temp1.Length)
            {
                arr[k] = temp1[i];
                i++;
                k++;
            }

            while (j < temp2.Length)
            {
                arr[k] = temp2[j];
                j++;
                k++;
            }

        }

        static void mergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = start + (end - start) / 2;

                mergeSort(arr, start, mid);
                mergeSort(arr, mid + 1, end);

                merge(arr, start, mid, end);
            }
        }
    }
}
