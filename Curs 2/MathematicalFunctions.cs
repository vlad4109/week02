using System;

namespace ConsoleApplication
{
    public class MathFunctions
    {
        public static void Main()
        {
            Console.WriteLine("Add the first number:");
            string temp1  = Console.ReadLine();

            Console.WriteLine("Add the second number");
            string temp2  = Console.ReadLine();

            int number1 = Convert.ToInt32(temp1);
            int number2 = Convert.ToInt32(temp2);

            int sum = Sum(number1, number2);
            Console.WriteLine("The sum is:" + sum);

            int sub = Sub(number1, number2);
            Console.WriteLine("The substraction is:" + sub);
        }

        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Sub(int number1, int number2)
        {
            if(number1 > number2)
            {
                return number1 - number2;
            }
            else
            {
                return number2 - number1;
            }
        }
        public static double Div(int no1, int no2)
        {
            if(no2!=0)
            {
                return no1/(double)no2;
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}