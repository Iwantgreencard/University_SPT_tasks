using System;
using System.Collections.Generic;
using System.Text;

namespace lab_16_17
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Лабораторна 16-17 | Варіант 20 | Піскун Іван | 4 підгруппа |";
            Console.OutputEncoding = Encoding.UTF8;

            List<Voucher> vouchers = new List<Voucher>();

            bool working = true;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----Завдання 1-----\n");
            Console.ResetColor();


            Voucher first_voucher = new Voucher(123, "Russia", 12, "Bussines", 1300);
            Console.WriteLine("Доброго дня, вас вітає туристична компанія \"Borderlands\". \nПрямо зараз ви можете замовити собі туристичну путівку куди тільки захочете!");
            Console.WriteLine("Якщо бажаєте замовити путівку, натисність Enter і потім введіть команду buy_voucher або help для списку команд, \nабо будь-що інше для виходу з программи.");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                while (working) {
                    Console.WriteLine("");
                    Console.Write("Введіть вашу команду: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (Console.ReadLine())
                    {
                        case "buy_voucher":
                            Random rand = new Random();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---------------------------Купівля путівки--------------------------------");
                            Console.ResetColor(); Voucher voucher = new Voucher();
                            vouchers.Add(voucher);
                            Console.Write("Заповніть будь-ласка куди б ви хотіли поїхати: ");
                            voucher.Country = Console.ReadLine();
                            bool is_number = false;
                            while (!is_number)
                            {
                                try
                                {
                                    try
                                    {
                                        Console.Write("На скільки(днів): ");
                                        voucher.Period = Convert.ToInt32(Console.ReadLine());
                                        is_number = true;
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Вибачте, вводити можна тільки, цілі числа, спробуйте знову.");
                                        throw;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    is_number = false;
                                }
                            }
                            Console.Write("Тип обслуговування(Bussines, Comfort, VIP): ");
                            bool right_servicicng = false;
                            while (!right_servicicng) {
                                voucher.Servicing = Console.ReadLine();
                                int cost = 0;
                                switch ((voucher.Servicing).ToLower())
                                {
                                    case "bussines":
                                        cost = rand.Next(1000, 1500) * voucher.Period;
                                        right_servicicng = true;
                                        break;
                                    case "comfort":
                                        cost = rand.Next(1500, 2000) * voucher.Period;
                                        right_servicicng = true;
                                        break;
                                    case "vip":
                                        cost = rand.Next(2500, 4000) * voucher.Period;
                                        right_servicicng = true;
                                        break;
                                    default:
                                        right_servicicng = false;
                                        Console.WriteLine("Вибачте, є тільки три плана обслуговування - Bussines, Comfort, VIP.");
                                        Console.Write("Введіть один з них: ");
                                        break;
                                }
                                voucher.set_cost(cost);
                            }
                            voucher.set_id(210 + vouchers.Count);
                            Console.WriteLine("Ваша путівка:");
                            voucher.show_voucher();
                            break;
                        case "my_vouchers":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---------------------------Ваші путівки---------------------------------");
                            Console.ResetColor(); 
                            if (vouchers.Count > 0)
                            {
                                foreach (Voucher v in vouchers)
                                {
                                    v.show_voucher();
                                    Console.WriteLine("");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ви ще не купили жодної путівки, для їх купівлі введіть команду buy_voucher");
                            }
                            break;
                        case "search":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---------------------------Пошук-----------------------------------------");
                            Console.ResetColor();
                            Console.WriteLine("Характеристики:Номер | Країна | Термін | Тип обслуговування | Ціна");
                            Console.Write("За якою характеристикою будемо шукати путівку? ");
                            bool right_charasteristic = false;
                            string charasteristic;
                            while (!right_charasteristic)
                            {
                                charasteristic = Console.ReadLine();
                                switch (charasteristic.ToLower())
                                {
                                    case "номер":
                                        Console.Write("Введіть номер: ");
                                        Voucher.search_by_id(vouchers.ToArray(), Convert.ToInt32(Console.ReadLine()));
                                        right_charasteristic = true;
                                        break;
                                    case "країна":
                                        Console.Write("Введіть країну: ");
                                        Voucher.search_by_country(vouchers.ToArray(), Console.ReadLine());
                                        right_charasteristic = true;
                                        break;
                                    case "термін":
                                        Console.Write("Введіть термін поїздки: ");
                                        Voucher.search_by_period(vouchers.ToArray(), Convert.ToInt32(Console.ReadLine()));
                                        right_charasteristic = true;
                                        break;
                                    case "тип обслуговування":
                                        Console.Write("Введіть тип обслуговування: ");
                                        Voucher.search_by_servicing(vouchers.ToArray(), Console.ReadLine());
                                        right_charasteristic = true;
                                        break;
                                    case "ціна":
                                        Console.Write("Введіть ціну: ");
                                        Voucher.search_by_cost(vouchers.ToArray(), Convert.ToInt32(Console.ReadLine()));
                                        right_charasteristic = true;
                                        break;
                                    case "exit":
                                        right_charasteristic = true;
                                        break;
                                    default:
                                        right_charasteristic = false;
                                        Console.WriteLine("Вибачте, немає такої характеристики, введіть характеристику зі списку або exit для виходу");
                                        Console.Write("Ввод: ");
                                        break;
                                }
                            }
                            Console.ResetColor();
                            break;
                        case "help":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---------------------------Список команд----------------------------------");
                            Console.ResetColor();
                            Console.WriteLine("help - список команд\nbuy_voucher - купити нову путівку\nmy_vouchers - подивитися список ваших путівок\nsearch - для пошуку серед ваших путівок за полями\nexit - для виходу з програми");
                            break;
                        case "exit":
                            working = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("---------------------------Помилка----------------------------------------");
                            Console.ResetColor();
                            Console.WriteLine("Не існує такої команди - \"help\" для списку команд");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("До побачення!");
            }
        }
    }
}
