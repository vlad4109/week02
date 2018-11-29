using System;

namespace ConsoleApplication
{
    public class Homework5
    {
        public static void Main()
        {
            int[] arr1 = new int[5];
            Console.WriteLine("Give the array elements: ");
            for(int i=0; i <= arr1.Length - 1; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your array looks like this:");
            for(int i = 0;i <= arr1.Length - 1; i++)
            {
                if(i==arr1.Length - 1)
                {
                    Console.WriteLine(arr1[i]);
                }
                else
                {
                    Console.Write(arr1[i] + ",");
                }
                
            }

            int[] arrodd = new int[arr1.Length];
            for(int i=0; i <= arr1.Length - 1; i++)
            {
                if(arr1[i] % 2 != 0)
                {
                    arrodd[i] = arr1[i];
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }

            Console.WriteLine("Your odd array looks like this:");
            for(int i = 0;i <= arrodd.Length - 1; i++)
            {
                if(i==arrodd.Length - 1)
                {
                    Console.WriteLine(arrodd[i]);
                }
                else
                {
                    Console.Write(arrodd[i] + ",");
                }
                
            }
            int[] arreven = new int[arr1.Length];
            for(int i=0; i <= arr1.Length - 1; i++)
            {
                if(arr1[i] % 2 == 0)
                {
                    arreven[i] = arr1[i];
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }

            Console.WriteLine("Your even array looks like this:");
            for(int i=0;i <= arreven.Length - 1; i++)
            {
                if(i==arreven.Length - 1)
                {
                    Console.WriteLine(arreven[i]);
                }
                else
                {
                    Console.Write(arreven[i] + ",");
                }
            }
        }
    }
}