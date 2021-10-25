using System;
using System.Text;

namespace Task_10
{
    class Program
    {
        static void Main()
        {
            // Типові формальності
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Завдання 10 | Піскун Іван | 3 підгруппа";

            // input - змінна для запису речення користувача | symbol_to_find - символ, котрий будет шукати в реченні | counter - змінна для рахунку зустрічей символа в реченні
            string input;
            char symbol_to_find = 'а';
            int counter = 0;

            try
            {
                // Запрошення на введеня речення
                Console.Write("Введіть ваше речення: ");
                input = Console.ReadLine();

                // Запрошую ввести символ для пошуку в реченні
                Console.Write("Введіть букву, для пошуку в реченні: ");
                symbol_to_find = Convert.ToChar(Console.ReadLine());

                // Перебираю кожний символ речення і шукаю збіг
                foreach (var symbol in input.ToLower())
                {
                    if (symbol == symbol_to_find)
                    {
                        counter++;
                    }
                }

                // Вивожу результати
                if (counter > 0)
                {
                    Console.WriteLine("В вашому реченні \"{0}\" символ \"{1}\" зустрічається {2} раз(-и, -ів)", input, symbol_to_find, counter);
                }
                else
                {
                    Console.WriteLine("В вашому реченні \"{0}\" немає символа \"{1}\")", input, symbol_to_find);
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Програма може шукати тільки одну букву");
                Console.WriteLine("Введіть y, щоб перезапустити программу або будь що інше, для виходу: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
            Console.ReadKey();
        }
    }
}
