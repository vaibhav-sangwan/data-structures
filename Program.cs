using System;
using System.Collections.Generic;
using System.Collections;

namespace Data_Structures
{

    class Program
    {
        static void Main(string[] args)
        {
            UnionFind uf = new UnionFind(10);
            uf.Unify(3, 5);
            uf.Unify(5, 8);
            uf.Unify(7, 8);
            uf.Unify(1, 4);
            uf.Unify(1, 3);
            Console.WriteLine(uf.Find(8));
            Console.WriteLine(uf.numOfComponents);
            Console.WriteLine(uf.Unified(7, 1));
            Console.WriteLine(uf.Unified(7, 6));

            


        }
    }
}

