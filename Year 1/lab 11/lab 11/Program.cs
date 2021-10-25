using System;
using System.Text;

namespace lab_11
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | Лабораторна 11 | Завдання 1";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            int number = 0;
            bool correct_number = false;

            Console.Write("Введіть число для отримання таблички множення цього числа: ");
            try
            {
                while (!correct_number)
                {
                    number = Int32.Parse(Console.ReadLine());
                    if (number > 9 || number < 1)
                    {
                        Console.Write("Вибачте, число може бути лише в діапазоні від 1 до 9 включно. Введіть будь ласка знову: ");
                        correct_number = false;
                    }
                    else
                    {
                        correct_number = true;
                        multiplication_table(number);
                    }
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Вводити можна лише числа");
                Console.WriteLine("Введіть y, щоб перезапустити программу або будь що інше, для виходу: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
            
        }
        static void multiplication_table(int number)
        {
            Console.WriteLine("Табличка множення для числа {0}", number);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number*i);
            }
        }
    }
}
