using System;
using System.Text;

namespace Task_11

{
    class Program
    {
        static int length = 109, V, T, S, Rounds, Ostacha;
        static double Rided;
        static string bike;
        static bool zvorotniy = false;
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Піскун Іван | 3 підгрупа";
            try
            {
                Console.WriteLine("Отже, уявiть ситуації, байкер на мотоциклі стартує на початку автомобільної дороги, довжина якої {0}", length);
                Console.WriteLine("Все що вам потрібно ввести - це сталу швидкість з якою їде байкер та час за який він повинен проїхати");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("————————————————————————");
                Console.ResetColor();
                Console.Write("Введіть швидкість V: ");
                V = Int32.Parse(Console.ReadLine());
                Console.Write("Введіть час T:  ");
                T = Int32.Parse(Console.ReadLine());
                Console.ReadLine();
                if (V > 0 || V == 0)
                {
                    bike = "o**`o";
                }
                else if (V < 0)
                {
                    zvorotniy = true;
                    bike = "o'**o";
                    V = V * -1;
                }
                S = V * Math.Abs(T);
                Rounds = S / 108;
                Ostacha = S % 108;
                Rided = Math.Round(Ostacha / 1.6);
                if (V > 35 && V < 38 && Rounds > 0)
                {
                    V = 0;
                }
                Ride();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("————————————————————————");
                Console.ResetColor();
                Console.WriteLine("Напевно ви ввели швидкість або час не правильно");
                Console.WriteLine("");
                Console.Write("Для того, щоб знову ввести числа, натиснiть \"y\", в iншому випадку нажмiть будь-яку кнопку для виходу з програми: ");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
        }

        private static void Ride()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("————————————————————————");
            Console.ResetColor();
            Console.Write("Мотоцикліст проїхав " + S + " км ");
            if(zvorotniy)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("в зворотньому напрямку");
                Console.ResetColor();
            }
            Console.WriteLine("");
            Console.WriteLine("Він проїхав {0} кіл і {1} кілометрів", Rounds, Ostacha);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("————————————————————————");
            Console.ResetColor();
            Console.Write("0 км");
            for (int i = 0; i < Rided - 7; i++)
            {
                if ((i + 1) < Rided - 7)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(Ostacha + " км");
                }
            }
            for (int i = 0; i < (65 - Rided); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("109 км");
            Console.Write("|");
            if(V == 0)
            {
                Console.Write(bike);
            }
            for (int i = 0; i < Rided - 2; i++)
            {
                if ((i + 1) < Rided - 2)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("| ");
                    Console.ResetColor();
                    Console.Write(bike);
                }
            }
            for (int i = 0; i < (65 - Rided); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ReadKey();
        }
    }
}
