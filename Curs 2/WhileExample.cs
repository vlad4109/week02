using System;

namespace ConsoleApplication
{
    public class VWhileExample
    {
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}