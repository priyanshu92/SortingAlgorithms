using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] a = new int[] { 5, 6, 2, 7, 1 };

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
