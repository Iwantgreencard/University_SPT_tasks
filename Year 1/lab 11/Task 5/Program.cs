using System;
using System.Text;

namespace Task_5
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | Лабораторна 11 | Завдання 5";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            int x, n;
            try
            {
                Console.WriteLine("∑(i*x^2) від i = 1 до n. Введіть число n та число х");
                Console.Write("x: ");
                x = Int32.Parse(Console.ReadLine());
                Console.Write("n: ");
                n = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Результат: " + suka(x, n));
            }
            catch
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Вводити можна лише цілі числа");
                Console.WriteLine("Введіть y, щоб перезапустити программу або будь що інше, для виходу: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
            
        }
        static int suka(int x, int n)
        {
            int result = 0;

            for (int i = 1; i < n; i++)
            {
                result += i * (x * x);
            }

            return result;
        }
    }
}
