using System;
using System.Collections.Generic;
using System.Timers;
using DataStructures.SortingAlgorithms;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 4, 3, 2, 1 };
            var ms = new MergeSort();
            ms.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }

            //var random = new Random();
            //var arr = new int[10000000];
            //for (int i = 0; i < 10000000; i++)
            //{
            //    arr[i] = random.Next(0, 100);
            //}

            //var ms = new MergeSort();
            //Console.WriteLine("Starting bs...");
            //Console.WriteLine();
            //ms.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item}, ");
            //}
            //Console.WriteLine("Donezo");
        }
    }
}
