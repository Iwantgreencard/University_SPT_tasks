using System;
using System.Text;

namespace Lab_3
{
    class Program
    {
        public static void mett()
        { Console.Write("*"); }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Піскун Іван | 3 підгрупа";

            int a = 0, b = 0, c = 0, N = 9;

            Console.WriteLine("Ця програма визначає тип трикутника: гострокутний, тупокутний чи прямокутний");
            Console.WriteLine("Введiть сторони вашого трикутника");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("————————————————————————");
            Console.ResetColor();
            try
            {
                Console.Write("Введiть сторону a: ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("Введiть сторону b: ");
                b = Int32.Parse(Console.ReadLine());
                Console.Write("Введiть сторону c: ");
                c = Int32.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("————————————————————————");
                Console.ResetColor();
                if ((a + b > c) && (b + c > a) && (a + c > b))
                {
                    Console.WriteLine("Трикутник зi сторонами a = {0}, b = {1}, c = {2} iснує", a, b, c);
                    if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) || Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2) || Math.Pow(b, 2) == Math.Pow(c, 2) + Math.Pow(a, 2))
                    {
                        Console.WriteLine("Це прямокутний трикутник, ось його звичайний вигляд");
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < 10; i++)
                        {
                            for (int f = 0; f < i; f++)
                            {
                                if (f == 0 && i > 1)
                                {
                                    Console.Write("|");
                                }
                                else if (i == 9)
                                {
                                    if ((f + 1) == i)
                                    {
                                        Console.Write("\\");
                                    }
                                    else
                                    {
                                        Console.Write("_");
                                    }
                                }
                                else if ((f + 1) == i && i > 1)
                                {
                                    Console.Write("\\");
                                }
                                else
                                {
                                    Console.Write(" ");

                                }
                            }
                            Console.WriteLine("");
                        }
                    }
                    else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2) || Math.Pow(c, 2) > Math.Pow(a, 2) + Math.Pow(b, 2) || Math.Pow(b, 2) > Math.Pow(c, 2) + Math.Pow(a, 2))
                    {
                        Console.WriteLine("Це тупокутний трикутник,  ось його звичайний вигляд");
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < N; i++)
                        {
                            for (int r = 0; r < i; r++)
                            {
                                if (r == 0 & i > 1)
                                {
                                    Console.Write("|");
                                }
                                else if (r + 1 == i & i > 1)
                                {
                                    Console.Write("\\");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine("");
                        }
                        for (int i = N - 1; i > 0; i--)
                        {
                            for (int r = 0; r < i; r++)
                            {
                                if (r == 0 & i > 1)
                                {
                                    Console.Write("|");
                                }
                                else if (r + 1 == i & i > 1)
                                {
                                    Console.Write("/");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine("");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Це гострокутний трикутник,  ось його звичайний вигляд");
                        Console.ForegroundColor = ConsoleColor.Red;
                        int q, j, m;
                        for (q = N; q != 0; q--)
                        {
                            for (j = q; j != 0; j--)
                            {
                                Console.Write(" ");
                            }
                            mett();
                            for (m = (N - q) * 2; m != 0; m--)
                                mett();
                            Console.Write("\n");
                        }

                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Трикутника з такими сторонами не iснує");
                }
                Console.ResetColor();
                Console.ReadKey();
            }
            catch{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("————————————————————————");
                Console.ResetColor();
                Console.WriteLine("Напевно ви ввели сторону не числом або ввели не правильно");
                Console.WriteLine("");
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





/* Для прямокутного
 *  for (int i = 0; i < 8; i++)
            {
                for (int f = 0; f < i; f++)
                {
                    if (f == 0 && i > 1)
                    {
                        Console.Write("|");
                    }
                    else if(i == 7){
                        if ((f + 1) == i)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write("_");
                        }
                    }
                    else if((f+1) == i && i > 1){
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                        
                    }
                }
                Console.WriteLine("");
            }
 */

