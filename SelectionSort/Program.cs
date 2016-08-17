using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] a = new int[] { 5, 6, 2, 7, 1 };

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
