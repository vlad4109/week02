using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the word!");
            var str = Console.ReadLine();
            char[] ch = str.ToArray();
            Array.Reverse(ch);
            Console.WriteLine(ch);
            int x=0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ch[i])
                    {
                        x++;
                    }
                }
                if(x == str.Length)
            {
                Console.WriteLine("Your word is a palindrome!");
            }
                else
            {
                Console.WriteLine("Your word is not a palindrome!");
            }

            
            
        }
    }
}
