using System;
using System.Text;

namespace _13
{
    class Program
    {
        static void Main()
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Піскун Іван | 3 підгрупа";

            string command;
            int direction;
            string direction_string;
            string direction_symbol;
            string history = "";
            bool end = false, running = true;

            Console.WriteLine("Ця программа дозволяє вам керувати роботом за допомогою всього лише трьох команд.");
            Console.WriteLine(" 0 - продовжувати рух, 1 - поворот наліво, -1 - поворот праворуч.");
            Console.Write("Для початку укажіть в якому напрямку зараз дивиться робот П - Північ, З - Захід, В - Південь, С - Схід: ");
            direction_string = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("————————————————————————");
            Console.ResetColor();
            switch (direction_string.ToUpper())
            {
                case "С":
                    Console.WriteLine("Отже напрямок - Схід ←");
                    direction = 1;
                    direction_string = "Схід";
                    direction_symbol = "←";
                    break;
                case "З":
                    Console.WriteLine("Отже напрямок - Захід →");
                    direction = 3;
                    direction_string = "Захід";
                    direction_symbol = "→";
                    break;
                case "П":
                    Console.WriteLine("Отже напрямок - Північ ↓");
                    direction = 2;
                    direction_string = "Північ";
                    direction_symbol = "↓";
                    break;
                case "В":
                    Console.WriteLine("Отже напрямок - Південь ↑");
                    direction = 4;
                    direction_string = "Південь";
                    direction_symbol = "↑";
                    break;
                default:
                    Console.WriteLine("Ви ввели якусь дурницю або нічого не ввели, тому напрямок Північ");
                    direction = 2;
                    direction_string = "Північ";
                    direction_symbol = "↓";
                    break;
            }

            do
            {
                    Console.Write("Введіть команду руху або \"вийти\" для виходу: ");
                    command = Console.ReadLine();
                    switch (command.ToLower())
                    {
                        case "0":
                            direction = direction;
                            direction_string = direction_string;
                            Console.Write("Ви просто продовжуєте рух. ");
                            break;
                        case "1":
                            if (direction == 4)
                            {
                                direction = 1;
                            }
                            else
                            {
                                direction = direction + Int32.Parse(command);
                            }
                            Console.Write("Ви повернули наліво. ");
                            break;
                        case "-1":
                            if (direction == 1)
                            {
                                direction = 4;
                            }
                            else
                            {
                                direction = direction + Int32.Parse(command);
                            }
                            Console.Write("Ви повернули направо. ");
                            break;
                        case "вийти":
                            running = false;
                            end = true;
                            direction = 0;
                            Console.Write("Ви вимкнули робота. І його кінцевий ");
                            break;
                        default:
                            direction = direction;
                            direction_string = direction_string;
                            Console.Write("Ви ввели щось не схоже на команду, тому ви просто продовжуєте рух.");
                            break;
                    }
                    switch (direction)
                    {
                        case 1:
                            direction_string = "Схід ←";
                            direction_symbol = "←";
                            break;
                        case 3:
                            direction_string = "Захід →";
                            direction_symbol = "→";
                            break;
                        case 2:
                            direction_string = "Північ ↓";
                            direction_symbol = "↓";
                            break;
                        case 4:
                            direction_string = "Південь ↑";
                            direction_symbol = "↑";
                            break;
                        case 0:
                            direction_symbol = "";
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Напрямок - " + direction_string);
                    Console.ResetColor();
                    history += direction_symbol;
                    Console.WriteLine("Ваша історія переміщення: " + history);
                if (end)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("———————————————————————— Кінець ——");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("————————————————————————");
                }
                Console.ResetColor();
            } while (running);
            Console.ReadKey();
        }
    }
}
