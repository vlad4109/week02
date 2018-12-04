using System;

namespace homework4a.cs
{
    class homework44
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Prime(n);
            Console.ReadLine();
            
            


        }

        public static void Prime(int n)
        {
            if((n % 2 != 0)&&(n % 3 != 0))
            {
                Console.WriteLine("The number is prime!");
            }
            else
            {
                Console.WriteLine("The number isn't prime!");
            }
        }
    }
}
