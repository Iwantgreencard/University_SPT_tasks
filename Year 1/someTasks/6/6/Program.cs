using System;

namespace _6
{
    class Program
    {
        static void Main()
        {
            int a;

            Console.Write("Введiть хвилини: ");
            a = Convert.ToInt32(Console.ReadLine());

            // Пояснювати сенс є тільки тут. Тут ми викликаємо класс DateTime, потім його властивість Now, в якій знаходиться дата та час в данний момент. 
            // І за допомогою Hour беремо звідти тільки години
            Console.WriteLine("Тобто час зараз: " + DateTime.Now.Hour + ":" + a);
        }
    }
}
