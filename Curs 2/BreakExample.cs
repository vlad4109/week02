using System;

namespace ConsoleApplication
{
    public class BreakExample
    {
        public static void Main()
        {
            int i = 100;
            while(i > 0)
            {
                if(i % 7 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
                i--;
            }
        }
    }
}