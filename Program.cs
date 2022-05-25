using System;
using System.Collections.Generic;
using System.Collections;

namespace Data_Structures.Algortihms
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 13, 24, 33, 54, 101, 123, 145, 233, 473, 2341 };
            BinarySearch bs = new BinarySearch();
            Console.WriteLine(bs.findIndex(arr, 473));



        }
    }
}

