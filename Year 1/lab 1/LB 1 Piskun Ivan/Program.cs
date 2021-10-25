using System;

namespace LB_1_Piskun_Ivan
{
    class Program
    {
        static void Main()
        {
            Console.Title = ("Піскун Іван | Варіант - " + (2 + 9) + " | Підгрупа 3");
            // Як і в попередньому завданні ініціюю зміні, але відміність тепер тут в тому, що не записую в x та y ніяких значень
            double x, y, z = 0.16, a = 5.7, b = 4.8, v, n, d, L;

            // Вивожу на екран текстову інформацію про те, що робить программа
            Console.WriteLine("Ця програма знаходить 4 змiннi за формулами: ");
            Console.WriteLine("--------------------");
            Console.WriteLine("v = √a + √(b + e^ax)");
            Console.WriteLine("n = (ln^3(10 + e^(-bx)))/b+x");
            Console.WriteLine("d = (x + (y/x+4)) / y(x-2) + (1/x^2+4)");
            Console.WriteLine("L = (arctg (z/2))^3");
            Console.WriteLine("--------------------");
            Console.WriteLine("Вiдомi змiннi: z = 0.16; a = 5.7; b = 4.8");
            Console.WriteLine("Змiннi що вводить користувач: х та y");
            Console.WriteLine("--------------------");

            // Прошу ввести користувача значення для змінних x та y, та перевіряю через try чи ввів користувач числові данні, та чи ввів їх коректно
            try
            {
                Console.Write("Введiть будь-ласка x: ");
                x = Double.Parse(Console.ReadLine());
                Console.Write("Введiть будь-ласка y: ");
                y = Double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------");
                Console.WriteLine("Для того, щоб почати обчислення натиснiть Enter");
                Console.ReadKey();
                v = Math.Sqrt(a) + Math.Sqrt(b + Math.Exp(a * x));
                n = Math.Pow(Math.Log(10 + Math.Exp(-b * x)), 3) / (b + x);
                d = (x + (y / (x + 4))) / (y * (x - 2) + (1 / (x * x + 4)));
                L = Math.Pow(Math.Atan(z / 2), 3);
                Console.WriteLine("v = {0:0.00} | n = {1:0.00} | d = {2:0.00} | L = {3:0.00000000}", v, n, d, L);
                Console.ReadKey();
            }

            // Код нижче виконується, якщо при спрацюванні кода з блока try программа отримала помилку
            catch (Exception A)
            {
                // Вивожу інформацію про помилку, та рекомендації щодо вводу чисел
                Console.WriteLine("--------------------");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write(A.Message);
                Console.ResetColor();
                Console.WriteLine(" Або простими словами - программа приймає тiльки числа");
                Console.WriteLine("Якщо ж ви впевненнi що ввели число, то перевiрте, чи ввели ви його в правильному форматi");
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("2.5 - НЕ ПРАВИЛЬНО ");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("2,5 - ПРАВИЛЬНО ");
                Console.ResetColor();
                Console.WriteLine("--------------------");

                // Пропоную користувачу ввести дані знову або ж закінчити виконання програми
                Console.Write("Для того, щоб знову ввести числа, натиснiть \"y\", в iншому випадку нажмiть будь-яку кнопку для виходу з програми: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
        }
    }
}
