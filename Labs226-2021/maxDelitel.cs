using System;

namespace Labs226_2021
{
    public class DDD
    {
        public static void Pupsik (int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            { 
                array[i] = new Random().Next(10, 50);
        }
            Console.WriteLine(array);
        }
    }
}
