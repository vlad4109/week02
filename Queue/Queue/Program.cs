using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        public static void PrintTheQueue(List<Queue> list)
        {
            foreach(Queue nr in list)
            {
                Console.Write($"{nr.A}\t");
            }
        }

        public static void Enqueue(List<Queue> numbersList)
        {
            Queue a6 = new Queue(6);
            numbersList.Insert(5, a6);
            Queue a7 = new Queue(7);
            numbersList.Insert(6, a7);
            Console.WriteLine("\nThe enqueued queue is the following: ");
            PrintTheQueue(numbersList);
        }

        public static void Dequeue(List<Queue> numbersList)
        {
            numbersList.RemoveAt(0);
            numbersList.RemoveAt(0);
            Console.WriteLine("\nThe dequeued queue is the following: ");
            PrintTheQueue(numbersList);
        }

        static void Main(string[] args)
        {
            List<Queue> numbersList = new List<Queue>();
            Queue a1 = new Queue(1);
            numbersList.Add(a1);
            Queue a2 = new Queue(2);
            numbersList.Add(a2);
            Queue a3 = new Queue(3);
            numbersList.Add(a3);
            Queue a4 = new Queue(4);
            numbersList.Add(a4);
            Queue a5 = new Queue(5);
            numbersList.Add(a5);

            Console.WriteLine("The queue is the following: ");
            PrintTheQueue(numbersList);

            Enqueue(numbersList);

            Dequeue(numbersList);
        }
    }
}
