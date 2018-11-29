using System;

namespace ConsoleApplication
{
    public class SirulLuiFibonacci
    {
        public static void Main()
        {
            Console.WriteLine("Give the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if((n<=1000)&&(n>=1)&&(n%3==0)&&(n%5==0))
            {
                Console.WriteLine("FIZZBUZZ");
            }
            else if((n<=1000)&&(n>=1)&&(n%5==0))
            {
                Console.WriteLine("BUZZ");
            }
            else if((n<=1000)&&(n>=1)&&(n%3==0))
            {
                Console.WriteLine("FIZZ");
            }
            else
            {
                Console.WriteLine("Your number is: " + n);
            }
        }
    }
}