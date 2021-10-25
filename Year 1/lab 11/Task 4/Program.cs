using System;
using System.Text;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Піскун Іван | Лабораторна 11 | Завдання 3";
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            string password;

            Console.Write("Введіть пароль для авторизації: ");
            password = Console.ReadLine();

            Console.WriteLine();

            if (check_password(password))
            {
                Console.WriteLine("Пароль введено вірно, авторизація успішна");
            }
            else
            {
                Console.WriteLine("Пароль введено не вірно, авторизація не вдалась");
            }
            Console.ReadKey();
        }
        static bool check_password(string pass)
        {
            string real_password = "12345678";
            bool authorized;

            if (real_password == pass)
            {
                authorized = true;
            }
            else
            {
                authorized = false;
            }
            return authorized;
        }
    }
}
