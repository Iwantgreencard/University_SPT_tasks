using System;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            // створюю 2 текстові та 4 числові змінні
            string first, second;
            int a, b, c, g;
            // Прошу користувача ввести числа
            Console.Write("Введите а: ");
            first = Console.ReadLine();
            Console.Write("Введите b: ");
            second = Console.ReadLine();
            
            // тут перевіряю чи ввів користувач числа
            string[] inputNumbers = new string[] { first, second };
            Check(inputNumbers);
            
            // якщо так то записую ці значення в a та b
            a = Int32.Parse(inputNumbers[0]);
            b = Int32.Parse(inputNumbers[1]);

            // c та g це такі собі "тимчасові" змінні для того, щоб помістити в них значенняДи a та b
            c = a;
            g = b;

            // виводимо значення а та b до обміну
            Console.WriteLine("Значение а до обмена: " + a);
            Console.WriteLine("Значение b до обмена: " + b);

            // міняємо значення а та b через наші "тимчасові змінні"
            a = g;
            b = c;

            // виводимо лінію для розмежування
            Console.WriteLine("_____________");

            // виводимо нові значення а та b 
            Console.WriteLine("Значение а после обмена: " +a);
            Console.WriteLine("Значение b после обмена: " +b);
        }
        public static void Check(string[] k)
        {
            int res;
            bool SUCCES = false;
            while (!SUCCES)
            {
                for (int i = 0; i < k.Length; i++)
                {
                    bool succes = Int32.TryParse(k[i], out res);
                    if (!succes)
                    {
                        SUCCES = false;
                        Console.WriteLine(k[i] + " - это не число, введите заново");
                        k[i] = Console.ReadLine();
                    }
                    else
                    {
                        SUCCES = true;
                    }
                }
            }
        }
    }
}
