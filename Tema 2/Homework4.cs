using System;

namespace ConsoleApplication
{
    public class Homework4
    {
        public static void Main()
        {
            int[] arr = new int[10] {3, 3, 4, 9, 8, 8, 1, 3, 4, 3};
            int i = 0;
            
            for(i = 0; i <= arr.Length - 1; i++)
            {            
                int j = 1;
                int nr = 1;
                while(j<10)
                {
                    if(arr[i]==arr[j])
                    {
                        nr++;
                        j++;
                    }
                    else
                    {
                        j++;
                    }
                }
                Console.WriteLine(arr[i] + " - " + nr + " times ");
            }

        }
    }
}