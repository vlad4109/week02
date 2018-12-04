using System;

namespace homework4a.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 3, 6, 8, 9, 1 };
            int[] arr2 = new int[4] { 1, 2, 7, 9 };
            for(int j = 0; j <= arr2.Length - 1; j++)
            {
                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    if (arr[i] == arr2[j])
                    {
                        Console.WriteLine(arr[i]);

                    }

                }
            }
        }
    }
}
