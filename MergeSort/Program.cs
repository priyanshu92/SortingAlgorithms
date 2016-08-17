using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 4, 1, 6, 5, 3, 7 };
            int n = a.Length;

            a = MergeSort(a);

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static int[] Merge(int[] l, int[] r, int[] a)
        {
            int nl = l.Length;
            int nr = r.Length;
            int i, j, k;
            i = j = k = 0;
            int n = a.Length;
            while (i < nl && j < nr)
            {
                if (l[i] <= r[j])
                {
                    a[k] = l[i];
                    i++;
                }
                else
                {
                    a[k] = r[j];
                    j++;
                }
                k++;

            }
            while (i < nl)
            {
                a[k] = l[i];
                k++;
                i++;
            }
            while (j < nr)
            {
                a[k] = r[j];
                k++;
                j++;
            }
            return a;
        }

        static int[] MergeSort(int[] a)
        {
            int n = a.Length;
            if (n < 2)
                return a;
            int mid = n / 2;
            int[] l = new int[mid];
            int[] r = new int[n - mid];
            for (int i = 0; i < mid; i++)
            {
                l[i] = a[i];
            }
            for (int i = mid; i < n; i++)
            {
                r[i - mid] = a[i];
            }
            MergeSort(l);
            MergeSort(r);
            return Merge(l, r, a);
        }
    }
}
