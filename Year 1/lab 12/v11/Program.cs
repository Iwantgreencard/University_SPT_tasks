using System;
using System.Text;

namespace v11
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Піскун Іван | 3 підгруппа | Лабораторна 12 | Варіант 11";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            string input, type = "", check;
            double f = 0;
            bool end = false;

            Console.WriteLine("Ця програма визначає площу квадрата або кола на вибір.");
            while (!end)
            {
                Console.Write("Веедіть \"коло\" або \"квадрат\": ");
                input = Console.ReadLine();
                try
                {
                    if (input.ToLower() == "коло")
                    {
                        type = "Circle";
                        Console.Write("Для обрахунку площі кола, введіть будь ласка його радіус: ");
                        f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Площа вашого кола з радіусом {0} см дорівнює {1} м²", f, FigureR(type, f));

                    }
                    else if (input.ToLower() == "квадрат")
                    {
                        type = "Square";
                        Console.Write("Для обрахунку площі квадрата, введіть будь ласка його сторону: ");
                        f = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Площа вашого квадрата зі строною {0} см дорівнює {1} м²", f, FigureR(type, f));
                    }
                    else
                    {
                        Console.WriteLine("Потрібно ввести або \"коло\", або \"квадрат\"");
                    }
                    Console.WriteLine();
                    Console.Write("Для продовження програми напишіть що завгодно, для виходу з програми напишіть \"досить\": ");
                    check = Console.ReadLine();
                    if (check.ToLower() == "досить")
                    {
                        end = true;
                    }
                    else
                    {
                        continue;
                    }
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
        }
        static double FigureR(string type, double f)
        {
            double result = 0;
            if (type == "Square")
            {
                result = Math.Pow(f, 2);
            }
            else if(type == "Circle")
            {
                result = Math.PI * (f * f);
            }
            return Math.Round(result, 2);
        }
    }
}
