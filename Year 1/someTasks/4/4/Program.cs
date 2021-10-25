using System;

namespace _4
{
    class Program
    {
        static void Main()
        {
            // створюю числову змінну a
            int a;
            Console.Write("Введiть число для обрахунку його квадрата та знаходження кореня з нього: ");
            a = Convert.ToInt32(Console.ReadLine());
            // тут виводимо наші обчислення
            Console.WriteLine("Квадрат числа а - " + (a * a)); // Я знаю що тут можна зробити так: Math.Pow(a, 2)
            Console.WriteLine("Корiнь з числа а - " +  Math.Round(Math.Sqrt(a), 3)); // тут я також вирішив округлити корінь до 3 знаків після 0 за допомогою метода Round
        }
    }
}
