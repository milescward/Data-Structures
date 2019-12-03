using System;
namespace DataStructures.SortingAlgorithms
{
    public class SelectionSort
    {
        public int [] Sort(int[] arr)
        {
            int temp;
            int smallest;
            int index = 0;
            var len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                smallest = arr[i];
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] <= smallest)
                    {
                        smallest = arr[j];
                        index = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }
            return arr;
        }
    }
}
