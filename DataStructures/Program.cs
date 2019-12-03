using System;
using DataStructures.BinaryTree;
using DataStructures.SinglyLinkedList;
using DataStructures.SortingAlgorithms;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var ss = new SelectionSort();
            var arr = new int[] { 3, 2, 6, 8, 1, 2 };
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
            var newArr = ss.Sort(arr);
            Console.WriteLine();
            foreach (var item in newArr)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
