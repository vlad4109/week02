using System;

namespace ConsoleApplication
{
    public class Homework1
    {
        public static void Main()
        {
            Console.WriteLine("Give the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number2!=0)
            {
            Console.WriteLine("The division is: " + (float)number1/(float)number2);
            }
            else
            {
                Console.WriteLine("You cannot divide a number with 0!");
            }

            int mul = number1*number2;
            Console.WriteLine("The multiplication is: " + mul);

            if(number1 > number2)
            {
                Console.WriteLine("The max number is: " + number1 + "\nThe min number is: " + number2);
            }
            else
            {
                Console.WriteLine("The max number is: " + number2 + "\nThe min number is: " + number1);
            }
        }
    }
}