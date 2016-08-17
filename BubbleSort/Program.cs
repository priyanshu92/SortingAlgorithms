using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 6, 2, 7, 1 };
            int n = a.Length;
            int flag = 0;

            for (int i = 1; i <= n - 1; i++)
            {
                flag = 0;
                for (int j = 0; j <= n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        flag = 1;

                    }
                }
                if (flag == 0)
                    break;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
