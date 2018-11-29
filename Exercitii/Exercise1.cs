using System;

namespace ConsoleApplication
{
    
    
        
    
    public class Exercise1
    {
        public static int FindIndex(int[] array, int value)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindOccurencies(int[] array, int value)
        {
            int counter = 0;
            foreach (var element in array)
            {
                if(element == value)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static void Main()
        {
            int[] array = new int[6];
            double sum = 0;
            Console.WriteLine("Give the array numbers:");
            for(int i = 0; i <= array.Length - 1; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i <= array.Length - 1; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("The sum of the array is: " + sum);

            
            double avg = sum/array.Length;
            Console.WriteLine("The average of the array is: " + avg);


            int value = 2;
            //var index = FindIndex(array, value);
            //Console.WriteLine("The index is: " + index);

            //var occurencies = FindOccurencies(array, value);

            //int[] newArray = new int[array.Length - occurencies];
            //int counter = -1;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if(array[i] == value)
            //    {
            //        continue;
            //    }
            //    counter++;
            //    newArray[counter] = array[i];
            //}
            //for(int i = 0; i < newArray.Length; i++)
            //{
            //    Console.WriteLine(newArray[i] + " ");
            //}

            int index = 3;
            int counter = 0;
            int[] array2 = new int[array.Length + 1];
            for(int i = 0; i <= array.Length ; i++)
            {
                if(i == index)
                {
                    array2[i] = value;
                    counter++;
                }
                else
                {
                    array2[i] = array[i - counter];
                }
            }

            for(int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i] + " ");
            }

                
            

            


        }
    }
}