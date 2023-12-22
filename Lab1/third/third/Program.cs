using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> elements = new List<string>();

            while (true)
            {
                Console.WriteLine("Введите элемент,для остановки введите пустую строку:");
                string element = Console.ReadLine();
                if (string.IsNullOrEmpty(element)) //Метод исп-ся для проверки строки на пустоту или Null
                    break;
                elements.Add(element);
            }
            string shortest = String.Empty;
            string longest = String.Empty;

            foreach (var element in elements)
            {
                if (string.IsNullOrEmpty(shortest) || element.Length < shortest.Length)
                    shortest = element;
                if (string.IsNullOrEmpty(longest) || element.Length > longest.Length)
                    longest = element;
            }
            Console.WriteLine($"Самый короткий элемент: {shortest}");
            Console.WriteLine($"Самый длинный элемент: {longest}");
            
        }
    }
}