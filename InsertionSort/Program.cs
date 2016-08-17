using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 6, 2, 7, 1 };
            int n = a.Length;

            for (int i = 1; i < n; i++)
            {
                int value = a[i];
                int hole = i;
                while (hole > 0 && a[hole-1] > value)
                {
                    a[hole] = a[hole - 1];
                    hole -= 1;
                }
                a[hole] = value;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
