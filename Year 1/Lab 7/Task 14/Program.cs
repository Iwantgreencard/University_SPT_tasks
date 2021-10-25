using System;
using System.Text;

namespace Task_9
{
    class Program
    {
        static void Main()
        {
            // Типові формальності
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "Завдання 9 | Піскун Іван | 3 підгруппа";


            string input;
            string reversed_input = string.Empty;

            Console.Write("Введіть слово для провірки на паліндром: ");

            input = Console.ReadLine();

            char[] input_chars = input.ToCharArray();
            char[] reversed_input_chars = new char[input_chars.Length];
            Array.Copy(input_chars, 0, reversed_input_chars, 0, input.Length);

            Array.Reverse(reversed_input_chars);

            for (int r = 0; r < reversed_input_chars.Length; r++)
            {
                reversed_input += reversed_input_chars[r];
            }
            Console.WriteLine("{0} - {1}", input.ToLower(), reversed_input.ToLower());
            if(input.ToLower() == reversed_input.ToLower())
            {
                Console.WriteLine("Так, слово паліндром");
            }
            else
            {
                Console.WriteLine("Ні, слово не є паліндромо");
            }
            Console.ReadKey();
        }
    }
}
