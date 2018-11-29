using System;

namespace ConsoleApplication
{
    public class ArrayExample
    {
        public static void Main()
        {
            //for(int i = 16; i <= 97; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //for(var i = 20; i <= 65; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            for(var i = 1400; i <= 2300; i++)
            {
                if((i % 7 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}