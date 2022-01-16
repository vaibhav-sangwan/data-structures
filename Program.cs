using System;
using System.Collections.Generic;
using System.Collections;

namespace Data_Structures
{

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree BST = new BinarySearchTree();
            BST.Insert(11);
            BST.Insert(8);
            BST.Insert(3);
            BST.Insert(1);
            BST.Insert(6);
            BST.Insert(12);
            BST.Insert(17);
            BST.Insert(13);
            BST.Insert(19);
            BST.Insert(14);
            BST.Insert(5);
            BST.Insert(15);
            BST.LevelOrderTraversal();
            BST.Remove(17);
            Console.WriteLine();
            BST.LevelOrderTraversal();


        }
    }
}

