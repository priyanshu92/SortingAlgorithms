using System;

namespace ShellSort
{
    class Program
    {
        static int[] items;
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number of items: ");        
            int n = Convert.ToInt32(Console.ReadLine());
            items = new int[n];
            System.Console.WriteLine("Enter the items: ");
            for (int i = 0; i < n; i++)
            {
                items[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("Sorted array is: ");
            Sort();
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(items[i]);
            }
        }

        static void Sort()
        {
            int i, j, h, temp;
            h = 1;
            while(h <= items.Length / 3)
                h = h * 3 + 1;
            
            while(h > 0)
            {
                for(i = h; i < items.Length; i++)
                {
                    temp = items[i];
                    j = i;
                    while(j > h - 1 && items[j - h] > temp)
                    {
                        items[j] = items[j - h];
                        j = j - h;
                    }
                    items[j] = temp;
                }
                h = (h - 1) / 3;
            }
        }
    }
}
