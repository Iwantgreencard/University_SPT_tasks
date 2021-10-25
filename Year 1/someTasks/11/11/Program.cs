    using System;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            /* тут я визнаначаю переменні, котрі буде вводити користувач, в моєму варіанті я створив для кожної змінної, 
            також її зміну типу "string" для перевірки на те, чи було введно число */
            double price_grn;
            double price_kopiyok;
            int kilkist_bulochki;
            string grn;
            string kopiyok;
            string bulochki;
            // Тут ми просимо ввести коричтувача ціну в гривнях, копійках так кількість булочок
            Console.Write("Введiть будь ласка скiльки гривень коштує булочка: ");
            grn = Console.ReadLine();
            Console.Write("Та копiйок: ");
            kopiyok = Console.ReadLine();
            Console.Write("Тепер введiть кiлькiсть булочок, що хочете купити: ");
            bulochki = Console.ReadLine();

            // НЕ ЗВЕРТАЙТЕ УВАГИ, ЦЕ ПРОСТО ФУНКЦІЯ ДЛЯ ПЕРЕВІРКИ НА ЧИСЛО
            string[] InputNumbers = new string[] { grn, kopiyok, bulochki };
            Check(InputNumbers);

            grn = InputNumbers[0];
            kopiyok = InputNumbers[1];
            bulochki = InputNumbers[2];

            // Тут я перетворюю тип string до потрібного мені числового типу, за допомогою мметоду Parse
            price_grn = Double.Parse(grn);
            price_kopiyok = Double.Parse(kopiyok);
            kilkist_bulochki = Int32.Parse(bulochki);

            // Формула, яка рахує скільки коштує одна булочка
            double price_bulochki = price_grn + (price_kopiyok / 100);

            // Тут я вивожу в консоль ціну одніє булочки
            Console.WriteLine("Цiна однiE булочки: " + price_bulochki);
            /* Тут я вивожу ціну всіх булочок переменоживши їх кількість та ціну одніє і округливши 
            їх за допомогою метода Math.Round, який округляє наше число до потрібного нам знача після нуля */
            Console.WriteLine("Скiльки вам потрiбно заплатити за " + kilkist_bulochki + " булочок: " + Math.Round(kilkist_bulochki * price_bulochki, 2));

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
