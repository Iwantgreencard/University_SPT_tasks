using System;
using System.Text;

namespace Second_Task___lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторна 18 - завдання 2 \"Класс Command\" | Піскун Іван | 4 підгруппа |";
            Console.OutputEncoding = Encoding.UTF8;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-------------");
            Console.ResetColor();

            Command first_command = new Command(180, 70, new DateTime(2003, 8, 23), "Пономарчук", 12, 7);
            Command second_command = new Command();
            second_command.set_height(180);
            second_command.set_last_name("Пыскун");
            second_command.set_date_of_birth(new DateTime(2001, 3, 12));
            second_command.set_game_score(20);
            second_command.set_goal_core(15);
            Command third_command = new Command(170, 55, new DateTime(1999, 2, 15), "Валов", 40, 27);

            first_command.show_person(true);
            Console.WriteLine("-----------------------");
            second_command.show_person(true);
            Console.WriteLine("-----------------------");
            third_command.show_person(true);
            Console.WriteLine("-----------------------");

            Console.WriteLine($"Середня кількість мячів за гру гравця {second_command.Last_name}: {second_command.average_goals()}");

            Console.ReadLine();

        }
    }
}
