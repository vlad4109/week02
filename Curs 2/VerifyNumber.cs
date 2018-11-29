using System;

namespace ConsoleApplication
{
    public class VerifyNumber
    {
        public static void Main()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            if(Modulo(number1 , 2)==0)
            {
                Console.WriteLine("The number is even!");
            }
            else
            {
                Console.WriteLine("The number is odd!");
            }
            

        }
        public static int Modulo(int number1, int number2)
        {
            return number1 % number2;
        }
    }
}