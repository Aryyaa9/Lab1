using System;
class HelloWorld
{
    static int[] GenerateRandomArray(int start, int end, int count) //ф-я позволяет сгенерировать МАССИВ случ-ых чисел в одном месте(внутри функции), а затем исп-ть в методе Main 

    {
        Random random = new Random();
        int[] array = new int[count];

        for (int i = 0; i < count; i++)
        {
            array[i] = random.Next(start, end + 1);
        }

        return array;
    }

    static void Main()
    {
        Console.Write("Введите начало диапазона: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Введите конец диапазона: ");
        int end = int.Parse(Console.ReadLine());

        Console.Write("Введите количество элементов: ");
        int count = int.Parse(Console.ReadLine());

        int[] array = GenerateRandomArray(start, end, count);

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
