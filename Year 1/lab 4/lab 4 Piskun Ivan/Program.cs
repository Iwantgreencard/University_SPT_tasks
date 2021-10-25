using System;
using System.Text;

namespace lab_4
{
    class Program
    {
        static void Main()
        {

            // Змініюю кодування для нормального відображеня символів та змінію заголовок консолі
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Піскун Іван | 3 підгрупа";

            // A - змінна яку далі вводить користувач, x та y - змінні в які запишуться результати розрахунків
            // answer - змінна в яку запишуться відповіді користувача на запитання, correct - перевірка чи відповід користувач правильно
            double A, x, y = 0;
            string answer_1, answer_2;
            bool correct_1 = false, correct_2 = false;

            // Вивожу текстову інформацію про роботу програми
            Console.WriteLine("Отже, ця програма обчислює значення y та x за формулами:");
            Console.WriteLine("x = (A + 1.6) / 3.8");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------");
            Console.ResetColor();
            Console.WriteLine("      -------");
            Console.WriteLine("     |");
            Console.WriteLine("     |  (2x +4.5)^3, якщо 0 < x < 8");
            Console.WriteLine("     /");
            Console.WriteLine("y=  -  -x^3, якщо x ≤ 0 або x > 20");
            Console.WriteLine("     \\");
            Console.WriteLine("     |  √(3x+5), якщо 8 ≤ x ≤ 20");
            Console.WriteLine("     |");
            Console.WriteLine("      --------");

            // Прошу користувача ввести число А
            Console.Write("Значення A введіть будь ласка з клавіатури: ");
            try
            {
                A = Int32.Parse(Console.ReadLine());

                // Роблю розрахунки згідно формул 
                x = (A + 1.6) / 3.8;


                if (x > 0 && x < 8)
                {
                    y = Math.Pow((2 * x + 4.5), 3);
                }
                else if (x <= 0 || x > 20)
                {
                    y = Math.Pow(-x, 3);
                }
                else if (x >= 8 && x <= 20)
                {
                    y = Math.Sqrt(3 * x + 5);
                }
                else
                {
                    Console.WriteLine("При таких значеннях x, y - не існує");
                }

                // Даю перше питання користувачу
                Console.WriteLine("");
                Console.WriteLine("Отже, програма провела свої обчислення, та вже знає значення x та y");
                Console.WriteLine("Але щоб ти їх дізнався, тобі потрібно відповісти на два простих запитаня");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Перше запитання: Який оператор вибору використовувався в цій програмі відповідай обов'язоково англійською");
                Console.Write("Твоя відповідь: ");
                answer_1 = Console.ReadLine();
                answer_1.ToLower();
                if (answer_1.ToLower() == "if else" || answer_1.ToLower() == "else if")
                {
                    Console.WriteLine(answer_1 + " - так це правильна відповідь!! Перейдемо до другого запитання.");
                    correct_1 = true;
                }
                else if (answer_1.ToLower() == "if" || answer_1.ToLower() == "else")
                {
                    Console.WriteLine(answer_1 + " - майже правильна відповідь але зарахую, перейдемо до другого запитання.");
                    correct_1 = true;
                }
                else
                {
                    Console.WriteLine(answer_1 + " - Точно не правильна відповідь, ти навіть не переходиш до другого запитання.");
                }

                // Якщо відповідь на перше запитання правильне, то даю друге
                if (correct_1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------------");
                    Console.ResetColor();
                    Console.WriteLine("Друге запитання: який оператор вибору ти ще знаєш?");
                    Console.Write("Твоя відповідь: ");
                    answer_2 = Console.ReadLine();
                    if (answer_2.ToLower() == "switch")
                    {
                        Console.WriteLine(answer_1 + " - так це правильна відповідь!! Зараз покажемо тобі результати обчислень");
                        correct_2 = true;
                    }
                    else if (answer_2.ToLower() == "swich")
                    {
                        Console.WriteLine("Правильно писати switch, а не " + answer_2 + " але загалом правильна відповідь.");
                        correct_2 = true;
                    }
                    else
                    {
                        Console.WriteLine(answer_2 + " - Точно не правильна відповідь, ти подолав перше завдання а от друге.. не вдалось");
                    }
                }

                // Якщо обидві відповіді правильні, то вивожу результат розрахунків
                if (correct_1 && correct_2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------------");
                    Console.ResetColor();
                    Console.WriteLine("Отже х = (A + 1.6) / 3.8 = " + Math.Round(x, 2));
                    Console.WriteLine("Отже y = " + Math.Round(y, 2));
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---------------------");
                Console.ResetColor();
                Console.WriteLine("Ви ввели щось не схоже на число, число в недопустимому форматі або число виходить за межі допустимого");
                Console.WriteLine("Введіть y, щоб перезапустити программу або будь що інше, для виходу: ");
                if(Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Main();
                }
            }
            Console.ReadKey();
        }
    }
}
