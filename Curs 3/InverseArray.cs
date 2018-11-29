using System;

namespace ConsoleApplication
{
    public class InverseArray
    {
        public static void Main()
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 11;
            numbers[2] = 13;
            numbers[3] = 14;
            numbers[4] = 15;
            
            int[] aux = new int[numbers.Length];

            
            for(int i = numbers.Length - 1; i >= 0; i--)
            {
                
                int index = numbers.Length -i - 1;
                aux[numbers.Length -i - 1] = numbers[i];
            }
            WriteNumbers(aux);
            Console.ReadLine();

        }
        public static void WriteNumbers(int[] aux)
        {
            for(int i = 0; i<= aux.Length -1; i++)
            {
                if(i == aux.Length - 1)
                    {
                        Console.Write(aux[i]);
                    }
                    else
                    {
                        Console.Write(aux[i] + ",");
                    }
            }
        }
    }
}