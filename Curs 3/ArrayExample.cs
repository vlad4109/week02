using System;

namespace ConsoleApplication
{
    public class ArrayExample
    {
        public static void Main()
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 11;
            numbers[2] = 13;
            numbers[3] = 14;
            numbers[4] = 15;
            for(int i = numbers.Length - 1;i >= 0; i--)
            {
                if(i==0)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + ",");
                }
                
            }
            Console.ReadLine();

        }
    }
}