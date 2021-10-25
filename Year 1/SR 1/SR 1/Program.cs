using System;

namespace SR_1
{
    class Program
    {
        static void Main()
        {
            // Ініціюю змінні а - для запису туди числового числа дати народження; дві текстові зміні, для запису туди дати народженя, та уже отформатованої дати народження 
            int a = 0;
            string date_of_birth;
            string splitted_date_of_birth = "";
            bool succes = false;

            // Змінюю заголовок вікна та вивожу текстову інформацію з проханням користувача ввести дату народження в певному форматі
            Console.Title = "Піскун Іван | 3 підгрупа";
            Console.WriteLine("Ця програма визначає ваш варiант за дoпомогою вашої дати народження");
            Console.WriteLine("Будь-ласка введiть дату вашого народження в форматi дд.мм.гггг");
            Console.Write("Дату та мiсяць можна вписати одним числом але рiк обов'язково в форматi гггг: ");
            date_of_birth = Console.ReadLine();

            // Розбиваю дату народження за допомогою метода split на частини після кожної крапки
            string[] elem = date_of_birth.Split(".");
            Console.WriteLine("--------------------");

            // Записую уже отформатовану дату народження в текстову змінну | було: 12.01.2003 - стало 12012003
            for (int i = 0; i < elem.Length; i++)
            {
                splitted_date_of_birth += elem[i];
            }

            // Подалі в коді є конвертування змінної "splitted_date_of_birth" в числовой формат і якщо буде помилка - ловлю її через блок try
            try
            {
                // Перевіряю довжину дати народження і якщо вона більше або меньше заданого мною формата, запускаю функції Restart()
                if (splitted_date_of_birth.Length < 6 || splitted_date_of_birth.Length > 8)
                {
                    Console.Write("Вибачте, але здається ви ввели занадто мале або велике число, дата вашого народження не може бути- ");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("  {0}  ", date_of_birth);
                    Console.ResetColor();
                    Restart();
                }
                
                // Якщо довжина задовільняє формат, запускаю цикл, який рахую суму цифр в даті народження і записую значення в змінну "a"
                else
                {
                    for (int i = 0; i < splitted_date_of_birth.Length; i++)
                    {
                        a += Convert.ToInt32(splitted_date_of_birth[i].ToString());
                        // Тут текстово вивожу в консоль додавання цифр
                        if ((i + 1) < splitted_date_of_birth.Length)
                        {
                            Console.Write(splitted_date_of_birth[i] + " + ");
                        }
                        else
                        {
                            Console.WriteLine(splitted_date_of_birth[i] + " = " + a);
                        }
                    }
                    
                    // Вивожу результат
                    Console.WriteLine("Сума цифр вашої дати народження - " + a);
                    Console.WriteLine("--------------------");

                    // Запускаю цикл, який буде виконуватись до поки число "a" не буде однозначим
                    while (succes == false)
                    {
                        // Якщо a поділити на 9 більше за 1, то число більше 9, тобто не є однозначним, в такому випадку виконую додавання цифр знову
                        if ((Convert.ToDouble(a) / 9) > 1)
                        {
                            Console.WriteLine("{0} - це ще не однозначене число, продовжуємо обчислення", a);
                            splitted_date_of_birth = Convert.ToString(a);
                            a = 0;
                            for (int i = 0; i < splitted_date_of_birth.Length; i++)
                            {
                                a += Convert.ToInt32(splitted_date_of_birth[i].ToString());
                                if ((i + 1) < splitted_date_of_birth.Length)
                                {
                                    Console.Write(splitted_date_of_birth[i] + " + ");
                                }
                                else
                                {
                                    Console.WriteLine(splitted_date_of_birth[i] + " = " + a);
                                }
                            }
                        }

                        // В іншому ж випадку, закінчую цикл та вивожу результат
                        else
                        {
                            succes = true;
                            Console.WriteLine("Однозначне число вашої дати народження - " + a);
                            Console.ReadKey();
                        }
                    }
                }
            }

            // Якщо при конвертування була виявлена помилка, повідомляю про це користувача і визиваю функцію Restart
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Напевно ви ввели дату в неправильному форматi або взагалi ввели щось незрозумiле");
                Restart();
            }
        }

        // Функція Restart(), яка пропоную користувача перезапустити програму, щоб ввести дату коректно, або закінчити виконання програми
        static void Restart()
        {
            Console.Write("Для того, щоб перезапустити програму, натиснiть \"y\", в iншому випадку нажмiть будь-яку кнопку для виходу з програми: ");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                Main();
            }
        }
    }
}
