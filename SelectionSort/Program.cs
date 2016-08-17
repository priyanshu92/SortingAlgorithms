using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 6, 2, 7, 1 };
            int n = a.Length;

            for (int i = 0; i < n - 2; i++)
            {
                int imin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[imin])
                        imin = j;
                }
                int temp = a[i];
                a[i] = a[imin];
                a[imin] = temp;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
