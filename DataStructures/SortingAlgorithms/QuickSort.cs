using System;
namespace DataStructures.SortingAlgorithms
{
    public class QuickSort
    {
        // O(n log n) Average case runtime
        // O(n^2) worst case runtime
        // O(1) space complexity
        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int pInd = Partition(a, l, r);
                Sort(a, l, pInd - 1);
                Sort(a, pInd + 1, r);
            }
        }

        private int Partition(int[] a, int l, int r)
        {
            //set variables pivot(p) and partitionIndex(pi)
            var p = a[r];
            var pi = l;
            for (int i = l; i < r; i++)
            {
                if (a[i] <= p)
                {
                    Swap(a, i, pi);
                    pi++;
                }
            }
            Swap(a, r, pi);
            return pi;
        }

        private void Swap(int[] a, int i, int pi)
        {
            int temp;
            temp = a[i];
            a[i] = a[pi];
            a[pi] = temp;
        }
    }
}
