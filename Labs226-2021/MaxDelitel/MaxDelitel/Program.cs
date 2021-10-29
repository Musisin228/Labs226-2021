using System;

namespace Rafil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ячеек массива");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.Write("Ваш массив выглядит так:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10, 100);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                int a = array[i];
                for (int j = array[i] - 1; j > 0; j -= 1)
                {
                    int b = a % j;
                    if (b == 0)
                    {
                        Console.WriteLine($"{j} является максимальным делителем для {i + 1}-го элемента массива");
                        break;
                    }
                }
            }
        }
    }
}