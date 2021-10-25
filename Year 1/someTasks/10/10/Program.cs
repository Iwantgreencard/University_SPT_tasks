using System;

namespace _10
{
    class Program
    {
        static void Main()
        {
            // створюю змінну а і даю їй значення 0, це потрібно для того, що я міг відразу до неї додавати числа та змінну input
            int a = 0;
            string input;
            // тут прошу користувача ввести число
            Console.Write("Введiть ваше число: ");
            input = Console.ReadLine();
            // я знаю, що ви писали без операторів управління, але я вирішив зробити це завдання за допомогою цикла
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("Цифра номер " + (i + 1) + ": " + input[i]);
                a += Int32.Parse(input[i].ToString());
            }
            // виводимо результат на екран
            Console.WriteLine("Сума цифр в вашому числi - " + a);
            Console.ReadKey();
        }
    }
}
