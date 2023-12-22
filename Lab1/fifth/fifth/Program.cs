using System;

class HelloWorld
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string str = Console.ReadLine();

        int word = 0;  
        bool isWord = false;

        foreach (char c in str)
        {
            if (Char.IsLetterOrDigit(c))  //проверка яв-ся ли символ буквой или цифрой
            {
                if (!isWord)
                {
                    word++;
                    isWord = true;
                }
            }
            else
            {
                isWord = false;
            }
        }
        string str2 = "Start " + str + " End";

        Console.WriteLine("Количество слов: " + word);
        Console.WriteLine("Строка: " + str2);
    }
}