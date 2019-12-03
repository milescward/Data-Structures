using System;
namespace DataStructures.SortingAlgorithms
{
    public class InsertionSort
    {
        public int[] Sort(int[] arr)
        {
            int len = arr.Length;
            int key;
            int j;
            for (int i = 1; i < len; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
    }
}
