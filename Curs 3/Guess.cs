using System;

namespace ConsoleApplication
{
    public class Guess
    {
        public static void Main()
        {
            var numberToGuess = new Random().Next(1, 10);
            
            while(true)
            {

                Console.WriteLine("Introduceti un numar: ");
                var x = Convert.ToInt32(Console.ReadLine());
                if(x == numberToGuess)
                {
                    Console.WriteLine("Felicitari! Ati ghicit numarul!");
                    break;
                }
                else
                {
                    Console.WriteLine(x < numberToGuess
                        ? "Nr introdus este prea mic!"
                        : "Nr introdus este prea mare!");
                    //if(x < numberToGuess)
                    //{
                    //    Console.WriteLine("Nr ales este prea mic!");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Nr ales este prea mare!");
                    //}
                    //Console.WriteLine("Mai incearca!");
                }
                Console.ReadLine();
            }
        }
    }
}