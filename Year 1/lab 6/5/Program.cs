using System;

namespace _5
{
    class Program
    {
        static void Main()
        {
            // створюємо дві числові змінні
            int a, b;
            // Просимо користувача ввести число
            Console.Write("Введiть ваше число: ");
            a =  Convert.ToInt32(Console.ReadLine());
            
            // Просимо користувача ввести степінь
            Console.Write("Введiть степiнь до якого пiднести число: ");
            b = Convert.ToInt32(Console.ReadLine());

            //Виводимо результат
            Console.WriteLine(a + " до степеня " + b + " = " + Math.Pow(a, b));
        }
    }
}
