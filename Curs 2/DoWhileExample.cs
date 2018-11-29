using System;

namespace ConsoleApplication
{
    public class DoWhileExample
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number > 0);
        }
    }
}