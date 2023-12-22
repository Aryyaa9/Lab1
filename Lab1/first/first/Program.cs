using System;
namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int [10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            int minNum = min + 1;
            
            Console.WriteLine("Массив случайных чисел: ");
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Номер минимального элемента: " + minNum);
        }
    }
}