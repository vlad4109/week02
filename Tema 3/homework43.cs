using System;
using System.Collections.Generic;

namespace homework4a.cs
{
    class homework43
    {
        static void Main(string[] args)
        {
            List<int> dup = new List<int>();
            dup.Add(5);
            dup.Add(3);
            dup.Add(6);
            dup.Add(3);
            dup.Add(7);
            foreach(int n in dup)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n");

            for(int i = 1; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(dup[i]==dup[j]&&(i!=j)&&(j>i-1))
                    {
                        Console.WriteLine("The duplicate number is: " + dup[i]);
                    }
                }
            }
            


        }
    }
}
