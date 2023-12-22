using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Введите число (для остановки введите: 0): ");
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                    break;
                numbers.Add(num);
            }

            int sum = 0;
            int proiz = 1;
            foreach (int num in numbers)
            {
                sum += num;
                proiz *= num;
            }

            double srednee = numbers.Count > 0 ? (double)sum / numbers.Count : 0; 
            // Count-свойство,к-ое возвращает кол-во эл-тов в списке
        

            Console.WriteLine($"Сумма элементов списка: {sum}");
            Console.WriteLine($"Произведение элементов списка: {proiz}");
            Console.WriteLine($"Среднее среди всех элементов списка: {srednee}");
        }
    }
}