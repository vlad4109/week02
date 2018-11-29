using System;

namespace ConsoleApplication
{
    public class ReadREverse
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduceti textul: ");
            var s = Console.ReadLine();
            var arr = s.ToCharArray();
            for(var i = arr.Length -1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            
            Console.ReadLine();
        }
    }
}