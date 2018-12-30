using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = Stack.CreateStack();
            Console.WriteLine("The stack is:");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }


            stack.Pop();
            Console.WriteLine("The new stack after the pop is:");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
