using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 2, 4, 1, 6, 5, 3, 7 };

            QuickSort(a, 0, a.Length - 1);

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        public static int Partition(int[] a, int start, int end)
        {
            int pivot = a[end];
            int partitionIndex = start;
            for (int i = start; i < end; i++)
            {
                if (a[i] <= pivot)
                {
                    swap(ref a[i], ref a[partitionIndex]);
                    partitionIndex++;
                }
            }
            swap(ref a[partitionIndex], ref a[end]);
            return partitionIndex;
        }

        public static void QuickSort(int[] a, int start, int end)
        {
            if (start < end)
            {
                int partitionIndex = Partition(a, start, end);
                QuickSort(a, start, partitionIndex - 1);
                QuickSort(a, partitionIndex + 1, end);
            }
        }

        public static void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }

        public string ShowMessage()
        {
            return "Hello";
        }
    }
}
