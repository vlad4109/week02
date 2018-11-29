using System;

namespace ConsoleApplication
{
    public class Homework2
    {
        public static void Main()
        {
            Console.WriteLine("Give the temperature in Celsius that you want to convert to Fahrenheit:");
            int cel = Convert.ToInt32(Console.ReadLine());
            float fahco = (cel*9/5f)+32;
            Console.WriteLine("The converted temperature in Fahrenheit is: " + fahco);

            Console.WriteLine("Give the temperature in Fahrenheit that you want to convert to Celsius:");
            int fah = Convert.ToInt32(Console.ReadLine());
            float celco = (5*(fah - 32))/9f;
            Console.WriteLine("The converted temperature in Celsius is: " + celco);


            Console.WriteLine("Give the number of days:");
            int nr = Convert.ToInt32(Console.ReadLine());

            int y = nr/365;
            int m = (nr%365)/30;
            int w = ((nr%365)%30)/7;
            int d = ((nr%365)%30)%7;
            Console.WriteLine("In your number there are: " + y + " years, " + m + " months, " + w + " weeks and " + d + " days" );
        }
    }
}