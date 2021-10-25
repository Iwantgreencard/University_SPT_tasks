using System;
using System.Text;

namespace Task_12
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Піскун Іван | 3 підгрупа";

            int year;
            string year_string;
            char last_child;
            char before_last_child;

            try
            {
                Console.WriteLine("Ця програма визначає чи є рік високосний, чи ні");
                Console.Write("Введіть рік для перевірки: ");
                year = Int32.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("————————————————————————");
                Console.ResetColor();
                year_string = year.ToString();

                if (year_string.Length < 2)
                {
                    last_child = ' ';
                    before_last_child = ' ';
                }
                else
                {
                    last_child = year_string[year_string.Length - 1];
                    before_last_child = year_string[year_string.Length - 2];
                }

                if (year % 4 > 0 || (last_child.ToString() == "0" && before_last_child.ToString() == "0" && year % 400 > 0))
                {
                    Console.WriteLine(year + " рік не є високосним");
                }
                else
                {
                    Console.WriteLine(year + " високосний");
                }
                Console.ReadKey();
            }
            catch(Exception A)
            {
                Console.WriteLine(A.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("————————————————————————");
                Console.ResetColor();
                Console.WriteLine("Напевно ви ввели рік не правильно");
                Console.WriteLine("");
                Console.Write("Для того, щоб знову ввести рік, натиснiть \"y\", в iншому випадку нажмiть будь-яку кнопку для виходу з програми: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
        }
    }
}
